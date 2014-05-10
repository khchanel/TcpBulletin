using System;
using System.Net;
using System.Net.Sockets;
using System.Collections.Generic;
using System.Threading;

using ProtoBuf;

using TcpBulletinCommon;


namespace TcpBulletinServer
{
    /// <summary>
    /// Bulletin Server implements the server using TCP
    /// </summary>
    public class BulletinServer
    {
        private TcpListener _listener;
        private List<TcpClient> _clients;

        /// <summary>
        /// Create server to listen to given ip and port
        /// default to IPAddress.Any and port 8888
        /// </summary>
        /// <param name="ip">IPAddress to listen to</param>
        /// <param name="port">port to listen on</param>
        public BulletinServer(IPAddress ip = null, int port = 8888)
        {
            this._listener = new TcpListener(ip == null ? IPAddress.Any : ip, port);
            this._clients = new List<TcpClient>();
        }

        /// <summary>
        /// Start the server and wait for client
        /// </summary>
        public void Start()
        {
            this._listener.Start();
            Console.WriteLine("Server: Started");

            this._listener.BeginAcceptTcpClient(ClientConnectedCallBack, null);
            Console.WriteLine("Server: Waiting for client...");
        }

        /// <summary>
        /// stop server and disconnect clients
        /// </summary>
        public void Stop()
        {
            this._listener.Stop();

            lock (this._clients)
            {
                foreach (TcpClient client in this._clients)
                {
                    client.Client.Disconnect(false);
                }

                this._clients.Clear();
            }
        }

        /// <summary>
        /// Callback for the accept tcp client opertaion.
        /// </summary>
        /// <param name="result">The async result object</param>
        private void ClientConnectedCallBack(IAsyncResult result)
        {
            TcpClient client = this._listener.EndAcceptTcpClient(result);

            lock (this._clients)
            {
                this._clients.Add(client);
            }

            using (NetworkStream stream = client.GetStream())
            {
                

                Console.WriteLine("Server: Client connected; reading message");

                // Deserialize received message
                try
                {
                    BulletinMessage msg = Serializer.DeserializeWithLengthPrefix<BulletinMessage>(stream, PrefixStyle.Base128);
                    Console.WriteLine("Server: Received '" + msg.ToString() + "'");
                }
                catch (Exception ex)
                {
                    Console.Error.WriteLine("Server: ERROR - " + Environment.NewLine);
                    Console.Error.WriteLine(ex.ToString());
                }

                
                Console.WriteLine("Server: Closing connection...");
                stream.Close();
                client.Close();

                lock (this._clients)
                {
                    this._clients.Remove(client);
                }
            }

            this._listener.BeginAcceptTcpClient(ClientConnectedCallBack, null);
        }
    }
}

using System;
using System.Net.Sockets;
using System.Net;
using System.Windows.Forms;

using ProtoBuf;

using TcpBulletinCommon;


namespace TcpBulletinClient
{
    public partial class BulletinForm : Form
    {
        public BulletinForm()
        {
            InitializeComponent();
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            BulletinMessage msg = new BulletinMessage();
            msg.Content = this.messageBox.Text;
            msg.Timestamp = DateTime.Now;

            this.statusLogBox.AppendText("CLIENT: Opening connection" + Environment.NewLine);

            using (TcpClient client = new TcpClient())
            {
                client.Connect(IPAddress.Loopback, 8888);

                using (NetworkStream stream = client.GetStream())
                {
                    this.statusLogBox.AppendText("CLIENT: Got connection; sending message..." + Environment.NewLine);
                    this.statusLogBox.AppendText(msg.ToString() + Environment.NewLine);

                    // send data to server
                    Serializer.SerializeWithLengthPrefix(stream, msg, PrefixStyle.Base128);

                    this.statusLogBox.AppendText("CLIENT: Closing connection" + Environment.NewLine);
                    stream.Close();
                }

                client.Close();
            }
        }
    }
}

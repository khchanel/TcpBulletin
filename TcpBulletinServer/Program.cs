using System;

namespace TcpBulletinServer
{
    class Program
    {
        static void Main(string[] args)
        {
            BulletinServer server  = new BulletinServer(port: 8888);

            server.Start();

            Console.WriteLine("Press Enter to stop server");
            Console.ReadLine();

            server.Stop();

            Console.WriteLine("Exit cleanly");
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UmamusumeFriendPoint
{
    internal class InteractServer
    {
        public event Action<string> Input;

        public void Output(string msg)
        {
            try
            {
                writer?.Write(msg);
                writer?.Flush();
            }
            catch
            {
                client.Dispose();
            }
        }

        private readonly TcpListener server;
        private TcpClient client;
        private BinaryReader reader;
        private BinaryWriter writer;
        public InteractServer(int port)
        {
            server = new (port);
            server.Start();
            new Thread(Listen).Start();
            new Thread(() =>
            {
                for (; ; )
                {
                    try
                    {
                        writer.Write("");
                    }
                    catch
                    {

                    }

                    Thread.Sleep(1000);
                }
            }).Start();
        }

        private void Listen()
        {
            while (true)
            {
                client = server.AcceptTcpClient();
                client.ReceiveTimeout = 10000;
                client.SendTimeout = 10000;

                try
                {
                    reader = new BinaryReader(client.GetStream());
                    writer = new BinaryWriter(client.GetStream());
                    for (;;)
                    {
                        var s = reader.ReadString();
                        if (!string.IsNullOrEmpty(s)) Input?.Invoke(s);
                    }
                }
                catch
                {
                    try
                    {
                        client.Dispose();
                    }
                    catch
                    {

                    }
                }
            }
        }
    }
}

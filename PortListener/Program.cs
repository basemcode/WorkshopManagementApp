using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;

namespace tcp;

class Program
{
    //dont forget to open port in the antivirus firewall
    static void Main(string[] args)
    {
        var listener = new TcpListener(IPAddress.Any, 12345);
        listener.Start();
        while (true)
        {
            System.Console.WriteLine("Waiting for client to connect...");
            var client = listener.AcceptTcpClient();
            System.Console.WriteLine("Client connected!");
            var clientStream = client.GetStream();

            StreamWriter sw = new StreamWriter(clientStream);
            StreamReader sr = new StreamReader(clientStream);
            System.Console.WriteLine($"Client is saying: {sr.ReadLine()}");
            sw.Write($"Listener says hi! {Environment.NewLine}");
            sw.Flush();
            
            while (true)
            {
                Thread.Sleep(2000);
                try
                {
                    sw.Write($"Listener keeps talking to the client. {Environment.NewLine}");
                    sw.Flush();
                }
                catch (IOException e)
                {
                    client.Close();
                    System.Console.WriteLine($"Client disconnected: {e.InnerException.Message}");
                    break;
                }
            }
        }
    }
}
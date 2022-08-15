using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            byte[] podaci = new byte[1024];

            string input, stringData;

            IPEndPoint ipep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8888);

            Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            try
            {
                server.Connect(ipep);

            }
            catch (SocketException e)
            {
                Console.WriteLine("Poteškoće sa konektovanjem na server.");

                Console.WriteLine(e.ToString());

                return;
            }

            int prijem = server.Receive(podaci);

            stringData = Encoding.UTF8.GetString(podaci, 0, prijem);

            Console.WriteLine(stringData);

            while (true)
            {
                input = Console.ReadLine();

                if (input == "exit")

                    break;

                Console.WriteLine("Vi: " + input);

                server.Send(Encoding.UTF8.GetBytes(input));

                podaci = new byte[1024];

                prijem = server.Receive(podaci);

                stringData = Encoding.UTF8.GetString(podaci, 0, prijem);

                byte[] utf8string = System.Text.Encoding.UTF8.GetBytes(stringData);

                Console.WriteLine("Server: " + stringData);
            }

            Console.WriteLine("Diskonektovanje sa servera u toku...");

            server.Shutdown(SocketShutdown.Both);

            server.Close();

            Console.WriteLine("Diskonektovan!");

            Console.ReadLine();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Collections;

namespace ISP_RAC1_ChatClient_SRV
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int prijem;
            string ime_korisnika;
            byte[] podaci = new byte[1024];
            try
            {
                Console.Write("Korisničko ime: ");
                ime_korisnika = Console.ReadLine();
                Console.Write("OK!\n\nPovezivanje...");
            }
            catch
            {
                Console.Clear();
                Console.Write("Molimo proverite validnost ulaza.\n\nPritisnite bilo koji taster za napuštanje programa.");
                return;
            }
            IPEndPoint ipep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8888);
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Bind(ipep);
            socket.Listen(10);
            Console.WriteLine("Server pokrenut.\n\nČekanje na klijentsku konekciju...");
            Socket client = socket.Accept();
            IPEndPoint clientep = (IPEndPoint)client.RemoteEndPoint;
            Console.Clear();
            Console.WriteLine("Veza uspostavljena sa {0} na portu {1}.", clientep.Address, clientep.Port);
            string motd = "Dobrodošli na Petnički chat client";
            podaci = Encoding.UTF8.GetBytes(motd);
            client.Send(podaci, podaci.Length, SocketFlags.None);
            string unos;
            while (true)
            {
                podaci = new byte[1024];
                prijem = client.Receive(podaci);
                if (prijem == 0)
                    break;
                Console.WriteLine("\n" + Encoding.UTF8.GetString(podaci, 0, prijem));
                Console.Write("\n" + ime_korisnika + " (Vi): ");
                unos = Console.ReadLine();
                client.Send(Encoding.UTF8.GetBytes(ime_korisnika + ": " + unos));
            }
            Console.WriteLine("Veza sa {0} okončana.", clientep.Address);
            client.Close();
            socket.Close();
            Console.ReadLine();
        }
    }
}
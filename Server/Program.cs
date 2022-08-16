using System;
using System.Threading;
using System.Net.Sockets;
using System.Text;
using System.Collections;
using System.Net;

namespace ISP_ChatServer
{
    class Program
    {
        public static Hashtable lista_klijenata = new Hashtable();
        static void Main(string[] args)
        {
            var localhost = IPAddress.Parse("127.0.0.1");
            TcpListener socket_servera = new TcpListener(localhost, 8888);
            TcpClient socket_klijenta = default(TcpClient);
            int i = 0;
            socket_servera.Start();
            Console.WriteLine("ISP ChatServer pokrenut.");
            while ((true))
            {
                i += 1;
                socket_klijenta = socket_servera.AcceptTcpClient();
                byte[] bajtovi = new byte[10000000];
                string podaci_klijenta = null;
                try
                {
                    String timeStamp = GetTimestamp(DateTime.Now);
                    NetworkStream stream_mreze = socket_klijenta.GetStream();
                    stream_mreze.Read(bajtovi, 0, (int)socket_klijenta.ReceiveBufferSize);
                    podaci_klijenta = System.Text.Encoding.ASCII.GetString(bajtovi);
                    podaci_klijenta = podaci_klijenta.Substring(0, podaci_klijenta.IndexOf("$"));
                    lista_klijenata.Add(podaci_klijenta, socket_klijenta);
                    Objava("[" + timeStamp + "] " + podaci_klijenta + " je online. ", podaci_klijenta, false);
                    Console.WriteLine(podaci_klijenta + " je online. ");
                    Klijent client = new Klijent();
                    client.pokreni_klijenta(socket_klijenta, podaci_klijenta, lista_klijenata);
                }
                catch (Exception ex)
                {
                    Console.Write(ex.Message);
                }
            }
            socket_klijenta.Close();
            socket_servera.Stop();
            Console.WriteLine("exit");
            Console.ReadLine();
        }
        public static String GetTimestamp(DateTime value)
        {
            return value.ToString("yyyy.MM.dd_HH-mm-ss");
        }
        public static void Objava(string poruka, string korisnicko_ime, bool oznaka)
        {
            foreach (DictionaryEntry Item in lista_klijenata)
            {
                String timeStamp = GetTimestamp(DateTime.Now);
                TcpClient socket_objave;
                socket_objave = (TcpClient)Item.Value;
                NetworkStream stream_objave = socket_objave.GetStream();
                Byte[] bajtovi = null;
                if (oznaka == true)
                {
                    bajtovi = Encoding.ASCII.GetBytes("[" + timeStamp + "] " + korisnicko_ime + ": " + poruka);
                }
                else
                {
                    bajtovi = Encoding.ASCII.GetBytes(poruka);
                }
                stream_objave.Write(bajtovi, 0, bajtovi.Length);
                stream_objave.Flush();
            }
        }
    }
    public class Klijent
    {
        TcpClient socket_klijenta;
        string broj_klijenta;
        Hashtable lista_klijenata;
        public void pokreni_klijenta(TcpClient ulazni_socket, string broj, Hashtable lista)
        {
            this.socket_klijenta = ulazni_socket;
            this.broj_klijenta = broj;
            this.lista_klijenata = lista;
            Thread thread_klijenta = new Thread(Chat);
            thread_klijenta.Start();
        }
        private void Chat()
        {
            int broj_zahteva = 0;
            byte[] bajtovi_od = new byte[1000000];
            string podaci_klijenta = null;
            Byte[] bajtovi_za = null;
            string odgovor_servera = null;
            string broj_z_s = null;
            while (true)
            {
                try
                {
                    broj_zahteva += 1;
                    NetworkStream stream_mreze = socket_klijenta.GetStream();
                    stream_mreze.Read(bajtovi_od, 0, (int)socket_klijenta.ReceiveBufferSize);
                    podaci_klijenta = Encoding.ASCII.GetString(bajtovi_od);
                    podaci_klijenta = podaci_klijenta.Substring(0, podaci_klijenta.IndexOf("$"));
                    Console.WriteLine("Klijent - " + broj_klijenta + " : " + podaci_klijenta);
                    broj_z_s = Convert.ToString(broj_zahteva);
                    Program.Objava(podaci_klijenta, broj_klijenta, true);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }
    }
}
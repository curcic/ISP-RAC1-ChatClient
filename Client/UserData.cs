using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ISP_ChatClient
{
    public partial class UserData : Form
    {
        TcpClient socket_klijenta = new TcpClient();
        NetworkStream stream_servera = default(NetworkStream);
        string ocitaj_podatke = null;

        public UserData()
        {
            InitializeComponent();
        }
        private void Poruka()
        {
            if (this.InvokeRequired)
                this.Invoke(new MethodInvoker(Poruka));
            else
                richTextBox1.Text = richTextBox1.Text + Environment.NewLine + " >> " + ocitaj_podatke;
        }

        private void primiPoruku()
        {
            while (true)
            {
                stream_servera = socket_klijenta.GetStream();
                int buffSize = 0;
                byte[] inStream = new byte[10000000];
                buffSize = socket_klijenta.ReceiveBufferSize;
                stream_servera.Read(inStream, 0, buffSize);
                string returndata = System.Text.Encoding.ASCII.GetString(inStream);
                ocitaj_podatke = "" + returndata;
                Poruka();
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            if (UserTextbox.Text == "")
            {
                MessageBox.Show("Molimo unesite korisničko ime.");
            }
            else
            {
                richTextBox1.Clear();
                ocitaj_podatke = "Povezivanje na server...";
                Poruka();
                try
                {
                    socket_klijenta.Connect("127.0.0.1", 8888);
                    stream_servera = socket_klijenta.GetStream();
                    byte[] izlazni_stream = Encoding.ASCII.GetBytes(UserTextbox.Text + "$");
                    stream_servera.Write(izlazni_stream, 0, izlazni_stream.Length);
                    stream_servera.Flush();
                    ConnectButton.Enabled = false;
                    ConnectButton.Visible = false;
                    SendButton.Enabled = true;
                    SendButton.Visible = true;
                    richTextBox1.Clear();
                    UserClass.userName = UserTextbox.Text;
                    UserTextbox.Clear();
                    UserTextbox.PlaceholderText = "Zdravo! Kako si?";
                    TextboxLabel.Text = "Vaša poruka:";
                    richTextBox1.ReadOnly = false;
                    Thread thread_klijenta = new Thread(primiPoruku);
                    thread_klijenta.Start();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void UserData_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = "Dobrodošli u ISP ChatClient.\n\nMolimo ukucajte Vaše korisničko ime, a zatim pritisnite dugme Poveži se.";
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            byte[] outStream = System.Text.Encoding.ASCII.GetBytes(UserTextbox.Text + "$");
            stream_servera.Write(outStream, 0, outStream.Length);
            stream_servera.Flush();
        }
    }
}

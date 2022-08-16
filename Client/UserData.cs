using System;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

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
                int velicina_buffera = 0;
                byte[] ulazni_stream = new byte[10000000];
                velicina_buffera = socket_klijenta.ReceiveBufferSize;
                stream_servera.Read(ulazni_stream, 0, velicina_buffera);
                string izlazni_podaci = Encoding.ASCII.GetString(ulazni_stream);
                ocitaj_podatke = "" + izlazni_podaci;
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
                    socket_klijenta.Connect("10.51.0.67", 8888);
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
                    UserTextbox.PlaceholderText = "Pozdrav! Kako si?";
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
            UserTextbox.Clear();
            stream_servera.Write(outStream, 0, outStream.Length);
            stream_servera.Flush();
            UserTextbox.Focus();
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = ".rtf | *.rtf";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName);
            }
        }

        private void FontButton_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font;
            }
        }
    }
}

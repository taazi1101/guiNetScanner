using guiNetScanner.scanners;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.SymbolStore;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace guiNetScanner
{
    public partial class Form3 : Form
    {
        string ip;
        int port;
        Socket socket = null;
        CancellationTokenSource ctsSource = new CancellationTokenSource();
        public Form3()
        {
            InitializeComponent();
        }



        private void Form2_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = "Connecting...";
            socket = connect.TcpConnect(ip, port, richTextBox1, textBox1, button1, ctsSource.Token);
            Thread recvThread = new Thread(delegate () { connect.recv(socket,richTextBox1, ctsSource.Token); });
            recvThread.Start();
        }

        public void setIp(string infos)
        {
            Text = infos;
            String[] list = infos.Split(':');
            ip = list[0];
            port = int.Parse(list[1]);
        }

        private void f2Label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (socket != null) {
                String input = textBox1.Text;
                connect.send(socket, input, richTextBox1, ctsSource.Token);
            }
        }
    }
}

using guiNetScanner.scanners;
using networkMultiScanner.scanners;
using System.Drawing.Text;
using System.Net;
using System.Threading;

namespace guiNetScanner
{
    public partial class Form1 : Form
    {
        public class ipAddresses
        {
            public List<string> addresses = [];
            public void add(string x) { addresses.Add(x); }
            public void clear() { addresses.Clear(); }

        }

        bool ipScanActive = false;
        bool portScanActive = false;
        CancellationTokenSource ipCts;
        CancellationTokenSource portCts;
        long lastClick = DateTime.Now.Ticks / 10000;
        ipAddresses ipAddrs = new ipAddresses();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            label6.Text = "";
            errLabel.Text = "";
            progressBar1.Visible = false;
            progressBar2.Visible = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            errLabel.Text = "";
            if (!ipScanActive)
            {
                string ip = textBox1.Text;
                try { IPAddress.Parse(ip.Replace("FUZZ", "0")); } catch { errLabel.Text = "INVALID IP"; return; } //Check correct ip format
                listBox1.Items.Clear();
                ipAddrs.clear();
                progressBar1.Visible = true;
                int timeOut = (int)numericUpDown3.Value;
                ipCts = new CancellationTokenSource();
                IpScan.StdScan(ip, timeOut, checkBox1.Checked, ipAddrs, listBox1, progressBar1, button1, ipCts.Token);
                textBox1.Text = string.Empty;
                ipScanActive = true;
                button1.Text = "Cancel";
            }
            else
            {
                ipCts.Cancel();
                ipCts.Dispose();
                progressBar1.Visible = false;
                ipScanActive = false;
                button1.Text = "Scan";

            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            errLabel.Text = "";
            if (listBox1.SelectedIndex != -1)
            {
                textBox2.Text = ipAddrs.addresses[listBox1.SelectedIndex].ToString();
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            errLabel.Text = "";
            if (!portScanActive)
            {
                string ip = textBox2.Text;
                try { IPAddress.Parse(ip); } catch { errLabel.Text = "INVALID IP"; return; } //Check correct ip format
                listBox2.Items.Clear();
                progressBar2.Visible = true;
                int minPort = (int)numericUpDown1.Value;
                int maxPort = (int)numericUpDown2.Value;
                int timeOut = (int)numericUpDown3.Value;
                portCts = new CancellationTokenSource();

                Thread thread = new Thread(delegate ()
                {
                    portScanner.StdPort(ip, minPort, maxPort, timeOut, progressBar2, listBox2, label6, button2, portCts.Token);
                });
                thread.Start();
                textBox2.Text = string.Empty;
                button2.Text = "Cancel";
                portScanActive = true;
            }
            else
            {
                portCts.Cancel();
                portCts.Dispose();
                progressBar2.Visible = false;
                button2.Text = "Scan";
                portScanActive = false;
            }
        }

        private void progressBar2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            errLabel.Text = "";
            if (listBox1.SelectedIndex != -1)
            {
                Form2 form2 = new();
                form2.setIp(ipAddrs.addresses[listBox1.SelectedIndex].ToString());
                form2.ShowDialog();
                //form2.Activate();
            }
            else { errLabel.Text = "No address selected."; }
        }
    }
}

using guiNetScanner;
using System.Net;
using System.Net.NetworkInformation;


namespace networkMultiScanner.scanners
{
    internal class IpScan
    {

        public static async void StdScan(string ipBase, int timeOut,bool getHostname, Form1.ipAddresses addrss,ListBox resultBox,ProgressBar prog,Button button,CancellationToken cts) // Ipbase: x.y.z.FUZZ , timeOut: milliseconds
        {
            Ping ping = new Ping();
            prog.Minimum = 0;
            prog.Maximum = 255;
            prog.Value = 0;
            prog.Step = 1;
            for (int i = 0; i < 256; i++)
            {
                if (cts.IsCancellationRequested) { return; }
                prog.PerformStep();
                string ip = ipBase.Replace("FUZZ", i.ToString());
                PingReply reply = await ping.SendPingAsync(ip, timeOut);
                if (reply.Status == IPStatus.Success)
                {
                    if (getHostname) { try {
                            IPHostEntry hostNameEntry = await Dns.GetHostEntryAsync(ip,cts);
                            resultBox.Items.Add(hostNameEntry.HostName); 
                        } catch (Exception) { resultBox.Items.Add(ip); } }
                    else { resultBox.Items.Add(ip); }
                    addrss.add(ip);
                }
            }
            prog.Value = 0;
            prog.Visible = false;
            button.Text = "Scan";
        }
    }
}

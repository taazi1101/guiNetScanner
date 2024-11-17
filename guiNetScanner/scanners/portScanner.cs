using System.Net.Sockets;
using System.Net;

namespace guiNetScanner.scanners
{
    internal class portScanner
    {
        public static void StdPort(string ip, int portMin,int portMax,int timeOut,ProgressBar prog,ListBox listbox,Label label,Button button,CancellationToken cts)
        {
            int closedPorts = 0;
            label.Invoke(new MethodInvoker(delegate { label.Text = closedPorts.ToString(); }));
            prog.Invoke(new MethodInvoker(delegate { prog.Minimum = portMin; }));
            prog.Invoke(new MethodInvoker(delegate { prog.Value = portMin; }));
            prog.Invoke(new MethodInvoker(delegate { prog.Maximum = portMax; }));
            prog.Invoke(new MethodInvoker(delegate { prog.Step = 1; }));
            IPAddress IP = IPAddress.Parse(ip);
            for (int i = portMin; i <= portMax; i++)
            {
                if (cts.IsCancellationRequested){return;}
                prog.Invoke(new MethodInvoker( prog.PerformStep ));
                try
                {
                    IPEndPoint endpoint = new IPEndPoint(IP,i); 
                    using Socket socket = new Socket(SocketType.Stream, ProtocolType.Tcp);
                    IAsyncResult res = socket.BeginConnect(endpoint,null,null);
                    if (res.AsyncWaitHandle.WaitOne(timeOut, true))
                    {
                        listbox.Invoke(new MethodInvoker(delegate { listbox.Items.Add(ip + ":" + i.ToString()); }));
                    }
                    else {
                        closedPorts++;
                        label.Invoke(new MethodInvoker(delegate { label.Text = closedPorts.ToString(); }));
                    }
                    
                } catch (Exception ex) {
                    Console.WriteLine(ex.ToString());
                }
            }
            prog.Invoke(new MethodInvoker(delegate { prog.Visible = false; }));
            button.Invoke(new MethodInvoker(delegate { button.Text = "Scan"; }));
        }
    }
}

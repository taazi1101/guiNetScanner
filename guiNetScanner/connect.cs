using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace guiNetScanner
{
    internal class connect
    {
        public static Socket TcpConnect(String ip, int port, RichTextBox output, TextBox input, Button sendButton, CancellationToken cts) 
        {
            try
            {
                Socket socket = new Socket(SocketType.Stream, ProtocolType.Tcp);
                socket.Connect(ip, port);
                output.Text = "Connection from: " + ip + ":" + port.ToString() + "\n\n";
                return socket;
            }
            catch (Exception ex) { output.Text = "Connection failed.";return null; }
        }
        public static async void send(Socket socket, string data,RichTextBox resultBox,CancellationToken cts)
        {
            try
            {
                await socket.SendAsync(Encoding.ASCII.GetBytes(data), cts);
                resultBox.Text += "Sent: " + data + "\n";
                Debug.WriteLine("SENT DATA");
            }
            catch (Exception ex) { resultBox.Text += "CONNECTION CLOSED"; Debug.WriteLine("FAILED SEND"); ; return; }

        }
        public static void recv(Socket socket,RichTextBox resultBox, CancellationToken cts)
        {
            Debug.WriteLine("STARTED LISTEN");
            resultBox.Invoke(new MethodInvoker(delegate { resultBox.Text += "Listener started...\n"; }));
            while (!cts.IsCancellationRequested) 
            {
                if (socket != null)
                {
                    if (!socket.Connected) { resultBox.Invoke(new MethodInvoker(delegate { resultBox.Text += "Socket closed.\n"; })); Debug.WriteLine("CLOSED LISTEN"); ; return; }
                    try
                    {
                        byte[] buffer = new byte[1024];
                        socket.Receive(buffer);
                        resultBox.Invoke(new MethodInvoker(delegate { resultBox.Text += "Received:\n" + Encoding.ASCII.GetString(buffer) + "\n"; ; }));
                        Debug.WriteLine("GOT LISTEN");
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine("FAILED LISTEN");
                        resultBox.Invoke(new MethodInvoker(delegate { resultBox.Text += "Receive failed.\n"; }));
                    }
                }
                else { Task.Delay(100); Debug.WriteLine("WAITING LISTEN"); ; }
            }

        }

    }
}

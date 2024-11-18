using System.Net.NetworkInformation;
using System.Net;
using ArpLookup;
using System.Text.Encodings.Web;
using System.Diagnostics.Eventing.Reader;
using System.Net.Sockets;

namespace guiNetScanner.scanners
{
    internal class getInfo
    {

        public static string GetOwnIp()
        {
            try
            {
                string localIP;
                using (Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, 0))
                {
                    socket.Connect("8.8.8.8", 65530);
                    IPEndPoint endPoint = socket.LocalEndPoint as IPEndPoint;
                    localIP = endPoint.Address.ToString();
                }
                return localIP;
            }
            catch (Exception ex) { return string.Empty; }
        }
        private static string MacLookup(string macAddr)
        {
            const string apiAddr = "https://api.macvendors.com/";

            HttpClient client = new HttpClient();
            UrlEncoder encoder = UrlEncoder.Create();
            HttpRequestMessage req = new() { RequestUri = new Uri(apiAddr + encoder.Encode(macAddr)), Method = new HttpMethod("GET") }; 
           
            HttpResponseMessage response = client.Send(req);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                return response.Content.ReadAsStringAsync().Result;
            }
            else { return "Could not resolve vendor."; }
        }

        public static string stdInfo(string ip)
        {
            IPAddress ipAddress = IPAddress.Parse(ip);
            Ping ping = new();
            string hostName = string.Empty;
            string ipv6 = string.Empty;
            string mac = string.Empty;
            string roundTrip = string.Empty;
            string vendor = string.Empty;
            bool gotMac = false;

            try { hostName = Dns.GetHostEntry(ip).HostName; }catch(Exception) { hostName = "Could not resolve hostname."; }
            try { ipv6 = ipAddress.MapToIPv6().ToString();gotMac = true; }catch (Exception) { ipv6 = "Could not resolve IPV6 address."; }
            try { mac = Arp.Lookup(ipAddress).ToString(); }catch (Exception) { mac = "Could not resolve MAC address."; }
            try { roundTrip = ping.Send(ipAddress).RoundtripTime.ToString(); }catch (Exception) { roundTrip = "Could not resolve roundtrip time."; }
            if (gotMac) { try { vendor = MacLookup(mac); } catch (Exception) { vendor = "Could not resolve vendor."; } }
            else { vendor = "Could not resolve vendor."; }

            return "Hostname: " + hostName + "\n" + "IPV4 address: " + ip + "\n" + "IPV6 address: " + ipv6 + "\n" + "Physical (MAC) address: " + mac + "\n" + "Vendor: " + vendor + "\n" + "Round trip time: " + roundTrip + "ms\n";
        }
    }
}

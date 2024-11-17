using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;
using System.Net;
using ArpLookup;

namespace guiNetScanner.scanners
{
    internal class getInfo
    {

        public static string stdInfo(string ip)
        {
            IPAddress ipAddress = IPAddress.Parse(ip);
            Ping ping = new();
            string hostName = string.Empty;
            string ipv6 = string.Empty;
            string mac = string.Empty;
            string roundTrip = string.Empty;

            try { hostName = Dns.GetHostEntry(ip).HostName; }catch(Exception) { hostName = "Could not resolve hostname."; }
            try { ipv6 = ipAddress.MapToIPv6().ToString(); }catch (Exception) { ipv6 = "Could not resolve IPV6 address."; }
            try { mac = Arp.Lookup(ipAddress).ToString(); }catch (Exception) { mac = "Could not resolve MAC address."; }
            try { roundTrip = ping.Send(ipAddress).RoundtripTime.ToString(); }catch (Exception) { roundTrip = "Could not resolve roundtrip time."; }

            return "Hostname: " + hostName + "\n" + "IPV4 address: " + ip + "\n" + "IPV6 address: " + ipv6 + "\n" + "Physical (MAC) address: " + mac + "\n" + "Round trip time: " + roundTrip + "ms\n";
        }
    }
}

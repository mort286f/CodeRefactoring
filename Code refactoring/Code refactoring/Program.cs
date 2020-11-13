using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Code_refactoring
{
    class Program
    {
        [Obsolete]
        static void Main()
        {
            DHCP dhcp = new DHCP();
            DNS dns = new DNS();
            Network network = new Network();
            Info info = new Info();

            IPAddress[] array = Dns.GetHostAddresses("en.wikipedia.org");
            foreach (IPAddress ip in array)
            {
                Console.WriteLine(ip.ToString());
            }


            network.LocalPing();
            Console.WriteLine("start");
            string t = dns.GetHostnameFromIp("8.8.8.8");
            Console.WriteLine(t);
            Console.WriteLine("slut");
            string adr = dns.GetIpFromHostname(t);
            Console.WriteLine("Weee " + adr);



            string a = network.Traceroute("8.8.8.8");
            Console.WriteLine("route*** " + a);

            dhcp.DisplayDhcpServerAddresses();

            //WIN-M69SG2Q0732.test.local
            //ZBC-RG01203MKC
            string hostName = "PCMorten";
            IPHostEntry hostInfo = Dns.GetHostByName(hostName);

            // Get the IP address list that resolves to the host names contained in the 
            // Alias property.

            IPAddress[] address = hostInfo.AddressList;
            // Get the alias names of the addresses in the IP address list.
            String[] alias = hostInfo.Aliases;

            Console.WriteLine("Host name : " + hostInfo.HostName);

            info.GetHostAddresses("PCMorten");

            Console.WriteLine("\nIP address list : ");

            info.GetHostAliases("PCMorten");

            Console.ReadKey();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Code_refactoring
{
    //Used to display different methods with hostname and ip addresses
    class Info
    {
        [Obsolete]
        public string GetHostAliases(string hostName)
        {
            IPHostEntry hostInfo = Dns.GetHostByName(hostName);
            String[] alias = hostInfo.Aliases;

            string aliases = "\aliases: ";
            for (int index = 0; index < alias.Length; index++)
            {
                aliases += alias[index] + "\n";
            }
            return aliases;
        }

        [Obsolete]
        public string GetHostAddresses(string hostName)
        {
            IPHostEntry hostInfo = Dns.GetHostByName(hostName);
            IPAddress[] address = hostInfo.AddressList;

            string addresses = "\nAddress list: \n";
            for (int index = 0; index < address.Length; index++)
            {
                addresses += address[index] + "\n";
            }
            return addresses;
        }
    }
}

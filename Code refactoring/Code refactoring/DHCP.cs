using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Code_refactoring
{
    public class DHCP
    {
        public string DisplayDhcpServerAddresses()
        {
            NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();
            string addressString = "";

            foreach (NetworkInterface adapter in adapters)
            {
                IPInterfaceProperties adapteradapterProperties = adapter.GetIPProperties();
                IPAddressCollection addresses = adapteradapterProperties.DhcpServerAddresses;
                if (addresses.Count > 0)
                {
                    addressString = adapter.Description + "\n";
                    foreach (IPAddress address in addresses)
                    {
                        addressString += $"  Dhcp Address ............................. : {address.ToString() } \n";
                    }
                }
            }
            return addressString;
        }
    }
}

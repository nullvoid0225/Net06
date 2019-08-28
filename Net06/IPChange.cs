using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Management;

namespace Net06
{
    public class IPChange
    {
        public bool IPChangeRun(string a, string b, string c, string d)
        {
            string myDesc = a;      // NIC 정보
            string address = b;     // 아이피 정보
            string subnetMask = c;  // 서브넷 정보
            string gateway = d;     //게이트웨이 정보

            ManagementClass adapterConfig = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection networkCollection = adapterConfig.GetInstances();

            foreach (ManagementObject adapter in networkCollection)
            {
                string description = adapter["Description"] as string;
                if (string.Compare(description, myDesc, StringComparison.InvariantCultureIgnoreCase) == 0)
                {
                    try
                    {
                        ManagementBaseObject newGateway = adapter.GetMethodParameters("SetGateways");
                        newGateway["DefaultIPGateway"] = new string[] { gateway };
                        newGateway["GatewayCostMetric"] = new int[] { 1 };

                        ManagementBaseObject newAddress = adapter.GetMethodParameters("EnableStatic");
                        newAddress["IPAddress"] = new string[] { address };
                        newAddress["SubnetMask"] = new string[] { subnetMask };

                        adapter.InvokeMethod("EnableStatic", newAddress, null);
                        adapter.InvokeMethod("SetGateways", newGateway, null);

                        return true;
                    }
                    catch
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NeoHub
{
    public class NetSettings
    {
        public string Net { get; set; }
        public int[] MainNetPorts { get; set; }
        public int[] TestNetPorts { get; set; }

        public int[] GetPorts()
        {
            if (this.Net == NetConstants.MAIN_NET)
            {
                return MainNetPorts;
            }

            return TestNetPorts;
        }
    }

    public class NetConstants
    {
        public const string MAIN_NET = "MainNet";
        public const string TEST_NET = "TestNet";
        public const string PRIVATE_NET = "PrivateNet";
    }
}

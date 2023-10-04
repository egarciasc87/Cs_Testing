using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NetworkUtility.DNS;

namespace NetworkUtility.Pin
{
    public class Network
    {
        public string Country { get; set; }
        public string IP { get; set; }
    }

    public class NetworkService
    {
        private readonly IDNS _dns;

        public NetworkService(IDNS dns)
        {
            this._dns = dns;
        }

        public string SendPing()
        {
            var dnsSuccess = _dns.SendDNS();

            if (dnsSuccess == true)
                return "SUCCESS: Ping sent!";
            else
                return "FAILED!";
        }

        public int PingTimeOut(int a, int b)
        {
            return a + b;
        }

        public DateTime LastPingdate()
        {
            return DateTime.Now.Date;
        }

        public Network GetNetwork()
        {
            return new Network
            {
                Country = "Peru",
                IP = "127.0.0.0"
            };
        }
    }
}

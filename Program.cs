using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace DNSNotice
{
    class Program
    {
        public static string wsAddress = "ws://192.168.1.118:25009";
        public static string wsToken = "PIXELTECHRCON";
        static string regionSelection = null;
        static string accessKey = null;
        static string accessSecret = null;
        static string domainName = null;
        static string subDomainName = null;
        public static string IpCached = "127.0.0.1";
        static void Main(string[] args)
        {
            ThreadStart eventThreadStarter = new ThreadStart(CoolQAPI.StartWebSocketEvent);
            ThreadStart apiThreadStarter = new ThreadStart(CoolQAPI.StartWebSocketApi);
            Thread eventThread = new Thread(eventThreadStarter);
            Thread apiThread = new Thread(apiThreadStarter);
            apiThread.Start();
            eventThread.Start();
            //CoolQAPI.StartWebSocketEvent();

            //CoolQAPI.ShowMessage();
            //Console.ReadLine();
        }
    }

}

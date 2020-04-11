
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WebSocketSharp;

namespace DNSNotice
{
    class CoolQAPI
    {
        public static void ReceiveMessage(string message)
        {
            //Console.WriteLine(GroupMessageExtractor("user_id", message));
        }
        public static void StartWebSocketApi()
        {
            string uri = Program.wsAddress + "/api/?access_token=" + Program.wsToken;
            var client = new WebSocket(uri);
            client.OnOpen += (sender, e) => Console.WriteLine("API Socket Opened");
            client.OnMessage += (sender, e) => Console.WriteLine("Receive:" + e.Data);
            client.ConnectAsync();
            //string post = String.Format("{0}{1}{2}", "a", "b", "c");
            string message = null;
            while (message != "exit")
            {
                message = Console.ReadLine();
                client.Send(GroupMessageBuilder(668053467, message));
            }
        }
        public static void StartWebSocketEvent()
        {
            string uri = Program.wsAddress + "/event/?access_token=" + Program.wsToken;
            var client = new WebSocket(uri);
            client.OnOpen += (sender, e) => Console.WriteLine("Event Socket Opened");
            client.OnMessage += (sender, e) => ReceiveMessage(e.Data);
            client.ConnectAsync();
        }
        public static string GroupMessageBuilder(int gid, string message)
        {
            if (gid == 0 || string.IsNullOrEmpty(message)) return null;
            SendJSON json = new SendJSON();
            json.action = "send_group_msg";
            @params param = new @params();
            param.group_id = gid;
            param.message = message;
            json.@params = param;
            return JsonConvert.SerializeObject(json);
        }
        public static ReceiveJSON GroupMessageAllExtractor(string source)
        {
            ReceiveJSON json = JsonConvert.DeserializeObject<ReceiveJSON>(source);
            return json;
        }
        public static string GroupMessageExtractor(string part, string source)
        {
            if (string.IsNullOrEmpty(part) || string.IsNullOrEmpty(source)) return null;
            ReceiveJSON json = JsonConvert.DeserializeObject<ReceiveJSON>(source);
            return typeof(ReceiveJSON).GetProperty(part).GetValue(json).ToString();
        }
    }
}

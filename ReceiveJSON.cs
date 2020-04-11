using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNSNotice
{
    public class Sender
    {
        /// <summary>
        /// 
        /// </summary>
        public int age { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string area { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string card { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string level { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string nickname { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string role { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string sex { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string title { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long user_id { get; set; }
    }

    public class ReceiveJSON
    {
        /// <summary>
        /// 
        /// </summary>
        public string anonymous { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long font { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long group_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string message { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long message_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string message_type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string post_type { get; set; }
        /// <summary>
        /// 行
        /// </summary>
        public string raw_message { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long self_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Sender sender { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string sub_type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long time { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long user_id { get; set; }
    }
}

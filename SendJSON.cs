using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNSNotice
{
    public class @params
    {
        /// <summary>
        /// 
        /// </summary>
        public int group_id { get; set; }
        /// <summary>
        /// 你好
        /// </summary>
        public string message { get; set; }
    }

    public class SendJSON
    {
        /// <summary>
        /// 
        /// </summary>
        public string action { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public @params @params { get; set; }
    }
}

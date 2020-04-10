using System;
using System.Collections.Generic;
using System.Text;

namespace GthxNet.Core
{
    public class Tell
    {
        public int Id { get; set; }
        public string Author { get; set; }  // varchar(60) DEFAULT NULL,
        public string Recipient { get; set; }  // varchar(60) DEFAULT NULL,
        public DateTime Timestamp { get; set; }
        public string Message { get; set; }
        public bool InTracked { get; set; } //  `inTracked` tinyint(1) DEFAULT NULL,   
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace GthxNet.Core
{
    public class Seen
    {
        public int Id { get; set; }
        public string Name { get; set; } //  varchar(30) DEFAULT NULL,
        public string Channel { get; set; } // varchar(30) DEFAULT NULL,
        public DateTime Timestamp { get; set; } // datetime DEFAULT NULL,
        public string Message { get; set; } // varchar(512) DEFAULT NULL,  
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GthxNet.Core
{
    public class FactoidHistory
    {
        public int Id { get; set; }
        public string Item { get; set; }
        public string Value { get; set; } // DEFAULT NULL
        public string Nick { get; set; } // varchar(30) DEFAULT NULL,
        public DateTime Dateset { get; set; } // datetime(6) DEFAULT NULL,
    }
}

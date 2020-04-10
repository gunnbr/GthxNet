using System;
using System.Collections.Generic;
using System.Text;

namespace GthxNet.Core
{
    public class YoutubeReferences
    {
        public string Item { get; set; } // varchar(255) NOT NULL,
        public string Title { get; set; } //  varchar(255) DEFAULT NULL,
        public int Count { get; set; } // int (11) NOT NULL,
        public DateTime LastReferenced { get; set; }
    }
}

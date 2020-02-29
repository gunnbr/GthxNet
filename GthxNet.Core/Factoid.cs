using System;
using System.Collections.Generic;
using System.Text;

namespace GthxNet.Core
{
    public class Factoid
    {
        public int Id { get; set; }
        public string Item { get; set; }
        public bool IsAre { get; set; }
        public string Value { get; set; }
        public string Nick { get; set; }
        public DateTime DateSet { get; set; }
        public bool IsLocked { get; set; }
        public DateTime LastSync { get; set; }
    }
}

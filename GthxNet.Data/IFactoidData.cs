using GthxNet.Core;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GthxNet.Data
{
    public interface IFactoidData
    {
        IEnumerable<Factoid> GetAll();
    }

    public class InMemoryFactoidData : IFactoidData
    {
        readonly List<Factoid> factoids;

        public InMemoryFactoidData()
        {
            factoids = new List<Factoid>()
            {
                new Factoid(){Id = 1, Item = "ender3", Value = "Quality cheap printer from China", Nick= "gunnbr", DateSet = new DateTime(2019,3,16) },
                new Factoid(){Id = 2, Item = "prusa", Value = "Joseph Prusa: The best printer designer", Nick= "Lizard|Work", DateSet = new DateTime(2015,4,21) },
                new Factoid(){Id = 3, Item = "#reprap", Value = "A wretched hive of villany", Nick= "hexa", DateSet = new DateTime(2016,1,3) },
            };
        }

        public IEnumerable<Factoid> GetAll()
        {
            return factoids.OrderBy(f => f.Item);
        }
    }
}

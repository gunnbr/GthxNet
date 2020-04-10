using GthxNet.Core;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GthxNet.Data
{
    public interface IFactoidData
    {
        IEnumerable<Factoid> GetFactoidsByName(string name);
        Factoid Update(Factoid updatedFactoid);
        Factoid Add(Factoid newFactoid);
        Factoid Delete(int id);
        int Commit();
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
                new Factoid(){Id = 4, Item = "printers", Value = "the best!", Nick= "rojro", DateSet = new DateTime(2016,4,21), IsAre=true },
                new Factoid(){Id = 5, Item = "botsnack", Value = "<reply>Yum, delicioso!", Nick= "gunnbr", DateSet = new DateTime(2015,4,21), IsLocked=true },
            };
        }

        public Factoid Add(Factoid newFactoid)
        {
            if (newFactoid == null)
            {
                return null;
            }

            factoids.Add(newFactoid);
            newFactoid.Id = factoids.Max(r => r.Id) + 1;
            return newFactoid;
        }

        public int Commit()
        {
            return 0;
        }

        public Factoid Delete(int id)
        {
            var factoid = factoids.FirstOrDefault(r => r.Id == id);
            factoids?.Remove(factoid);
            return null;
        }

        public IEnumerable<Factoid> GetFactoidsByName(string name = null)
        {
            if (name == null)
            {
                return factoids.OrderBy(f => f.Item);
            }

            return factoids.Where(f => f.Item.Contains(name, StringComparison.CurrentCultureIgnoreCase)).OrderBy(f => f.Item);
        }

        public Factoid Update(Factoid updatedFactoid)
        {
            if (updatedFactoid == null)
            {
                return null;
            }

            var factoid = factoids.SingleOrDefault(r => r.Id == updatedFactoid.Id);
            if (factoid != null)
            {
                factoid.Item = updatedFactoid.Item;
                factoid.IsAre = updatedFactoid.IsAre;
                factoid.Value = updatedFactoid.Value;
                factoid.DateSet = DateTime.UtcNow;
                factoid.IsLocked = updatedFactoid.IsLocked;
                factoid.LastSync = updatedFactoid.LastSync;
                factoid.Nick = updatedFactoid.Nick;
            }
            return factoid;
        }
    }
}

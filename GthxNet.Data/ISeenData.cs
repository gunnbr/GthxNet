using GthxNet.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GthxNet.Data
{
    public interface ISeenData
    {
        IEnumerable<Seen> GetSeenByName(string name);
        Factoid Delete(int id);
        int Commit();
    }

    public class InMemorySeenData : ISeenData
    {
        readonly List<Seen> seens;

        public InMemorySeenData()
        {
            seens = new List<Seen>()
            {
                new Seen(){Id = 1, Name = "vader", Channel = "#gthx", Message = "Luke, I am your father.", Timestamp = new DateTime(2019,3,16) },
            };
        }

        public IEnumerable<Seen> GetSeenByName(string name = null)
        {
            if (name == null)
            {
                return seens.OrderByDescending(s => s.Timestamp);
            }

            return seens.Where(s => s.Name.Contains(name, StringComparison.CurrentCultureIgnoreCase)).OrderBy(s => s.Name);
        }
        public Factoid Delete(int id)
        {
            var seen = seens.FirstOrDefault(r => r.Id == id);
            seens?.Remove(seen);
            return null;
        }

        public int Commit()
        {
            return 0;
        }
    }
}

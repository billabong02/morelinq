using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreLinQ
{
    class Maker 
    {
        public int Id { get; set; }
        public string Name { get; set; }   
             
        public Maker() {}

        public Maker(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public List<Maker> CreateList()
        {
            List<Maker> list = new List<Maker>();
            list.Add(new Maker(Id = 1, Name = "Toyota"));
            list.Add(new Maker(Id = 2, Name = "BMW"));
            list.Add(new Maker(Id = 3, Name = "Mercedes"));
            list.Add(new Maker(Id = 4, Name = "Mitsubishi"));
            list.Add(new Maker(Id = 5, Name = "Mini"));
            return list;
        }
    }
}

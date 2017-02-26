using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreLinQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Maker maker = new Maker();
            Car car = new Car();

            List<Car> carlist = car.CreateList();
            List<Maker> makerlist = maker.CreateList();

            var joined = from c in carlist
                         join m in makerlist
                         on c.Id equals m.Id
                         where c.Year == 2016
                         select new {m.Name, c.Model};

            Console.WriteLine("Cars made in the year 2016 are as follows:");
            Console.WriteLine("");

            foreach (var obj in joined)
            {
                Console.WriteLine(obj.Name + " " + obj.Model);
            }

            Console.ReadLine();
                       
        }
    }
}

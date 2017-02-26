using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreLinQ
{
    class Car
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public Car() {}

        public Car(int id, string model, int year)
        {
            Id = id;
            Model = model;
            Year = year;
        }

        public List<Car> CreateList()
        {
            List<Car> list = new List<Car>();
            list.Add(new Car(Id = 1, Model = "Corolla", Year = 2016));
            list.Add(new Car(Id = 2, Model = "750IL", Year = 2016));
            list.Add(new Car(Id = 3, Model = "W214", Year = 2016));
            list.Add(new Car(Id = 4, Model = "Lancer", Year = 2016));
            list.Add(new Car(Id = 5, Model = "Cooper X", Year = 2016));
            return list;
        }
    }    
}

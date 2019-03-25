using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismChallenge {
    class Program {
        static void Main(string[] args) {
            var cars = new List<Car> {
                new BMW("Z5", 200, "red"),
                new Audi("A4", 225, "black")
            };
            foreach (var car in cars) {
                //car.ShowDetails();
                car.Repair();
            }
            //Car bmw = new BMW("Z5", 200, "red");
            //bmw.ShowDetails();
            //bmw.Repair();
            //Car audi = new Audi("A4", 225, "black");
            //audi.ShowDetails();
            //audi.Repair();

            BMW bmwz5 = new BMW("Z5", 200, "red");
            Audi audiA4 = new Audi("A4", 225, "black");
            bmwz5.ShowDetails();
            audiA4.ShowDetails();

            Console.ReadKey();
        }
    }
}

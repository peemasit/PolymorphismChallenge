using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismChallenge {
    class Car {
        protected int HP { get; set; }
        protected string Color { get; set; }

        public Car(int hp, string color) {
            this.HP = hp;
            this.Color = color;
        }

        public void ShowDetails() {
            Console.WriteLine($"HP: {HP} - Color {Color}." );
        }

        public virtual void Repair() {
            Console.WriteLine("Car was repaired.");
        }

    }
}

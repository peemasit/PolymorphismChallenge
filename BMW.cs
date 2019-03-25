using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismChallenge {
    class BMW:Car {
        protected string Model { get; set; }
        private string Brand = "BMW";
        
        public BMW(string model, int hp, string color) : base(hp, color) {
            this.Model = model;
        }

        public new void ShowDetails() {
            Console.WriteLine($"Car brand {Brand} model {Model} - HP: {HP} - Color {Color}.");
        }

        public override void Repair() {
            Console.WriteLine($"The BMW {Model} was repaired.");
        }

    }
}

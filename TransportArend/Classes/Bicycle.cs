using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportArend.Classes
{
    class Bicycle : Transport
    {
        public override string DriveLicense { get { return "None"; } set { } }
        public override int NumOfWheels { get { return 2; } set { } }
        public override string Motor { get => base.Motor; set => base.Motor = value; }
        public override void Print()
        {
            Console.Write($"Велосипед {Model}, цвет: {Colour}, средняя скорость: {Speed} {IsArended}");
        }

        public override void Delivery()
        {
            Console.WriteLine("Ожидайте доставку");
        }

        public Bicycle(string model, string colour)
        {
            this.Model = model;
            this.Colour = colour;
            this.Speed = 30;
        }

        public override int GetClass()
        {
            return 1;
        }
    }
}

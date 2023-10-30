using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportArend.Classes
{
    class Bike : Transport
    {
        public override string DriveLicense { get { return "A"; } set { } }
        public override int NumOfWheels { get { return 2; } set { } }
        public override string Motor { get { return "МД"; } set => base.Motor = value; }
        public override void Print()
        {
            Console.Write($"Мотоцикл {Model}, цвет: {Colour}, средняя скорость: {Speed} {IsArended}");
        }

        public override void Delivery()
        {
            Console.WriteLine("Ожидайте доставку");
        }

        public Bike(string model, string colour, int speed)
        {
            this.Model = model;
            this.Colour = colour;
            this.Speed = speed;
        }

        public override int GetClass()
        {
            return 3;
        }
    }
}

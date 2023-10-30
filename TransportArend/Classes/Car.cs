using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportArend.Classes
{
    class Car : Transport
    {
        public override string DriveLicense { get { return "B"; } set { } }
        public override int NumOfWheels { get { return 4; } set { } }
        public override string Motor { get { return "ДВС"; } set => base.Motor = value; }
        public override void Print()
        {
            Console.Write($"Машина {Model}, цвет: {Colour}, средняя скорость: {Speed} {IsArended}");
        }

        public override void Delivery()
        {
            Console.WriteLine("Ожидайте доставку");
        }

        public Car(string model, string colour, int speed)
        {
            this.Model = model;
            this.Colour = colour;
            this.Speed = speed;
        }

        public override int GetClass()
        {
            return 0;
        }
    }
}

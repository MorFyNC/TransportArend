using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportArend.Classes
{
    class Boat: Transport
    {
        public override string DriveLicense { get { return "None"; } set { } }
        public override int NumOfWheels { get { return 0; } set { } }
        public override string Motor { get { return "ПЛМ"; } set => base.Motor = value; }
        public override void Print()
        {
            Console.WriteLine($"Лодка {Model}, цвет:{Colour}, средняя скорость:{Speed} {IsArended}");
        }
    }
}

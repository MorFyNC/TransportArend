using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportArend.Classes
{
    class Scooter : Transport
    {
        public override string DriveLicense { get { return "None"; } set { } }
        public override int NumOfWheels { get { return 2; } set { } }
        public override string Motor { get => base.Motor; set => base.Motor = value; }
        public override void Print()
        {
            Console.WriteLine($"Самокат {Model}, цвет:{Colour}, средняя скорость:{Speed} {IsArended}");
        }

        public override void Delivery()
        {
            Console.WriteLine("Ожидайте доставку");
        }
    }
}

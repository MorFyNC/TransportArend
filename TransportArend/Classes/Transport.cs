﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportArend.Classes
{
    abstract class Transport
    {
        protected string motor = "None";
        public abstract string DriveLicense { get; set; }
        public int Speed { get; set; }
        public string Colour { get; set; }
        public string Model { get; set; }
        public string IsArended { get; set; }
        public abstract int NumOfWheels { get; set; }
        public virtual string Motor
        {
            get { return motor; }
            set { motor = value; }
        }

        public abstract void Print();

        public virtual void Delivery()
        {
            Console.WriteLine("Данный транспорт не доставляется");
        }
        public void Arend()
        {
            Console.WriteLine($"Модель {Model} была арендована");
            IsArended = "арендована";
        }
        
        public void Return()
        {
            Console.WriteLine($"Модель {Model} возвращена");
            IsArended = "не арендована";
        }

        public abstract int GetClass();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_STO
{
    class Car
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public Car()
        {
            Name = "Unknown";
            Year = 2000;
        }

        public Car(string n, int y)
        {
            Name = n;
            Year = y;
        }
    }
}

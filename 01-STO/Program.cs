using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_STO
{
    class Program
    {
        static void Main(string[] args)
        {
            STO sto = new STO();
            sto.AddCar(new Car("Lexus", 2010));
            sto.AddCar(new Car("Toyota", 2012));
            sto.AddCar(new Car("Honda", 2015));
            sto.AddCar(new Car("Volvo", 2009));
            sto.RepairCar();
            sto.RepairCar();
            sto.FinishRepair();
            foreach (dynamic item in sto)
            {
                Console.WriteLine(item);
            }
        }
    }
}

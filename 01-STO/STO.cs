using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_STO
{
    class STO : IEnumerable
    {
        List<Car> Cars = new List<Car>();
        List<Car> Repair = new List<Car>();
        List<Car> Finish = new List<Car>();
        public void AddCar(Car c)
        {
            Cars.Add(c);
        }

        public void RepairCar()
        {
            Repair.Add(Cars[0]);
            Cars.RemoveAt(0);
        }
        public void FinishRepair()
        {
            Finish.Add(Repair[0]);
            Repair.RemoveAt(0);
        }

        public IEnumerator GetEnumerator()
        {
            return new Iteration(this);
        }

        struct Iteration
        {
            int lst;
            int ar;
            Car[][] arr = new Car[3][];          
            public object Current
            {
                get
                {
                    return car[lst][ar];
                }
            }

            public bool MoveNext()
            {
                ;
            }

            public void Reset()
            {
                throw new NotImplementedException();
            }
        }
    }
}

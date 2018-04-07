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
            return new MyIterator(this);
        }

        struct MyIterator : IEnumerator
        {
            STO sto;
            int current_lst;
            int current_arr;
            List<Car>[] carl;
            public MyIterator(STO s)
            {
                sto = s;
                carl = new List<Car>[3];
                carl[0] = sto.Cars;
                carl[1] = sto.Repair;
                carl[2] = sto.Finish;
                current_lst = 0;
                current_arr = -1;
            }
            public object Current
            {
                get
                {
                    return carl[current_lst][current_arr];
                }
            }

            public bool MoveNext()
            {
                if (carl[current_lst].Count-1 > current_arr)
                {
                    current_arr++;
                    return true;
                }
                else if (current_lst < 2)
                {    
                    current_arr = 0;
                    current_lst++;
                    if (carl[current_lst].Count == 0)
                        MoveNext();
                    return true;
                }
                else
                    return false;
            }

            public void Reset()
            {
                current_lst = 0;
                current_arr = -1;
            }
        }
    }
}

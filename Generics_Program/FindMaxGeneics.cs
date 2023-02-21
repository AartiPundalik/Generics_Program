using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Program
{
        public class FindMaxGenric<T> where T : IComparable
        {
            public T GenricValue(T firstNum, T secondNum, T thirdNum)
            {
                if (firstNum.CompareTo(secondNum) > 0 && firstNum.CompareTo(thirdNum) > 0)
                    return firstNum;
                else if (secondNum.CompareTo(thirdNum) > 0 && secondNum.CompareTo(firstNum) > 0)
                    return secondNum;
                else
                    return thirdNum;
                Console.ReadLine();
            }
        }
    }



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Program
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=================\nChoose Number :\n=================" +
         "\nEnter 1:Finding Maximum Numbers ");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    FindMaximum.FindIntMaxVal(3, 5, 1);
                    break;
                case 2:
                    FindMaximum.FindingStringMaximum("Pune", "Mumbai", "Rajasthan");
                    break;
            }
        }
    }
}

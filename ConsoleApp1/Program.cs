using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] omas = new int[7];

            
            for (int i = 0; i < omas.Length; i++)
            {
                omas[i] = i; 
            }

            foreach (int el in omas)
            {
                Console.Write($"{el}\t");
            }
            Console.ReadKey();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipilcationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eneter number of row/s: ");
            int row = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number of column/s: ");
            int col = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= col; j++)
                {
                    Console.Write(i * j + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}

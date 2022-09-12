using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InicijalnoPonavljanjeZadatak4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;
            int z;

            Console.WriteLine("Unesite vrijednost x, y i z");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            z = Convert.ToInt32(Console.ReadLine());
            

            if(x > 0 && y > 0 && z > 0)
            {
                if (x*x + y*y == z*z || z*z + y*y == x*x || z*z + x*x == y*y)
                {
                    Console.WriteLine("Trokut je pravokutan.");
                }
                else
                {
                    Console.WriteLine("Trokut nije pravokutan.");
                }
            }

            Console.ReadKey();
        }
    }
}

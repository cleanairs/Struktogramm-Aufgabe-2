using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struktogramm_Aufgabe_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geben Sie eine ganzzahlige zahl ein: ");
            int zahl1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Geben Sie eine ganzzahlige zahl ein: ");
            int zahl2 = Convert.ToInt32(Console.ReadLine());

            while (zahl1 < 10)
            {
                zahl2 = zahl1 * 10;
                Console.WriteLine(zahl1);
                Console.WriteLine(zahl2);
                zahl1 = zahl1 + zahl1;

            }
            Console.ReadLine();

           /*int wert = 1;

            for (int i = 1; i <= Zahl2; i++)
            {
                
                wert = wert * Zahl1;
               
            }
            Console.WriteLine(wert);
            Console.ReadLine();*/

        }
    }
}

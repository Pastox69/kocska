using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Negyszog;

namespace Negyzsogg
{
   public class Program
    {
       public static void Main()
        {
            // Példányosítom az osztályt
            NegyszogClass k1 = new NegyszogClass(3, 5);
            k1.SetKerulet();
            k1.SetTerulet();

            Console.WriteLine("A  Négyszög kerülete: {0: 0.00}, területe: {1: 0.00}", k1.getKerulet(), k1.getTerulet());

           
        }
    }
}
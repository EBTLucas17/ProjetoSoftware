using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSoftware
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            int c = 10;
            int d = 10;

            Calculadora calc = new Calculadora();
            int r = calc.Soma(a, b);
            int r2 = calc.Soma(c, d);
            Console.WriteLine("A soma do número {0} mais o número {1} é igual a {2}", a, b, r);
            Console.WriteLine("A soma do número {0} mais o número {1} é igual a {2}", c, d, r2);
            Console.ReadLine();
        }

       
    }
}

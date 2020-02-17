using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex01Cap4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creati un obiect Animal cu caracteristicile: tipAnimal de tip String (caine, pisica, iepure etc), culoare de tip String, varsta de tip int. 
            //Clasa va contine declararea variabilelor, metode de tip accesor (set si get) si 3 constructori.
            //In Program.cs sau o clasa cu metoda Main creati 3 instante ale clasei Animal in metoda main.

            Animal x1 = new Animal();
            x1.detaliiAnimal();
            x1.tipAnimal = "catel";
            x1.culoare = "alb";
            x1.varsta = 10;

            Console.WriteLine();
            Console.WriteLine("TipAnimal: " + x1.tipAnimal + "\nCuloare: " + x1.culoare + "\nVarsta: " + x1.varsta);

            Animal x2 = new Animal("pisica", "neagra");
            x2.varsta = 4;

            Console.WriteLine();
            Console.WriteLine("TipAnimal: " + x2.tipAnimal + "\nCuloare: " + x2.culoare + "\nVarsta: " + x2.varsta);


            Animal x3 = new Animal("papagal", "albastru", 3);
            Console.WriteLine();
            Console.WriteLine("TipAnimal: " + x3.tipAnimal + "\nCuloare: " + x3.culoare + "\nVarsta: " + x3.varsta);


            Console.ReadKey();
        }
    }

}

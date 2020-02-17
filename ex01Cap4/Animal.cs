using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex01Cap4
{
    class Animal
    {

        public string tipAnimal { get; set; }
        public string culoare { get; set; }
        public int varsta { get; set; }

        public string detaliiAnimal()
        {
            return "tipAnimal: " + tipAnimal + "\nCuloare: " + culoare + "\nVarsta: " + varsta;
        }

        //constructor implicit
        public Animal()
        {
            tipAnimal = "";
            culoare = "";
            varsta = 0;
        }



        //constructor cu 2 parametri
        public Animal(string tipAnimal, string culoare)
        {
            this.tipAnimal = tipAnimal;
            this.culoare = culoare;
            varsta = 0;
        }

        //constructor cu 3 parametri
        public Animal(string tipAnimal, string culoare, int varsta)
        {
            this.tipAnimal = tipAnimal;
            this.culoare = culoare;
            this.varsta = varsta;
        }
   
    }
}

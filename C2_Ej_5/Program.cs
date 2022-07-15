using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2_Ej_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca el valor para A: ");
            int numa = Convert.ToInt32(Console.ReadLine()); //leemos y asignamos a numa el valor de A
            Console.WriteLine("Introduzca el valor para B: ");
            int numb = Convert.ToInt32(Console.ReadLine()); //leemos y asignamos a numb el valor de B
            Console.WriteLine("Introduzca el valor para C: ");
            int numc = Convert.ToInt32(Console.ReadLine()); //leemos y asignamos a numc el valor de C
            Console.WriteLine("Introduzca el valor para D: ");
            int numd = Convert.ToInt32(Console.ReadLine()); //leemos y asignamos a numd el valor de D
            
            int numtemp = numb;
            numb = numc;
            numc = numa;
            numa = numd;
            numd = numtemp;

            //mostramos por pantalla los valores contenidos en las variables
            Console.WriteLine();
            Console.WriteLine("El valor de A es: " + numa);
            Console.WriteLine("El valor de B es: " + numb);
            Console.WriteLine("El valor de C es: " + numc);
            Console.WriteLine("El valor de D es: " + numd);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    //Reynoso Rosales Eduardo Guadalupe #21212036
    class Program
    {
        static void Main(string[] args)
        {
            int nEntero;
            try
            {
                 Console.Write("Indica un numero entero para calcular su cuadrado: ");
                 nEntero = int.Parse(Console.ReadLine());


                 Console.WriteLine("Numero al cuadrado: " + Math.Pow(nEntero, 2));

            }
            
            catch (FormatException)
            {
                 Console.WriteLine("Debes ingresar un numero ENTERO. \nNo se admite el uso de decimales y/o letras !!!");
                 Console.ReadKey();
            }
            
            catch (OverflowException)
            {
                 Console.WriteLine("Tu numero es muy grande !!!");
            }
            

            
            

                
            
            
        }
    }
}

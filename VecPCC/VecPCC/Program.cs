using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VecPCC
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] dato = new double[10];//0 -  n
            double buscar;

            //carga de datos
            for (int i = 0; i<10; i++)
            {
                //Console.WriteLine("i: "+i);
                Console.Write("ingrese un valor: ");
                dato[i] = double.Parse(Console.ReadLine());   
            }
            Console.WriteLine("----------------------------");
            for (int x=0; x<10; x++)
            {
                Console.WriteLine(dato[x]);
            }

            Console.WriteLine("----------------------------");

            Console.Write("ingrese el valor a buscar: ");
            buscar = double.Parse(Console.ReadLine());

            for (int z=0; z<10;z++)
            {
                if (buscar==dato[z])
                {
                    Console.WriteLine("el dato " + buscar + " existe");
                }
            }

            Console.ReadKey();
        }
    }
}

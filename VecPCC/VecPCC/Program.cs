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

            //carga de datos
            for (int i = 0; i<10; i++)
            {
                //Console.WriteLine("i: "+i);
                Console.Write("ingrese un valor: ");
                dato[i] = double.Parse(Console.ReadLine());   
            }


            Console.ReadKey();
        }
    }
}

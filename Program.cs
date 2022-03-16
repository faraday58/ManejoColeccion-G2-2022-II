using System;
using System.Collections;

namespace ManejoColeccion_G2_2022_II
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList alimentos = new ArrayList();

            alimentos.Add("Café");
            alimentos.Add("Pan Dulce");
            alimentos.Add("Galletas");
            alimentos.Add("Tamal");

         //   Console.WriteLine("Capacidad de elementos: {0} ",alimentos.Capacity);

            alimentos.Insert(1, "Guajolota");
            alimentos.Remove("Tamal");
            alimentos.Remove("Pan Dulce");
            alimentos.Add("Pan Dulce");
            alimentos.Add(16);
            alimentos.Add(10);


            Console.WriteLine("Total de elementos:{0}", alimentos.Count);
            Console.WriteLine("Capacidad de elementos: {0} ", alimentos.Capacity);

            for ( int i=0; i < alimentos.Count; i ++)
            {
                if (i < 4)
                {
                    Console.WriteLine(" Alimento: {0} ", alimentos[i]);
                }
                else
                {
                    Console.WriteLine("Precios: {0}", alimentos[i]);
                }    

            }


            /*foreach (string alimento in alimentos   )
            {
                Console.WriteLine(" Alimento: {0} ", alimento);
            }*/

            Console.ReadLine();


            




        }
    }
}

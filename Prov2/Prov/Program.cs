using System.Collections;
using System;

namespace Prov
{
    class Program
    {
        static void Main(string[] args)
        {
            int Limpa;
            ArrayList arlist1 = new ArrayList();
            arlist1.Add("Mjölk");
            arlist1.Add("Tårta");
            arlist1.Add("Ost");
            arlist1.Add("Skinka");
            arlist1.Add("Limpa");

            Random generator = new Random();
            string Limpa2 = "";
            Console.ReadLine();

            if (Limpa2 != "Limpa")
            {
                Limpa = generator.Next(1 - 100);
                Console.WriteLine("Limpa " + Limpa + " kg");
            }

            else
            {
                Console.WriteLine("Ogiltigt");
            }






        }
    }
}

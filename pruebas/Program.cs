using System;

namespace pruebas
{
    class Program
    {
        static void Main(string[] args)
        {
            double redondeo = 123.123456789012345;
            Console.WriteLine("Redondeo: " + redondeo);            

            for (int i = 1; i <= 15; i++)
            {
                Console.WriteLine("Redondeo: #"+ i +" = " + Math.Round(redondeo, i));
            }

            Console.ReadLine();
        }
    }
}
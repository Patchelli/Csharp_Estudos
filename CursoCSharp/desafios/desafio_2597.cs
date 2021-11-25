using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.desafios
{
    class desafio_2597
    {
        public static void Executar()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                double b = int.Parse(Console.ReadLine());
                Console.WriteLine(b - (Math.Floor(Math.Sqrt(b))));
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.desafios
{
    class desafio_1073
    {
        public static void Executar()
        {
            int n = int.Parse(Console.ReadLine());
            double contador = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    contador = Math.Pow(i, 2);
                    System.Console.WriteLine($"{i}^2 = {contador}");
                }
            }
        }
    }
}

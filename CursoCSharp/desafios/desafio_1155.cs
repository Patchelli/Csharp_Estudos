using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CursoCSharp.desafios
{
    class desafio_1155
    {
        public static void Executar()
        {
            double S = 1;

            for (int i = 2; i <= 100; i++)
            {
                S += (double)1 / i;
            }

            Console.WriteLine(S.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

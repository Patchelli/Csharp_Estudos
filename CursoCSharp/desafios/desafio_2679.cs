using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CursoCSharp.desafios
{
    class desafio_2679
    {
        public static void Executar()
        {
            int x = int.Parse(Console.ReadLine());
            int resultado = x % 2 == 0 ? x + 2 : x + 1;
            System.Console.WriteLine(resultado);
        }
    }
}
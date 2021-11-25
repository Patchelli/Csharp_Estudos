using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CursoCSharp.desafios
{
    class desafio_1164
    {
        public static void Executar()
        {
            string str;
            while ((str = Console.ReadLine()) != null)
            {
                if (str == "0")
                {
                    Console.WriteLine("vai ter copa!");
                }
                else
                {
                    Console.WriteLine("vai ter duas!");
                }
            }
        }
    }
}
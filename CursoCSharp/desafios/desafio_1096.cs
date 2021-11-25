using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CursoCSharp.desafios
{
    class desafio_1096
    {
        public static void Executar()
        {
            int I, J;
            I = 1;

            for (int c = 1; c <= 5; c++)
            {
                J = 7;
                for (int e = 0; e < 3; e++)
                {
                    Console.WriteLine("I=" + I + " J=" + J);
                    J--;
                }
                I += 2;
            }
        }
    }
}


// Teste #1
// 
// Dado de entrada:
// No need input, check output only!
// Saída esperada:
// I=1 J=7
// I=1 J=6
// I=1 J=5
// I=3 J=7
// I=3 J=6
// I=3 J=5
// I=5 J=7
// I=5 J=6
// I=5 J=5
// I=7 J=7
// I=7 J=6
// I=7 J=5
// I=9 J=7
// I=9 J=6
// I=9 J=5
// Sua Saída:
// I=1 J=7
// I=1 J=6
// I=1 J=5
// I=3 J=7
// I=3 J=6
// I=3 J=5
// I=5 J=7
// I=5 J=6
// Mensagem:
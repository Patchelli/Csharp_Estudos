using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ManipularStrings
{
    class IsNullOrEmpty
    {
        public static void Executar()
        {

            string nulo = null;

            bool v = string.IsNullOrEmpty(nulo);

            System.Console.WriteLine(v);


        }
    }
}

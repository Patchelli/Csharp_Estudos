using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ManipularStrings
{
    class StarsWith_EndsWith_Contains
    {
        public static void Executar()
        {
            string urlTeste = "https://www.bytebank.com/cambio";
            int indiceByteBank = urlTeste.IndexOf("https://www.bytebank.com");

            //começa com 
            Console.WriteLine(urlTeste.StartsWith("https://www.bytebank.com"));
            //termina com 
            Console.WriteLine(urlTeste.EndsWith("cambio/"));

            //contem a string - true or false
            Console.WriteLine(urlTeste.Contains("bytebank"));


            Console.ReadLine();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ManipularStrings
{
    class indexOf_Substring
    {
        public static void Executar()
        {

            string url = "paginasInicias?argumentosPassados";
            int indiceInterrogacao = url.IndexOf('?');
            var newUrl = url.Substring(indiceInterrogacao + 1);
            System.Console.WriteLine(newUrl);


            // var urlSplit = url.Split('?');
            // System.Console.WriteLine(urlSplit[0]);
            // System.Console.WriteLine(urlSplit[1]);


            // string novaUrl = "paginasInicias?moedaOrigem=real&moedaDestino=dolar";

        }
    }
}

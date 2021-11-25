using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ManipularStrings
{
    class Replace_Remove
    {
        public static void Executar()
        {
            //Testando ToLower
            string mensagemOrigem = "PALAVRA";
            string termoBusca = "ra";

            Console.WriteLine(mensagemOrigem.ToLower());


            // Testando Replace
            termoBusca = termoBusca.Replace('r', 'R');
            Console.WriteLine(termoBusca);

            termoBusca = termoBusca.Replace('a', 'A');
            Console.WriteLine(termoBusca);

            Console.WriteLine(mensagemOrigem.IndexOf(termoBusca));
            Console.ReadLine();

            // Testando o método Remove
            string testeRemocao = "primeiraParte&123456789";
            int indiceEComercial = testeRemocao.IndexOf('&');
            Console.WriteLine(testeRemocao.Remove(indiceEComercial, 4));


        }
    }
}

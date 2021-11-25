using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace CursoCSharp.ManipularStrings
{
    class RegexER
    {
        public static void Executar()
        {

            // Olá, meu nome é Guilherme e você pode entrar em contato comigo
            // através do número 8457-4456!

            // Meu nome é Guilherme, me ligue em 4784-4546

            //  "[0123456789][0123456789][0123456789][0123456789][-][0123456789][0123456789][0123456789][0123456789]";
            //  "[0-9][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]";
            //  "[0-9]{4,5}[-][0-9]{4}";
            //  "[0-9]{4,5}[-]{0,1}[0-9]{4}";
            //  "[0-9]{4,5}-{0,1}[0-9]{4}";
            string padrao = "[0-9]{4,5}-?[0-9]{4}";

            // 879.546.120-20
            // 879546120-20
            string textoDeTeste = "idyufdgfugfjkdawdwadsdhf dwadawd 99871-5456 dwdwadws djkfgsdjgsjgh sfsdjgsdjghsdfj";
            //IsMatch retorna um bool
            var resultado = Regex.IsMatch(textoDeTeste, padrao);
            System.Console.WriteLine(resultado);
            Match matchResultado = Regex.Match(textoDeTeste, padrao);

            Console.WriteLine(matchResultado.Value);
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int PROD = a * b;
            Console.WriteLine("PROD = " + PROD);






        }
    }
}

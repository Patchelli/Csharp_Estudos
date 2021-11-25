using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaIf
    {
        public static void Executar()
        {
            bool bomComportamento = false;
            string entrada;

            Console.Write("Digite a nota do aluno: ");
            entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);

            Console.WriteLine("Possui bom comportamento (S/N): ");
            entrada = Console.ReadLine();

            //if (entrada == "S" || entrada == "s")
            //    bomComportamento = true;

            // bomComportamento = entrada == "S" || entrada == "s";
            bomComportamento = entrada.ToLower() == "s";


            string resultado = nota >= 9.0 && bomComportamento ? "Aprovado : Quadro de honra!" : nota <= 7.0 && nota >= 4.0 || bomComportamento ? "Recuperação" : "Reprovado";

            System.Console.WriteLine(resultado);
        }
    }
}

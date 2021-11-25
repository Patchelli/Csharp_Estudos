using System;

namespace CursoCSharp.ClassesEMetodos
{
    class Membros
    {
        public static void Executar()
        {
            Pessoa sicrano = new Pessoa();
            sicrano.Nome = "Renato";
            sicrano.Idade = 21;

            // Console.WriteLine($"{sicrano.Nome} tem {sicrano.Idade} anos.");

            sicrano.ApresentarNoConsole();
            // sicrano.Zerar(); // limpa nome e idade feito referencia no objeto
            // sicrano.ApresentarNoConsole();

            var fulano = new Pessoa();
            fulano.Nome = "Beto";
            fulano.Idade = 21;

            var apresentacaoDoFulano = fulano.Apresentar();
            Console.WriteLine($"Conta os caracteres da string, {apresentacaoDoFulano.Length}");
            Console.WriteLine(apresentacaoDoFulano);
        }
    }
}

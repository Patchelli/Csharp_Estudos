using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.Fundamentos;
using CursoCSharp.MetodosEFuncoes;
using CursoCSharp.OO;
using CursoCSharp.Excecoes;
using CursoCSharp.TopicosAvancados;
using System;
using System.Collections.Generic;
using CursoCSharp.ManipularStrings;
using CursoCSharp.desafios;

namespace CursoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                // Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"comentários - fundamentos", Comentarios.Executar},
                {"váriaveis e constantes - fundamentos", VariaveisEConstantes.Executar},
                {"inferência - fundamentos", Inferencia.Executar},
                {"interpolação - fundamentos", Interpolacao.Executar},
                {"notação ponto - fundamentos", NotacaoPonto.Executar},
                {"lendo dados - fundamentos", LendoDados.Executar},
                {"formatando número - fundamentos", FormatandoNumero.Executar},
                {"conversões - fundamentos", Conversoes.Executar},
                {"operadores aritmeticos - fundamentos", OperadoresAritmeticos.Executar},
                {"operadores relacionais - fundamentos", OperadoresRelacionais.Executar},
                {"operadores logicos - fundamentos", OperadoresLogicos.Executar},
                {"operadores de atribuição - fundamentos", OperadoresAtribuicao.Executar},
                {"operadores unários - fundamentos", OperadoresUnarios.Executar},
                {"operador ternário - fundamentos", OperadorTernario.Executar},
                
                // estruturas de controle
                {"estrutura if - estruturas de controle", EstruturaIf.Executar},
                {"estrutura if/else - estruturas de controle", EstruturaIfElse.Executar},
                {"estrutura if/else/if - estruturas de controle", EstruturaIfElseIf.Executar},
                {"estrutura switch - estruturas de controle", EstruturaSwitch.Executar},
                {"estrutura while - estruturas de controle", EstruturaWhile.Executar},
                {"estrutura do while - estruturas de controle", EstruturaDoWhile.Executar},
                {"estrutura for - estruturas de controle", EstruturaFor.Executar},
                {"estrutura foreach - estruturas de controle", EstruturaForEach.Executar},
                {"usando break - estruturas de controle", UsandoBreak.Executar},
                {"usando continue - estruturas de controle", UsandoContinue.Executar},

                // classes e métodos
                { "membros - classes e métodos", Membros.Executar},
                { "construtores - classes e métodos", Construtores.Executar},
                { "métodos com retorno - classes e métodos", MetodosComRetorno.Executar},
                { "métodos estáticos - classes e métodos", MetodosEstaticos.Executar},
                { "atributos estáticos - classes e métodos", AtributosEstaticos.Executar},
                { "desafio atributo - classes e métodos", DesafioAtributo.Executar},
                { "params - classes e métodos", Params.Executar},
                { "parametros nomeados - classes e métodos", ParametrosNomeados.Executar},
                { "get set - classes e métodos", GetSet.Executar},
                { "props - classes e métodos", Props.Executar},
                { "readonly - classes e métodos", Readonly.Executar},
                { "enum - classes e métodos", ExemploEnum.Executar},
                { "struct - classes e métodos", ExemploStruct.Executar},
                { "struct vs classe - classes e métodos", StructVsClasse.Executar},
                { "valor vs referência - classes e métodos", ValorVsReferencia.Executar},
                { "parâmetros por referência - classes e métodos", ParametrosPorReferencia.Executar},
                { "parâmetro com valor padrão - classes e métodos", ParametroPadrao.Executar},

                // coleções
                { "array - coleções", Colecoes.Array.Executar},
                { "list - coleções", ColecoesList.Executar},
                { "array list - coleções", ColecoesArrayList.Executar},
                { "set - coleções", ColecoesSet.Executar},
                { "queue - coleções", ColecoesQueue.Executar},
                { "igualdade - coleções", Igualdade.Executar},
                { "stack - coleções", ColecoesStack.Executar},
                { "dictionary - coleções", ColecoesDictionary.Executar},

                //desafios
                {"desafio_2596",desafio_2597.Executar},
                {"desafio_1073",desafio_1073.Executar},
                {"desafio_1155",desafio_1155.Executar},
                {"desafio_1098",desafio_1098.Executar},
                // oo
                { "herança - oo", Heranca.Executar},
                { "construtor this - oo", ConstrutorThis.Executar},
                { "encapsulamento - oo", OO.Encapsulamento.Executar},
                { "polimorfismo - oo", Polimorfismo.Executar},
                { "abstract - oo", Abstract.Executar},
                { "interface - oo", Interface.Executar},
                { "sealed - oo", Sealed.Executar},

                // métodos & funções
                { "exemplo lambda - métodos & funções", ExemploLambda.Executar},
                { "lambdas como delegates - métodos & funções", LambdasDelegate.Executar},
                { "usando delegates - métodos & funções", UsandoDelegates.Executar},
                { "delegates como função anonima - métodos & funções", DelegateFunAnonima.Executar},
                { "delegates como parâmetros - métodos & funções", DelegatesComoParametros.Executar},
                { "métodos de extensão - métodos & funções", MetodosDeExtensao.Executar},

                // exceções
                { "primeira exceção - exceções", PrimeiraExcecao.Executar},
                { "exceções personalizadas - exceções", ExcecoesPersonalizadas.Executar},

                // api
                //{ "primeiro arquivo - usando api", primeiroarquivo.executar},
                //{ "lendo arquivos - usando api", lendoarquivos.executar},
                //{ "exemplo fileinfo - usando api", exemplofileinfo.executar},
                //{ "diretórios - usando api", diretorios.executar},
                //{ "exemplo directoryinfo - usando api", exemplodirectoryinfo.executar},
                //{ "exemplo path - usando api", exemplopath.executar},
                //{ "exemplo datetime - usando api", exemplodatetime.executar},
                //{ "exemplo timespan - usando api", exemplotimespan.executar},

                //Regex
                {"manipular string - indexOf&Substring",indexOf_Substring.Executar},
                {"isnullorempty",IsNullOrEmpty.Executar},
                {"length",Length.Executar},
                {"starsWith&endsWith&contains",StarsWith_EndsWith_Contains.Executar},
                {"replace_remove",Replace_Remove.Executar},
                {"regex",RegexER.Executar},

                // tópicos avançados
                //{ "linq #01 - tópicos avançados", linq1.executar},
                //{ "linq #02 - tópicos avançados", linq2.executar},
                //{ "nullables - tópicos avançados", nullables.executar},
                //{ "dynamics - tópicos avançados", dynamics.executar},
                { "genéricos - tópicos avançados", Genericos.Executar},
            });
            central.SelecionarEExecutar();
        }
    }
}
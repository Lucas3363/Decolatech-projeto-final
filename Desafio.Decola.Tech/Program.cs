using System;
using Desafio.Decola.Tech;

namespace DesafioDecola
{
    class projeto
    {
        static RepositorioSeries repositorio = new RepositorioSeries();
        static void Main(string[] args)
        {

            string escolha = Escolha();

            while (escolha != "0")
            {
                
                switch(escolha)
                {
                    case "1":
                        MostrarSeries();
                        break;
                    case "2":
                        InserirSerie();
                        break;
                    case "3":
                        AtualizarSerie();
                        break;
                    case "4":
                        ExcluirSerie();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                escolha = Escolha();
            }

        }

        private static void ExcluirSerie()
        {
            System.Console.WriteLine("Digite o indice que deseja apagar: ");
            int idx = int.Parse(Console.ReadLine());

            repositorio.Excluir(idx);

        }
        private static void MostrarSeries()
        {

            System.Console.WriteLine("Series Disponiveis!!");
            System.Console.WriteLine();
            var dicionario = repositorio.Lista();

            if (dicionario.Count == 0)
            {
                System.Console.WriteLine("Não há nenhuma Serie cadastrada.");
                return;
            }

            foreach (var item in dicionario)
            {
                System.Console.WriteLine($"ID {item.Key} - {item.Value}");
            }
        }
        private static void InserirSerie()
        {

            System.Console.WriteLine("Inserir nova série.");
            System.Console.WriteLine();

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                System.Console.WriteLine($"{i} - {Enum.GetName(typeof(Genero), i)}");
            }

            System.Console.WriteLine("Digite o genero dentre os acima: ");
            int EntradaGenero = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite o nome da série: ");
            string nome = Console.ReadLine();

            System.Console.WriteLine("Digite o ano da série: ");
            int ano = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite uma breve descrição da série: ");
            string descricao = Console.ReadLine();

            Series newserie = new Series( repositorio.NextID(repositorio.Lista()), (Genero)EntradaGenero, nome, descricao, ano);
            repositorio.Inserir( repositorio.NextID(repositorio.Lista()), newserie);

        }

        private static void AtualizarSerie()
        {
            System.Console.WriteLine("Digite O ID a ser substituido: ");
            int index = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Inserir nova série.");
            System.Console.WriteLine();

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                System.Console.WriteLine($"{i} - {Enum.GetName(typeof(Genero), i)}");
            }

            System.Console.WriteLine("Digite o genero dentre os acima: ");
            int EntradaGenero = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite o nome da série: ");
            string nome = Console.ReadLine();

            System.Console.WriteLine("Digite o ano da série: ");
            int ano = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite uma breve descrição da série: ");
            string descricao = Console.ReadLine();

            Series newserie = new Series( index, (Genero)EntradaGenero, nome, descricao, ano);
            repositorio.Update( index, newserie);

        }

        private static string Escolha()
        {
            System.Console.WriteLine();
            System.Console.WriteLine("");
            System.Console.WriteLine("Bem vindo ao Listador de Series do desafio DIO");

            System.Console.WriteLine("Qual opcao deseja acessar?");
            System.Console.WriteLine("1 - Listar Series");
            System.Console.WriteLine("2 - Inserir nova Serie");
            System.Console.WriteLine("3 - Atualizar Serie");
            System.Console.WriteLine("4 - Remover Serie");
            System.Console.WriteLine("0 - Sair");
            System.Console.WriteLine();

            string Escolha = Console.ReadLine();
            System.Console.WriteLine();
            
            return Escolha;
        }
    }
}
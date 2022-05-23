using Exemplo.Biblioteca.Statica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_gestão_de_uma_biblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao = 1;
            int qtdCadastrados = 0;
            string codigo = string.Empty;

            List<Livro> listaLivros = new List<Livro>();
            Livro livroEncontrado = new Livro();

            while (opcao != 4)
            {
                Console.WriteLine("SELECIONE UM OPÇÃO");
                Console.WriteLine("1 - Cadastrar um Livro\n2 - Pesquisar Por um Livro\n3 - Listar Todos Os Livros\n4 - Sair");
                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:

                        Livro livro = new Livro();

                        Console.WriteLine("Informe o titulo do livro");
                        livro.Titulo = Console.ReadLine();

                        Console.WriteLine("Informe o Codigo do livro");
                        livro.Codigo= Console.ReadLine();
                     
                       qtdCadastrados++;
                        Biblioteca.CadastrarLivro(livro);

                        break;
                    case 2:
                        Console.WriteLine("Informe o codigo do livro");
                        codigo = Console.ReadLine();

                        livroEncontrado = Biblioteca.BurcarLivro(codigo);
                        Console.WriteLine("\nLIVRO ENCONTRADO\n");
                        Console.WriteLine($"{livroEncontrado.Titulo}");
                        Console.WriteLine($"{livroEncontrado.Codigo}\n");
                        
                        break;
                    case 3:
                        listaLivros = Biblioteca.ListarLivros();
                        Console.WriteLine("\nLIVROS DA LISTA\n");
                        foreach (var item in listaLivros)
                        {
                            
                            Console.WriteLine($"{item.Titulo}\n");
                        }
                        break;
                    case 4:
                        Console.WriteLine($"Foram cadastrados {qtdCadastrados} livros");
                        break;
                }
            }

            Console.ReadKey();


        }
    }
}

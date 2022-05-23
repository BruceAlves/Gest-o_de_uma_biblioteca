using Exercício_gestão_de_uma_biblioteca;
using System.Collections.Generic;

namespace Exemplo.Biblioteca.Statica
{
    public static class Biblioteca
    {
        public static List<Livro> Livros = new List<Livro>(); // esta é a sua lista de livros

        // OBS: todos os metodos tem a palavrinha "static" depois do modificador de acesso
        // exemplo:
        public static void CadastrarLivro(Livro livro)
        {
            Livros.Add(livro);
        }

        // Metodo de listar todos os livros
        public static List <Livro> ListarLivros()
        {

            return Livros;
        }

        // Metodo de buscar um livro pelo código

        public static Livro BurcarLivro(string codigo)
        {
            foreach (var item in Livros)
            {
                if(item.Codigo == codigo)
                {
                    return item;
                }
            }
            return null;
        }

        // Metodo de cadastrar um livro

    }
}

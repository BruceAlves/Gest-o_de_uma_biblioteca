using System;

namespace Exemplo.Biblioteca.Statica
{
    public class Livro
    {
        public string Titulo { get; set; }
        public string Codigo { get; set; }
        public DateTime DataCadastro { get; private set; } = DateTime.Now;
    }
}
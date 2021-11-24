using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proj_Biblioteca.Models
{
    public class Livro
    {
        public Livro(
             int id
            ,string autor
            ,string codigo
            ,string nome
            ,string descricao)
        {
            Id = id;
            Autor = autor;
            Codigo = codigo;
            NomeDoLivro = nome;
            Descricao = descricao;
        }

        public int Id { get; set; }
        public string Autor { get; set; }
        public string Codigo { get; set; }
        public string NomeDoLivro { get; set; }
        public string Descricao { get; set; }
    }
}

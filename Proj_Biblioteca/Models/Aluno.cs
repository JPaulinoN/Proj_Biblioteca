using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proj_Biblioteca.Models
{
    public class Aluno
    {

        public Aluno(
             int id
            ,string nome
            ,string email
            ,string telefone
            ,string curso
            ,string periodo)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Telefone = telefone;
            Curso = curso;
            Periodo = periodo;
        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Curso { get; set; }
        public string Periodo { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore_DI.Models
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        public List<Usuario> GetTodosUsuarios()
        {
            return new List<Usuario>
           {
               new Usuario()
               {
                   Nome = "Teste",
                   Sobrenome="1",
                   Nascimento= new DateTime(1997,02,03),
                   NomeUsuario="willian"
               },
               new Usuario()
               {
                   Nome = "Teste",
                   Sobrenome="2",
                   Nascimento= new DateTime(1999,11,08),
                   NomeUsuario="willian"
               },
           };
        }
    }
}

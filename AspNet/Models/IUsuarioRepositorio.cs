using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore_DI.Models
{
    public interface IUsuarioRepositorio
    {
        List<Usuario> GetTodosUsuarios();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entidades;

namespace DomainService.Interfaces
{
    public interface IUsuarioService
    {
        Usuario GetUsuario(int id);
        List<Usuario> GetUsuarios();
        void InsertUsuario(Usuario avaliacao);
        void UpdateUsuario(Usuario avaliacao);
        void DeleteUsuario(int id);

    }
}

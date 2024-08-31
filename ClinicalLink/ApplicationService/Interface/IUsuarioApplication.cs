using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entidades;

namespace ApplicationService.Interface
{
    public interface IUsuarioApplication
    {
        Usuario GetUsuario(int id);
        List<Usuario> GetUsuarios();
        void InsertUsuario(Usuario usuario);
        void UpdateUsuario(Usuario usuario);
        void DeleteUsuario(int id);
    }
}

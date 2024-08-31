using Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicalLink.Infrastructure.Interface
{
    public interface IUsuarioRepository
    {
        public Usuario GetUsuario(int id);
        public List<Usuario> GetUsuarios();
        public void InsertUsuario(Usuario usuario);
        public void UpdateUsuario(Usuario usuario);
        public void DeleteUsuario(Usuario usuario);

    }
}


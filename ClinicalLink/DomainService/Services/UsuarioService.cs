using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainService.Interfaces;
using Domain.Entidades;
using ClinicalLink.Infrastructure.Interface;

namespace DomainService.Services
{

    public class UsuarioService : IUsuarioService
    {
        public readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }
        public Usuario GetUsuario(int id)
        {
            return _usuarioRepository.GetUsuario(id);
        }

        public List<Usuario> GetUsuarios()
        {
            return _usuarioRepository.GetUsuarios();
        }


        public void InsertUsuario(Usuario usuario)
        {
            _usuarioRepository.InsertUsuario(usuario);
        }

        public void UpdateUsuario(Usuario usuario)
        {
            _usuarioRepository.UpdateUsuario(usuario);
        }

        public void DeleteUsuario(int id)
        {

            var Usuario = _usuarioRepository.GetUsuario(id);
            if (Usuario == null)
                throw new Exception("Essa denuncia Não Existe.");

            _usuarioRepository.DeleteUsuario(Usuario);
        }


    }
}

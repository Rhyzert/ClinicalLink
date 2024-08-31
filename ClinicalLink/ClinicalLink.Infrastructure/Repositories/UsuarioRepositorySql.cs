using ClinicalLink.Infrastructure.Interface;
using Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ClinicalLink.Infrastructure.Repositories
{
    public class UsuarioRepositorySql : IUsuarioRepository
    {
        private readonly SqlContext _context;

        public UsuarioRepositorySql(SqlContext context)
        {
            _context = context;
        }

        public Usuario GetUsuario(int id)
        {
            try
            {
                return _context.Usuarios.Find(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<Usuario> GetUsuarios()
        {
            try
            {
                return _context.Usuarios.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void InsertUsuario(Usuario usuario)
        {
            try
            {
                _context.Usuarios.Add(usuario);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }


        public void UpdateUsuario(Usuario usuario)
        {
            try
            {
                _context.Entry(usuario).State = EntityState.Modified;
                _context.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void DeleteUsuario(Usuario usuario)
        {
            try
            {
                _context.Set<Usuario>().Remove(usuario);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }



    }

}
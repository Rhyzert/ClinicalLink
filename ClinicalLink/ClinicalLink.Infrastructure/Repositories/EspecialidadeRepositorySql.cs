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
    public class EspecialidadeRepositorySql : IEspecialidadeRepository
    {
        private readonly SqlContext _context;

        public EspecialidadeRepositorySql(SqlContext context)
        {
            _context = context;
        }

        public Especialidade GetEspecialidade(int id)
        {
            try
            {
                return _context.Especialidades.Find(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<Especialidade> GetEspecialidades()
        {
            try
            {
                return _context.Especialidades.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void InsertEspecialidade(Especialidade especialidade)
        {
            try
            {
                _context.Especialidades.Add(especialidade);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }


        public void UpdateEspecialidade(Especialidade especialidade)
        {
            try
            {
                _context.Entry(especialidade).State = EntityState.Modified;
                _context.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void DeleteEspecialidade(Especialidade especialidade)
        {
            try
            {
                _context.Set<Especialidade>().Remove(especialidade);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }



    }

}
using Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicalLink.Infrastructure.Interface
{
    public interface IFuncionalidadeSupervisaoRepository
    {
        public List<Usuario> GetAlunosSupervisao(int idSupervisor);
        public List<Avaliacao> BuscarAvaliacoesSupervisao(int idUsuario);
        public Consulta BuscarConsultasSupervisao(int idUsuario);
        public List<Consulta> ConsultasMensais(Usuario usuario,string dataInicio,string dataFim);
        

    }
}


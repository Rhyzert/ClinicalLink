using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entidades;

namespace DomainService.Interfaces
{
    public interface IFuncionalidadeSupervisaoService
    {
        List<Usuario> GetAlunosSupervisao(int idSupervisor);
        List<Avaliacao> BuscarAvaliacoesSupervisao(int idUsuario);
        Consulta BuscarConsultasSupervisao(int idUsuario);
        List<Consulta> ConsultasMensais(Usuario usuario, string dataInicio, string dataFim);


    }
}

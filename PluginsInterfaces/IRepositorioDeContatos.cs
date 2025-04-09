using CoreBusiness.Entidades;
using System.Threading.Tasks;

namespace ProvaRodolfo.PluginsInterfaces
{
    public interface IRepositorioDeContatos
    {
        Task EditarAsync(Contato contato);
    }
}

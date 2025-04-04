using CoreBusiness.Entidades;
using System.Threading.Tasks;

namespace PluginsInterfaces
{
    public interface IRepositorioDeContatos
    {
        Task EditarAsync(Contato contato);
    }
}

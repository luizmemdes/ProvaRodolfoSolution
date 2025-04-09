using CoreBusiness.Entidades;
using System.Threading.Tasks;

namespace CasosDeUso.Interface
{
    public interface IEditarContatoUseCase
    {
        Task ExecutaAsync(Contato contato);
    }
}

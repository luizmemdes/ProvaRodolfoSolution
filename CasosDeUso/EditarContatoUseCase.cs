using CasosDeUso.Interface;
using CoreBusiness.Entidades;
using PluginsInterfaces;
using System.Threading.Tasks;

namespace CasosDeUso
{
    public class EditarContatoUseCase : IEditarContatoUseCase
    {
        private readonly IRepositorioDeContatos _repositorio;

        public EditarContatoUseCase(IRepositorioDeContatos repositorio)
        {
            _repositorio = repositorio;
        }

        public async Task ExecutaAsync(Contato contato)
        {
            await _repositorio.EditarAsync(contato);
        }
    }
}

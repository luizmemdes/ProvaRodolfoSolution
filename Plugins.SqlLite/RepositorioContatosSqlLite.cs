using CoreBusiness.Entidades;
using ProvaRodolfo.PluginsInterfaces; // <- esse aqui é o novo namespace certo
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Plugins.SqlLite
{
    public class RepositorioContatosSqlLite : IRepositorioDeContatos
    {
        private List<Contato> _contatos = new();

        public Task EditarAsync(Contato contato)
        {
            
            return Task.CompletedTask;
        }
    }
}

using CoreBusiness.Entidades;
using PluginsInterfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Plugins.SqlLite
{
    public class RepositorioContatosSqlLite : IRepositorioDeContatos
    {
        private List<Contato> _contatos = new();

        public Task EditarAsync(Contato contato)
        {
            // Simula edição (aqui você implementaria a lógica real com SQLite)
            return Task.CompletedTask;
        }
    }
}

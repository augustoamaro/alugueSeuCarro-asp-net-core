using AlugueSeuCarro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlugueSeuCarro.AcessoDados.Interfaces
{
    public interface IContaRepositorio : IRepositorioGenerico<Conta>
    {
        new Task<IEnumerable<Conta>> PegarTodos();
        int PegarSaldoPeloId(string Id);
        Task<Conta> PegarSaldoPeloUsuarioId(string id);
    }
}

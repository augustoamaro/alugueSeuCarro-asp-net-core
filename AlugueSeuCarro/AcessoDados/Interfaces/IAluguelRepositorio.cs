using AlugueSeuCarro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlugueSeuCarro.AcessoDados.Interfaces
{
    public interface IAluguelRepositorio : IRepositorioGenerico<Aluguel>
    {
        Task<bool> VerificarReserva(string usuarioId, int carroId, string dataInicio, string dataFim);
    }
}

using AlugueSeuCarro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace AlugueSeuCarro.AcessoDados.Interfaces
{
    public interface IRepositorioGenerico<TEntity> where TEntity : class
    {
        IQueryable<TEntity> PegarTodos();
        Task<TEntity> PegarPeloId(int id);
        Task<TEntity> PegarPeloId(string id);
        Task Inserir(TEntity entity);
        Task Atualizar(TEntity entity);
        Task Excluir(int id);
        Task Excluir(string id);
    }
}

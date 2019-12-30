using AlugueSeuCarro.AcessoDados.Interfaces;
using AlugueSeuCarro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlugueSeuCarro.AcessoDados.Repositorios
{
    public class CarroRepositorio : RepositorioGenerico<Carro>, ICarroRepositorio
    {
        public CarroRepositorio(Contexto contexto) : base(contexto)
        {
        }
    }
}

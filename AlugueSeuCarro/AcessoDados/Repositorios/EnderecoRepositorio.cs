using AlugueSeuCarro.AcessoDados.Interfaces;
using AlugueSeuCarro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlugueSeuCarro.AcessoDados.Repositorios
{
    public class EnderecoRepositorio : RepositorioGenerico<Endereco>, IEnderecoRepositorio
    {
        public EnderecoRepositorio(Contexto contexto) : base(contexto)
        {
        }
    }
}

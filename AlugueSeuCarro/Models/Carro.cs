using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlugueSeuCarro.Models
{
    public class Carro
    {
        public int CarroId { get; set; }
        public string Nome { get; set; }
        public string Marca { get; set; }
        public string Foto { get; set; }
        public int PrecoDia { get; set; }
        public bool Disponibilidade { get; set; }

        public ICollection<Aluguel> Alugueis { get; set; }
    }
}

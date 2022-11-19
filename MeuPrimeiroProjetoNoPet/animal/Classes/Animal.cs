using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuPrimeiroProjetoNoPet.animal.Classes
{
    public abstract class Animal
    {
        public Animal() { }
        public string? Nome { get; set; }
        public int Idade { get; set; }
        public string? Cor { get; set; }
        public abstract void Velocidade();
    }
}


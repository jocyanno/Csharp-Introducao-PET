using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuPrimeiroProjetoNoPet.animal.Classes
{
    public class Humano : Animal, AnimaisInterface
    {
        public void Locomover()
        {
            Console.WriteLine("Pessoa Andando");
        }
        public override void Velocidade()
        {
            Console.WriteLine("Humano Andando a 7 km/h");
        }
    }
}

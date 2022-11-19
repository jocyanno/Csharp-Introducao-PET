using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuPrimeiroProjetoNoPet.animal.Classes
{
    public class Cachorro : Animal, AnimaisInterface
    {
        public void Locomover()
        {
            Console.WriteLine("Cachorro Correndo");
        }
        public override void Velocidade()
        {
            Console.WriteLine("Cachorro Correndo a 15 km/h");
        }
    }
}


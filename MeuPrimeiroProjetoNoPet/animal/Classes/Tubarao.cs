using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuPrimeiroProjetoNoPet.animal.Classes
{
    public class Tubarao : Animal, AnimaisInterface
    {
        public void Locomover()
        {
            Console.WriteLine("Tubarao Nadando rapidamente");
        }
        public override void Velocidade()
        {
            Console.WriteLine("Tubarao Nadando a 30 km/h");
        }
    }
}
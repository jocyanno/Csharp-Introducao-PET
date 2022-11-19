using MeuPrimeiroProjetoNoPet.animal.Classes;

Humano H = new Humano();
H.Nome = "Ronaldinho Gaúcho";
Console.Write(H.Nome);

Cachorro C = new Cachorro();
C.Nome = "Doguinho";
Console.WriteLine("\r\n" + C.Nome);

Tubarao T = new Tubarao();
T.Locomover();

Humano N = new Humano();
N.Velocidade();
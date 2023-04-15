using Abstraction.Models;

// instancia a primeira pessoa
PessoaModel p1 = new PessoaModel();
p1.Nome = "Nicolas";
p1.Idade = 21;
p1.Id = Guid.NewGuid();
p1.Apresentar();

Console.WriteLine(p1.Id);

// instancia a segunda pessoa
PessoaModel p2 = new PessoaModel();
p2.Nome = "Carlos";
p2.Idade = 22;
p2.Id = Guid.NewGuid();
Console.WriteLine(p2.Id);
p2.Apresentar();
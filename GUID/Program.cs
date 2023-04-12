// faz a criação de um id que não terá nenhum identico, assim permitindo ser uma primary key
var id = Guid.NewGuid();
Console.WriteLine(id);
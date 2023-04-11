// faz a criação de um id que não terá ids identicos, assim permitindo ser uma primary key
var id = Guid.NewGuid();
Console.WriteLine(id);
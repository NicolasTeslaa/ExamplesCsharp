//exemplo de exceção
var arr = new int[3];


//tenta executar o for
//dentro do try é o ideal colocar apenas os métodos principais e não declarar nenhum tipo de variavel
try
{
    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine(arr[i]);
    }
}
// se der errado faça tal coisa
catch
{
    Console.WriteLine("Deu ruim menó");
}
LeValores();
// Lê os valores de entrada do usuario
static void LeValores()
{
    Console.Clear();

    Console.WriteLine("Digite o primeiro valor");
    float v1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Digite o segundo valor");
    float v2 = float.Parse(Console.ReadLine());

    Console.WriteLine("Digite a operação que deseja realizar");
    string operation = Console.ReadLine();

    // decide quais operações serão chamadas
    DecideOperacao(operation, v1, v2);
}
//Decide a operação aritmética que o usuário irá realizar
static void DecideOperacao(string operation, float v1, float v2)
{

    if (operation == "+")
    {
        Soma(v1, v2);
    }
    else if (operation == "-")
    {
        Subtracao(v1, v2);
    }
    else if (operation == "/")
    {
        Divisao(v1, v2);
    }
    else if (operation == "*")
    {
        Multiplicacao(v1, v2);
    }
}
static void Soma(float v1, float v2)
{
    var result = v1 + v2;
    Console.WriteLine($" Resultado da Soma {result}");
}
static void Subtracao(float v1, float v2)
{
    var result = v1 - v2;
    Console.WriteLine($" Resultado da Subtração {result}");
}
static void Divisao(float v1, float v2)
{
    var result = v1 / v2;
    Console.WriteLine($" Resultado da Divisão {result}");
}
static void Multiplicacao(float v1, float v2)
{
    var result = v1 * v2;
    Console.WriteLine($"O resultado da multiplicação é {result}");
}
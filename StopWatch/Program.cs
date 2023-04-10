using System;

Menu();

static void Menu()
{
    Console.Clear();
    Console.WriteLine("Quanto tempo deseja contar?");
    Console.WriteLine("---------------------------");
    Console.WriteLine("S - Segundos => 10s = 10 segundos");
    Console.WriteLine("M - Minutos => 1m = 1 minuto");
    Console.WriteLine("0 - Sair");
    Console.WriteLine("---------------------------");
    //to lower faz com que a letra digitada pelo usuario sempre seja minusculo
    string data = Console.ReadLine().ToLower();
    //pega o ultimo caractere que será o segundo ou minuto
    char type = char.Parse(data.Substring(data.Length - 1, 1));
    //pega todos os caracteres menos 1, fazendo a exclusão do ultimo
    int time = int.Parse(data.Substring(0, data.Length - 1));
    //multiplica a quantidade de minutos para fazer a conversão dos segundos para minutos
    int multiplier = 1;
    if (type == 'm')
        multiplier = 60;
    if (time == 0)
        System.Environment.Exit(0);
    Start(time * multiplier);
}
static void Start(int time)
{
    int currentTime = 0;

    while (currentTime != time)
    {
        Console.Clear();
        currentTime++;
        Console.WriteLine($"Contagem: {currentTime}");
        //cria um atraso de 1 segundo para que conseguimos alinhar com o tempo real, saindo da ideia do clock do processador
        Thread.Sleep(1000);
    }

    Console.Clear();
    Console.WriteLine("Cronômetro finalizado");
    Thread.Sleep(2500);
    Menu();
}
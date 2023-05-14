Menu();
static void Menu()
{
    Console.Clear();
    Console.WriteLine("O que deseja fazer?");
    Console.WriteLine("1 - Abrir Arquivo");
    Console.WriteLine("2 - Novo Arquivo");
    Console.WriteLine("0 - Sair");
    short option = short.Parse(Console.ReadLine());
    switch (option)
    {
        case 0: System.Environment.Exit(0); break;
        case 1: Abrir(); break;
        case 2: Editar(); break;
        default: Menu(); break;
    }
}
static void Abrir()
{
    Console.Clear();
    Console.WriteLine("Qual caminho do arquivo ?");
    string path = Console.ReadLine();
    using (var file = new StreamReader(path))
    {
        string text = file.ReadToEnd();
        Console.WriteLine(text);
    }
    Console.WriteLine("");
    Console.ReadLine();
    Menu();
}
static void Editar()
{
    Console.Clear();
    Console.WriteLine("Digite seu texto abaixo       (ESC para sair)");
    Console.WriteLine("---------------------------------------------");
    string text = "";

    // faça isso enquanto (while)
    do
    {
        // incrementa e concatena tudo que ja tem na variavel text e com o que o usuario irá escrever no readline
        text += Console.ReadLine();
        //adiciona uma quebra de linha
        text += Environment.NewLine;
    }
    //  a tecla pressionada for diferente de ESC ele continuará neste looping de repetição
    while (Console.ReadKey().Key != ConsoleKey.Escape);

    Salvar(text);
}
static void Salvar(string text)
{
    Console.Clear();
    Console.WriteLine("Qual caminho deseja salvar esse arquivo?");
    var path = Console.ReadLine();
    using (var file = new StreamWriter(path))
    {
        file.Write(text);
    }
    Console.WriteLine($"Arquivo salvo com sucesso em {path}");
    Console.ReadLine();
    Menu();
}

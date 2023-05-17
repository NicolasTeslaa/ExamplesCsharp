List<string> nomes = new List<string>()
        {
        "ana", "nicolas", "lucas", "carla","alberto"
        };

// primeiro exemplo extenso
var resultado = from m in nomes
                where m.Contains('o')
                select m;

foreach(var item in resultado)
        Console.WriteLine(item);


//segundo exemplo mais compacto
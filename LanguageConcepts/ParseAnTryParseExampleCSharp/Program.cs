//Parse
//faz a conversão da string para inteiro
using System;

int valor = int.Parse("123");

// faz a conversão da string para booleano
bool valor2 = bool.Parse("true");

//faz a conversão do string para DateTime
DateTime valor3 = DateTime.Parse("2/02/2023");

Console.WriteLine(valor);
Console.WriteLine(valor2);
Console.WriteLine(valor3);


// tryparse
/* cria uma variavel deu certo que é booleana e tenta converter o a string para inteiro, 
que só irá retornar true, se for tipo numerico  */
bool deuCerto = int.TryParse(s:"1,2", out int resultado);
//resultado se deu para converter ou não
Console.WriteLine(deuCerto);
Console.WriteLine(valor);
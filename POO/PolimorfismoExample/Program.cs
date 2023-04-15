// See https://aka.ms/new-console-template for more information
using System;
using PolimorfismoCsharpExample;


//instacia estagiario
Imposto objetoE = new Estagiario();

//valor do salario do estagiario
var salarioEstagiario = 1000;

//encaminha o valor do salario para os métodos
objetoE.ValeAlimentacao(salarioEstagiario);
objetoE.ValeTransporte(salarioEstagiario);
Console.WriteLine("-------------------------------------------");



//instacia gerente
Imposto objetoG = new Gerente();
var salarioGerente = 5000;
objetoG.ValeAlimentacao(salarioGerente);
objetoG.ValeTransporte(salarioGerente);
Console.WriteLine("-------------------------------------------");



//instacia atendente
Imposto objetoA = new Atendente();
var salarioAtendente = 2000;
objetoA.ValeAlimentacao(salarioAtendente);
objetoA.ValeTransporte(salarioAtendente);
Console.WriteLine("-------------------------------------------");
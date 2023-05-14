using System;

namespace PolimorfismoCsharpExample
{
    public class Atendente : Imposto
    {
        // é necessário dizer ao c# que esse método sofrerá alteração e não usará as mesmas definições do que o Imposto.cs, faremos isso com o virtual
        public override void ValeAlimentacao(double salario)
        {
            //desconta 12% do salário base do colaborador
            Console.WriteLine("Desconto atendente do vale alimentação R$ " + (salario * 0.12));
        }
    }
}
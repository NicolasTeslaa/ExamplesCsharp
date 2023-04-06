using System;

namespace PolimorfismoCsharpExample
{
    public class Gerente : Imposto
    {
        // é necessário dizer ao c# que esse método sofrerá alteração e não usará as mesmas definições do que o Imposto.cs, faremos isso com o OVERRIDE
        public override void ValeAlimentacao(double salario)
        {
            //desconta 15% do salário base do colaborador
            Console.WriteLine("Desconto gerente do vale alimentação R$ " + (salario * 0.15));
        }
    }
}
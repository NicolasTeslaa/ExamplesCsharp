using System;

namespace PolimorfismoCsharpExample
{
    public class Imposto
    {
        // para que as classes Gerente e Atendente possam alterar o valor dentro do método ValeAlimentação, é necessário passar o VIRTUAL antes do VOID
        public virtual void ValeAlimentacao(double salario)
        {
            //desconta 10% do salário base do colaborador
            Console.WriteLine("Desconto padrão do vale alimentação R$ " + (salario * 0.1));
        }
        public void ValeTransporte(double salario)
        {
            //desconta 6% do salário base do colaborador
            Console.WriteLine("Desconto padrão do vale transporte R$ " + (salario * 0.06));
        }
    }
}
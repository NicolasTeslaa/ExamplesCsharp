using System.Globalization;

namespace Moedas
{
    public class Formatting
    {
        public static void formatacoes()
        {
            decimal valor = 10.25m;

            //usa formatação padrão e especifica o tipo como um numero
            Console.WriteLine(valor.ToString(
        "G",
        CultureInfo.CreateSpecificCulture("pt-BR")));

            //usa formatação tipo moeda setado no culture info
            Console.WriteLine(valor.ToString(
            "C",
            CultureInfo.CreateSpecificCulture("pt-BR")));

        }
    }
}
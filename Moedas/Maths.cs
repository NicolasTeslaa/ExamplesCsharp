namespace Moedas
{
    public class Maths
    {
        public static void maths()
        {
            decimal valor = 10536.25m;
            //arredonda o valor
            Console.WriteLine(Math.Round(valor));

            //arredonda sempre pra cima
            Console.WriteLine(Math.Ceiling(valor));

            //arredonda sempre pra baixo, quase igual o Round
            Console.WriteLine(Math.Floor(valor));

        }
    }
}
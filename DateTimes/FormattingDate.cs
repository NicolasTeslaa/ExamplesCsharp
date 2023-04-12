namespace DateTimes
{
    public class FormattingDate
    {
        public static void FormatandoData()
        {
            Console.Clear();
            var dataAtual = DateTime.Now;
            Console.WriteLine(dataAtual);

            var formatada = String.Format("{0: dd/MM/yyyy  ** hh:mm:ss z}", dataAtual);
            Console.WriteLine(formatada);

            // z signfica time zone onde o sistema está configurado
        }
    }
}
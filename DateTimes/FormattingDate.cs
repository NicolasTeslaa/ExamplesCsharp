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

            //temos tambem algumas formatações predefinidas 
            //formatação padrão do tempo
            var timeFormatter = String.Format("{0:t}", dataAtual);
            Console.WriteLine(timeFormatter);
            //formatação padrão do tempo em extenso
            var timeFormatterExtenser = String.Format("{0:T}", dataAtual);
            Console.WriteLine(timeFormatterExtenser);
            //formatação padrão da data em extenso
            var dateFormatter = String.Format("{0:D}", dataAtual);
            Console.WriteLine(dateFormatter);
            //formatação padrão da data minima
            var dateFormatterMinimal = String.Format("{0:d}", dataAtual);
            Console.WriteLine(dateFormatterMinimal);
        }
    }
}
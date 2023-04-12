namespace DateTimes
{
    public class DataFixa
    {
        public static void DataFixaAnexada()
        {
            Console.Clear();
            var dataFixa = new DateTime(2020, 10, 13, 8, 23, 14);
            Console.WriteLine(dataFixa);

            //obtendo as informações separadamentes
            Console.WriteLine(dataFixa.Year);
            Console.WriteLine(dataFixa.Month);
            Console.WriteLine(dataFixa.Day);
            Console.WriteLine(dataFixa.Hour);
            Console.WriteLine(dataFixa.Minute);
            Console.WriteLine(dataFixa.Second);
            //dia da semana
            Console.WriteLine(dataFixa.DayOfWeek);
            // dia do ano
            Console.WriteLine(dataFixa.DayOfYear);

        }
    }
}
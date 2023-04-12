namespace DateTimes
{
    public class AddValues
    {
        public static void Add()
        {
            var data = DateTime.Now;

            
            Console.WriteLine(data.AddDays(1));
            Console.WriteLine(data.AddMonths(1));
            Console.WriteLine(data.AddYears(1));
        }
    }
}
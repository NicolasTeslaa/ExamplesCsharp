namespace Exceptions
{
    public class ExceptionCostumer : Exception
    {

        public ExceptionCostumer(DateTime date)
        {
            QuandoAconteceu = date;
        }

        public DateTime QuandoAconteceu { get; set; }

    }
}
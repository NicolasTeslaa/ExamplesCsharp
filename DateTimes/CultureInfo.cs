
namespace DateTimes
{
    public class CultureInfo
    {
        public static void AdicionaCultura()
        {

            //só é necessário usar essas culture info em casos especificos quando o fuso horário é diferente do requirido
            //cria a cultureInfo
            var br = new System.Globalization.CultureInfo("pt-BR");
            var pt = new System.Globalization.CultureInfo("pt-PT");

            //utilizando 
            Console.WriteLine(DateTime.Now.ToString("D", br));
        }
    }
}
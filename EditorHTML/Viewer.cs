using System.Text.RegularExpressions;

namespace EditorHTML
{
    public class Viewer
    {
        public static void Show(string text)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("MODO VISUALIZAÇÃO");
            Console.WriteLine("---------------------------------");
            Replace(text);
            Console.WriteLine("---------------------------------");
            Console.ReadKey();
            Menu.Show();
        }

        public static void Replace(string text)
        {
            //traz para variavel  tudo que está dentro da tag strong
            var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>");
        }
    }
}
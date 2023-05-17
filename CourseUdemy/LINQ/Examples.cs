namespace LINQ
{
    public class Examples
    {
        List<string> nomes = new List<string>()
        {"ana", "nicolas", "lucas", "carla","alberto"};

        static void exibeResultado(IEnumerable<string> resultado)
        {
            foreach (var item in resultado)
                Console.WriteLine(item);
        }

        public void metodoExtenso()
        {
            // primeiro exemplo extenso
            var resultado = from m in nomes
                            where m.Contains('o')
                            select m;

            exibeResultado(resultado);
        }

        public void metodoCompacto()
        {
            //segundo exemplo mais compacto
            var resultadoCompacto = nomes.Where(n => n.Contains('s'));
            exibeResultado(resultadoCompacto);
        }


    }
}
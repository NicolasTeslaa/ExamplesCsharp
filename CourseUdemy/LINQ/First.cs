namespace LINQ
{
    public class First
    {
        private static List<Produto> listaProdutos = Data.GetProdutos();

        public static void usoFirst()
        {
            // se caso o primeiro Produto fosse nulo ou vazio ele iria retornar uma exception
            var primeiroProduto = listaProdutos.First();
            Console.WriteLine($"{primeiroProduto.Nome}");
        }

        public static void usoFirstOrDefautl(){
            
        }
    }
}
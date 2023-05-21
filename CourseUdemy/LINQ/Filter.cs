namespace LINQ
{
    public class Filter
    {
        private static List<Produto> listaProdutos = Data.GetProdutos();
        // WHERE - filtra uma coleção de objetos com base em uma condição, retorna um BOOL
        public static void filtraEletronicos()
        {
            Console.WriteLine("\n Produtos Eletrônicos");
            var produtosEletronicos = listaProdutos
                                                    .Where(p => p.Categoria == "Eletrônicos");
            foreach (var produto in produtosEletronicos)
            {
                Console.WriteLine($"{produto.Nome} \t{produto.Preco:C2}");
            }
        }

        public static void filtraMaiorValor()
        {
            Console.WriteLine("\n Produtos mais Caros");
            var produtosCaros = listaProdutos
                                            .Where(pc => pc.Preco >= 50);
            foreach (var produto in produtosCaros)
            {
                Console.WriteLine($"{produto.Nome} \t{produto.Preco:C2} \t{produto.Estoque}");
            }
        }
        public static void filtraNome()
        {
            var produtosNome = listaProdutos
                                            .Where(p => p.Preco >= 50)
                                            .OrderBy(p => p.Preco);

            Console.WriteLine("\nProdutos filtrados por nome");
            foreach (var produto in produtosNome)
            {
                Console.WriteLine($"{produto.Nome} \t{produto.Preco}");
            }
        }

        // ordenando por categoria 
        public static void filtraCategoriaNome()
        {
            Console.WriteLine("\n Produtos ordenados por categoria:");
            var produtosPorCategoriaNome = listaProdutos.OrderBy(p => p.Categoria);
                                                                                    

            string? categoriaAnterior = "";
            foreach (var produto in produtosPorCategoriaNome)
            {
                if (produto.Categoria != categoriaAnterior)
                {
                    Console.WriteLine($"    {produto.Categoria}: ");
                    categoriaAnterior = produto.Categoria;
                }
                Console.WriteLine($"             {produto.Nome}");
            }
        }
    }
}
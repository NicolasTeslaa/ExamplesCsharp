namespace LINQ
{
    public class Data
    {

        public static List<Produto> GetProdutos()
        {
            List<Produto> produtos = new List<Produto>()
            {
                new Produto { Id = 1, Nome = "Camisa", Preco = 29.99, Estoque = 10, Categoria = "Roupas"},
                new Produto { Id = 2, Nome = "Meia Soc", Preco = 19.99, Estoque = 20, Categoria = "Roupas"},
                new Produto { Id = 3, Nome = "Calça Jeans", Preco = 89.99, Estoque = 30, Categoria = "Roupas"},
                new Produto { Id = 4, Nome = "Tênis Nike", Preco = 239.99, Estoque = 40, Categoria = "Roupas"},
                new Produto { Id = 5, Nome = "Celular NK", Preco = 879.99, Estoque = 50, Categoria = "Eletrônicos"},
                new Produto { Id = 6, Nome = "Notebook", Preco = 2999.99, Estoque = 60, Categoria = "Eletrônicos"},
                new Produto { Id = 7, Nome = "Mochila", Preco = 229.99, Estoque = 70, Categoria = "Acessórios"}
            };
            return produtos;
        }
    }
}
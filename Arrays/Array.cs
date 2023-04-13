namespace Arrays
{
    public class Array
    {
        public static void MontagemArray()
        {
            //cria um array com dois itens
            var meuArray = new Teste[2];

            //instancia
            meuArray[0] = new Teste();


            //para copiar os valores de um array para outro use o .CopyTo
        }

        //apenas com o struc ou uma model é possivel usar o nome TESTE
        // struct Teste
        // {
        //     public int Id { get; set; }
        // }
    }
}
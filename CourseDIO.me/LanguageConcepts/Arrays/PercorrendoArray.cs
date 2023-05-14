namespace Arrays
{
    public class PercorrendoArray
    {
        public static void Metodo()
        {
            var meuArray = new int[5] { 1, 2, 3, 4, 5 };

            //mostra o tipo, no caso = System.Int32[]
            Console.WriteLine(meuArray);

            //mostra a quantidade de itens dentro do array
            Console.WriteLine(meuArray.Length);

            //mostra o conteudo em cada i dentro do array
            for (int i = 0; i < meuArray.Length; i++)
            {
                Console.WriteLine(i);
            }

            //percorre o conteudo de cada um dentro do array porém não precisamos especificar tantas coisas
            // pra cada item do meu array
            foreach (var item in meuArray)
            {
                //faça tal coisa
                Console.WriteLine(item);
            }
        }
    }
}




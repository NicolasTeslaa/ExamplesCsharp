namespace Exceptions
{
    public class TratamentosDiferentesDeErros
    {
        public static void Tratamento()
        {
            var arr = new int[3];

            //podemos ter mais de um tratamento de erro utilizando o try catch
            try
            {
                // for (int i = 0; i < 10; i++)
                // {
                //     Console.WriteLine(arr[i]);
                // }
                Salvar("");
            }
            catch (IndexOutOfRangeException ex)
            {
                // mostra a mensagem do erro
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                Console.WriteLine("Não encontrei o indice na lista");
            }
            catch (System.Exception ex)
            {
                // mostra a mensagem do erro
                Console.WriteLine($"Erro ao exercutar procedimento     {ex.Message}");
            }   
        }


        //cria uma nova exceção e não apenas pega ela
        public static void Salvar(string texto)
        {
            if (string.IsNullOrEmpty(texto))
                throw new ArgumentNullException("O texto não pode ser nulo ou vazio");
        }
    }

}
namespace Arrays
{
    public class ListaFuncionarios
    {
        //cria a lista de funcionarios
        public static void CreateList()
        {
            var funcionarios = new Funcionario[5];
            AddFuncionario(funcionarios);
        }
        public static void AddFuncionario(Funcionario[] funcionarios)
        {
            funcionarios[0] = new Funcionario() { Id = 2579, Nome = "André" };
            MostraListaAtualizada(funcionarios);
        }
        public static void MostraListaAtualizada(Funcionario[] funcionarios)
        {
            foreach (var funcionario in funcionarios)
            {
                Console.WriteLine(funcionario.Id);
                Console.WriteLine(funcionario.Nome);
            }
        }
    }
}
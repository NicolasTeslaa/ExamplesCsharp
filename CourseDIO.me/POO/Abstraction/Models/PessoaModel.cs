namespace Abstraction.Models
{
    public class PessoaModel
    {

        //molde e forma do objeto pessoa
        //como se fosse uma regra que será aplicada para todas as pessoas dentro desse sistema
        public Guid  Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }

        public  void Apresentar(){
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos");
        }
    }
}
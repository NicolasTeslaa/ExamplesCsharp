namespace Encapsulation.Models
{
    public class ContaCorrente
    {
        public ContaCorrente(int numeroConta, decimal saldoInicial)
        {
            NumeroConta = numeroConta;
            saldo = saldoInicial;
        }
        public int NumeroConta { get; set; }

        //esse private faz com que essa propriedade fique oculta, para todas as classes do sistema, menos a atual
        private decimal saldo { get; set; }
        public void Sacar(decimal valor)
        {
            if (saldo >= valor)
            {
                saldo -= valor;
                Console.WriteLine("Saque Realizado com sucesso");
            }
            else
            {
                Console.WriteLine("Valor indisponivel");
            }
        }
        public void ExibirSaldo()
        {
            Console.WriteLine($"Seu Saldo: {saldo}");
        }
    }
}
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
            saldo -= valor;
        }
    }
}
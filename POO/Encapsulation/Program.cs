using Encapsulation.Models;

ContaCorrente c1 = new ContaCorrente(123, 1000);

/*consigo visualizar o saldo através da chamada do método que apresenta o saldo, porém não consigo chamar
 o saldo direto em outra classe */
c1.ExibirSaldo();
c1.Sacar(500);
c1.ExibirSaldo();


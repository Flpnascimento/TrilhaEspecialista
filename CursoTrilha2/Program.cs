using System;

namespace CursoTrilha2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1-Conta Poupança / 2- Conta Corrente :");
            int escolha = Convert.ToInt32(Console.ReadLine());

            if (escolha == 1)
            {
                double salario = 2000;
                ContaPoupanca contaPoupanca = new ContaPoupanca("Felipe", 1111, 10000, salario);
                Console.WriteLine("Nome:" + contaPoupanca.Name);
                Console.WriteLine("Agencia:" + contaPoupanca.Agencia);
                Console.WriteLine("Saldo:" + contaPoupanca.Saldo.ToString("F2"));
                Console.WriteLine("Salário:" + contaPoupanca.Salario.ToString("F2"));
            }
            else if (escolha == 2)

            {
                double salario = 2000;
                ContaCorrente contaCorrente = new ContaCorrente("Felipe", 1111, 2000, true, salario);
                contaCorrente.AtualizaLimiteCartao();

                Console.WriteLine("Nome:" + contaCorrente.Name);
                Console.WriteLine("Agencia:" + contaCorrente.Agencia);
                Console.WriteLine("Saldo:" + contaCorrente.Saldo.ToString("F2"));
                Console.WriteLine("Salário:" + contaCorrente.Salario.ToString("F2"));
                Console.WriteLine("Cartão:" + contaCorrente.Cartao);
                Console.WriteLine("Limite do Cartão:" + contaCorrente.LimiteCartao.ToString("F2"));

            }
            else
            {
                Console.WriteLine("Tipo de Conta Inexistente!");
            }
        }
    }
}

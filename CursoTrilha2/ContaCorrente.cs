using System;
using System.Collections.Generic;
using System.Text;

namespace CursoTrilha2
{
    public class ContaCorrente : ContaPoupanca
    {
        public bool Cartao { get; set; }
        public double LimiteCartao { get; set; }

        public ContaCorrente(string name, int agencia, int saldo, bool cartao, double salario)
            : base(name, agencia, saldo, salario)
        {
            Cartao = cartao;
            LimiteCartao = 0;
        }

        public void AtualizaLimiteCartao()
        {
            if (Salario < 100)
            {
                LimiteCartao = 100;
            }
            else
            {
                LimiteCartao = 2 * Salario;
            }
        }
    }
}

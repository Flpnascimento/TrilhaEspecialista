using System;
using System.Collections.Generic;
using System.Text;

namespace CursoTrilha2
{
    public class ContaPoupanca
    {
        public string Name { get; private set; }
        public int Agencia { get; set; }
        public double Salario { get; set; }
        public double Saldo { get; private set; }
        public ContaPoupanca() { }

        public ContaPoupanca(string name, int agencia, double saldo, double salario)
        {
            Name = name;
            Agencia = agencia;
            Salario = salario;
            Saldo = saldo;
        }
    }
}

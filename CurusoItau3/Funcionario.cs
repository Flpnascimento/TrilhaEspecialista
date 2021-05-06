using System;

namespace CurusoItau3
{
    public class Funcionario : FuncionarioBase
    {
        public string NomeEmpresa { get; set; }

        public Funcionario() {}
        public Funcionario(double salario,string nomeEmpresa)
            :base(salario)
        {
            NomeEmpresa = nomeEmpresa;
        }
        public Funcionario(double salario)
            :base(salario)
        {

        }  
    }
}

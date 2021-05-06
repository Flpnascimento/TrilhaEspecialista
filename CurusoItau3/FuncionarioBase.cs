using System;

namespace CurusoItau3
{
    public class FuncionarioBase
    {
        private string _nome;

        public virtual void SetNome(String nome )
        {
            if (nome.Length<3)
            {
                Console.WriteLine("Erro: nome invállido");
            }
            else
            {
                _nome = nome;
            }
        }
        public String GetNome()
        {
            return _nome;
        }

        public double Salario { get; set; }

        public FuncionarioBase(){}
        public FuncionarioBase(double salario)
        {           
            Salario = salario;
        }

    }
   

}

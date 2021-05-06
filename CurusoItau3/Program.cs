using System;

namespace CurusoItau3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha o tipo de Funcionario: 1-Funcionario / 2-Terceiro");
            int escolha = Convert.ToInt32(Console.ReadLine());

            if (escolha == 1)
            {
                Funcionario funcionario = new Funcionario(5000);

                funcionario.SetNome("Felipe");
                Console.WriteLine("Nome: "+ funcionario.GetNome());
                Console.WriteLine("Salario: "+funcionario.Salario.ToString("F2"));
            }
            else if (escolha == 2)           
            {
                Funcionario terceiro = new Funcionario(5000, "Cognizant");

                terceiro.SetNome("Diego");
                Console.WriteLine("Nome: " + terceiro.GetNome());
                Console.WriteLine("Salário: "+ terceiro.Salario.ToString("F2"));
                Console.WriteLine("Nome da Empresa: "+ terceiro.NomeEmpresa);
            }

            else
            {
                Console.WriteLine("Esolha invalida!");
            }


        }
    }
}

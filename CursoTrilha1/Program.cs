using System;
using System.Collections.Generic;

namespace CursoItau
{
    class Program
    {

        static void Main(string[] args)
        {
            List<int> lista = new List<int>(10);
            int x = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite o número que deseja adicionar:");
                int value = Convert.ToInt32(Console.ReadLine());
                lista.Add(value);
            }
            Console.WriteLine("Digite o valor que deseja buscar:");
            int busca = Convert.ToInt32(Console.ReadLine());

            while (x <= 9)
            {
                if (lista[x] == busca)
                {
                    if (busca % 2 == 0)
                    {
                        Console.WriteLine($"O {lista[x]} número foi encontrado com sucesso!");
                        Console.WriteLine("O seu numero é par");
                    }
                    else
                    {
                        Console.WriteLine($"O {lista[x]} número foi encontrado com sucesso!");
                        Console.WriteLine("O seu numero é impar");
                    }
                    x = 11;
                }
                x++;
            }
            if (x == 10)
            {
                Console.WriteLine("O seu número não foi encontrado");
            }
        }
    }
}

using System;
using System.Collections.Generic;

namespace ATIVIDADE1
{
    class Program
    {
        static void Main(string[] args)
        {
            

            string descricao;
            double valor_unitario;
            int quantidade;
            char fim = 's';

            do{
                Console.Clear();

                Console.WriteLine("Informe a descrição do produto:");
                descricao = Console.ReadLine();

                Console.WriteLine("Digite o valor unitário: ");
                valor_unitario = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite a quantidade: ");
                quantidade = int.Parse(Console.ReadLine());

                Console.WriteLine("Deseja inserir novo produto? s/n ");
                fim = char.Parse(Console.ReadLine());

            }while (fim == 's');
             
        }
    }
}



using System;
using System.Collections.Generic;

namespace ATIV_01
{
    public class Program
    {

        static void Main(string[] args)
        {
            string descricao;

            double valor_unitario;

            double quantidade;

            char Fim = 's';

            
            Pedido pedir = new Pedido();

            do{
                Console.Clear();

                Console.WriteLine("Informe a descrição do produto:");
                descricao = Console.ReadLine();

                Console.WriteLine("Digite o valor unitário: ");
                valor_unitario = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite a quantidade: ");
                quantidade = int.Parse(Console.ReadLine());

                ItemPedido item = new ItemPedido();
                

                item.descricao = descricao;

                item.valor_unitario = valor_unitario;

                item.quantidade = quantidade;

                pedir.AddPedido(item);
                pedir.TotalPedido();
                

                Console.WriteLine("Deseja inserir novo produto? s/n ");
                Fim = char.Parse(Console.ReadLine());

            }while (Fim == 's');

                Console.WriteLine("O valor Total em pedidos é de " + pedir.TotalPedido().ToString("C")+".");

        }


    }
}
 
using System;
using System.Collections.Generic;

namespace Ativ01
{
    public class Pedido
    {
        private List<ItemPedido> itemPedidos;

        public Pedido(){
            itemPedidos = new List<ItemPedido>();
            
        }

        public void AddPedido(ItemPedido item){
            itemPedidos.Add(item);

        }

        public double TotalPedido(){

            double total = 0;

            Console.WriteLine(itemPedidos.Count);

            return total;

        }
    }
}
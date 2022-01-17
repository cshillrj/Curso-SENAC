using System;
using System.Collections.Generic;

namespace ATIV_01
{
    public class Pedido
    {
        private List<ItemPedido> itemPedidos;

        public Pedido(){

            itemPedidos = new List<ItemPedido>();
        }
        public void AddPedido(ItemPedido item)
        {
            itemPedidos.Add(item);
        }

        public double TotalPedido() 
        {

            double total = 0;

            foreach (var Total in itemPedidos)
            {
                total = total + (Total.quantidade * Total.valor_unitario);
            }

            return total;

        }
        
    }

}
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ATIV_02.Models;

namespace ATIV_02.Models
{
    public  class Pedido
    {
        private static List<ItemPedido> itemPedidos;

        public Pedido(){

            itemPedidos = new List<ItemPedido>();
        }
        public void AddPedido(ItemPedido item)
        {
            itemPedidos.Add(item);
        }

        public List<ItemPedido> lista()
        {
            return itemPedidos;
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
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
    public class ItemPedido
    {
        public string descricao {get; set;}

        public double valor_unitario {get; set;}
            
        public double quantidade {get; set;}
     
    }
}
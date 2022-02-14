using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MySqlConnector;
using ATIV_02.Models;

namespace ATIV_02.Models
{
    public class PacotesTuristicos
    {
        public int Id{get; set;}

        public string Nome{get; set;}

        public string Origem{get; set;}

        public string Destino{get; set;}

        public string Atrativos{get; set;}

        public DateTime Saida{get; set;}

        public DateTime Retorno{get; set;}

        public int Usuario{get; set;}
        
    }
}
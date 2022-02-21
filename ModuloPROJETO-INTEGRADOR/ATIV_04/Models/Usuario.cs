using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MySqlConnector;
using ATIV_04.Models;

namespace ATIV_04.Models
{
    public class Usuario
    {
        public int Id{get; set;}

        public string Nome{get; set;}

        public string Login{get; set;}

        public string Senha{get; set;}
        
    }
}
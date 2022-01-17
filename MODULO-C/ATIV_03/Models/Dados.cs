using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ATIV_03.Models;

namespace ATIV_03.Models
{
    public class Dados
    {
        public string Nome {get; set;}

        public string Telefone {get; set;}

        public DateTime Data {get; set;}

        public string Animal {get; set;}

        public string Necessidade {get; set;}
    }

}
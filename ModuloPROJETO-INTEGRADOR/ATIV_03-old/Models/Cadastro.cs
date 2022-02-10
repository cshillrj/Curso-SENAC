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
    public class Cadastro
    {
        public string Nome {get; set;}

        public string Cpf {get; set;}

        public string Email {get; set;}

        public string Telefone {get; set;}

        public DateTime DataNascimento {get; set;}

        public string Endereco {get; set;}

        public string Bairro {get; set;}

        public string Cidade {get; set;}

        public string Senha {get; set;}

    }
}
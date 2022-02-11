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
    public class AgendaCadastro
    {
        private static List<Cadastro> ListaCadastro = new List<Cadastro>();

        public static void Incluir(Cadastro dados)
        {
            ListaCadastro.Add(dados);
        }

        public static List<Cadastro> Listar()
        {
            return ListaCadastro;
        }
        
    }
}
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
    public class Agenda
    {
        private static List<Dados> ListaDados = new List<Dados>();

        public static void Incluir(Dados dados)
        {
            ListaDados.Add(dados);
        }

        public static List<Dados> Listar()
        {
            return ListaDados;
        }
    }
}
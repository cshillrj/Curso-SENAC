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
using System;
using System.Collections.Generic;

namespace Exemplos
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pele = new Pessoa();


            // 1 - Atribuir informações aos atributos dos objetos
            pele.nome = "Edson";
            pele.altura = 1.85;
            pele.peso = 90;
            pele.dataNasc = DateTime.Parse("1950-02-12");


            // 2 - Como acessar metodos das classes
            pele.exibirInformacao();

        }
    }
}


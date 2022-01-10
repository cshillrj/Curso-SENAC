using System;
using System.Collections.Generic;

namespace Exemplos
{
    class Pessoa
    {
        // Abaixo bloco dos ATRIBUTOS ou propriedades ou características
        public string nome = "";

        public double altura, peso;

        public DateTime dataNasc;

        // Abaixo bloco dos METODOS ou funcionalidades ou comportamento

        public void acordar(){
            Console.WriteLine("Acordando " + nome + "! Bom dia!!");
        }

        public void exibirInformacao(){
            Console.WriteLine("nome: " + nome);
            Console.WriteLine("altura: " + altura);
            Console.WriteLine("peso: " + peso);
            Console.WriteLine("data de Nascimento: " + dataNasc);
        }

    }
}
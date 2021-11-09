using System;
    namespace primeiroApp
    {
        class Program
        {
            static void Main(string[] args)
            {
string nome;
    Console.WriteLine("Digite seu nome:");
    nome = Console.ReadLine();
    Console.WriteLine($"Seu nome é {nome}.");
int nasData;
    Console.WriteLine("Informe o ano de nascimento:(xxxx)");
    nasData = int.Parse(Console.ReadLine());
int anoAtual = DateTime.Now.Year;
int idade;
    idade = anoAtual - nasData;
//Console.WriteLine($"Sua idade é {idade} anos.");
string senha;
    if (idade < 18){
        senha = nome + idade;
        Console.WriteLine($"Sua senha é {senha}");
    }
    else{
        senha = idade + nome;
        Console.WriteLine($"Sua senha é {senha}");
    }
    
        }
    }
}


/*----------------GERADOR DE SENHAS---------------------------------------------------
string chars = "abcdefghjkmnpqrstuvwxyz023456789";
string pass = "";
Random random = new Random();
for (int f = 0; f < 6; f++) {
pass = pass + chars.Substring(random.Next(0, chars.Length-1), 1);
}
Console.WriteLine(pass);*/
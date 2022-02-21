using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MySqlConnector;
using ATIV_04.Models;

namespace ATIV_04.Models
{
    public class ClienteRepository
    {
        private const string DadosConexao = "Database=MangiaPizza;Data Source=localhost;User Id=root;";

        public void TestarConexao()
        {
            MySqlConnection conexao = new MySqlConnection(DadosConexao);

            conexao.Open();

            Console.WriteLine("Banco de dados funcionando...");

            conexao.Close();
        }

        public void Insert(Cliente novoCliente)
        {
            MySqlConnection conexao = new MySqlConnection(DadosConexao);
            conexao.Open();

            String Query = "INSERT INTO CadastroCliente(Nome, Cpf, Email, Telefone, DataNascimento, Endereco, Bairro, Cidade, Senha) VALUES (@Nome, @Cpf, @Email, @Telefone, @DataNascimento, @Endereco, @Bairro, @Cidade, @Senha)";

            MySqlCommand comando = new MySqlCommand(Query, conexao);
            
            comando.Parameters.AddWithValue("@Nome", novoCliente.Nome);
            comando.Parameters.AddWithValue("@Cpf", novoCliente.Cpf);
            comando.Parameters.AddWithValue("@Email", novoCliente.Email);
            comando.Parameters.AddWithValue("@Telefone", novoCliente.Telefone);
            comando.Parameters.AddWithValue("@DataNascimento", novoCliente.DataNascimento);
            comando.Parameters.AddWithValue("@Endereco", novoCliente.Endereco);
            comando.Parameters.AddWithValue("@Bairro", novoCliente.Bairro);
            comando.Parameters.AddWithValue("@Cidade", novoCliente.Cidade);
            comando.Parameters.AddWithValue("@Senha", novoCliente.Senha);

            comando.ExecuteNonQuery();

            conexao.Close();
        }

        public List<Cliente> Listar()
        {
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);

            Conexao.Open();

            List<Cliente> ListaClientes = new List<Cliente>();

            String Query = "SELECT * FROM CadastroCliente";

            MySqlCommand Comando = new MySqlCommand(Query, Conexao);

            MySqlDataReader Reader = Comando.ExecuteReader();

            while(Reader.Read())
            {
                Cliente ClienteEncontrado = new Cliente();

                ClienteEncontrado.Id = Reader.GetInt32("Id");

                if (!Reader.IsDBNull(Reader.GetOrdinal("Nome")))
                {
                    ClienteEncontrado.Nome = Reader.GetString("Nome");
                }

                if (!Reader.IsDBNull(Reader.GetOrdinal("Cpf")))
                {
                    ClienteEncontrado.Cpf = Reader.GetString("Cpf");
                }

                if (!Reader.IsDBNull(Reader.GetOrdinal("Email")))
                {
                    ClienteEncontrado.Email = Reader.GetString("Email");
                }

                if (!Reader.IsDBNull(Reader.GetOrdinal("Telefone")))
                {
                    ClienteEncontrado.Telefone = Reader.GetString("Telefone");
                }

                ClienteEncontrado.DataNascimento = Reader.GetDateTime("DataNascimento");

                if (!Reader.IsDBNull(Reader.GetOrdinal("Endereco")))
                {
                    ClienteEncontrado.Endereco = Reader.GetString("Endereco");
                }

                if (!Reader.IsDBNull(Reader.GetOrdinal("Bairro")))
                {
                    ClienteEncontrado.Bairro = Reader.GetString("Bairro");
                }

                if (!Reader.IsDBNull(Reader.GetOrdinal("Cidade")))
                {
                    ClienteEncontrado.Cidade = Reader.GetString("Cidade");
                }

                if (!Reader.IsDBNull(Reader.GetOrdinal("Senha")))
                {
                    ClienteEncontrado.Senha = Reader.GetString("Senha");
                }
                
                ListaClientes.Add(ClienteEncontrado);
            }
            
            Conexao.Close();

            return ListaClientes;
        }

        public Cliente QueryLogin(Cliente cliente)
        {
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);

            Conexao.Open();

            String Query = "SELECT * FROM CadastroCliente WHERE Email = @Email AND Senha = @Senha";
            MySqlCommand comando = new MySqlCommand(Query, Conexao);
            comando.Parameters.AddWithValue("@Email", cliente.Email);
            comando.Parameters.AddWithValue("@Senha", cliente.Senha);
            MySqlDataReader reader = comando.ExecuteReader();
            Cliente client = null;
            if(reader.Read())
            {
                client = new Cliente();
                client.Id = reader.GetInt32("Id");
            if(!reader.IsDBNull(reader.GetOrdinal("Nome")))
                client.Nome = reader.GetString("Nome");
       
            if(!reader.IsDBNull(reader.GetOrdinal("Email")))
                client.Email = reader.GetString("Email");
            if(!reader.IsDBNull(reader.GetOrdinal("Senha")))
                client.Senha = reader.GetString("Senha");
            }
   
            Conexao.Close();

            return client;
        }

        public Cliente BuscarPorId(int Id)
        {
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);

            Conexao.Open();

            Cliente clienteEncontrado = new Cliente();

            String Query = "SELECT * FROM CadastroCliente WHERE Id=@Id";

            MySqlCommand comando = new MySqlCommand(Query, Conexao);

            comando.Parameters.AddWithValue("@Id", Id);

            MySqlDataReader Reader = comando.ExecuteReader();

            if(Reader.Read())
            {
                clienteEncontrado.Id = Reader.GetInt32("Id");

                if (!Reader.IsDBNull(Reader.GetOrdinal("Nome")))
                {
                    clienteEncontrado.Nome = Reader.GetString("Nome");
                }

                if (!Reader.IsDBNull(Reader.GetOrdinal("Email")))
                {
                    clienteEncontrado.Email = Reader.GetString("Email");
                }

                if (!Reader.IsDBNull(Reader.GetOrdinal("Senha")))
                {
                    clienteEncontrado.Senha = Reader.GetString("Senha");
                }
                
            }

            Conexao.Close();

            return clienteEncontrado;  

        }
    }
}
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
    public class UsuarioRepository
    {
        private const string DadosConexao = "Database=MangiaPizza;Data Source=localhost;User Id=root;";

        public void TestarConexao()
        {
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);

            Conexao.Open();

            Console.WriteLine("Banco de dados funcionando...");

            Conexao.Close();
        }

        public void Insert(Usuario novoUsuario)
        {
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);

            Conexao.Open();

            String Query = "INSERT INTO Usuario(Nome, Login, Senha) VALUES (@Nome, @Login, @Senha)";

            MySqlCommand comando = new MySqlCommand(Query, Conexao);

            comando.Parameters.AddWithValue("@Nome", novoUsuario.Nome);
            comando.Parameters.AddWithValue("@Login", novoUsuario.Login);
            comando.Parameters.AddWithValue("@Senha", novoUsuario.Senha);
            
            comando.ExecuteNonQuery();

            Conexao.Close();
        }

        public void atualizar(Usuario user)
        {
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);

            Conexao.Open();

            String Query = "UPDATE Usuario SET Nome=@Nome, Login=@Login, Senha=@Senha WHERE Id=@Id";

            MySqlCommand comando = new MySqlCommand(Query, Conexao);

            comando.Parameters.AddWithValue("@Nome", user.Nome);
            comando.Parameters.AddWithValue("@Login", user.Login);
            comando.Parameters.AddWithValue("@Senha", user.Senha);
            comando.Parameters.AddWithValue("@Id", user.Id);

            comando.ExecuteNonQuery();

            Conexao.Close();
        }

        public void excluir(Usuario user)
        {
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);

            Conexao.Open();

            String Query = "DELETE FROM Usuario WHERE Id=@Id";
            MySqlCommand comando = new MySqlCommand(Query, Conexao);

            comando.Parameters.AddWithValue("@Id", user.Id);

            comando.ExecuteNonQuery();

            Conexao.Close();

        }

        public Usuario QueryLogin(Usuario user)
        {
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);

            Conexao.Open();

            String Query = "SELECT * FROM Usuario WHERE Login = @Login AND Senha = @Senha";
            MySqlCommand comando = new MySqlCommand(Query, Conexao);
            comando.Parameters.AddWithValue("@Login", user.Login);
            comando.Parameters.AddWithValue("@Senha", user.Senha);
            MySqlDataReader reader = comando.ExecuteReader();
            Usuario usr = null;
            if(reader.Read())
            {
                usr = new Usuario();
                usr.Id = reader.GetInt32("Id");
            if(!reader.IsDBNull(reader.GetOrdinal("Nome")))
                usr.Nome = reader.GetString("Nome");
       
            if(!reader.IsDBNull(reader.GetOrdinal("Login")))
                usr.Login = reader.GetString("Login");
            if(!reader.IsDBNull(reader.GetOrdinal("Senha")))
                usr.Senha = reader.GetString("Senha");
            }
   
            Conexao.Close();

            return usr;
        }

        public List<Usuario> Listar()
        {
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);

            Conexao.Open();

            List<Usuario> ListaDeUsuarios = new List<Usuario>();

            String Query = "SELECT * FROM Usuario";

            MySqlCommand Comando = new MySqlCommand(Query, Conexao);

            MySqlDataReader Reader = Comando.ExecuteReader();

            while(Reader.Read())
            {
                Usuario UsuarioEncontrado = new Usuario();

                UsuarioEncontrado.Id = Reader.GetInt32("Id");

                if (!Reader.IsDBNull(Reader.GetOrdinal("Nome")))
                {
                    UsuarioEncontrado.Nome = Reader.GetString("Nome");
                }

                if (!Reader.IsDBNull(Reader.GetOrdinal("Login")))
                {
                    UsuarioEncontrado.Login = Reader.GetString("Login");
                }

                if (!Reader.IsDBNull(Reader.GetOrdinal("Senha")))
                {
                    UsuarioEncontrado.Senha = Reader.GetString("Senha");
                }

                ListaDeUsuarios.Add(UsuarioEncontrado);
            }
            
            Conexao.Close();

            return ListaDeUsuarios;
        }
        public Usuario BuscarPorId(int Id)
        {
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);

            Conexao.Open();

            Usuario usuarioEncontrado = new Usuario();

            String Query = "SELECT * FROM Usuario WHERE Id=@Id";

            MySqlCommand comando = new MySqlCommand(Query, Conexao);

            comando.Parameters.AddWithValue("@Id", Id);

            MySqlDataReader Reader = comando.ExecuteReader();

            if(Reader.Read())
            {
                usuarioEncontrado.Id = Reader.GetInt32("Id");

                if (!Reader.IsDBNull(Reader.GetOrdinal("Nome")))
                {
                    usuarioEncontrado.Nome = Reader.GetString("Nome");
                }

                if (!Reader.IsDBNull(Reader.GetOrdinal("Login")))
                {
                    usuarioEncontrado.Login = Reader.GetString("Login");
                }

                if (!Reader.IsDBNull(Reader.GetOrdinal("Senha")))
                {
                    usuarioEncontrado.Senha = Reader.GetString("Senha");
                }

            }

            Conexao.Close();

            return usuarioEncontrado;  

        }

    }
}
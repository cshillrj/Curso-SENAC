using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MySqlConnector;
using ATIV_02.Models;

namespace ATIV_02.Models
{
    public class PacotesRepository
    {
        private const string DadosConexao = "Database=Turismo;Data Source=localhost;User Id=root;";

        public void Inserir(PacotesTuristicos novoPacote)
        {
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);

            Conexao.Open();

            String Query = "INSERT INTO PacotesTuristicos(Nome, Origem, Destino, Atrativos, Saida, Retorno, Usuario) VALUES (@Nome, @Origem, @Destino, @Atrativos, @Saida, @Retorno, @Usuario)";

            MySqlCommand comando = new MySqlCommand(Query, Conexao);

            comando.Parameters.AddWithValue("@Nome", novoPacote.Nome);
            comando.Parameters.AddWithValue("@Origem", novoPacote.Origem);
            comando.Parameters.AddWithValue("@Destino", novoPacote.Destino);
            comando.Parameters.AddWithValue("@Atrativos", novoPacote.Atrativos);
            comando.Parameters.AddWithValue("@Saida", novoPacote.Saida);
            comando.Parameters.AddWithValue("@Retorno", novoPacote.Retorno);
            comando.Parameters.AddWithValue("@Usuario", novoPacote.Usuario);

            comando.ExecuteNonQuery();

            Conexao.Close();
        }

        public void Atualizar(PacotesTuristicos pacotes)
        {
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);

            Conexao.Open();

            String Query = "UPDATE PacotesTuristicos SET Nome=@Nome, Origem=@Origem, Destino=@Destino, Atrativos=@Atrativos, Saida=@Saida, Retorno=@Retorno, Usuario=@Usuario WHERE Id=@Id";

            MySqlCommand comando = new MySqlCommand(Query, Conexao);

            
            comando.Parameters.AddWithValue("@Nome", pacotes.Nome);
            comando.Parameters.AddWithValue("@Origem", pacotes.Origem);
            comando.Parameters.AddWithValue("@Destino", pacotes.Destino);
            comando.Parameters.AddWithValue("@Atrativos", pacotes.Atrativos);
            comando.Parameters.AddWithValue("@Saida", pacotes.Saida);
            comando.Parameters.AddWithValue("@Retorno", pacotes.Retorno);
            comando.Parameters.AddWithValue("@Usuario", pacotes.Usuario);
            comando.Parameters.AddWithValue("@Id", pacotes.Id);
            
            comando.ExecuteNonQuery();

            Conexao.Close();
        }

        public void Excluir(PacotesTuristicos pacotes)
        {
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);

            Conexao.Open();

            String Query = "DELETE FROM PacotesTuristicos WHERE Id=@Id";

            MySqlCommand comando = new MySqlCommand(Query, Conexao);

            comando.Parameters.AddWithValue("@Id", pacotes.Id);

            comando.ExecuteNonQuery();

            Conexao.Close();

        }

        public List<PacotesTuristicos> Listar()
        {
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);

            Conexao.Open();

            List<PacotesTuristicos> ListaPacotes = new List<PacotesTuristicos>();

            String Query = "SELECT * FROM PacotesTuristicos";

            MySqlCommand Comando = new MySqlCommand(Query, Conexao);

            MySqlDataReader Reader = Comando.ExecuteReader();

            while(Reader.Read())
            {
                PacotesTuristicos PacoteEncontrado = new PacotesTuristicos();

                PacoteEncontrado.Id = Reader.GetInt32("Id");

                if (!Reader.IsDBNull(Reader.GetOrdinal("Nome")))
                {
                    PacoteEncontrado.Nome = Reader.GetString("Nome");
                }

                if (!Reader.IsDBNull(Reader.GetOrdinal("Origem")))
                {
                    PacoteEncontrado.Origem = Reader.GetString("Origem");
                }

                if (!Reader.IsDBNull(Reader.GetOrdinal("Destino")))
                {
                    PacoteEncontrado.Destino = Reader.GetString("Destino");
                }
                
                PacoteEncontrado.Atrativos = Reader.GetString("Atrativos");

                //if (!Reader.IsDBNull(Reader.GetOrdinal("Saida")))
                //{
                    PacoteEncontrado.Saida = Reader.GetDateTime("Saida");
                //}

                //if (!Reader.IsDBNull(Reader.GetOrdinal("Retorno")))
                //{
                    PacoteEncontrado.Retorno = Reader.GetDateTime("Retorno");
                //}

                if (!Reader.IsDBNull(Reader.GetOrdinal("Usuario")))
                {
                    PacoteEncontrado.Usuario = Reader.GetInt32("Usuario");
                }

                ListaPacotes.Add(PacoteEncontrado);
            }
            
            Conexao.Close();

            return ListaPacotes;
        }

        public PacotesTuristicos BuscarPorId(int Id)
        {
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);

            Conexao.Open();

            PacotesTuristicos pacoteEncontrado = new PacotesTuristicos();

            String Query = "SELECT * FROM PacotesTuristicos WHERE Id=@Id";

            MySqlCommand comando = new MySqlCommand(Query, Conexao);

            comando.Parameters.AddWithValue("@Id", Id);

            MySqlDataReader Reader = comando.ExecuteReader();

            if(Reader.Read())
            {
                pacoteEncontrado.Id = Reader.GetInt32("Id");

                if (!Reader.IsDBNull(Reader.GetOrdinal("Nome")))
                {
                    pacoteEncontrado.Nome = Reader.GetString("Nome");
                }

                if (!Reader.IsDBNull(Reader.GetOrdinal("Origem")))
                {
                    pacoteEncontrado.Origem = Reader.GetString("Origem");
                }

                if (!Reader.IsDBNull(Reader.GetOrdinal("Destino")))
                {
                    pacoteEncontrado.Destino = Reader.GetString("Destino");
                }
                
                pacoteEncontrado.Atrativos = Reader.GetString("Atrativos");

                //if (!Reader.IsDBNull(Reader.GetOrdinal("Saida")))
                //{
                    pacoteEncontrado.Saida = Reader.GetDateTime("Saida");
                //}

                //if (!Reader.IsDBNull(Reader.GetOrdinal("Retorno")))
                //{
                    pacoteEncontrado.Retorno = Reader.GetDateTime("Retorno");
                //}

                if (!Reader.IsDBNull(Reader.GetOrdinal("Usuario")))
                {
                    pacoteEncontrado.Usuario = Reader.GetInt32("Usuario");
                }

            }

            Conexao.Close();

            return pacoteEncontrado;  

        }

        
    }
}
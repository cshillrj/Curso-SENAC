using System.Collections.Generic;


namespace Newsletter.Models
{
    public static class BaseDados
    {
        private static List<Usuario> dados = new List<Usuario>();

        public static void Incluir(Usuario u)
        {
            dados.Add(u);
        }

        public static List<Usuario> Listar()
            {
                return dados;
            }

    }

}
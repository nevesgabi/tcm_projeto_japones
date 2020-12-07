using MySql.Data.MySqlClient;
using System;

namespace projeto_tcm.Repositorio
{
    public class Conexao
    {
        MySqlConnection cn = new MySqlConnection("Server=192.168.0.9;Database=tomoe_sushi;user=root; pwd=Trdaejk789");
        public static string msg;

        public MySqlConnection ConectarBD()
        {
            try
            {
                cn.Open();
            }
            catch(Exception erro)
            {
                msg = "Ocorreu um erro ao conectar" + erro.Message;
            }
            return cn;
        }

        public void DesconectarBD()
        {
            try
            {
                cn.Close();
            }
            catch (Exception erro)
            {
                msg = "Ocorreu um erro ao conectar" + erro.Message;
            }
        }

    }
}
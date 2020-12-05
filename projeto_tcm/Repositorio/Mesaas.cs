using MySql.Data.MySqlClient;
using projeto_tcm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace projeto_tcm.Repositorio
{
    public class Mesaas
    {
        Conexao cn = new Conexao();
        MySqlCommand cmd = new MySqlCommand();

        public void CadastroMesa(Mesaa dto)
        {
            MySqlCommand cmd = new MySqlCommand("INSERT INTO Mesa(num_mesa, num_assentos, status_mesa) VALUES (@num_mesa, @num_assentos, @status_mesa)", cn.ConectarBD());
            cmd.Parameters.Add("@num_mesa", MySqlDbType.Int16).Value = dto.mesa;
            cmd.Parameters.Add("@num_assentos", MySqlDbType.Int16).Value = dto.assentos;
            cmd.Parameters.Add("@status_mesa", MySqlDbType.VarChar).Value = dto.statusmesa;

            cmd.ExecuteNonQuery();
            cn.DesconectarBD();
        }

        public Mesaa ConsultarMesa(int id)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM Mesa where id_mesa = @id_mesa", cn.ConectarBD());
            cmd.Parameters.Add("@id_mesa", MySqlDbType.Int16).Value = id;

            cmd.ExecuteNonQuery();

            return new Mesaa();
        } 
    }
}
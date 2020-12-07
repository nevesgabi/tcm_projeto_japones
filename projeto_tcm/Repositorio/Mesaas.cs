using MySql.Data.MySqlClient;
using projeto_tcm.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace projeto_tcm.Repositorio
{
    public class Mesaas
    {
        Conexao cn = new Conexao();
        MySqlCommand cmd = new MySqlCommand();

        public long CadastroMesa(Mesaa dto)
        {
            MySqlCommand cmd = new MySqlCommand("INSERT INTO Mesa(num_mesa, num_assentos, status_mesa) VALUES (@num_mesa, @num_assentos, @status_mesa)", cn.ConectarBD());
            cmd.Parameters.Add("@num_mesa", MySqlDbType.Int16).Value = dto.mesa;
            cmd.Parameters.Add("@num_assentos", MySqlDbType.Int16).Value = dto.assentos;
            cmd.Parameters.Add("@status_mesa", MySqlDbType.VarChar).Value = dto.statusmesa;

            cmd.Parameters.Add("@ID", MySqlDbType.Int16, 4).Direction = ParameterDirection.Output;

            cmd.ExecuteNonQuery();

            long id = cmd.LastInsertedId;

            cn.DesconectarBD();

            return id;
        }

        public Mesaa ConsultarMesas(int id)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM mesa where id_mesa = @id_mesa", cn.ConectarBD());
            cmd.Parameters.Add("@id_mesa", MySqlDbType.Int16).Value = id;

            cmd.ExecuteNonQuery();

            MySqlDataReader reader = cmd.ExecuteReader();

            Mesaa ms = new Mesaa();

            while (reader.Read())
            {
                //ms.idmesa = reader.GetString[reader.GetOrdinal("id_mesa");
                ms.mesa = reader.GetInt32(reader.GetOrdinal("num_mesa"));
                ms.assentos = reader.GetInt32(reader.GetOrdinal("num_assentos"));
                ms.statusmesa = reader.GetString(reader.GetOrdinal("status_mesa"));
            }

            reader.Close();

            cn.DesconectarBD();

            return ms;
        }

        public List<Mesaa> ListarTodasMesas()
        {
            List<Mesaa> mesas = new List<Mesaa>();

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM mesa", cn.ConectarBD());

            cmd.ExecuteNonQuery();

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Mesaa ms = new Mesaa();
                ms.idmesa = reader.GetInt16(reader.GetOrdinal("id_mesa"));
                ms.mesa = reader.GetInt16(reader.GetOrdinal("num_mesa"));
                ms.assentos = reader.GetInt16(reader.GetOrdinal("num_assentos"));
                ms.statusmesa = reader.GetString(reader.GetOrdinal("status_mesa"));
                mesas.Add(ms);
            }


            return mesas;
        }

        public bool DeletarMesa(int id)
        {

            MySqlCommand cmd = new MySqlCommand("DELETE FROM mesa WHERE id_mesa = @id_mesa", cn.ConectarBD());
            cmd.Parameters.Add("@id_mesa", MySqlDbType.Int16).Value = id;

            int deletedRows = cmd.ExecuteNonQuery();

            return deletedRows > 0;
        }
    }
}
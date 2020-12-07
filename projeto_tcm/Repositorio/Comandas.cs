using MySql.Data.MySqlClient;
using projeto_tcm.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace projeto_tcm.Repositorio
{
    public class Comandas
    {
        Conexao cn = new Conexao();
        MySqlCommand cmd = new MySqlCommand();

        public long CadastroComanda(Comanda dto)
        {
            MySqlCommand cmd = new MySqlCommand("INSERT INTO Comanda(data_comanda, horario_comanda, qt_item, id_mesa, id_func, status_comanda) VALUES (@data_comanda, @horario_comanda, @qt_item, @id_mesa, @id_func, @status_comanda)", cn.ConectarBD());
            cmd.Parameters.Add("@data_comanda", MySqlDbType.VarChar).Value = dto.dataComanda;
            cmd.Parameters.Add("@horario_comanda", MySqlDbType.VarChar).Value = dto.horarioComanda;
            cmd.Parameters.Add("@id_mesa", MySqlDbType.Int16).Value = dto.mesaComanda;
            cmd.Parameters.Add("@id_func", MySqlDbType.Int16).Value = dto.funcionarioComanda;
            cmd.Parameters.Add("@status_comanda", MySqlDbType.VarChar).Value = dto.statusComanda;

            cmd.Parameters.Add("@ID", MySqlDbType.Int16, 4).Direction = ParameterDirection.Output;

            cmd.ExecuteNonQuery();

            long id = cmd.LastInsertedId;

            cn.DesconectarBD();

            return id;
        }

        public Comanda ConsultarComanda(int id)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM comanda where id_comanda = @id_comanda", cn.ConectarBD());
            cmd.Parameters.Add("@id_comanda", MySqlDbType.Int16).Value = id;

            cmd.ExecuteNonQuery();

            MySqlDataReader reader = cmd.ExecuteReader();

            Comanda coman = new Comanda();

            while (reader.Read())
            {
                coman.idComanda = reader.GetInt16(reader.GetOrdinal("id_comanda"));
                coman.dataComanda = reader.GetString(reader.GetOrdinal("data_comanda"));
                coman.horarioComanda = reader.GetString(reader.GetOrdinal("horario_comanda"));
                coman.mesaComanda = reader.GetInt16(reader.GetOrdinal("id_mesa"));
                coman.funcionarioComanda = reader.GetInt16(reader.GetOrdinal("id_func"));
                coman.statusComanda = reader.GetString(reader.GetOrdinal("status_comanda"));
            }

            reader.Close();

            cn.DesconectarBD();

            return coman;
        }

        public List<Comanda> ListarTodasComandas()
        {
            List<Comanda> comandas = new List<Comanda>();

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM comanda", cn.ConectarBD());

            cmd.ExecuteNonQuery();

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Comanda coman = new Comanda();
                coman.idComanda = reader.GetInt16(reader.GetOrdinal("id_comanda"));
                coman.dataComanda = reader.GetString(reader.GetOrdinal("data_comanda"));
                coman.horarioComanda = reader.GetString(reader.GetOrdinal("horario_comanda"));
                coman.mesaComanda = reader.GetInt16(reader.GetOrdinal("id_mesa"));
                coman.funcionarioComanda = reader.GetInt16(reader.GetOrdinal("id_func"));
                coman.statusComanda = reader.GetString(reader.GetOrdinal("status_comanda"));
                comandas.Add(coman);
            }


            return comandas;
        }

        public bool DeletarComanda(int id)
        {

            MySqlCommand cmd = new MySqlCommand("DELETE FROM comanda WHERE id_comanda = @id_comanda", cn.ConectarBD());
            cmd.Parameters.Add("@id_comanda", MySqlDbType.Int16).Value = id;

            int deletedRows = cmd.ExecuteNonQuery();

            return deletedRows > 0;
        }
    }
}
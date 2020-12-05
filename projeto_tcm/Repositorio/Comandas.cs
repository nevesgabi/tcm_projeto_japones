using MySql.Data.MySqlClient;
using projeto_tcm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace projeto_tcm.Repositorio
{
    public class Comandas
    {
        Conexao cn = new Conexao();
        MySqlCommand cmd = new MySqlCommand();

        public void CadastroComanda(Comanda dto)
        {
            MySqlCommand cmd = new MySqlCommand("INSERT INTO Comanda(data_comanda, horario_comanda, qt_item, id_mesa, id_func, status_comanda) VALUES (@data_comanda, @horario_comanda, @qt_item, @id_mesa, @id_func, @status_comanda)", cn.ConectarBD());
            cmd.Parameters.Add("@data_comanda", MySqlDbType.VarChar).Value = dto.dataComanda;
            cmd.Parameters.Add("@horario_comanda", MySqlDbType.Decimal).Value = dto.horarioComanda;
            cmd.Parameters.Add("@qt_item", MySqlDbType.VarChar).Value = dto.quantidadeComanda;
            cmd.Parameters.Add("@id_mesa", MySqlDbType.VarChar).Value = dto.mesaComanda;
            cmd.Parameters.Add("@id_func", MySqlDbType.VarChar).Value = dto.funcionarioComanda;
            cmd.Parameters.Add("@status_comanda", MySqlDbType.VarChar).Value = dto.statusComanda;

            cmd.ExecuteNonQuery();
            cn.DesconectarBD();
        }
    }
}
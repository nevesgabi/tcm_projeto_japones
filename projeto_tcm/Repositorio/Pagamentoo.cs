using MySql.Data.MySqlClient;
using projeto_tcm.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace projeto_tcm.Repositorio
{
    public class Pagamentoo
    {
        Conexao cn = new Conexao();
        MySqlCommand cmd = new MySqlCommand();

        public long CadastroPagamento(Pagamento dto)
        {
            MySqlCommand cmd = new MySqlCommand("INSERT INTO Pagamento(troco_pag, total_pagamento, total_pago, tipo_pag, CPF_pag, status_pag, id_comanda) VALUES (@troco_pag, @total_pagamento, @total_pago, @tipo_pag, @CPF_pag, @status_pag, @id_comanda)", cn.ConectarBD());
            cmd.Parameters.Add("@troco_pag", MySqlDbType.Decimal).Value = dto.trocoPagamento;
            cmd.Parameters.Add("@total_pagamento", MySqlDbType.Decimal).Value = dto.totalPagamento;
            cmd.Parameters.Add("@total_pago", MySqlDbType.Decimal).Value = dto.totalPago;
            cmd.Parameters.Add("@tipo_pag", MySqlDbType.VarChar).Value = dto.tipoPag;
            cmd.Parameters.Add("@CPF_pag", MySqlDbType.Int16).Value = dto.cpfPagamento;
            cmd.Parameters.Add("@status_pag", MySqlDbType.VarChar).Value = dto.statusPagamento;
            cmd.Parameters.Add("@id_comanda", MySqlDbType.Int16).Value = dto.comandaPagamento;

            cmd.Parameters.Add("@ID", MySqlDbType.Int16, 4).Direction = ParameterDirection.Output;

            cmd.ExecuteNonQuery();

            long id = cmd.LastInsertedId;

            cn.DesconectarBD();

            return id;
        }

        public Pagamento ConsultarPagamento(int id)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM pagamento where id_pag = @id_pag", cn.ConectarBD());
            cmd.Parameters.Add("@id_pag", MySqlDbType.Int16).Value = id;

            cmd.ExecuteNonQuery();

            MySqlDataReader reader = cmd.ExecuteReader();

            Pagamento pag = new Pagamento();

            while (reader.Read())
            {
                pag.idPagamento = reader.GetInt16(reader.GetOrdinal("id_pag"));
                pag.trocoPagamento = reader.GetString(reader.GetOrdinal("troco_pag"));
                pag.totalPagamento = reader.GetString(reader.GetOrdinal("total_pagamento"));
                pag.totalPago = reader.GetString(reader.GetOrdinal("total_pago"));
                pag.tipoPag = reader.GetString(reader.GetOrdinal("tipo_pag"));
                pag.cpfPagamento = reader.GetString(reader.GetOrdinal("CPF_pag"));
                pag.statusPagamento = reader.GetString(reader.GetOrdinal("status_pag"));
                pag.comandaPagamento = reader.GetInt16(reader.GetOrdinal("id_comanda"));
            }

            reader.Close();

            cn.DesconectarBD();

            return pag;
        }

        public List<Pagamento> ListarTodosPagamentos()
        {
            List<Pagamento> pagamentos = new List<Pagamento>();

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM pagamento", cn.ConectarBD());

            cmd.ExecuteNonQuery();

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Pagamento pag = new Pagamento();
                pag.idPagamento = reader.GetInt16(reader.GetOrdinal("id_pag"));
                pag.totalPagamento = reader.GetString(reader.GetOrdinal("total_pagamento"));
                pag.totalPago = reader.GetString(reader.GetOrdinal("total_pago"));
                pag.trocoPagamento = reader.GetString(reader.GetOrdinal("troco_pag"));
                pag.tipoPag = reader.GetString(reader.GetOrdinal("tipo_pag"));
                pag.statusPagamento = reader.GetString(reader.GetOrdinal("status_pag"));
                pag.comandaPagamento = reader.GetInt16(reader.GetOrdinal("id_comanda"));
                pag.cpfPagamento = reader.GetString(reader.GetOrdinal("CPF_pag"));
                pagamentos.Add(pag);
            }


            return pagamentos;
        }

        public bool DeletarPagamento(int id)
        {

            MySqlCommand cmd = new MySqlCommand("DELETE FROM pagamento WHERE id_pag = @id_pag", cn.ConectarBD());
            cmd.Parameters.Add("@id_pag", MySqlDbType.Int16).Value = id;

            int deletedRows = cmd.ExecuteNonQuery();

            return deletedRows > 0;
        }
    }
}
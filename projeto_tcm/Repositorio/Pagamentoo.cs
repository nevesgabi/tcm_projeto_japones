using MySql.Data.MySqlClient;
using projeto_tcm.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace projeto_tcm.Repositorio
{
    public class Pagamentoo
    {
        Conexao cn = new Conexao();
        MySqlCommand cmd = new MySqlCommand();

        public void CadastroPagamento(Pagamento dto)
        {
            MySqlCommand cmd = new MySqlCommand("INSERT INTO Pagamento(troco_pag, taxa_servico, total_pagamento, total_pago, tipo_pag, CPF_pag, status_pag, id_comanda) VALUES (@troco_pag, @taxa_servico, @total_pagamento, @total_pago, @tipo_pag, @CPF_pag, @status_pag, @id_comanda)", cn.ConectarBD());
            cmd.Parameters.Add("@troco_pag", MySqlDbType.Decimal).Value = dto.trocoPagamento;
            cmd.Parameters.Add("@taxa_servico", MySqlDbType.Decimal).Value = dto.taxaPagamento;
            cmd.Parameters.Add("@total_pagamento", MySqlDbType.Decimal).Value = dto.totalPagamento;
            cmd.Parameters.Add("@total_pago", MySqlDbType.Decimal).Value = dto.totalPago;
            cmd.Parameters.Add("@tipo_pag", MySqlDbType.VarChar).Value = dto.tipoPag;
            cmd.Parameters.Add("@CPF_pag", MySqlDbType.Int16).Value = dto.cpfPagamento;
            cmd.Parameters.Add("@status_pag", MySqlDbType.VarChar).Value = dto.statusPagamento;
            cmd.Parameters.Add("@id_comanda", MySqlDbType.Int16).Value = dto.comandaPagamento;

            cmd.ExecuteNonQuery();
            cn.DesconectarBD();
        }

        public Pagamento ConsultarPagamento (int id)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM Pagamento where id_pag = @id_pag", cn.ConectarBD());
            cmd.Parameters.Add("@id_pag", MySqlDbType.Int16).Value = id;

            cmd.ExecuteNonQuery();

            return new Pagamento();
        }
    }
}
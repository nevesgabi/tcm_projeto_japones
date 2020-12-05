using MySql.Data.MySqlClient;
using projeto_tcm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace projeto_tcm.Repositorio
{
    public class Itens
    {
        Conexao cn = new Conexao();
        MySqlCommand cmd = new MySqlCommand();

        public void CadastroItem(Item dto)
        {
            MySqlCommand cmd = new MySqlCommand("INSERT INTO Item(nome_item, preco_item, descricao_item, nome_categoria) VALUES (@nome_item, @preco_item, @descricao_item, @nome_categoria)", cn.ConectarBD());
            cmd.Parameters.Add("@nome_item", MySqlDbType.VarChar).Value = dto.NomeItem;
            cmd.Parameters.Add("@preco_item", MySqlDbType.Decimal).Value = dto.PrecoItem;
            cmd.Parameters.Add("@descricao_item", MySqlDbType.VarChar).Value = dto.DescItem;
            cmd.Parameters.Add("@nome_categoria", MySqlDbType.VarChar).Value = dto.CategoriaItem;
            
            cmd.ExecuteNonQuery();
            cn.DesconectarBD();
        }
    }
}
using MySql.Data.MySqlClient;
using projeto_tcm.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace projeto_tcm.Repositorio
{
    public class Itens
    {
        Conexao cn = new Conexao();
        MySqlCommand cmd = new MySqlCommand();

        public long CadastroItem(Item dto)
        {
            MySqlCommand cmd = new MySqlCommand("INSERT INTO Item(nome_item, preco_item, descricao_item, nome_categoria) VALUES (@nome_item, @preco_item, @descricao_item, @nome_categoria)", cn.ConectarBD());
            cmd.Parameters.Add("@nome_item", MySqlDbType.VarChar).Value = dto.NomeItem;
            cmd.Parameters.Add("@preco_item", MySqlDbType.Decimal).Value = dto.PrecoItem;
            cmd.Parameters.Add("@descricao_item", MySqlDbType.VarChar).Value = dto.DescItem;
            cmd.Parameters.Add("@nome_categoria", MySqlDbType.VarChar).Value = dto.CategoriaItem;;

            // Utilizado para obter o ID
            cmd.Parameters.Add("@Id_item", MySqlDbType.Int16, 4).Direction = ParameterDirection.Output;

            cmd.ExecuteNonQuery();

            long id_item = cmd.LastInsertedId;

            cn.DesconectarBD();

            return id_item;
        }

        public Item ConsultarItem(int id)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM item where id_item = @id_item", cn.ConectarBD());
            cmd.Parameters.Add("@id_item", MySqlDbType.Int16).Value = id;

            cmd.ExecuteNonQuery();

            MySqlDataReader reader = cmd.ExecuteReader();

            Item it = new Item();

            while (reader.Read())
            {
                it.IdItem = reader.GetInt16(reader.GetOrdinal("id_item"));
                it.NomeItem = reader.GetString(reader.GetOrdinal("nome_item"));
                it.PrecoItem = reader.GetString(reader.GetOrdinal("preco_item"));
                it.DescItem = reader.GetString(reader.GetOrdinal("descricao_item"));
                it.CategoriaItem = reader.GetString(reader.GetOrdinal("nome_categoria"));
                }

            reader.Close();

            cn.DesconectarBD();

            return it;
        }

        public List<Item> ListaTodosItens()
        {
            List<Item> itens = new List<Item>();

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM item", cn.ConectarBD());

            cmd.ExecuteNonQuery();

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Item it = new Item();
                it.IdItem = reader.GetInt16(reader.GetOrdinal("id_item"));
                it.NomeItem = reader.GetString(reader.GetOrdinal("nome_item"));
                it.PrecoItem = reader.GetString(reader.GetOrdinal("preco_item"));
                it.DescItem = reader.GetString(reader.GetOrdinal("descricao_item"));
                it.CategoriaItem = reader.GetString(reader.GetOrdinal("nome_categoria"));
                itens.Add(it);
            }

            return itens;
        }

        public bool DeletarItem(int id)
        {

            MySqlCommand cmd = new MySqlCommand("DELETE FROM item WHERE id_item = @id_item", cn.ConectarBD());
            cmd.Parameters.Add("@id_item", MySqlDbType.Int16).Value = id;

            int deletedRows = cmd.ExecuteNonQuery();

            return deletedRows > 0;
        }
    }
}
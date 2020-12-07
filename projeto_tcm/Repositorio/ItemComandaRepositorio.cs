using MySql.Data.MySqlClient;
using System;
using projeto_tcm.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace projeto_tcm.Repositorio
{
    public class ItemComandaRepositorio
    {
        Conexao cn = new Conexao();
        MySqlCommand cmd = new MySqlCommand();

        public void AdicionarItem(ItemComanda itemComanda)
        {
            MySqlCommand cmd = new MySqlCommand("INSERT INTO ItemComanda(qt_item, id_comanda, id_item) VALUES (@qtd, @comanda, @item)", cn.ConectarBD());

            cmd.Parameters.Add("@qtd", MySqlDbType.Int16).Value = itemComanda.qt_item;
            cmd.Parameters.Add("@comanda", MySqlDbType.Int16).Value = itemComanda.id_comanda;
            cmd.Parameters.Add("@item", MySqlDbType.Int16).Value = itemComanda.id_item;

            cmd.ExecuteNonQuery();

            cn.DesconectarBD();
        }

        public List<ItemComandaFormatado> ListarItensComanda(int idComanda)
        {
            MySqlCommand cmd = new MySqlCommand(@"SELECT itemComanda.id_item_comanda, item.nome_item, item.preco_item,  itemComanda.qt_item
                                                    FROM itemComanda
                                                    INNER JOIN item ON itemComanda.id_item = item.id_item
                                                    WHERE id_comanda = @idComanda;", cn.ConectarBD());

            cmd.Parameters.Add("@idComanda", MySqlDbType.Int16).Value = idComanda;

            cmd.ExecuteNonQuery();

            List<ItemComandaFormatado> itens = new List<ItemComandaFormatado>();

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ItemComandaFormatado it = new ItemComandaFormatado();
                it.id_itemComanda = reader.GetInt16(reader.GetOrdinal("id_item_comanda"));
                it.nome_item = reader.GetString(reader.GetOrdinal("nome_item"));
                it.preco_item = reader.GetDouble(reader.GetOrdinal("preco_item"));
                it.qtd_item = reader.GetInt16(reader.GetOrdinal("qt_item"));
                itens.Add(it);
            }

            cn.DesconectarBD();

            return itens;
        }

        public bool DeletarItem(int id)
        {
            MySqlCommand cmd = new MySqlCommand("DELETE FROM itemComanda WHERE id_item_comanda = @id_item_comanda", cn.ConectarBD());
            cmd.Parameters.Add("@id_item_comanda", MySqlDbType.Int16).Value = id;

            int deletedRows = cmd.ExecuteNonQuery();

            return deletedRows > 0;
        }
    }
}
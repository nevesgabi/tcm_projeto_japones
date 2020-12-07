using MySql.Data.MySqlClient;
using System;
using projeto_tcm.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace projeto_tcm.Repositorio
{
    public class LoginRepositorio
    {
        Conexao cn = new Conexao();
        MySqlCommand cmd = new MySqlCommand();

        public UserLogin TestarUsuario(UserLogin user)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM funcionario where usuario_func =@usuario_func AND senha_func =@senha_func", cn.ConectarBD());
            cmd.Parameters.Add("@usuario_func", MySqlDbType.VarChar).Value = user.nome_usuario;
            cmd.Parameters.Add("@senha_func", MySqlDbType.VarChar).Value = user.senha;

            MySqlDataReader leitor;

            leitor = cmd.ExecuteReader();

            if (leitor.HasRows)
            {
                while (leitor.Read())
                {
                    UserLogin dto = new UserLogin();
                    {
                        dto.nome_usuario = Convert.ToString(leitor["usuario_func"]);
                        dto.senha = Convert.ToString(leitor["senha_func"]);
                    }

                }
            }
            else
            {
                user.nome_usuario = null;
                user.senha = null;
            }
            return user;
        }


    }
}
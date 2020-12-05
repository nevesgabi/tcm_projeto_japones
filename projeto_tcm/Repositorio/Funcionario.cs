using MySql.Data.MySqlClient;
using projeto_tcm.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;


namespace projeto_tcm.Repositorio
{
    public class Funcionario
    {
        Conexao cn = new Conexao();
        MySqlCommand cmd = new MySqlCommand();

        public void CadastroFuncionario(Cadastro dto)
        {
            MySqlCommand cmd = new MySqlCommand("INSERT INTO Funcionario(nome_func, cpf_func, tel_func, funcao_func, endereco_func, usuario_func, senha_func, nivel_acesso_func) VALUES (@nome_func, @CPF_func, @tel_func, @funcao_func, @endereco_func, @usuario_func, @senha_func, @nivel_acesso_func)", cn.ConectarBD());
            cmd.Parameters.Add("@nome_func", MySqlDbType.VarChar).Value = dto.nomeCadastro;
            cmd.Parameters.Add("@CPF_func", MySqlDbType.Int16).Value = dto.cpfCadastro;
            cmd.Parameters.Add("@tel_func", MySqlDbType.Int16).Value = dto.telefoneCadastro;
            cmd.Parameters.Add("@funcao_func", MySqlDbType.VarChar).Value = dto.funcaoCadastro;
            cmd.Parameters.Add("@endereco_func", MySqlDbType.VarChar).Value = dto.enderecoCadastro;
            cmd.Parameters.Add("@usuario_func", MySqlDbType.VarChar).Value = dto.usuarioCadastro;
            cmd.Parameters.Add("@senha_func", MySqlDbType.VarChar).Value = dto.senhaCadastro;
            cmd.Parameters.Add("@nivel_acesso_func", MySqlDbType.Int16).Value = dto.nivelCadastro;

            cmd.ExecuteNonQuery();
            cn.DesconectarBD();
        }

        public Funcionario ConsultarFuncionario(int id)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM Mesa where id_func = @id_func", cn.ConectarBD());
            cmd.Parameters.Add("@id_func", MySqlDbType.Int16).Value = id;

            cmd.ExecuteNonQuery();

            return new Funcionario();
        }
    }
}
using MySql.Data.MySqlClient;
using projeto_tcm.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;


namespace projeto_tcm.Repositorio
{
    public class FuncionarioRepositorio
    {
        Conexao cn = new Conexao();
        MySqlCommand cmd = new MySqlCommand();

        public long CadastroFuncionario(FuncionarioModel dto)
        {
            MySqlCommand cmd = new MySqlCommand(@"
                INSERT INTO Funcionario(
                    nome_func, 
                    cpf_func, 
                    tel_func, 
                    funcao_func, 
                    endereco_func, 
                    usuario_func, 
                    senha_func, 
                    nivel_acesso_func) 
                VALUES (
                    @nome_func, 
                    @CPF_func, 
                    @tel_func, 
                    @funcao_func, 
                    @endereco_func, 
                    @usuario_func, 
                    @senha_func, 
                    @nivel_acesso_func)", cn.ConectarBD());
            cmd.Parameters.Add("@nome_func", MySqlDbType.VarChar).Value = dto.nomeCadastro;
            cmd.Parameters.Add("@CPF_func", MySqlDbType.VarChar).Value = dto.cpfCadastro;
            cmd.Parameters.Add("@tel_func", MySqlDbType.VarChar).Value = dto.telefoneCadastro;
            cmd.Parameters.Add("@funcao_func", MySqlDbType.VarChar).Value = dto.funcaoCadastro;
            cmd.Parameters.Add("@endereco_func", MySqlDbType.VarChar).Value = dto.enderecoCadastro;
            cmd.Parameters.Add("@usuario_func", MySqlDbType.VarChar).Value = dto.usuarioCadastro;
            cmd.Parameters.Add("@senha_func", MySqlDbType.VarChar).Value = dto.senhaCadastro;
            cmd.Parameters.Add("@nivel_acesso_func", MySqlDbType.Int16).Value = Int16.Parse(dto.nivelCadastro);

            // Utilizado para obter o ID
            cmd.Parameters.Add("@ID", MySqlDbType.Int16, 4).Direction = ParameterDirection.Output;

            cmd.ExecuteNonQuery();

            long id = cmd.LastInsertedId;

            cn.DesconectarBD();

            return id;
        }

        public FuncionarioModel ConsultarFuncionario(int id)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM funcionario where id_func = @id_func", cn.ConectarBD());
            cmd.Parameters.Add("@id_func", MySqlDbType.Int16).Value = id;

            cmd.ExecuteNonQuery();

            MySqlDataReader reader = cmd.ExecuteReader();

            FuncionarioModel func = new FuncionarioModel();

            while (reader.Read())
            {
                func.idCadastro = reader.GetInt16(reader.GetOrdinal("id_func"));
                func.nomeCadastro = reader.GetString(reader.GetOrdinal("nome_func"));
                func.cpfCadastro = reader.GetString(reader.GetOrdinal("CPF_func"));
                func.telefoneCadastro = reader.GetString(reader.GetOrdinal("tel_func"));
                func.funcaoCadastro = reader.GetString(reader.GetOrdinal("funcao_func"));
                func.enderecoCadastro = reader.GetString(reader.GetOrdinal("endereco_func"));
                func.usuarioCadastro = reader.GetString(reader.GetOrdinal("usuario_func"));
                func.nivelCadastro = reader.GetString(reader.GetOrdinal("senha_func"));
                func.nivelCadastro = reader.GetString(reader.GetOrdinal("nivel_acesso_func"));
            }

            reader.Close();

            cn.DesconectarBD();

            return func;
        }

        public List<FuncionarioModel> ListarTodos()
        {
            List<FuncionarioModel> funcionarios = new List<FuncionarioModel>();

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM funcionario", cn.ConectarBD());

            cmd.ExecuteNonQuery();

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                FuncionarioModel func = new FuncionarioModel();
                func.idCadastro = reader.GetInt16(reader.GetOrdinal("id_func"));
                func.nomeCadastro = reader.GetString(reader.GetOrdinal("nome_func"));
                func.cpfCadastro = reader.GetString(reader.GetOrdinal("CPF_func"));
                func.telefoneCadastro = reader.GetString(reader.GetOrdinal("tel_func"));
                func.funcaoCadastro = reader.GetString(reader.GetOrdinal("funcao_func"));
                func.enderecoCadastro = reader.GetString(reader.GetOrdinal("endereco_func"));
                func.usuarioCadastro = reader.GetString(reader.GetOrdinal("usuario_func"));
                func.nivelCadastro = reader.GetString(reader.GetOrdinal("senha_func"));
                func.nivelCadastro = reader.GetString(reader.GetOrdinal("nivel_acesso_func"));
                funcionarios.Add(func);
            }


            return funcionarios;
        }


        public bool DeletarFuncionario(int id)
        {

            MySqlCommand cmd = new MySqlCommand("DELETE FROM funcionario WHERE id_func = @id_func", cn.ConectarBD());
            cmd.Parameters.Add("@id_func", MySqlDbType.Int16).Value = id;

            int deletedRows = cmd.ExecuteNonQuery();

            return deletedRows > 0;
        }
    }
}
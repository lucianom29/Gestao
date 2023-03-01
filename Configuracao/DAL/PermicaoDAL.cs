using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PermicaoDAL
    {
        public void Inserir(Permissao _permicao)
        {
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"INSERT INTO Usuario(Nome, NomeUsuario, CPF,Email,senha,Ativo)" +
                    "VALUES(@Nome, @NomeUsuario,@CPF,@Email,@Senha,@Ativo)";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Nome", _permicao.Descricao);
      

                cn.Open();
                cmd.ExecuteScalar();
            
            }
            catch (Exception ex)
            {
             throw new Exception("ocorreu um erro ao tentar inserir um usuario no banco:" + ex.Message);

            }
            finally
            {
                cn.Close();
            }
        }
        public Permissao Buscar(string _NomeUsuario)
        {
            return new Permissao();
        }
        public void Alterar (Usuario usuario)
        {

        }
        public void Excluir (int _id)
        {

        }
    }
}

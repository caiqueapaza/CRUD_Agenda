using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Agenda.DB
{
    internal class Usuario : ConexaoDB 
    {
        public static string GerarHash(string strSenha)
        {
            using (var deriveBytes = new Rfc2898DeriveBytes(strSenha, 16, 10000))
            {
                byte[] salt = deriveBytes.Salt;
                byte[] hash = deriveBytes.GetBytes(32);

                byte[] hashCompleto = new byte[48];
                Array.Copy(salt, 0, hashCompleto, 0, 16);
                Array.Copy(hash, 0, hashCompleto, 16, 32);

                return Convert.ToBase64String(hashCompleto);
            }
        }
        public bool VerificarUsuario(string strUsuario, string senhaDigitada)
        {
            string hashArmazenado = ObterHashSenha(strUsuario);

            if (string.IsNullOrEmpty(hashArmazenado))
                return false;

            byte[] hashBytes;
            try
            {
                hashBytes = Convert.FromBase64String(hashArmazenado);
            }
            catch
            {
                return false; 
            }

            if (hashBytes.Length != 48)
                return false;

            byte[] salt = new byte[16];
            Array.Copy(hashBytes, 0, salt, 0, 16);

            using (var deriveBytes = new Rfc2898DeriveBytes(senhaDigitada, salt, 10000))
            {
                byte[] novoHash = deriveBytes.GetBytes(32);
                for (int i = 0; i < 32; i++)
                {
                    if (hashBytes[i + 16] != novoHash[i])
                        return false;
                }
            }

            return true;
        }

        public int VerificaUsuarioExistente()
        {
            string SqlString = string.Empty;
            SqlCommand comando = null;
            SqlConnection conexao = null;

            try
            {
                SqlString = "SELECT COUNT(1) FROM usuarios WHERE fl_ativo = 1 AND fl_adm = 1";
                

                conexao = new SqlConnection(SQLString);
                comando = new SqlCommand(SqlString.ToString(), conexao);

                DataTable dt = GetDataTable(comando);

                if (dt != null && dt.Rows.Count > 0)
                    return Convert.ToInt32(dt.Rows[0][0]);

                return 0;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public string ObterHashSenha(string strEmail)
        {
            string SqlString = string.Empty;
            string strHashSenha = string.Empty;
            SqlCommand comando = null;
            SqlConnection conexao = null;

            try
            {
                SqlString = "SELECT ds_senha FROM usuarios WHERE fl_ativo = 1";
                SqlString = SqlString + "AND ds_email = @Email";

                conexao = new SqlConnection(SQLString);
                comando = new SqlCommand(SqlString.ToString(), conexao);

                comando.Parameters.Add("@Email", SqlDbType.VarChar);

                comando.Parameters["@Email"].Value = strEmail;

                DataTable dt = ConexaoDB.GetDataTable(comando);
                if (dt != null && dt.Rows.Count > 0)
                {
                    strHashSenha = dt.Rows[0]["ds_senha"].ToString();
                }

                return strHashSenha;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int ObterIdUsuario(string strUsuario)
        {
            string SqlString = string.Empty;
            SqlCommand comando = null;
            SqlConnection conexao = null;

            try
            {
                SqlString = "SELECT id FROM usuarios WHERE ds_email = @Email AND fl_ativo = 1";

                conexao = new SqlConnection(SQLString);
                comando = new SqlCommand(SqlString.ToString(), conexao);

                comando.Parameters.Add("@Email", SqlDbType.VarChar);

                comando.Parameters["@Email"].Value = strUsuario;

                DataTable dt = GetDataTable(comando);
                if (dt != null && dt.Rows.Count > 0)
                    return Convert.ToInt32(dt.Rows[0]["id"]);

                return -1;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string ObterNomeUsuario(int idUsuario)
        {
            string SqlString = string.Empty;
            SqlCommand comando = null;
            SqlConnection conexao = null;

            try
            {
                SqlString = "SELECT ds_nome FROM usuarios WHERE id = @Id AND fl_ativo = 1";

                conexao = new SqlConnection(SQLString);
                comando = new SqlCommand(SqlString.ToString(), conexao);

                comando.Parameters.Add("@Id", SqlDbType.Int);

                comando.Parameters["@Id"].Value = idUsuario;

                DataTable dt = GetDataTable(comando);
                if (dt != null && dt.Rows.Count > 0)
                    return dt.Rows[0]["ds_nome"].ToString();

                return "";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int CadastrarUsuario(string strNomeUsuario, string strEmailUsuario, string strSenhaUsuario, int intAdm)
        {
            string SqlString = string.Empty;
            SqlCommand comando = null;
            SqlConnection conexao = null;

            try
            {
                SqlString = "INSERT INTO usuarios (ds_nome, ds_email, ds_senha, fl_adm)";
                SqlString = SqlString + "VALUES (@NomeUsuario, @EmailUsuario, @SenhaUsuario, @Adm)";

                conexao = new SqlConnection(SQLString);
                comando = new SqlCommand(SqlString.ToString(), conexao);

                comando.Parameters.Add("@NomeUsuario", SqlDbType.Text);
                comando.Parameters.Add("@EmailUsuario", SqlDbType.Text);
                comando.Parameters.Add("@SenhaUsuario", SqlDbType.Text);
                comando.Parameters.Add("@Adm", SqlDbType.Bit);

                comando.Parameters["@NomeUsuario"].Value = strNomeUsuario;
                comando.Parameters["@EmailUsuario"].Value = strEmailUsuario;
                comando.Parameters["@SenhaUsuario"].Value = GerarHash(strSenhaUsuario);
                comando.Parameters["@Adm"].Value = intAdm;

                return ExecuteNonQuery(comando);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}

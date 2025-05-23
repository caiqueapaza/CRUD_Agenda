using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Agenda.DB
{
    internal class Agenda : ConexaoDB
    {
        
        public DataTable ObterPermissaoAdm(int idUsuario)
        {
            string SqlString = string.Empty;
            SqlCommand comando = null;
            SqlConnection conexao = null;
            try
            {
                SqlString = "SELECT fl_adm FROM usuarios WHERE id = @Id AND fl_adm = 1";

                conexao = new SqlConnection(SQLString);
                comando = new SqlCommand(SqlString.ToString(), conexao);

                comando.Parameters.Add("@Id", SqlDbType.Int);
                comando.Parameters["@Id"].Value = idUsuario;

                return GetDataTable(comando);
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }

        public DataTable ObterAgenda(int idUsuario, DateTime dtAgenda)
        {
            string SqlString = string.Empty;
            SqlCommand comando = null;
            SqlConnection conexao = null;

            try
            {
                SqlString = "SELECT a.id, ds_hora, ds_titulo, ds_descricao, ds_status FROM agenda a ";
                SqlString = SqlString + "JOIN status s ON s.id = a.id_status ";
                SqlString = SqlString + "WHERE id_usuario = @IdUsuario AND dt_agenda = @DtAgenda ";
                SqlString = SqlString + "AND fl_ativo = 1";

                conexao = new SqlConnection(SQLString);
                comando = new SqlCommand(SqlString.ToString(), conexao);

                comando.Parameters.Add("@IdUsuario", SqlDbType.Int);
                comando.Parameters.Add("@DtAgenda", SqlDbType.DateTime);

                comando.Parameters["@IdUsuario"].Value = idUsuario;
                comando.Parameters["@DtAgenda"].Value = dtAgenda;

                return GetDataTable(comando);
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }

        public int IncluirAgenda(int idUsuario, DateTime dtAgenda, string strHora, string strTitulo, string strDescricao)
        {
            string SqlString = string.Empty;
            SqlCommand comando = null;
            SqlConnection conexao = null;

            try
            {
                SqlString = "INSERT INTO agenda (id_usuario, dt_agenda, ds_hora, ds_titulo, ds_descricao)";
                SqlString = SqlString + "VALUES (@IdUsuario, @DtAgenda, @Hora, @Titulo, @Descricao)";

                conexao = new SqlConnection(SQLString);
                comando = new SqlCommand(SqlString.ToString(), conexao);

                comando.Parameters.Add("@IdUsuario", SqlDbType.Int);
                comando.Parameters.Add("@DtAgenda", SqlDbType.DateTime);
                comando.Parameters.Add("@Hora", SqlDbType.Text);
                comando.Parameters.Add("@Titulo", SqlDbType.Text);
                comando.Parameters.Add("@Descricao", SqlDbType.Text);

                comando.Parameters["@IdUsuario"].Value = idUsuario;
                comando.Parameters["@DtAgenda"].Value = dtAgenda;
                comando.Parameters["@Hora"].Value = strHora;
                comando.Parameters["@Titulo"].Value = strTitulo;
                comando.Parameters["@Descricao"].Value = strDescricao;

                return ExecuteNonQuery(comando);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int AlterarAgenda(int id, string strHora, string strTitulo, string strDescricao)
        {
            string SqlString = string.Empty;
            SqlCommand comando = null;
            SqlConnection conexao = null;

            try
            {
                SqlString = "UPDATE agenda SET ";
                SqlString = SqlString + "ds_hora = @Hora, ";
                SqlString = SqlString + "ds_titulo = @Titulo, ";
                SqlString = SqlString + "ds_descricao = @Descricao ";
                SqlString = SqlString + "WHERE id = @Id";

                conexao = new SqlConnection(SQLString);
                comando = new SqlCommand(SqlString.ToString(), conexao);

                comando.Parameters.Add("@Id", SqlDbType.Int);
                comando.Parameters.Add("@Hora", SqlDbType.Text);
                comando.Parameters.Add("@Titulo", SqlDbType.Text);
                comando.Parameters.Add("@Descricao", SqlDbType.Text);

                comando.Parameters["@Id"].Value = id;
                comando.Parameters["@Hora"].Value = strHora;
                comando.Parameters["@Titulo"].Value = strTitulo;
                comando.Parameters["@Descricao"].Value = strDescricao;

                return ExecuteNonQuery(comando);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int ConcluirAgenda(int id)
        {
            string SqlString = string.Empty;
            SqlCommand comando = null;
            SqlConnection conexao = null;

            try
            {
                SqlString = "UPDATE agenda SET id_status = 2";
                SqlString = SqlString + "WHERE id = @Id";

                conexao = new SqlConnection(SQLString);
                comando = new SqlCommand(SqlString.ToString(), conexao);

                comando.Parameters.Add("@Id", SqlDbType.Int);

                comando.Parameters["@Id"].Value = id;

                return ExecuteNonQuery(comando);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int ExcluirAgenda(int id)
        {
            string SqlString = string.Empty;
            SqlCommand comando = null;
            SqlConnection conexao = null;

            try
            {
                SqlString = "UPDATE agenda SET id_status = 3, fl_ativo = 0";
                SqlString = SqlString + "WHERE id = @Id";

                conexao = new SqlConnection(SQLString);
                comando = new SqlCommand(SqlString.ToString(), conexao);

                comando.Parameters.Add("@Id", SqlDbType.Int);

                comando.Parameters["@Id"].Value = id;

                return ExecuteNonQuery(comando);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}

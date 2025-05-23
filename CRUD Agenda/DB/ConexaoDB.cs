using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Agenda.DB
{
    internal class ConexaoDB : IDisposable
    {
        public static string SQLString = @"Server=localhost,1433;Database=teste_agenda;User Id=sa;Password=Senha123!";


        #region Métodos para acesso ao banco de dados
        //Executa Query Ex.: Insert, Update, Delete
        public static int ExecuteNonQuery(SqlCommand cm)
        {

            int RetVal = 0;
            using (SqlConnection cn = new SqlConnection(SQLString))
            {
                cn.Open();
                cm.Connection = cn;
                RetVal = cm.ExecuteNonQuery();
                cn.Close();
                cm.Dispose();
            }
            return RetVal;
        }
        //Executa Query para trazer Select com linhas
        public static DataTable GetDataTable(SqlCommand cm)
        {
            DataTable dt = new DataTable();
            using (SqlConnection cn = new SqlConnection(SQLString))
            {
                cm.Connection = cn;
                cm.Connection.Open();
                SqlDataReader dr = cm.ExecuteReader();
                dt.Load(dr);
                cm.Connection.Close();
                dr.Dispose();
                cm.Dispose();
            }
            return dt;
        }
        #endregion
        #region IDisposable Members

        /// <summary>
        /// Método Dispose para liberar os objetos
        /// </summary>
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        #endregion
    }
}

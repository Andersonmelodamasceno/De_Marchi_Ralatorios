using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace De_Marchi_Relatorios
{
    class Consulta
    {
        private string connectionString = "Data Source=LAPTOP-BLUA29AH;Initial Catalog=thoth_balbinot;User ID=sa;Password=123456";
        private readonly Data.DbContext dbContext;

        // Criar uma instância de DbContext
        SqlConnection dbConnection;



        public Consulta()
        {
            dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();
        }

        public DataTable RealizarConsulta(DateTime DataInicial,DateTime DataFinal, int IdFilial)
        {
            
            string query = "SP_CARREGAR_FECHAMENTO_BASE";

            using (SqlConnection connection = dbConnection)
            {
                //try
                //{
                    SqlCommand command = new SqlCommand(query, connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    command.Parameters.Add("@DATAINICIAL", SqlDbType.Date).Value = DataInicial;
                    command.Parameters.Add("@DATAFINAL", SqlDbType.Date).Value = DataFinal;
                    command.Parameters.Add("@IDFILIAL", SqlDbType.Int).Value = IdFilial ;
                    command.Parameters.Add("@VIRTUAL", SqlDbType.Int).Value = 0;

                    SqlDataAdapter _Load = new SqlDataAdapter(command);
                    DataSet dsretorno = new DataSet();
                    _Load.Fill(dsretorno);
                    if (dsretorno.Tables.Count > 0)
                        return dsretorno.Tables[0];
                    else
                        return new DataTable();
                //}
                //catch (Exception ex)
                //{

                //    return new DataTable();
                //}
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De_Marchi_Relatorios
{
    class Consulta
    {
        private readonly Data.DbContext dbContext;

        public Consulta(Data.DbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void RealizarConsulta()
        {
            // Exemplo de consulta
            string query = "SELECT Nome, Sobrenome FROM TabelaExemplo";

            using (SqlConnection connection = dbContext.OpenConnection())
            {
                try
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string nome = reader["Nome"].ToString();
                                string sobrenome = reader["Sobrenome"].ToString();
                                Console.WriteLine($"Nome: {nome}, Sobrenome: {sobrenome}");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro: " + ex.Message);
                }
            }
        }
    }
}
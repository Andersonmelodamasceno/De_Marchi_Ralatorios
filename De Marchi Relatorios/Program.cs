using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace De_Marchi_Relatorios
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Substitua a string de conexão com suas próprias informações
            string connectionString = "Data Source=LAPTOP-BLUA29AH;Initial Catalog=thoth_balbinot;User ID=sa;Password=123456";

            // Criar uma instância de DbContext
            Data.DbContext dbContext = new Data.DbContext(connectionString);

            // Criar uma instância de Consulta
            Consulta consulta = new Consulta(dbContext);

            // Executar consulta
            consulta.RealizarConsulta();

            Application.Run(new Form1());
        }
    }
}
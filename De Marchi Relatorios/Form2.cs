using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace De_Marchi_Relatorios
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Consulta new_pesq = new Consulta();
            dataGridView1.DataSource = new_pesq.RealizarConsulta(DateTime.Parse("2023-01-01"), DateTime.Parse("2023-12-31"), 1);

        }
    }
}

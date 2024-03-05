using Syncfusion.WinForms.DataGrid;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
                      InitializeComponent();
            SfDataGrid sfDataGrid1 = new SfDataGrid();
            sfDataGrid1.Location = new System.Drawing.Point(85, 108);
            sfDataGrid1.Size = new System.Drawing.Size(240, 150);
            this.Controls.Add(sfDataGrid1);
        }

        private void sfDataGrid1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("sfDataGrid1 foi clicado!");
        }

        private void sfDateTimeEdit1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("sfDateTimeEdit1 foi clicado!");
        }

        private void gridControl1_CellClick(object sender, Syncfusion.Windows.Forms.Grid.GridCellClickEventArgs e)
        {

        }

        private void sfButton1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sfComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxBase2_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxBase5_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MapControlApplication111
{
    public partial class DataBoard : Form
    {
        public DataBoard(String sDataName,DataTable dataTable)
        {
            InitializeComponent();
            // tbDataName.Text = sDataName;
            dataGridView1.DataSource = dataTable;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataBoard_Load(object sender, EventArgs e)
        {

        }
    }
}

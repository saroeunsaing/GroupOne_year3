using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        SQLcontrol sql = new SQLcontrol();
        public Form1()
        {
            InitializeComponent();
        }

        private void form_load(object sender, EventArgs e)
        {
            sql.retrieve(dataGridView1);


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

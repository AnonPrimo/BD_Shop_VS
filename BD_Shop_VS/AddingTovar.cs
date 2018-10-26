using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD_Shop_VS
{
    public partial class AddingTovar : Form
    {
        private DataGridView dgv;

        public AddingTovar(DataGridView d)
        {
            InitializeComponent();
            dgv = new DataGridView();
            dgv = d;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                BD.InsertMat(textBox1.Text, textBox_Kol.Text);
                BD.ChangeKlMat(Int32.Parse(textBox_Kol.Text, BD.IdOp));
                this.Close();
           
        }

        private void AddingTovar_Load(object sender, EventArgs e)
        {
            label1.Text = BD.NameMat;
        }
    }
}

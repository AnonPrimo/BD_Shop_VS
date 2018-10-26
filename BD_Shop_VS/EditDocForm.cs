using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD_Shop_VS
{
    public partial class EditDocForm : Form
    {
        public EditDocForm()
        {
            InitializeComponent();
        }

        private void EditDocForm_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = BD.GetTable("Sp_Post");
            comboBox1.DisplayMember = "name_post";
            comboBox1.ValueMember = "id_post";
            labelDocNum.Text += BD.DocNum.ToString();
            dataGridViewTov.DataSource = BD.GetTablePolya("Sp_Mat", "id_mat", "name_mat", "kl_opt");
            dataGridView1.DataSource = Doc_Tovar.GetTovar(BD.DocNum);
            button2.Enabled = false;


        }

        private void dataGridViewTov_Click(object sender, EventArgs e)
        {
            BD.IdMat = (int)dataGridViewTov.SelectedRows[0].Cells["id_mat"].Value;
            BD.NameMat = dataGridViewTov.SelectedRows[0].Cells["name_mat"].Value.ToString();
            AddingTovar at = new AddingTovar(dataGridViewTov);
            at.Owner = this;
            at.ShowDialog();
            dataGridView1.DataSource = Doc_Tovar.GetTovar(BD.DocNum);
            dataGridViewTov.DataSource = BD.GetTablePolya("Sp_Mat", "id_mat", "name_mat", "kl_opt");

        }



        private void textBoxFind_KeyUp(object sender, KeyEventArgs e)
        {
            if (textBoxFind.Text == "")
                button2.Enabled = false;
            else
                button2.Enabled = true;
            dataGridViewTov.DataSource = BD.FindPole(textBoxFind.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BD.IdTov = (int)dataGridView1.SelectedRows[0].Cells["id_id"].Value;
            BD.DelTov();
            dataGridView1.DataSource = Doc_Tovar.GetTovar(BD.DocNum);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxFind.Text = "";
            dataGridViewTov.DataSource = BD.FindPole(textBoxFind.Text);

        }
    }
}

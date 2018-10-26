using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BD_Shop_VS
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            
            button_Prihod.Visible = false;
            button_Rashod.Visible = false;
            button_Correct.Visible = false;

            comboBox_Login.DisplayMember = "name_sotr";
            comboBox_Login.ValueMember = "id_sort";

            comboBox_Login.DataSource = BD.GetTable("Sp_Sotr");


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Changing<string>.Rewrite(textBox_Pass.Text);

            DataTable dt = BD.GetTable("Sp_Sotr");
            int id = (int)comboBox_Login.SelectedIndex;
            string pass = dt.Rows[id][2].ToString().Trim();
            if(textBox_Pass.Text == pass)
            {
                button_Prihod.Visible = true;
                button_Rashod.Visible = true;
                button_Correct.Visible = true;
            }

         }

        private void button_Prihod_Click(object sender, EventArgs e)
        {
            Doc_TovarForm dtf = new Doc_TovarForm();
            BD.IdOp = 2;
            dtf.Show();
        }
        
    }
}

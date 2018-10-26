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


namespace BD_Shop_VS   ///приход
{
    public partial class Doc_TovarForm : Form
    {

        public Doc_TovarForm()
        {
            InitializeComponent();
        }

        private void Doc_TovarForm_Load(object sender, EventArgs e)
        {
            textBoxDataFrom.Text = "01.01.2018";
            textBoxDataTo.Text = "01.10.2018";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            dataGridViewDoc.DataSource = Doc_Tovar.GetDoc(textBoxDataFrom.Text, textBoxDataTo.Text, 3);
            textBoxSumm.Text = getSumm();
            textBoxOplata.Text = getOpl();
            textBoxDolg.Text = getDolg();
        }

        private void dataGridViewDoc_Click(object sender, EventArgs e)
        {
            int id_doc = (int)dataGridViewDoc.SelectedRows[0].Cells["id_doc"].Value;
            dataGridViewTovar.DataSource = Doc_Tovar.GetTovar(id_doc);
            BD.DocNum = id_doc;
                       
        }

        string getSumm()
        {
            double summ = 0;
            foreach (DataGridViewRow s in dataGridViewDoc.Rows)
            {
                if(Convert.ToInt32(s.Cells["id_op"].Value) == BD.IdOp)
                    summ += Convert.ToDouble(s.Cells["summ"].Value);
            }
            return summ.ToString();
        }

        string getDolg()
        {
            double dolg = 0;
            foreach (DataGridViewRow d in dataGridViewDoc.Rows)
            {
                if (Convert.ToInt32(d.Cells["id_op"].Value) == BD.IdOp)
                    dolg += Convert.ToDouble(d.Cells["dolg"].Value);
            }

            return dolg.ToString();
        }

        string getOpl()
        {
            double opl = 0;
            foreach (DataGridViewRow o in dataGridViewDoc.Rows)
            {
                if (Convert.ToInt32(o.Cells["id_op"].Value) == BD.IdOp)
                    opl += Convert.ToDouble(o.Cells["oplata"].Value);
            }

            return opl.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditDocForm edf = new EditDocForm();
            edf.Show();
        }
    }
}

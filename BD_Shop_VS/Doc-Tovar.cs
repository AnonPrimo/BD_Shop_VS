using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;

namespace BD_Shop_VS
{
    public class Doc_Tovar
    {
        static string connecting = @"Data Source=USER-ПК\SQLEXPRESS;Initial Catalog=Shop_VS;Integrated Security=True";

        static SqlConnection con;

        public Doc_Tovar()
        {
            con = new SqlConnection(connecting);
        }


        public static DataTable GetDoc(string df, string dt, int op)
        {
            using (con = new SqlConnection(connecting))
            {
                string commandStr = "select * from Doc where datt >= '" + df + "' and datt <= '" + dt + "' and id_op = " + op;
                SqlCommand comm = new SqlCommand(commandStr, con);
                SqlDataAdapter adapter = new SqlDataAdapter(comm);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }

        public static DataTable GetTovar(int id_doc)
        {
            using (con = new SqlConnection(connecting))
            {
                string commandStr = "select * from Tovar where id_doc = " + id_doc;
                SqlCommand comm = new SqlCommand(commandStr, con);
                SqlDataAdapter adapter = new SqlDataAdapter(comm);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }

       

    }
}

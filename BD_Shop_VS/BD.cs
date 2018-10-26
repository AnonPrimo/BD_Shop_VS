using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BD_Shop_VS
{
    class BD
    {
        static string connecting = @"Data Source=USER-ПК\SQLEXPRESS;Initial Catalog=Shop_VS;Integrated Security=True";

        static SqlConnection con;

        public static int DocNum { get; set; }
        public static int IdMat { get; set; }
        public static int IdTov { get; set; }
        public static int IdOp { get; set; }

        public static string NameMat { get; set; }
        public static bool AddTov { get; set; }

        public BD()
        {
            con = new SqlConnection(connecting);
            DocNum = 0;
            IdMat = 0;
            IdTov = 0;
            IdOp = 0;
            NameMat = "";
            AddTov = false;
        }


        public static DataTable GetTable(string tab)
        {
            using (con = new SqlConnection(connecting))
            {
                string commandStr = "select * from " + tab;
                SqlCommand comm = new SqlCommand(commandStr, con);
                SqlDataAdapter adapter = new SqlDataAdapter(comm);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }

        public static DataTable GetTablePolya(string tab, string p1, string p2, string p3)
        {
            using (con = new SqlConnection(connecting))
            {
                string commandStr = "select " + p1 + ", " + p2 + ", " + p3 + " from " + tab;
                SqlCommand comm = new SqlCommand(commandStr, con);
                SqlDataAdapter adapter = new SqlDataAdapter(comm);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }

        public static DataTable GetTablePolya(string tab, string p1, string p2, string p3, string p4)
        {
            using (con = new SqlConnection(connecting))
            {
                string commandStr = "select " + p1 + ", " + p2 + ", " + p3 + ", " + p4 + " from " + tab;
                SqlCommand comm = new SqlCommand(commandStr, con);
                SqlDataAdapter adapter = new SqlDataAdapter(comm);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }

        public static DataTable FindPole(string p1)
        {
            using (con = new SqlConnection(connecting))
            {
                string commandStr = "select * from Sp_Mat where name_mat like ('%" + p1 + "%')";
                SqlCommand comm = new SqlCommand(commandStr, con);
                SqlDataAdapter adapter = new SqlDataAdapter(comm);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }

        public static void InsertMat(string s, string k)
        {
            string sqlProcedure = "pr_insert_Tovar";
            using (con = new SqlConnection(connecting))
            {
                con.Open();

                SqlCommand comm = new SqlCommand(sqlProcedure, con);
                comm.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter id_docPar = new SqlParameter
                {
                    ParameterName = "@id_doc",
                    Value = DocNum
                };
                comm.Parameters.Add(id_docPar);

                SqlParameter id_MatPar = new SqlParameter
                {
                    ParameterName = "@id_mat",
                    Value = IdMat
                };
                comm.Parameters.Add(id_MatPar);

                SqlParameter Sena = new SqlParameter
                {
                    ParameterName = "@sena",
                    Value = s
                };
                comm.Parameters.Add(Sena);

                SqlParameter Kol = new SqlParameter
                {
                    ParameterName = "@kol",
                    Value = k
                };
                comm.Parameters.Add(Kol);
                var result = comm.ExecuteNonQuery();
                con.Close();

            }
        }

        public static void DelTov()
        {
            string sqlProcedure = "pr_delete_Tovar";
            using (con = new SqlConnection(connecting))
            {
                con.Open();

                SqlCommand comm = new SqlCommand(sqlProcedure, con);
                comm.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter id_tov = new SqlParameter
                {
                    ParameterName = "@id",
                    Value = IdTov
                };
                comm.Parameters.Add(id_tov);
                var result = comm.ExecuteNonQuery();
                con.Close();
            }
        }

        public static void ChangeKlMat(int i)
        {
            string sqlProcedure = "pr_change_KlMat";
            using (con = new SqlConnection(connecting))
            {
                con.Open();

                SqlCommand comm = new SqlCommand(sqlProcedure, con);
                comm.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter id_tov = new SqlParameter
                {
                    ParameterName = "@id_mat",
                    Value = IdMat
                };
                comm.Parameters.Add(id_tov);

                SqlParameter kl = new SqlParameter
                {
                    ParameterName = "@kol",
                    Value = i
                };
                comm.Parameters.Add(kl);

                SqlParameter id_op = new SqlParameter
                {
                    ParameterName = "@op",
                    Value = IdOp
                };
                comm.Parameters.Add(id_op);

                var result = comm.ExecuteNonQuery();
                con.Close();
            }
        }

       
    }
}

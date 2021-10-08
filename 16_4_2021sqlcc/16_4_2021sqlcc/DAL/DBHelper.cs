using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_4_2021sqlcc.BLL
{
    class DBHelper
    {
        public SqlConnection cnn { get; set; }
        private static DBHelper _Instance;

        public static DBHelper Instance
        {
            get
            {
                if (_Instance == null)
                {
                    string connst = @"Data Source =DESKTOP-FCKCG6E\SQLEXPRESS01;Initial Catalog =QLSV1;Integrated Security = True";

                    _Instance = new DBHelper(connst);
                }
                return _Instance;
            }
            set { }
        }
        private DBHelper(string query)
        {
            cnn = new SqlConnection(query);
        }
        public DataTable GetRecord(string query)
        {
            DataTable data = new DataTable();
            //SqlCommand cmd = new SqlCommand(query, cnn);
            SqlDataAdapter da = new SqlDataAdapter(query,cnn);
            cnn.Open();
            da.Fill(data);
            cnn.Close();
            return data;
        }
        public void ExecuteDB(string query)
        {
            SqlCommand cmd = new SqlCommand(query, cnn);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
    }
}

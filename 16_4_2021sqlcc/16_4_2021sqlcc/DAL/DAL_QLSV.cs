using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _16_4_2021sqlcc.BLL;
using _16_4_2021sqlcc.DTO;

namespace _16_4_2021sqlcc.DAL
{
    class DAL_QLSV
    {
 
        private static DAL_QLSV _Instance;
        public static DAL_QLSV Instance
        {
            get
            {
                if (_Instance == null)
                {
                   

                    _Instance = new DAL_QLSV();
                }
                return _Instance;
            }
            set { }
        }
        private DAL_QLSV()
        {
           
        }
        public List<LSH> getAllLSHDAL()
        {
            List<LSH> data = new List<LSH>();
            string query = "select *from LopSH";
            foreach(DataRow i in DBHelper.Instance.GetRecord(query).Rows  )
            {
                data.Add(LoadLSH(i));

            }
            return data;
        }
        public List<SV> GetAllSV_DAL()
        {
            List<SV> data = new List<SV>(); string query = "select *from SV";
            foreach (DataRow i in DBHelper.Instance.GetRecord(query).Rows)
            {
                data.Add(LoadSV(i));
            }
            return data;
        }
        public List<SV> GetSV_id_name(int ClassID, string Name)
        {
            List<SV> data = new List<SV>();
            string query = "select *from SV";
            foreach (DataRow i in DBHelper.Instance.GetRecord(query).Rows)
            {
                if (ClassID == 0)
                {
                    if (Name != "")
                    {
                        if (i["NameSV"].ToString() == Name)
                            data.Add(LoadSV(i));

                    }
                    else
                    {
                        data.Add(LoadSV(i));
                    }

                }

                else
                {
                    if (Name != "")
                    {
                        if (i["NameSV"].ToString() == Name && Convert.ToInt32(i["ID_Lop"]) == ClassID)
                            data.Add(LoadSV(i));
                    }
                    else
                    {
                        if (Convert.ToInt32(i["ID_Lop"]) == ClassID)
                            data.Add(LoadSV(i));
                    }

                }
            }
            return data;
        }
        public void AddSV_DAL(SV s)
        {
            string query = "INSERT INTO SV values('";
            query += s.MSSV + "', '" + s.NameSV + "', '" + s.Gender + "', '" + s.NS + "', '" + s.ID_Lop + "');";
            DBHelper.Instance.ExecuteDB(query);   
        }
        public void getEditSV_DAL(string mssv)
        {
            string query = "select *from SV where MSSV="+mssv;
            LoadSV( DBHelper.Instance.GetRecord(query).Rows[0]);
        }
        public void EditSV_DAL(SV s)
        {
            string query = "update SV set MSSV = '" + s.MSSV + "', NameSV ='" + s.NameSV + "', Gender ='" + s.Gender + "', NS ='" + s.NS + "', ID_Lop ='" + s.ID_Lop;
            DBHelper.Instance.ExecuteDB(query);
        }
        public void delSV_DAL(string mssv)
        {
            string query = "delete from SV where MSSV=" + mssv;
            DBHelper.Instance.ExecuteDB(query);
            //LoadSV(DBHelper.Instance.GetRecord(query).Rows[0]);
        }
       public string getNameLop_byIDLop(int ID_Lop)
        {
            string query = "select *from LopSH where ID_Lop =" + ID_Lop;
            DataRow dr = DBHelper.Instance.GetRecord(query).Rows[0];
            return dr["NameLop"].ToString();
        }
        public LSH LoadLSH(DataRow i)
        {
            LSH l = new LSH();
            l.NameLop = i["NameLop"].ToString();
            l.ID_Lop = Convert.ToInt32(i["ID_Lop"]);
            return l;
        }       
        public SV LoadSV(DataRow i)
        {
            SV data = new SV();
            data.MSSV = i["MSSV"].ToString();
            data.NameSV = i["NameSV"].ToString();
            data.Gender = Convert.ToBoolean(i["Gender"]);
            data.NS = Convert.ToDateTime(i["NS"]);
            data.ID_Lop = Convert.ToInt32(i["ID_Lop"]);
            return data;
        }
        public SVView LoadSVView(DataRow i)
        {
            SVView data = new SVView();
            data.MSSV = i["MSSV"].ToString();
            data.NameSV = i["NameSV"].ToString();
            data.Gender = Convert.ToBoolean(i["Gender"]);
            data.NS = Convert.ToDateTime(i["NS"]);
            data.NameLop = i["NameLop"].ToString();
            return data;
        }
    }
}

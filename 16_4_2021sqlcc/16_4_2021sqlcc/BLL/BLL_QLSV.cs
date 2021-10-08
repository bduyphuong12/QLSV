using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _16_4_2021sqlcc.DAL;
using _16_4_2021sqlcc.DTO;

namespace _16_4_2021sqlcc.BLL
{
    class BLL_QLSV
    {
        private static BLL_QLSV _Instance;

        public static BLL_QLSV Instance
        {
            get
            {
                if (_Instance == null)
                {


                    _Instance = new BLL_QLSV();
                }
                return _Instance;
            }
            set { }
        }
        private BLL_QLSV()
        {

        }
        public List<CBBItem> getCBBItems ()
        {
            List<CBBItem> data = new List<CBBItem>();
            foreach(LSH i in GetAllLSH_BLL())
            {
                data.Add(new CBBItem
                {
                    Value = i.ID_Lop,
                    Text = i.NameLop
                });

            }
            return data;
        }
        public List<SV> GetSVByNameandIDLOP(int classID, string Name)
        {
           
            return DAL_QLSV.Instance.GetSV_id_name(classID, Name);
        }
        public DataTable GetALLSVView(int classID, string Name)
        {
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("MSSV",typeof(string)),
                new DataColumn("NameSV",typeof(string)),
                new DataColumn("Gender",typeof(bool)),
                new DataColumn("NS",typeof(DateTime)),
                new DataColumn("NameLop",typeof(string))
            });
            foreach(var i in DAL_QLSV.Instance.GetSV_id_name(classID,Name))
            {
                DataRow dr = dt.NewRow();
                dr["MSSV"] = i.MSSV;
                dr["NameSV"] = i.NameSV;
                dr["Gender"] = i.Gender;
                dr["NS"] = i.NS;
                dr["NameLop"] = DAL_QLSV.Instance.getNameLop_byIDLop(i.ID_Lop);
                dt.Rows.Add(dr);
            }
            return dt;
        }
        public SV GetSVbyMSSV(string m)
        {
            SV s = new SV();
            s = null;
            foreach(SV i in DAL_QLSV.Instance.GetAllSV_DAL())
            {
                if(i.MSSV==m)
                {
                    s = i;
                    break;
                }
            }
            return s;
        }
        public void AddSv_BLL(SV s)
        {
             DAL_QLSV.Instance.AddSV_DAL(s);
            
        }
        public void EditSv_BLL(string mssv)
        {
            DAL_QLSV.Instance.getEditSV_DAL(mssv);
        }
        public void EditSv_BLL(SV s)
        {
            DAL_QLSV.Instance.EditSV_DAL(s);
        }
        public void DelSv_BLL(string mssv)
        {
            DAL_QLSV.Instance.delSV_DAL(mssv);
        }
        public delegate bool Compare(object s1, object s2);
        public void sort_BLL(List<SV> sv, Compare cmp)
        {
            SV temp = new SV();
            int d;
            for (int i = 0; i < sv.Count; i++)
            {
                temp = sv[i];
                d = i;
                while (d > 0 && cmp(temp, sv[d - 1]))
                {
                    sv[d] = sv[d - 1];
                    d--;
                }
                sv[d] = temp;
            }
        }
        public static bool compare_MSSV(object s1, object s2)
        {
            if (string.Compare(((SV)s1).MSSV, ((SV)s2).MSSV) < 0)
                return true;
            else return false;
        }
        public static bool compare_Name(object s1, object s2)
        {
            if (string.Compare(((SV)s1).NameSV, ((SV)s2).NameSV) < 0)
                return true;
            else return false;
        }
        public static bool compare_IDLOP(object s1, object s2)
        {
            return (((SV)s1).ID_Lop < ((SV)s2).ID_Lop);
        }
       
        public List<LSH> GetAllLSH_BLL()
        {
            return DAL_QLSV.Instance.getAllLSHDAL();
        }
        public List<SV> GetAllSV_BLL()
        {
            return DAL_QLSV.Instance.GetAllSV_DAL();
        }

    }
}

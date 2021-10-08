using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _16_4_2021sqlcc.BLL;
using _16_4_2021sqlcc.DTO;
using _16_4_2021sqlcc.View;

namespace _16_4_2021sqlcc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            setCBB();
            setCBBsort();
            loadform();
            //datagridsv.DataSource = BLL_QLSV.Instance.GetALLSVView(0, "") ;
        }
        public void setCBB()
        {
            combolopSH.Items.Add(new CBBItem
            {
                Text = "ALL",
                Value = 0
            });

            combolopSH.Items.AddRange(BLL_QLSV.Instance.getCBBItems().ToArray());
            combolopSH.SelectedIndex = 0;
        }
        public void setCBBsort()
        {
            string[] st = { "MSSV", "NameSV", "ID_Lop" };
            foreach (string i in st)
            {
                cbbsort.Items.Add(i);
            }
        }
        public void loadform()
        {
            int ID_Lop = ((CBBItem)combolopSH.SelectedItem).Value;
            string nameSV = txtSearch.Text;
            datagridsv.DataSource = null;
            datagridsv.DataSource = BLL_QLSV.Instance.GetALLSVView(ID_Lop, nameSV);
            datagridsv.Columns[0].Visible = false;
        }

       private void btshow_Click(object sender, EventArgs e)
        {
            loadform();
        }

        private void btsearch_Click(object sender, EventArgs e)
        {
            loadform();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            string idSV = "";
    
            f.Sender(idSV);
            f.Show();
            this.Hide();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            string idSV = datagridsv.CurrentRow.Cells["MSSV"].Value.ToString();
       
            f2.Sender(idSV);
            f2.Show();
            this.Hide();
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            string svID = datagridsv.CurrentRow.Cells["MSSV"].Value.ToString();
            BLL_QLSV.Instance.DelSv_BLL(svID);
            loadform();
        }

        private void btsort_Click(object sender, EventArgs e)
        {
            List<SV> st = new List<SV>();
            st = BLL_QLSV.Instance.GetAllSV_BLL();

            if (cbbsort.SelectedItem.ToString() == "MSSV")
            {
                BLL_QLSV.Instance.sort_BLL(st, BLL_QLSV.compare_MSSV);
            }
            else if (cbbsort.SelectedItem.ToString() == "NameSV")
            {
                BLL_QLSV.Instance.sort_BLL(st, BLL_QLSV.compare_Name);
            }
            else if (cbbsort.SelectedItem.ToString() == "ID_Lop")
            {
                BLL_QLSV.Instance.sort_BLL(st, BLL_QLSV.compare_IDLOP);
            }

            datagridsv.DataSource = st;
        }
    }
}

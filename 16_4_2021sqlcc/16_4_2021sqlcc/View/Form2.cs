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

namespace _16_4_2021sqlcc.View
{
    public partial class Form2 : Form
    {
        public delegate void mydel1(string mssv);
        public mydel1 Sender;

        string mssv = "";
        
        private void getData(string _mssv)
        {
            mssv = _mssv;
            
        }
       
        public Form2()
        {
            InitializeComponent();
            Sender = new mydel1(getData);
            setcbbform2();
        }

        private SV getSVadd()
        {
            SV s = new SV();
                s.MSSV = txtmssv.Text;
                s.NameSV = txtname.Text;
                if (rdbfmale.Checked)
                {
                    s.Gender = false;
                }
                else
                {
                    s.Gender = true;
                }
                s.NS = Convert.ToDateTime(dateTimePicker1.Value);
                s.ID_Lop = ((CBBItem)cbbLopSHCHitiet.SelectedItem).Value;

            return s;
            
        }
        private void Form2_Load(object sender, EventArgs e)
        {
           
        }
        private void setSV()
        {
            SV st = new SV();
            st =BLL_QLSV.Instance.GetSVbyMSSV(mssv);
            txtmssv.Text = st.MSSV;
            txtname.Text = st.NameSV;
            if (st.Gender) rdbfmale.Checked = true;
            dateTimePicker1.Value = st.NS;
            cbbLopSHCHitiet.SelectedIndex = st.ID_Lop - 1;
        }
        private void btOK_Click(object sender, EventArgs e)
        {
            if (mssv == "")
            {
                BLL_QLSV.Instance.AddSv_BLL(getSVadd());
            }
            else
            {
                BLL_QLSV.Instance.EditSv_BLL(getSVadd());
            }
            Form1 f1 = new Form1();
            f1.Show();
            this.Dispose();
        }
        private void setcbbform2()
        {
            cbbLopSHCHitiet.Items.AddRange(BLL_QLSV.Instance.getCBBItems().ToArray());
            cbbLopSHCHitiet.SelectedIndex = 0;
        }
        private void btCancel_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            Sender("");
            this.Dispose();
        }

        private void Form2_Load_1(object sender, EventArgs e)
        {
            if (mssv != "")
            {
                setSV();
                txtmssv.Enabled = false;

            }
        }
    }
}


namespace _16_4_2021sqlcc
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btsearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.combolopSH = new System.Windows.Forms.ComboBox();
            this.lblopsh = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btsort = new System.Windows.Forms.Button();
            this.btDel = new System.Windows.Forms.Button();
            this.cbbsort = new System.Windows.Forms.ComboBox();
            this.btEdit = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.datagridsv = new System.Windows.Forms.DataGridView();
            this.btshow = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridsv)).BeginInit();
            this.SuspendLayout();
            // 
            // btsearch
            // 
            this.btsearch.Location = new System.Drawing.Point(510, 24);
            this.btsearch.Name = "btsearch";
            this.btsearch.Size = new System.Drawing.Size(75, 23);
            this.btsearch.TabIndex = 20;
            this.btsearch.Text = "Search";
            this.btsearch.UseVisualStyleBackColor = true;
            this.btsearch.Click += new System.EventHandler(this.btsearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(386, 27);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 20);
            this.txtSearch.TabIndex = 19;
            // 
            // combolopSH
            // 
            this.combolopSH.FormattingEnabled = true;
            this.combolopSH.Location = new System.Drawing.Point(126, 25);
            this.combolopSH.Name = "combolopSH";
            this.combolopSH.Size = new System.Drawing.Size(121, 21);
            this.combolopSH.TabIndex = 18;
            // 
            // lblopsh
            // 
            this.lblopsh.AutoSize = true;
            this.lblopsh.Location = new System.Drawing.Point(55, 33);
            this.lblopsh.Name = "lblopsh";
            this.lblopsh.Size = new System.Drawing.Size(43, 13);
            this.lblopsh.TabIndex = 17;
            this.lblopsh.Text = "Lớp SH";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btsort);
            this.groupBox1.Controls.Add(this.btDel);
            this.groupBox1.Controls.Add(this.cbbsort);
            this.groupBox1.Controls.Add(this.btEdit);
            this.groupBox1.Controls.Add(this.btAdd);
            this.groupBox1.Controls.Add(this.datagridsv);
            this.groupBox1.Controls.Add(this.btshow);
            this.groupBox1.Location = new System.Drawing.Point(44, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(643, 259);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sinh viên";
            // 
            // btsort
            // 
            this.btsort.Location = new System.Drawing.Point(369, 209);
            this.btsort.Name = "btsort";
            this.btsort.Size = new System.Drawing.Size(75, 23);
            this.btsort.TabIndex = 6;
            this.btsort.Text = "Sort";
            this.btsort.UseVisualStyleBackColor = true;
            this.btsort.Click += new System.EventHandler(this.btsort_Click);
            // 
            // btDel
            // 
            this.btDel.Location = new System.Drawing.Point(278, 209);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(84, 23);
            this.btDel.TabIndex = 6;
            this.btDel.Text = "Del";
            this.btDel.UseVisualStyleBackColor = true;
            this.btDel.Click += new System.EventHandler(this.btDel_Click);
            // 
            // cbbsort
            // 
            this.cbbsort.FormattingEnabled = true;
            this.cbbsort.Location = new System.Drawing.Point(468, 211);
            this.cbbsort.Name = "cbbsort";
            this.cbbsort.Size = new System.Drawing.Size(149, 21);
            this.cbbsort.TabIndex = 2;
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(187, 209);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(85, 23);
            this.btEdit.TabIndex = 6;
            this.btEdit.Text = "Edit";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(95, 209);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(86, 23);
            this.btAdd.TabIndex = 6;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // datagridsv
            // 
            this.datagridsv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridsv.Location = new System.Drawing.Point(14, 19);
            this.datagridsv.Name = "datagridsv";
            this.datagridsv.Size = new System.Drawing.Size(603, 160);
            this.datagridsv.TabIndex = 0;
            // 
            // btshow
            // 
            this.btshow.Location = new System.Drawing.Point(14, 209);
            this.btshow.Name = "btshow";
            this.btshow.Size = new System.Drawing.Size(75, 23);
            this.btshow.TabIndex = 6;
            this.btshow.Text = "Show";
            this.btshow.UseVisualStyleBackColor = true;
            this.btshow.Click += new System.EventHandler(this.btshow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 353);
            this.Controls.Add(this.btsearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.combolopSH);
            this.Controls.Add(this.lblopsh);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagridsv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btsearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox combolopSH;
        private System.Windows.Forms.Label lblopsh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btsort;
        private System.Windows.Forms.Button btDel;
        private System.Windows.Forms.ComboBox cbbsort;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.DataGridView datagridsv;
        private System.Windows.Forms.Button btshow;
    }
}


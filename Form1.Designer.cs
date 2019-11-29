namespace SpliteHelper
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDownload = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCsv = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnDatabase = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sd1 = new System.Windows.Forms.Label();
            this.maxText = new System.Windows.Forms.Label();
            this.minText = new System.Windows.Forms.Label();
            this.btnCount = new System.Windows.Forms.Button();
            this.sd2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.sd3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.sd4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.sd5 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.sd6 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.row = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 21);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(985, 489);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // btnDownload
            // 
            this.btnDownload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnDownload.Location = new System.Drawing.Point(822, 590);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(175, 28);
            this.btnDownload.TabIndex = 1;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnDelete.Location = new System.Drawing.Point(612, 590);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(175, 28);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnEdit.Location = new System.Drawing.Point(402, 590);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(175, 28);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnCsv
            // 
            this.btnCsv.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnCsv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCsv.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnCsv.Location = new System.Drawing.Point(822, 652);
            this.btnCsv.Name = "btnCsv";
            this.btnCsv.Size = new System.Drawing.Size(175, 28);
            this.btnCsv.TabIndex = 4;
            this.btnCsv.Text = "Open CSV";
            this.btnCsv.UseVisualStyleBackColor = false;
            this.btnCsv.Click += new System.EventHandler(this.btnCsv_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnInsert.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnInsert.Location = new System.Drawing.Point(612, 652);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(175, 28);
            this.btnInsert.TabIndex = 5;
            this.btnInsert.Text = "Insert To Database";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnDatabase
            // 
            this.btnDatabase.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnDatabase.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnDatabase.Location = new System.Drawing.Point(402, 652);
            this.btnDatabase.Name = "btnDatabase";
            this.btnDatabase.Size = new System.Drawing.Size(175, 28);
            this.btnDatabase.TabIndex = 6;
            this.btnDatabase.Text = "Go To Database";
            this.btnDatabase.UseVisualStyleBackColor = false;
            this.btnDatabase.Click += new System.EventHandler(this.btnDatabase_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(14, 590);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(252, 28);
            this.comboBox1.TabIndex = 7;
            // 
            // txtTo
            // 
            this.txtTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTo.Location = new System.Drawing.Point(152, 654);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(114, 26);
            this.txtTo.TabIndex = 9;
            // 
            // txtFrom
            // 
            this.txtFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtFrom.Location = new System.Drawing.Point(14, 653);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(114, 26);
            this.txtFrom.TabIndex = 10;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSearch.Location = new System.Drawing.Point(284, 589);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 91);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 526);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Row Count :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(166, 526);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "第1段溫度 SD :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(728, 526);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Maximum :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(728, 554);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Minmum :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(240, 526);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 20;
            // 
            // sd1
            // 
            this.sd1.AutoSize = true;
            this.sd1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.sd1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.sd1.Location = new System.Drawing.Point(289, 526);
            this.sd1.Name = "sd1";
            this.sd1.Size = new System.Drawing.Size(18, 20);
            this.sd1.TabIndex = 22;
            this.sd1.Text = "_";
            // 
            // maxText
            // 
            this.maxText.AutoSize = true;
            this.maxText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.maxText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.maxText.Location = new System.Drawing.Point(818, 526);
            this.maxText.Name = "maxText";
            this.maxText.Size = new System.Drawing.Size(18, 20);
            this.maxText.TabIndex = 23;
            this.maxText.Text = "_";
            // 
            // minText
            // 
            this.minText.AutoSize = true;
            this.minText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.minText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.minText.Location = new System.Drawing.Point(818, 554);
            this.minText.Name = "minText";
            this.minText.Size = new System.Drawing.Size(18, 20);
            this.minText.TabIndex = 24;
            this.minText.Text = "_";
            // 
            // btnCount
            // 
            this.btnCount.BackColor = System.Drawing.Color.LightBlue;
            this.btnCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCount.Location = new System.Drawing.Point(904, 526);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(93, 28);
            this.btnCount.TabIndex = 25;
            this.btnCount.Text = "Count";
            this.btnCount.UseVisualStyleBackColor = false;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click_1);
            // 
            // sd2
            // 
            this.sd2.AutoSize = true;
            this.sd2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.sd2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.sd2.Location = new System.Drawing.Point(470, 526);
            this.sd2.Name = "sd2";
            this.sd2.Size = new System.Drawing.Size(18, 20);
            this.sd2.TabIndex = 27;
            this.sd2.Text = "_";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(347, 526);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "第2段溫度 SD :";
            // 
            // sd3
            // 
            this.sd3.AutoSize = true;
            this.sd3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.sd3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.sd3.Location = new System.Drawing.Point(661, 526);
            this.sd3.Name = "sd3";
            this.sd3.Size = new System.Drawing.Size(18, 20);
            this.sd3.TabIndex = 29;
            this.sd3.Text = "_";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(538, 526);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 20);
            this.label9.TabIndex = 28;
            this.label9.Text = "第3段溫度 SD :";
            // 
            // sd4
            // 
            this.sd4.AutoSize = true;
            this.sd4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.sd4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.sd4.Location = new System.Drawing.Point(288, 558);
            this.sd4.Name = "sd4";
            this.sd4.Size = new System.Drawing.Size(18, 20);
            this.sd4.TabIndex = 31;
            this.sd4.Text = "_";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label11.Location = new System.Drawing.Point(165, 558);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 20);
            this.label11.TabIndex = 30;
            this.label11.Text = "第4段溫度 SD :";
            // 
            // sd5
            // 
            this.sd5.AutoSize = true;
            this.sd5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.sd5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.sd5.Location = new System.Drawing.Point(470, 558);
            this.sd5.Name = "sd5";
            this.sd5.Size = new System.Drawing.Size(18, 20);
            this.sd5.TabIndex = 33;
            this.sd5.Text = "_";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label13.Location = new System.Drawing.Point(347, 558);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(117, 20);
            this.label13.TabIndex = 32;
            this.label13.Text = "第5段溫度 SD :";
            // 
            // sd6
            // 
            this.sd6.AutoSize = true;
            this.sd6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.sd6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.sd6.Location = new System.Drawing.Point(661, 558);
            this.sd6.Name = "sd6";
            this.sd6.Size = new System.Drawing.Size(18, 20);
            this.sd6.TabIndex = 35;
            this.sd6.Text = "_";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label15.Location = new System.Drawing.Point(538, 558);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(117, 20);
            this.label15.TabIndex = 34;
            this.label15.Text = "第6段溫度 SD :";
            // 
            // row
            // 
            this.row.AutoSize = true;
            this.row.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.row.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.row.Location = new System.Drawing.Point(114, 526);
            this.row.Name = "row";
            this.row.Size = new System.Drawing.Size(18, 20);
            this.row.TabIndex = 36;
            this.row.Text = "_";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1009, 703);
            this.Controls.Add(this.row);
            this.Controls.Add(this.sd6);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.sd5);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.sd4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.sd3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.sd2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.minText);
            this.Controls.Add(this.maxText);
            this.Controls.Add(this.sd1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnDatabase);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnCsv);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCsv;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnDatabase;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private string rowCount;
        private System.Windows.Forms.Label sd1;
        private System.Windows.Forms.Label maxText;
        private System.Windows.Forms.Label minText;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Label sd2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label sd3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label sd4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label sd5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label sd6;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label row;
    }
}


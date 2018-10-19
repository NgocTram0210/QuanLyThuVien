namespace QL_ThuVien
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvShow = new System.Windows.Forms.DataGridView();
            this.dtNgaymuon = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxDG = new System.Windows.Forms.ComboBox();
            this.cbxSach = new System.Windows.Forms.ComboBox();
            this.btThoat = new System.Windows.Forms.Button();
            this.btMuon = new System.Windows.Forms.Button();
            this.cbxPML = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvLapPM = new System.Windows.Forms.DataGridView();
            this.btLapPM = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btReset = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cbxPMS = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btTraSach = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLapPM)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(236, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 40);
            this.label1.TabIndex = 47;
            this.label1.Text = "Phiếu Mượn Sách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 19);
            this.label2.TabIndex = 48;
            this.label2.Text = "ĐG Mượn:";
            // 
            // dgvShow
            // 
            this.dgvShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShow.Location = new System.Drawing.Point(239, 31);
            this.dgvShow.Name = "dgvShow";
            this.dgvShow.Size = new System.Drawing.Size(543, 125);
            this.dgvShow.TabIndex = 52;
            this.dgvShow.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvShow_MouseClick_1);
            // 
            // dtNgaymuon
            // 
            this.dtNgaymuon.Location = new System.Drawing.Point(362, 221);
            this.dtNgaymuon.Name = "dtNgaymuon";
            this.dtNgaymuon.Size = new System.Drawing.Size(119, 20);
            this.dtNgaymuon.TabIndex = 64;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(269, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 19);
            this.label5.TabIndex = 63;
            this.label5.Text = "Ngày Mượn:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 19);
            this.label4.TabIndex = 65;
            this.label4.Text = "Sách Mượn:";
            // 
            // cbxDG
            // 
            this.cbxDG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDG.FormattingEnabled = true;
            this.cbxDG.Location = new System.Drawing.Point(106, 221);
            this.cbxDG.Name = "cbxDG";
            this.cbxDG.Size = new System.Drawing.Size(119, 21);
            this.cbxDG.TabIndex = 67;
            // 
            // cbxSach
            // 
            this.cbxSach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSach.FormattingEnabled = true;
            this.cbxSach.Location = new System.Drawing.Point(113, 81);
            this.cbxSach.Name = "cbxSach";
            this.cbxSach.Size = new System.Drawing.Size(108, 23);
            this.cbxSach.TabIndex = 68;
            // 
            // btThoat
            // 
            this.btThoat.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.Location = new System.Drawing.Point(623, 477);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(82, 45);
            this.btThoat.TabIndex = 71;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click_1);
            // 
            // btMuon
            // 
            this.btMuon.Location = new System.Drawing.Point(385, 162);
            this.btMuon.Name = "btMuon";
            this.btMuon.Size = new System.Drawing.Size(92, 36);
            this.btMuon.TabIndex = 69;
            this.btMuon.Text = "Cho Mượn Sách";
            this.btMuon.UseVisualStyleBackColor = true;
            this.btMuon.Click += new System.EventHandler(this.btMuon_Click_1);
            // 
            // cbxPML
            // 
            this.cbxPML.FormattingEnabled = true;
            this.cbxPML.Location = new System.Drawing.Point(102, 32);
            this.cbxPML.Name = "cbxPML";
            this.cbxPML.Size = new System.Drawing.Size(119, 23);
            this.cbxPML.TabIndex = 73;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 19);
            this.label6.TabIndex = 72;
            this.label6.Text = "Phiếu Mượn:";
            // 
            // dgvLapPM
            // 
            this.dgvLapPM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLapPM.Location = new System.Drawing.Point(239, 29);
            this.dgvLapPM.Name = "dgvLapPM";
            this.dgvLapPM.Size = new System.Drawing.Size(462, 96);
            this.dgvLapPM.TabIndex = 74;
            this.dgvLapPM.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvLapPM_MouseClick_1);
            // 
            // btLapPM
            // 
            this.btLapPM.Location = new System.Drawing.Point(716, 97);
            this.btLapPM.Name = "btLapPM";
            this.btLapPM.Size = new System.Drawing.Size(92, 28);
            this.btLapPM.TabIndex = 75;
            this.btLapPM.Text = "Lập Phiếu";
            this.btLapPM.UseVisualStyleBackColor = true;
            this.btLapPM.Click += new System.EventHandler(this.btLapPM_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btReset);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btLapPM);
            this.groupBox1.Controls.Add(this.dgvLapPM);
            this.groupBox1.Controls.Add(this.cbxPML);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(4, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(814, 140);
            this.groupBox1.TabIndex = 76;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tra Cứu Và Lập Phiếu Mượn";
            // 
            // btReset
            // 
            this.btReset.Location = new System.Drawing.Point(716, 64);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(92, 27);
            this.btReset.TabIndex = 77;
            this.btReset.Text = "Reset";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(716, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 27);
            this.button1.TabIndex = 76;
            this.button1.Text = "Tìm theo DG";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // cbxPMS
            // 
            this.cbxPMS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPMS.FormattingEnabled = true;
            this.cbxPMS.Location = new System.Drawing.Point(113, 42);
            this.cbxPMS.Name = "cbxPMS";
            this.cbxPMS.Size = new System.Drawing.Size(108, 23);
            this.cbxPMS.TabIndex = 78;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 19);
            this.label3.TabIndex = 77;
            this.label3.Text = "Phiếu Mượn:";
            // 
            // btTraSach
            // 
            this.btTraSach.Location = new System.Drawing.Point(515, 162);
            this.btTraSach.Name = "btTraSach";
            this.btTraSach.Size = new System.Drawing.Size(92, 36);
            this.btTraSach.TabIndex = 79;
            this.btTraSach.Text = "Trả Sách";
            this.btTraSach.UseVisualStyleBackColor = true;
            this.btTraSach.Click += new System.EventHandler(this.btTraSach_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btTraSach);
            this.groupBox2.Controls.Add(this.cbxPMS);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btMuon);
            this.groupBox2.Controls.Add(this.cbxSach);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dgvShow);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(4, 263);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(814, 208);
            this.groupBox2.TabIndex = 80;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mượn Và Trả Sách";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 534);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxDG);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtNgaymuon);
            this.Name = "Form2";
            this.Text = "PhieuMuonSaxh";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLapPM)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvShow;
        private System.Windows.Forms.DateTimePicker dtNgaymuon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxDG;
        private System.Windows.Forms.ComboBox cbxSach;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btMuon;
        private System.Windows.Forms.ComboBox cbxPML;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvLapPM;
        private System.Windows.Forms.Button btLapPM;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxPMS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btTraSach;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btReset;
    }
}
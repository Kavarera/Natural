
namespace Natural_1.Admin.UC
{
    partial class UC_Log
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.tglSelesaiDTP = new System.Windows.Forms.DateTimePicker();
            this.tglMulaiDTP = new System.Windows.Forms.DateTimePicker();
            this.modulTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cariBTN = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.logDGV = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.katakunciTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cetakBTN = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.operatorTB = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logDGV)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(55)))), ((int)(((byte)(63)))));
            this.panel1.Controls.Add(this.operatorTB);
            this.panel1.Controls.Add(this.tglSelesaiDTP);
            this.panel1.Controls.Add(this.tglMulaiDTP);
            this.panel1.Controls.Add(this.modulTB);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cariBTN);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1240, 133);
            this.panel1.TabIndex = 0;
            // 
            // tglSelesaiDTP
            // 
            this.tglSelesaiDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tglSelesaiDTP.Location = new System.Drawing.Point(467, 30);
            this.tglSelesaiDTP.Name = "tglSelesaiDTP";
            this.tglSelesaiDTP.Size = new System.Drawing.Size(138, 26);
            this.tglSelesaiDTP.TabIndex = 8;
            this.tglSelesaiDTP.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tglSelesaiDTP_KeyUp);
            // 
            // tglMulaiDTP
            // 
            this.tglMulaiDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tglMulaiDTP.Location = new System.Drawing.Point(155, 30);
            this.tglMulaiDTP.Name = "tglMulaiDTP";
            this.tglMulaiDTP.Size = new System.Drawing.Size(138, 26);
            this.tglMulaiDTP.TabIndex = 7;
            this.tglMulaiDTP.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tglMulaiDTP_KeyUp);
            // 
            // modulTB
            // 
            this.modulTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.modulTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.modulTB.Location = new System.Drawing.Point(723, 31);
            this.modulTB.Name = "modulTB";
            this.modulTB.Size = new System.Drawing.Size(172, 25);
            this.modulTB.TabIndex = 5;
            this.modulTB.KeyUp += new System.Windows.Forms.KeyEventHandler(this.modulTB_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(914, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Operator";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(624, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Modul";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(312, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tgl Selesai";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(23, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tgl Mulai";
            // 
            // cariBTN
            // 
            this.cariBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(87)))), ((int)(((byte)(228)))));
            this.cariBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cariBTN.FlatAppearance.BorderSize = 3;
            this.cariBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cariBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cariBTN.ForeColor = System.Drawing.Color.White;
            this.cariBTN.Location = new System.Drawing.Point(1039, 76);
            this.cariBTN.Name = "cariBTN";
            this.cariBTN.Size = new System.Drawing.Size(123, 44);
            this.cariBTN.TabIndex = 0;
            this.cariBTN.Text = "Cari";
            this.cariBTN.UseVisualStyleBackColor = false;
            this.cariBTN.Click += new System.EventHandler(this.cariBTN_Click);
            this.cariBTN.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cariBTN_KeyUp);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(55)))), ((int)(((byte)(63)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 133);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(81, 583);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(55)))), ((int)(((byte)(63)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1159, 133);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(81, 583);
            this.panel3.TabIndex = 2;
            // 
            // logDGV
            // 
            this.logDGV.AllowUserToAddRows = false;
            this.logDGV.AllowUserToDeleteRows = false;
            this.logDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.logDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.logDGV.Dock = System.Windows.Forms.DockStyle.Top;
            this.logDGV.Location = new System.Drawing.Point(81, 133);
            this.logDGV.Name = "logDGV";
            this.logDGV.ReadOnly = true;
            this.logDGV.RowHeadersWidth = 62;
            this.logDGV.RowTemplate.Height = 28;
            this.logDGV.Size = new System.Drawing.Size(1078, 362);
            this.logDGV.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.katakunciTB);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.cetakBTN);
            this.panel4.Controls.Add(this.button2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(81, 495);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1078, 123);
            this.panel4.TabIndex = 4;
            // 
            // katakunciTB
            // 
            this.katakunciTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.katakunciTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.katakunciTB.Location = new System.Drawing.Point(226, 45);
            this.katakunciTB.Name = "katakunciTB";
            this.katakunciTB.Size = new System.Drawing.Size(172, 25);
            this.katakunciTB.TabIndex = 6;
            this.katakunciTB.Enter += new System.EventHandler(this.katakunciTB_Enter);
            this.katakunciTB.KeyUp += new System.Windows.Forms.KeyEventHandler(this.katakunciTB_KeyUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(29, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 29);
            this.label5.TabIndex = 3;
            this.label5.Text = "Cari Kata Kunci";
            // 
            // cetakBTN
            // 
            this.cetakBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cetakBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(151)))), ((int)(((byte)(251)))));
            this.cetakBTN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(87)))), ((int)(((byte)(228)))));
            this.cetakBTN.FlatAppearance.BorderSize = 3;
            this.cetakBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(87)))), ((int)(((byte)(228)))));
            this.cetakBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cetakBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cetakBTN.ForeColor = System.Drawing.Color.White;
            this.cetakBTN.Location = new System.Drawing.Point(912, 26);
            this.cetakBTN.Name = "cetakBTN";
            this.cetakBTN.Size = new System.Drawing.Size(123, 44);
            this.cetakBTN.TabIndex = 2;
            this.cetakBTN.Text = "Cetak";
            this.cetakBTN.UseVisualStyleBackColor = false;
            this.cetakBTN.Click += new System.EventHandler(this.cetakBTN_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(151)))), ((int)(((byte)(24)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(255)))), ((int)(((byte)(63)))));
            this.button2.FlatAppearance.BorderSize = 3;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(174)))), ((int)(((byte)(63)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(746, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 44);
            this.button2.TabIndex = 1;
            this.button2.Text = "Baru";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // operatorTB
            // 
            this.operatorTB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.operatorTB.FormattingEnabled = true;
            this.operatorTB.Location = new System.Drawing.Point(1039, 28);
            this.operatorTB.Name = "operatorTB";
            this.operatorTB.Size = new System.Drawing.Size(172, 28);
            this.operatorTB.TabIndex = 9;
            // 
            // UC_Log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(55)))), ((int)(((byte)(63)))));
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.logDGV);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UC_Log";
            this.Size = new System.Drawing.Size(1240, 716);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logDGV)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cariBTN;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker tglSelesaiDTP;
        private System.Windows.Forms.DateTimePicker tglMulaiDTP;
        private System.Windows.Forms.TextBox modulTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView logDGV;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button cetakBTN;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox katakunciTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox operatorTB;
    }
}

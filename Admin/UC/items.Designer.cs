﻿
namespace Natural_1.Admin.UC
{
    partial class items
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
            this.simpanBTN = new System.Windows.Forms.Button();
            this.baruBTN = new System.Windows.Forms.Button();
            this.statusTB = new System.Windows.Forms.TextBox();
            this.bonusTB = new System.Windows.Forms.TextBox();
            this.hargaTB = new System.Windows.Forms.TextBox();
            this.jumlahTB = new System.Windows.Forms.TextBox();
            this.namabarangTB = new System.Windows.Forms.TextBox();
            this.idTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.itemsDGV = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.aktifBTN = new System.Windows.Forms.Button();
            this.nonaktifBTN = new System.Windows.Forms.Button();
            this.cariTB = new System.Windows.Forms.TextBox();
            this.ubahBTN = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsDGV)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(192)))), ((int)(((byte)(140)))));
            this.panel1.Controls.Add(this.simpanBTN);
            this.panel1.Controls.Add(this.baruBTN);
            this.panel1.Controls.Add(this.statusTB);
            this.panel1.Controls.Add(this.bonusTB);
            this.panel1.Controls.Add(this.hargaTB);
            this.panel1.Controls.Add(this.jumlahTB);
            this.panel1.Controls.Add(this.namabarangTB);
            this.panel1.Controls.Add(this.idTB);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(674, 717);
            this.panel1.TabIndex = 0;
            // 
            // simpanBTN
            // 
            this.simpanBTN.Enabled = false;
            this.simpanBTN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(239)))));
            this.simpanBTN.FlatAppearance.BorderSize = 3;
            this.simpanBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(202)))), ((int)(((byte)(239)))));
            this.simpanBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.simpanBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.simpanBTN.Location = new System.Drawing.Point(507, 438);
            this.simpanBTN.Name = "simpanBTN";
            this.simpanBTN.Size = new System.Drawing.Size(124, 56);
            this.simpanBTN.TabIndex = 13;
            this.simpanBTN.Text = "Simpan";
            this.simpanBTN.UseVisualStyleBackColor = true;
            this.simpanBTN.Click += new System.EventHandler(this.simpanBTN_Click);
            // 
            // baruBTN
            // 
            this.baruBTN.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.baruBTN.FlatAppearance.BorderSize = 3;
            this.baruBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(90)))), ((int)(((byte)(60)))));
            this.baruBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.baruBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.baruBTN.ForeColor = System.Drawing.Color.White;
            this.baruBTN.Location = new System.Drawing.Point(364, 438);
            this.baruBTN.Name = "baruBTN";
            this.baruBTN.Size = new System.Drawing.Size(124, 56);
            this.baruBTN.TabIndex = 12;
            this.baruBTN.Text = "Baru";
            this.baruBTN.UseVisualStyleBackColor = true;
            this.baruBTN.Click += new System.EventHandler(this.baruBTN_Click);
            // 
            // statusTB
            // 
            this.statusTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.statusTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusTB.Location = new System.Drawing.Point(275, 369);
            this.statusTB.Name = "statusTB";
            this.statusTB.ReadOnly = true;
            this.statusTB.Size = new System.Drawing.Size(213, 28);
            this.statusTB.TabIndex = 11;
            this.statusTB.Text = "Active";
            // 
            // bonusTB
            // 
            this.bonusTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bonusTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bonusTB.Location = new System.Drawing.Point(275, 307);
            this.bonusTB.Name = "bonusTB";
            this.bonusTB.Size = new System.Drawing.Size(213, 28);
            this.bonusTB.TabIndex = 10;
            // 
            // hargaTB
            // 
            this.hargaTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hargaTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hargaTB.Location = new System.Drawing.Point(275, 245);
            this.hargaTB.Name = "hargaTB";
            this.hargaTB.Size = new System.Drawing.Size(213, 28);
            this.hargaTB.TabIndex = 9;
            // 
            // jumlahTB
            // 
            this.jumlahTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.jumlahTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jumlahTB.Location = new System.Drawing.Point(275, 183);
            this.jumlahTB.Name = "jumlahTB";
            this.jumlahTB.Size = new System.Drawing.Size(213, 28);
            this.jumlahTB.TabIndex = 8;
            // 
            // namabarangTB
            // 
            this.namabarangTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.namabarangTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namabarangTB.Location = new System.Drawing.Point(275, 121);
            this.namabarangTB.Name = "namabarangTB";
            this.namabarangTB.Size = new System.Drawing.Size(213, 28);
            this.namabarangTB.TabIndex = 7;
            // 
            // idTB
            // 
            this.idTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.idTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTB.Location = new System.Drawing.Point(275, 59);
            this.idTB.Name = "idTB";
            this.idTB.ReadOnly = true;
            this.idTB.Size = new System.Drawing.Size(213, 28);
            this.idTB.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(149, 368);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 29);
            this.label6.TabIndex = 5;
            this.label6.Text = "Status :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(105, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Bonus per :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(82, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Harga / PCS :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(138, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Jumlah :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(68, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama Barang :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(149, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "NO ID :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.itemsDGV);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(674, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(817, 717);
            this.panel2.TabIndex = 1;
            // 
            // itemsDGV
            // 
            this.itemsDGV.AllowUserToAddRows = false;
            this.itemsDGV.AllowUserToDeleteRows = false;
            this.itemsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemsDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemsDGV.Location = new System.Drawing.Point(124, 94);
            this.itemsDGV.MultiSelect = false;
            this.itemsDGV.Name = "itemsDGV";
            this.itemsDGV.ReadOnly = true;
            this.itemsDGV.RowHeadersWidth = 62;
            this.itemsDGV.RowTemplate.Height = 28;
            this.itemsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.itemsDGV.Size = new System.Drawing.Size(581, 344);
            this.itemsDGV.TabIndex = 5;
            this.itemsDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.itemsDGV_CellClick);
            this.itemsDGV.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.itemsDGV_RowHeaderMouseClick);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(192)))), ((int)(((byte)(140)))));
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(705, 94);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(112, 344);
            this.panel6.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(192)))), ((int)(((byte)(140)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 94);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(124, 344);
            this.panel5.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(192)))), ((int)(((byte)(140)))));
            this.panel4.Controls.Add(this.aktifBTN);
            this.panel4.Controls.Add(this.nonaktifBTN);
            this.panel4.Controls.Add(this.cariTB);
            this.panel4.Controls.Add(this.ubahBTN);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 438);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(817, 279);
            this.panel4.TabIndex = 2;
            // 
            // aktifBTN
            // 
            this.aktifBTN.Enabled = false;
            this.aktifBTN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(231)))), ((int)(((byte)(140)))));
            this.aktifBTN.FlatAppearance.BorderSize = 3;
            this.aktifBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(140)))));
            this.aktifBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aktifBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.aktifBTN.Location = new System.Drawing.Point(681, 44);
            this.aktifBTN.Name = "aktifBTN";
            this.aktifBTN.Size = new System.Drawing.Size(124, 43);
            this.aktifBTN.TabIndex = 16;
            this.aktifBTN.Text = "Aktif";
            this.aktifBTN.UseVisualStyleBackColor = true;
            this.aktifBTN.Click += new System.EventHandler(this.aktifBTN_Click);
            // 
            // nonaktifBTN
            // 
            this.nonaktifBTN.Enabled = false;
            this.nonaktifBTN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nonaktifBTN.FlatAppearance.BorderSize = 3;
            this.nonaktifBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(88)))), ((int)(((byte)(68)))));
            this.nonaktifBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nonaktifBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.nonaktifBTN.Location = new System.Drawing.Point(535, 44);
            this.nonaktifBTN.Name = "nonaktifBTN";
            this.nonaktifBTN.Size = new System.Drawing.Size(124, 43);
            this.nonaktifBTN.TabIndex = 15;
            this.nonaktifBTN.Text = "Non-Aktif";
            this.nonaktifBTN.UseVisualStyleBackColor = true;
            this.nonaktifBTN.Click += new System.EventHandler(this.nonaktifBTN_Click);
            // 
            // cariTB
            // 
            this.cariTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cariTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cariTB.Location = new System.Drawing.Point(144, 51);
            this.cariTB.Name = "cariTB";
            this.cariTB.Size = new System.Drawing.Size(213, 28);
            this.cariTB.TabIndex = 14;
            this.cariTB.Enter += new System.EventHandler(this.cariTB_Enter);
            this.cariTB.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cariTB_KeyUp);
            // 
            // ubahBTN
            // 
            this.ubahBTN.Enabled = false;
            this.ubahBTN.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ubahBTN.FlatAppearance.BorderSize = 3;
            this.ubahBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(207)))), ((int)(((byte)(239)))));
            this.ubahBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ubahBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.ubahBTN.Location = new System.Drawing.Point(389, 44);
            this.ubahBTN.Name = "ubahBTN";
            this.ubahBTN.Size = new System.Drawing.Size(124, 43);
            this.ubahBTN.TabIndex = 14;
            this.ubahBTN.Text = "Ubah";
            this.ubahBTN.UseVisualStyleBackColor = true;
            this.ubahBTN.Click += new System.EventHandler(this.ubahBTN_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(41, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 29);
            this.label7.TabIndex = 6;
            this.label7.Text = "Cari";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(192)))), ((int)(((byte)(140)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(817, 94);
            this.panel3.TabIndex = 1;
            // 
            // items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "items";
            this.Size = new System.Drawing.Size(1491, 717);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.itemsDGV)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView itemsDGV;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox statusTB;
        private System.Windows.Forms.TextBox bonusTB;
        private System.Windows.Forms.TextBox hargaTB;
        private System.Windows.Forms.TextBox jumlahTB;
        private System.Windows.Forms.TextBox namabarangTB;
        private System.Windows.Forms.TextBox idTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button simpanBTN;
        private System.Windows.Forms.Button baruBTN;
        private System.Windows.Forms.Button aktifBTN;
        private System.Windows.Forms.Button nonaktifBTN;
        private System.Windows.Forms.TextBox cariTB;
        private System.Windows.Forms.Button ubahBTN;
        private System.Windows.Forms.Label label7;
    }
}


namespace Natural_1.Kasir
{
    partial class UC_Belanja
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Belanja));
            this.panel1 = new System.Windows.Forms.Panel();
            this.hapusBTN = new System.Windows.Forms.Button();
            this.baruBTN = new System.Windows.Forms.Button();
            this.beliBTN = new System.Windows.Forms.Button();
            this.ongkir_TB = new System.Windows.Forms.TextBox();
            this.cetakStrukBTN = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.struk_TB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BTN_tambah = new System.Windows.Forms.Button();
            this.TB_Jumlah = new System.Windows.Forms.TextBox();
            this.hargaSatuan_TB = new System.Windows.Forms.TextBox();
            this.CBX_Barang = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.belanja_DVG = new System.Windows.Forms.DataGridView();
            this.namaBarang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlah = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaSatuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalHarga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TB_NoDistr = new System.Windows.Forms.TextBox();
            this.TB_Jam = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_TglBeli = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_Kurir = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_Area = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_alamat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TB_NoTel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CBX_namaToko = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.belanja_DVG)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(181)))), ((int)(((byte)(101)))));
            this.panel1.Controls.Add(this.hapusBTN);
            this.panel1.Controls.Add(this.baruBTN);
            this.panel1.Controls.Add(this.beliBTN);
            this.panel1.Controls.Add(this.ongkir_TB);
            this.panel1.Controls.Add(this.cetakStrukBTN);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.struk_TB);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(523, 536);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(990, 100);
            this.panel1.TabIndex = 18;
            // 
            // hapusBTN
            // 
            this.hapusBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.hapusBTN.BackColor = System.Drawing.Color.White;
            this.hapusBTN.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.hapusBTN.FlatAppearance.BorderSize = 5;
            this.hapusBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.hapusBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hapusBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.hapusBTN.Location = new System.Drawing.Point(774, 53);
            this.hapusBTN.Name = "hapusBTN";
            this.hapusBTN.Size = new System.Drawing.Size(190, 43);
            this.hapusBTN.TabIndex = 22;
            this.hapusBTN.Text = "HAPUS BARANG";
            this.hapusBTN.UseVisualStyleBackColor = false;
            this.hapusBTN.Click += new System.EventHandler(this.hapusBTN_Click);
            // 
            // baruBTN
            // 
            this.baruBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.baruBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(130)))), ((int)(((byte)(73)))));
            this.baruBTN.Enabled = false;
            this.baruBTN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(130)))), ((int)(((byte)(73)))));
            this.baruBTN.FlatAppearance.BorderSize = 3;
            this.baruBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.baruBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.baruBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.baruBTN.Location = new System.Drawing.Point(490, 52);
            this.baruBTN.Name = "baruBTN";
            this.baruBTN.Size = new System.Drawing.Size(89, 35);
            this.baruBTN.TabIndex = 21;
            this.baruBTN.Text = "Baru";
            this.baruBTN.UseVisualStyleBackColor = false;
            this.baruBTN.Click += new System.EventHandler(this.baruBTN_Click);
            // 
            // beliBTN
            // 
            this.beliBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.beliBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(130)))), ((int)(((byte)(73)))));
            this.beliBTN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(130)))), ((int)(((byte)(73)))));
            this.beliBTN.FlatAppearance.BorderSize = 3;
            this.beliBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.beliBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.beliBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.beliBTN.Location = new System.Drawing.Point(387, 53);
            this.beliBTN.Name = "beliBTN";
            this.beliBTN.Size = new System.Drawing.Size(97, 34);
            this.beliBTN.TabIndex = 20;
            this.beliBTN.Text = "Beli";
            this.beliBTN.UseVisualStyleBackColor = false;
            this.beliBTN.Click += new System.EventHandler(this.beliBTN_Click);
            // 
            // ongkir_TB
            // 
            this.ongkir_TB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ongkir_TB.Enabled = false;
            this.ongkir_TB.Location = new System.Drawing.Point(659, 14);
            this.ongkir_TB.Name = "ongkir_TB";
            this.ongkir_TB.Size = new System.Drawing.Size(305, 26);
            this.ongkir_TB.TabIndex = 3;
            // 
            // cetakStrukBTN
            // 
            this.cetakStrukBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cetakStrukBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(130)))), ((int)(((byte)(73)))));
            this.cetakStrukBTN.Enabled = false;
            this.cetakStrukBTN.FlatAppearance.BorderSize = 0;
            this.cetakStrukBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.cetakStrukBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cetakStrukBTN.Location = new System.Drawing.Point(175, 59);
            this.cetakStrukBTN.Name = "cetakStrukBTN";
            this.cetakStrukBTN.Size = new System.Drawing.Size(135, 36);
            this.cetakStrukBTN.TabIndex = 19;
            this.cetakStrukBTN.Text = "Cetak Struk";
            this.cetakStrukBTN.UseVisualStyleBackColor = false;
            this.cetakStrukBTN.Click += new System.EventHandler(this.cetakStrukBTN_Click);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(567, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "Ongkir :";
            // 
            // struk_TB
            // 
            this.struk_TB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.struk_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.struk_TB.Location = new System.Drawing.Point(175, 17);
            this.struk_TB.Name = "struk_TB";
            this.struk_TB.ReadOnly = true;
            this.struk_TB.Size = new System.Drawing.Size(179, 30);
            this.struk_TB.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(90, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "No Struk :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(181)))), ((int)(((byte)(73)))));
            this.panel2.Controls.Add(this.BTN_tambah);
            this.panel2.Controls.Add(this.TB_Jumlah);
            this.panel2.Controls.Add(this.hargaSatuan_TB);
            this.panel2.Controls.Add(this.CBX_Barang);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(523, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(990, 99);
            this.panel2.TabIndex = 19;
            // 
            // BTN_tambah
            // 
            this.BTN_tambah.BackColor = System.Drawing.Color.White;
            this.BTN_tambah.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(130)))), ((int)(((byte)(73)))));
            this.BTN_tambah.FlatAppearance.BorderSize = 4;
            this.BTN_tambah.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.BTN_tambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_tambah.Location = new System.Drawing.Point(829, 44);
            this.BTN_tambah.Name = "BTN_tambah";
            this.BTN_tambah.Size = new System.Drawing.Size(109, 37);
            this.BTN_tambah.TabIndex = 6;
            this.BTN_tambah.Text = "Tambah";
            this.BTN_tambah.UseVisualStyleBackColor = false;
            this.BTN_tambah.Click += new System.EventHandler(this.BTN_tambah_Click);
            // 
            // TB_Jumlah
            // 
            this.TB_Jumlah.Location = new System.Drawing.Point(832, 12);
            this.TB_Jumlah.Name = "TB_Jumlah";
            this.TB_Jumlah.Size = new System.Drawing.Size(106, 26);
            this.TB_Jumlah.TabIndex = 5;
            // 
            // hargaSatuan_TB
            // 
            this.hargaSatuan_TB.Location = new System.Drawing.Point(470, 15);
            this.hargaSatuan_TB.Name = "hargaSatuan_TB";
            this.hargaSatuan_TB.Size = new System.Drawing.Size(134, 26);
            this.hargaSatuan_TB.TabIndex = 4;
            // 
            // CBX_Barang
            // 
            this.CBX_Barang.FormattingEnabled = true;
            this.CBX_Barang.Location = new System.Drawing.Point(131, 15);
            this.CBX_Barang.Name = "CBX_Barang";
            this.CBX_Barang.Size = new System.Drawing.Size(190, 28);
            this.CBX_Barang.TabIndex = 3;
            this.CBX_Barang.SelectedIndexChanged += new System.EventHandler(this.CBX_Barang_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(766, 15);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 20);
            this.label13.TabIndex = 2;
            this.label13.Text = "Jumlah";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(355, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(109, 20);
            this.label12.TabIndex = 1;
            this.label12.Text = "Harga Satuan";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(64, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Barang";
            // 
            // belanja_DVG
            // 
            this.belanja_DVG.AllowUserToAddRows = false;
            this.belanja_DVG.AllowUserToDeleteRows = false;
            this.belanja_DVG.BackgroundColor = System.Drawing.Color.White;
            this.belanja_DVG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.belanja_DVG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.belanja_DVG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.belanja_DVG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.namaBarang,
            this.jumlah,
            this.satuan,
            this.hargaSatuan,
            this.totalHarga});
            this.belanja_DVG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.belanja_DVG.Location = new System.Drawing.Point(523, 99);
            this.belanja_DVG.Name = "belanja_DVG";
            this.belanja_DVG.ReadOnly = true;
            this.belanja_DVG.RowHeadersWidth = 62;
            this.belanja_DVG.RowTemplate.Height = 28;
            this.belanja_DVG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.belanja_DVG.Size = new System.Drawing.Size(990, 437);
            this.belanja_DVG.TabIndex = 20;
            // 
            // namaBarang
            // 
            this.namaBarang.HeaderText = "Nama Barang";
            this.namaBarang.MinimumWidth = 200;
            this.namaBarang.Name = "namaBarang";
            this.namaBarang.ReadOnly = true;
            this.namaBarang.Width = 250;
            // 
            // jumlah
            // 
            this.jumlah.HeaderText = "Jumlah";
            this.jumlah.MinimumWidth = 180;
            this.jumlah.Name = "jumlah";
            this.jumlah.ReadOnly = true;
            this.jumlah.Width = 240;
            // 
            // satuan
            // 
            this.satuan.HeaderText = "Satuan";
            this.satuan.MinimumWidth = 150;
            this.satuan.Name = "satuan";
            this.satuan.ReadOnly = true;
            this.satuan.Width = 150;
            // 
            // hargaSatuan
            // 
            this.hargaSatuan.HeaderText = "Harga Satuan";
            this.hargaSatuan.MinimumWidth = 180;
            this.hargaSatuan.Name = "hargaSatuan";
            this.hargaSatuan.ReadOnly = true;
            this.hargaSatuan.Width = 220;
            // 
            // totalHarga
            // 
            this.totalHarga.HeaderText = "Total Harga";
            this.totalHarga.MinimumWidth = 150;
            this.totalHarga.Name = "totalHarga";
            this.totalHarga.ReadOnly = true;
            this.totalHarga.Width = 180;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(181)))), ((int)(((byte)(73)))));
            this.groupBox1.Controls.Add(this.TB_NoDistr);
            this.groupBox1.Controls.Add(this.TB_Jam);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TB_TglBeli);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TB_Kurir);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TB_Area);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TB_alamat);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TB_NoTel);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.CBX_namaToko);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(523, 636);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // TB_NoDistr
            // 
            this.TB_NoDistr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TB_NoDistr.Location = new System.Drawing.Point(197, 99);
            this.TB_NoDistr.Name = "TB_NoDistr";
            this.TB_NoDistr.ReadOnly = true;
            this.TB_NoDistr.Size = new System.Drawing.Size(265, 35);
            this.TB_NoDistr.TabIndex = 8;
            // 
            // TB_Jam
            // 
            this.TB_Jam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TB_Jam.Location = new System.Drawing.Point(197, 416);
            this.TB_Jam.Name = "TB_Jam";
            this.TB_Jam.ReadOnly = true;
            this.TB_Jam.Size = new System.Drawing.Size(265, 35);
            this.TB_Jam.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(16, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "No Distributor :";
            // 
            // TB_TglBeli
            // 
            this.TB_TglBeli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TB_TglBeli.Location = new System.Drawing.Point(197, 372);
            this.TB_TglBeli.Name = "TB_TglBeli";
            this.TB_TglBeli.ReadOnly = true;
            this.TB_TglBeli.Size = new System.Drawing.Size(265, 35);
            this.TB_TglBeli.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(31, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama Toko :";
            // 
            // TB_Kurir
            // 
            this.TB_Kurir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TB_Kurir.Location = new System.Drawing.Point(197, 331);
            this.TB_Kurir.Name = "TB_Kurir";
            this.TB_Kurir.Size = new System.Drawing.Size(265, 35);
            this.TB_Kurir.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(31, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "No Telepon :";
            // 
            // TB_Area
            // 
            this.TB_Area.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TB_Area.Location = new System.Drawing.Point(197, 267);
            this.TB_Area.Name = "TB_Area";
            this.TB_Area.Size = new System.Drawing.Size(265, 35);
            this.TB_Area.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(72, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Alamat :";
            // 
            // TB_alamat
            // 
            this.TB_alamat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TB_alamat.Location = new System.Drawing.Point(197, 227);
            this.TB_alamat.Name = "TB_alamat";
            this.TB_alamat.Size = new System.Drawing.Size(265, 35);
            this.TB_alamat.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(91, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Area :";
            // 
            // TB_NoTel
            // 
            this.TB_NoTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TB_NoTel.Location = new System.Drawing.Point(197, 188);
            this.TB_NoTel.Name = "TB_NoTel";
            this.TB_NoTel.Size = new System.Drawing.Size(265, 35);
            this.TB_NoTel.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(35, 337);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Nama Kurir :";
            // 
            // CBX_namaToko
            // 
            this.CBX_namaToko.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBX_namaToko.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CBX_namaToko.FormattingEnabled = true;
            this.CBX_namaToko.Location = new System.Drawing.Point(197, 145);
            this.CBX_namaToko.Name = "CBX_namaToko";
            this.CBX_namaToko.Size = new System.Drawing.Size(265, 37);
            this.CBX_namaToko.Sorted = true;
            this.CBX_namaToko.TabIndex = 9;
            this.CBX_namaToko.SelectedIndexChanged += new System.EventHandler(this.CBX_namaToko_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(24, 378);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tanggal Beli :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(95, 416);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Jam :";
            // 
            // timer1
            // 
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // UC_Belanja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.belanja_DVG);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "UC_Belanja";
            this.Size = new System.Drawing.Size(1513, 636);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.belanja_DVG)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button hapusBTN;
        private System.Windows.Forms.Button baruBTN;
        private System.Windows.Forms.Button beliBTN;
        private System.Windows.Forms.TextBox ongkir_TB;
        private System.Windows.Forms.Button cetakStrukBTN;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox struk_TB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BTN_tambah;
        private System.Windows.Forms.TextBox TB_Jumlah;
        private System.Windows.Forms.TextBox hargaSatuan_TB;
        private System.Windows.Forms.ComboBox CBX_Barang;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView belanja_DVG;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TB_NoDistr;
        private System.Windows.Forms.TextBox TB_Jam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_TglBeli;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_Kurir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_Area;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TB_alamat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TB_NoTel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CBX_namaToko;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer timer1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaBarang;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlah;
        private System.Windows.Forms.DataGridViewTextBoxColumn satuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaSatuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalHarga;
    }
}

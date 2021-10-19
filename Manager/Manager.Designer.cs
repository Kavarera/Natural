
namespace Natural_1.Manager
{
    partial class Manager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manager));
            this.panel1 = new System.Windows.Forms.Panel();
            this.clsBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.satuanBTN = new System.Windows.Forms.Button();
            this.item_BTN = new System.Windows.Forms.Button();
            this.pllBTN = new System.Windows.Forms.Button();
            this.transaksiBTN = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(57)))), ((int)(((byte)(171)))));
            this.panel1.Controls.Add(this.clsBTN);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1214, 89);
            this.panel1.TabIndex = 0;
            // 
            // clsBTN
            // 
            this.clsBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clsBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.clsBTN.FlatAppearance.BorderSize = 0;
            this.clsBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clsBTN.Image = global::Natural_1.Properties.Resources.close;
            this.clsBTN.Location = new System.Drawing.Point(1082, 0);
            this.clsBTN.Name = "clsBTN";
            this.clsBTN.Size = new System.Drawing.Size(132, 89);
            this.clsBTN.TabIndex = 2;
            this.clsBTN.UseVisualStyleBackColor = true;
            this.clsBTN.Click += new System.EventHandler(this.clsBTN_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(251, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(737, 79);
            this.label1.TabIndex = 1;
            this.label1.Text = "NATURAL MANAGER";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::Natural_1.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.satuanBTN);
            this.panel2.Controls.Add(this.item_BTN);
            this.panel2.Controls.Add(this.pllBTN);
            this.panel2.Controls.Add(this.transaksiBTN);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 89);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1214, 89);
            this.panel2.TabIndex = 1;
            // 
            // satuanBTN
            // 
            this.satuanBTN.BackColor = System.Drawing.Color.White;
            this.satuanBTN.Dock = System.Windows.Forms.DockStyle.Left;
            this.satuanBTN.FlatAppearance.BorderSize = 0;
            this.satuanBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.satuanBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.satuanBTN.Location = new System.Drawing.Point(492, 0);
            this.satuanBTN.Name = "satuanBTN";
            this.satuanBTN.Size = new System.Drawing.Size(164, 89);
            this.satuanBTN.TabIndex = 5;
            this.satuanBTN.Text = "Satuan";
            this.satuanBTN.UseVisualStyleBackColor = false;
            this.satuanBTN.Click += new System.EventHandler(this.satuanBTN_Click);
            // 
            // item_BTN
            // 
            this.item_BTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.item_BTN.Dock = System.Windows.Forms.DockStyle.Left;
            this.item_BTN.FlatAppearance.BorderSize = 0;
            this.item_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.item_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.item_BTN.Location = new System.Drawing.Point(328, 0);
            this.item_BTN.Margin = new System.Windows.Forms.Padding(20, 3, 25, 3);
            this.item_BTN.Name = "item_BTN";
            this.item_BTN.Size = new System.Drawing.Size(164, 89);
            this.item_BTN.TabIndex = 4;
            this.item_BTN.Text = "Item";
            this.item_BTN.UseVisualStyleBackColor = true;
            this.item_BTN.Click += new System.EventHandler(this.item_BTN_Click);
            // 
            // pllBTN
            // 
            this.pllBTN.BackColor = System.Drawing.Color.White;
            this.pllBTN.Dock = System.Windows.Forms.DockStyle.Left;
            this.pllBTN.FlatAppearance.BorderSize = 0;
            this.pllBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pllBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.pllBTN.Location = new System.Drawing.Point(164, 0);
            this.pllBTN.Name = "pllBTN";
            this.pllBTN.Size = new System.Drawing.Size(164, 89);
            this.pllBTN.TabIndex = 1;
            this.pllBTN.Text = "Pengeluaran Lain Lain";
            this.pllBTN.UseVisualStyleBackColor = false;
            this.pllBTN.Click += new System.EventHandler(this.pllBTN_Click);
            // 
            // transaksiBTN
            // 
            this.transaksiBTN.BackColor = System.Drawing.Color.White;
            this.transaksiBTN.Dock = System.Windows.Forms.DockStyle.Left;
            this.transaksiBTN.FlatAppearance.BorderSize = 0;
            this.transaksiBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transaksiBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.transaksiBTN.Location = new System.Drawing.Point(0, 0);
            this.transaksiBTN.Name = "transaksiBTN";
            this.transaksiBTN.Size = new System.Drawing.Size(164, 89);
            this.transaksiBTN.TabIndex = 0;
            this.transaksiBTN.Text = "Transaksi";
            this.transaksiBTN.UseVisualStyleBackColor = false;
            this.transaksiBTN.Click += new System.EventHandler(this.transaksiBTN_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 178);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1214, 472);
            this.panelContainer.TabIndex = 2;
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 650);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Manager";
            this.Text = "Manager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button clsBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Button pllBTN;
        private System.Windows.Forms.Button transaksiBTN;
        private System.Windows.Forms.Button item_BTN;
        private System.Windows.Forms.Button satuanBTN;
    }
}

namespace Natural_1.Admin
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.close_BTN = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.log_BTN = new System.Windows.Forms.Button();
            this.distributor_BTN = new System.Windows.Forms.Button();
            this.pelanggan_BTN = new System.Windows.Forms.Button();
            this.user_BTN = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(73)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.close_BTN);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1260, 78);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(979, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Admin";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(480, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 55);
            this.label1.TabIndex = 2;
            this.label1.Text = "NATURAL";
            // 
            // close_BTN
            // 
            this.close_BTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_BTN.Dock = System.Windows.Forms.DockStyle.Right;
            this.close_BTN.FlatAppearance.BorderSize = 0;
            this.close_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_BTN.Image = global::Natural_1.Properties.Resources.close;
            this.close_BTN.Location = new System.Drawing.Point(1149, 0);
            this.close_BTN.Name = "close_BTN";
            this.close_BTN.Size = new System.Drawing.Size(111, 78);
            this.close_BTN.TabIndex = 1;
            this.close_BTN.UseVisualStyleBackColor = true;
            this.close_BTN.Click += new System.EventHandler(this.close_BTN_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::Natural_1.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.log_BTN);
            this.panel2.Controls.Add(this.distributor_BTN);
            this.panel2.Controls.Add(this.pelanggan_BTN);
            this.panel2.Controls.Add(this.user_BTN);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1260, 71);
            this.panel2.TabIndex = 1;
            // 
            // log_BTN
            // 
            this.log_BTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.log_BTN.Dock = System.Windows.Forms.DockStyle.Left;
            this.log_BTN.FlatAppearance.BorderSize = 0;
            this.log_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.log_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.log_BTN.Location = new System.Drawing.Point(408, 0);
            this.log_BTN.Margin = new System.Windows.Forms.Padding(20, 3, 25, 3);
            this.log_BTN.Name = "log_BTN";
            this.log_BTN.Size = new System.Drawing.Size(136, 71);
            this.log_BTN.TabIndex = 4;
            this.log_BTN.Text = "Log";
            this.log_BTN.UseVisualStyleBackColor = true;
            this.log_BTN.Click += new System.EventHandler(this.log_BTN_Click);
            // 
            // distributor_BTN
            // 
            this.distributor_BTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.distributor_BTN.Dock = System.Windows.Forms.DockStyle.Left;
            this.distributor_BTN.FlatAppearance.BorderSize = 0;
            this.distributor_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.distributor_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.distributor_BTN.Location = new System.Drawing.Point(272, 0);
            this.distributor_BTN.Margin = new System.Windows.Forms.Padding(20, 3, 25, 3);
            this.distributor_BTN.Name = "distributor_BTN";
            this.distributor_BTN.Size = new System.Drawing.Size(136, 71);
            this.distributor_BTN.TabIndex = 2;
            this.distributor_BTN.Text = "Distributor";
            this.distributor_BTN.UseVisualStyleBackColor = true;
            this.distributor_BTN.Click += new System.EventHandler(this.distributor_BTN_Click);
            // 
            // pelanggan_BTN
            // 
            this.pelanggan_BTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pelanggan_BTN.Dock = System.Windows.Forms.DockStyle.Left;
            this.pelanggan_BTN.FlatAppearance.BorderSize = 0;
            this.pelanggan_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pelanggan_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.pelanggan_BTN.Location = new System.Drawing.Point(136, 0);
            this.pelanggan_BTN.Margin = new System.Windows.Forms.Padding(20, 3, 25, 3);
            this.pelanggan_BTN.Name = "pelanggan_BTN";
            this.pelanggan_BTN.Padding = new System.Windows.Forms.Padding(10);
            this.pelanggan_BTN.Size = new System.Drawing.Size(136, 71);
            this.pelanggan_BTN.TabIndex = 1;
            this.pelanggan_BTN.Text = "Pelanggan";
            this.pelanggan_BTN.UseVisualStyleBackColor = true;
            this.pelanggan_BTN.Click += new System.EventHandler(this.pelanggan_BTN_Click);
            // 
            // user_BTN
            // 
            this.user_BTN.BackColor = System.Drawing.Color.White;
            this.user_BTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.user_BTN.Dock = System.Windows.Forms.DockStyle.Left;
            this.user_BTN.FlatAppearance.BorderSize = 0;
            this.user_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.user_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_BTN.ForeColor = System.Drawing.Color.Black;
            this.user_BTN.Location = new System.Drawing.Point(0, 0);
            this.user_BTN.Margin = new System.Windows.Forms.Padding(20, 3, 25, 3);
            this.user_BTN.Name = "user_BTN";
            this.user_BTN.Size = new System.Drawing.Size(136, 71);
            this.user_BTN.TabIndex = 0;
            this.user_BTN.Text = "User";
            this.user_BTN.UseVisualStyleBackColor = false;
            this.user_BTN.Click += new System.EventHandler(this.user_BTN_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 149);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1260, 324);
            this.panelContainer.TabIndex = 2;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 473);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button close_BTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button log_BTN;
        private System.Windows.Forms.Button distributor_BTN;
        private System.Windows.Forms.Button pelanggan_BTN;
        private System.Windows.Forms.Button user_BTN;
        private System.Windows.Forms.Panel panelContainer;
    }
}
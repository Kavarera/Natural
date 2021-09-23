
namespace Natural_1.Kasir
{
    partial class KasirForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.close_BTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.belanja_BTN = new System.Windows.Forms.Button();
            this.kasir_BTN = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(73)))));
            this.panel1.Controls.Add(this.close_BTN);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1076, 74);
            this.panel1.TabIndex = 0;
            // 
            // close_BTN
            // 
            this.close_BTN.Dock = System.Windows.Forms.DockStyle.Right;
            this.close_BTN.FlatAppearance.BorderSize = 0;
            this.close_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_BTN.Image = global::Natural_1.Properties.Resources.close;
            this.close_BTN.Location = new System.Drawing.Point(991, 0);
            this.close_BTN.Name = "close_BTN";
            this.close_BTN.Size = new System.Drawing.Size(85, 74);
            this.close_BTN.TabIndex = 4;
            this.close_BTN.UseVisualStyleBackColor = true;
            this.close_BTN.Click += new System.EventHandler(this.close_BTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(478, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 55);
            this.label1.TabIndex = 3;
            this.label1.Text = "Natural";
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(131, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(347, 74);
            this.panel3.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::Natural_1.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.belanja_BTN);
            this.panel2.Controls.Add(this.kasir_BTN);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1076, 65);
            this.panel2.TabIndex = 1;
            // 
            // belanja_BTN
            // 
            this.belanja_BTN.Dock = System.Windows.Forms.DockStyle.Left;
            this.belanja_BTN.FlatAppearance.BorderSize = 0;
            this.belanja_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.belanja_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.belanja_BTN.Location = new System.Drawing.Point(131, 0);
            this.belanja_BTN.Name = "belanja_BTN";
            this.belanja_BTN.Size = new System.Drawing.Size(152, 65);
            this.belanja_BTN.TabIndex = 1;
            this.belanja_BTN.Text = "Belanja";
            this.belanja_BTN.UseVisualStyleBackColor = true;
            this.belanja_BTN.Click += new System.EventHandler(this.belanja_BTN_Click);
            // 
            // kasir_BTN
            // 
            this.kasir_BTN.Dock = System.Windows.Forms.DockStyle.Left;
            this.kasir_BTN.FlatAppearance.BorderSize = 0;
            this.kasir_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kasir_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kasir_BTN.Location = new System.Drawing.Point(0, 0);
            this.kasir_BTN.Name = "kasir_BTN";
            this.kasir_BTN.Size = new System.Drawing.Size(131, 65);
            this.kasir_BTN.TabIndex = 0;
            this.kasir_BTN.Text = "Kasir";
            this.kasir_BTN.UseVisualStyleBackColor = true;
            this.kasir_BTN.Click += new System.EventHandler(this.kasir_BTN_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 139);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1076, 467);
            this.panelContainer.TabIndex = 2;
            // 
            // KasirForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 606);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KasirForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Natural";
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button close_BTN;
        private System.Windows.Forms.Button belanja_BTN;
        private System.Windows.Forms.Button kasir_BTN;
        private System.Windows.Forms.Panel panelContainer;
    }
}
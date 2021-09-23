
namespace Natural_1.Setting
{
    partial class setting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(setting));
            this.server_TB = new System.Windows.Forms.TextBox();
            this.usernameSetting_TB = new System.Windows.Forms.TextBox();
            this.passwordSetting_TB = new System.Windows.Forms.TextBox();
            this.database_TB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Save_BTN = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // server_TB
            // 
            this.server_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.server_TB.Location = new System.Drawing.Point(228, 59);
            this.server_TB.Name = "server_TB";
            this.server_TB.Size = new System.Drawing.Size(270, 35);
            this.server_TB.TabIndex = 0;
            // 
            // usernameSetting_TB
            // 
            this.usernameSetting_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.usernameSetting_TB.Location = new System.Drawing.Point(228, 155);
            this.usernameSetting_TB.Name = "usernameSetting_TB";
            this.usernameSetting_TB.Size = new System.Drawing.Size(270, 35);
            this.usernameSetting_TB.TabIndex = 1;
            // 
            // passwordSetting_TB
            // 
            this.passwordSetting_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.passwordSetting_TB.Location = new System.Drawing.Point(228, 204);
            this.passwordSetting_TB.Name = "passwordSetting_TB";
            this.passwordSetting_TB.PasswordChar = '*';
            this.passwordSetting_TB.Size = new System.Drawing.Size(270, 35);
            this.passwordSetting_TB.TabIndex = 2;
            // 
            // database_TB
            // 
            this.database_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.database_TB.Location = new System.Drawing.Point(228, 106);
            this.database_TB.Name = "database_TB";
            this.database_TB.Size = new System.Drawing.Size(270, 35);
            this.database_TB.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Database";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Server";
            // 
            // Save_BTN
            // 
            this.Save_BTN.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Save_BTN.FlatAppearance.BorderSize = 5;
            this.Save_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save_BTN.Location = new System.Drawing.Point(408, 256);
            this.Save_BTN.Name = "Save_BTN";
            this.Save_BTN.Size = new System.Drawing.Size(101, 44);
            this.Save_BTN.TabIndex = 8;
            this.Save_BTN.Text = "SAVE";
            this.Save_BTN.UseVisualStyleBackColor = true;
            this.Save_BTN.Click += new System.EventHandler(this.Save_BTN_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.BorderSize = 5;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(288, 256);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 44);
            this.button2.TabIndex = 9;
            this.button2.Text = "CANCEL";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(225)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(540, 312);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Save_BTN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.database_TB);
            this.Controls.Add(this.passwordSetting_TB);
            this.Controls.Add(this.usernameSetting_TB);
            this.Controls.Add(this.server_TB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "setting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "setting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox server_TB;
        private System.Windows.Forms.TextBox usernameSetting_TB;
        private System.Windows.Forms.TextBox passwordSetting_TB;
        private System.Windows.Forms.TextBox database_TB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Save_BTN;
        private System.Windows.Forms.Button button2;
    }
}
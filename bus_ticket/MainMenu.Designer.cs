namespace bus_ticket
{
    partial class MainMenu
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
            this.Guest_btn = new System.Windows.Forms.Button();
            this.RegUser_btn = new System.Windows.Forms.Button();
            this.Admin_btn = new System.Windows.Forms.Button();
            this.Exit_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(334, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "WELCOME";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Guest_btn
            // 
            this.Guest_btn.BackColor = System.Drawing.Color.SkyBlue;
            this.Guest_btn.ForeColor = System.Drawing.Color.Black;
            this.Guest_btn.Location = new System.Drawing.Point(316, 200);
            this.Guest_btn.Name = "Guest_btn";
            this.Guest_btn.Size = new System.Drawing.Size(171, 44);
            this.Guest_btn.TabIndex = 1;
            this.Guest_btn.Text = "GUEST USER\r\n";
            this.Guest_btn.UseVisualStyleBackColor = false;
            this.Guest_btn.Click += new System.EventHandler(this.Guest_btn_Click_1);
            // 
            // RegUser_btn
            // 
            this.RegUser_btn.BackColor = System.Drawing.Color.SkyBlue;
            this.RegUser_btn.ForeColor = System.Drawing.Color.Black;
            this.RegUser_btn.Location = new System.Drawing.Point(316, 280);
            this.RegUser_btn.Name = "RegUser_btn";
            this.RegUser_btn.Size = new System.Drawing.Size(171, 44);
            this.RegUser_btn.TabIndex = 2;
            this.RegUser_btn.Text = "REGISTERED USER\r\n";
            this.RegUser_btn.UseVisualStyleBackColor = false;
            this.RegUser_btn.Click += new System.EventHandler(this.registeruser_Click);
            // 
            // Admin_btn
            // 
            this.Admin_btn.BackColor = System.Drawing.Color.SkyBlue;
            this.Admin_btn.ForeColor = System.Drawing.Color.Black;
            this.Admin_btn.Location = new System.Drawing.Point(316, 362);
            this.Admin_btn.Name = "Admin_btn";
            this.Admin_btn.Size = new System.Drawing.Size(171, 44);
            this.Admin_btn.TabIndex = 3;
            this.Admin_btn.Text = "ADMIN\r\n";
            this.Admin_btn.UseVisualStyleBackColor = false;
            this.Admin_btn.Click += new System.EventHandler(this.Admin_btn_Click);
            // 
            // Exit_btn
            // 
            this.Exit_btn.BackColor = System.Drawing.Color.SkyBlue;
            this.Exit_btn.ForeColor = System.Drawing.Color.Black;
            this.Exit_btn.Location = new System.Drawing.Point(316, 445);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(171, 44);
            this.Exit_btn.TabIndex = 4;
            this.Exit_btn.Text = "EXIT";
            this.Exit_btn.UseVisualStyleBackColor = false;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(834, 540);
            this.Controls.Add(this.Exit_btn);
            this.Controls.Add(this.Admin_btn);
            this.Controls.Add(this.RegUser_btn);
            this.Controls.Add(this.Guest_btn);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Location = new System.Drawing.Point(100, 100);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MENU";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Guest_btn;
        private System.Windows.Forms.Button RegUser_btn;
        private System.Windows.Forms.Button Admin_btn;
        private System.Windows.Forms.Button Exit_btn;

    }
}


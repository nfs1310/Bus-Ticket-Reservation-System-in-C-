namespace bus_ticket
{
    partial class AdminPanel
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
            this.adnewfair_btn = new System.Windows.Forms.Button();
            this.adminlist_btn = new System.Windows.Forms.Button();
            this.logout_btn = new System.Windows.Forms.Button();
            this.userlist_btn = new System.Windows.Forms.Button();
            this.admin_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // adnewfair_btn
            // 
            this.adnewfair_btn.BackColor = System.Drawing.Color.SkyBlue;
            this.adnewfair_btn.ForeColor = System.Drawing.Color.Black;
            this.adnewfair_btn.Location = new System.Drawing.Point(192, 70);
            this.adnewfair_btn.Name = "adnewfair_btn";
            this.adnewfair_btn.Size = new System.Drawing.Size(114, 41);
            this.adnewfair_btn.TabIndex = 3;
            this.adnewfair_btn.Text = "ADD NEW FAIR";
            this.adnewfair_btn.UseVisualStyleBackColor = false;
            this.adnewfair_btn.Click += new System.EventHandler(this.adnewfair_btn_Click);
            // 
            // adminlist_btn
            // 
            this.adminlist_btn.BackColor = System.Drawing.Color.SkyBlue;
            this.adminlist_btn.ForeColor = System.Drawing.Color.Black;
            this.adminlist_btn.Location = new System.Drawing.Point(192, 146);
            this.adminlist_btn.Name = "adminlist_btn";
            this.adminlist_btn.Size = new System.Drawing.Size(114, 41);
            this.adminlist_btn.TabIndex = 4;
            this.adminlist_btn.Text = "ADMIN LIST";
            this.adminlist_btn.UseVisualStyleBackColor = false;
            this.adminlist_btn.Click += new System.EventHandler(this.adminlist_btn_Click);
            // 
            // logout_btn
            // 
            this.logout_btn.BackColor = System.Drawing.Color.SkyBlue;
            this.logout_btn.ForeColor = System.Drawing.Color.Black;
            this.logout_btn.Location = new System.Drawing.Point(192, 290);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(114, 41);
            this.logout_btn.TabIndex = 5;
            this.logout_btn.Text = "LOGOUT";
            this.logout_btn.UseVisualStyleBackColor = false;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // userlist_btn
            // 
            this.userlist_btn.BackColor = System.Drawing.Color.SkyBlue;
            this.userlist_btn.ForeColor = System.Drawing.Color.Black;
            this.userlist_btn.Location = new System.Drawing.Point(192, 222);
            this.userlist_btn.Name = "userlist_btn";
            this.userlist_btn.Size = new System.Drawing.Size(114, 41);
            this.userlist_btn.TabIndex = 6;
            this.userlist_btn.Text = "USER LIST";
            this.userlist_btn.UseVisualStyleBackColor = false;
            this.userlist_btn.Click += new System.EventHandler(this.userlist_btn_Click);
            // 
            // admin_lbl
            // 
            this.admin_lbl.AutoSize = true;
            this.admin_lbl.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_lbl.Location = new System.Drawing.Point(437, 9);
            this.admin_lbl.Name = "admin_lbl";
            this.admin_lbl.Size = new System.Drawing.Size(59, 17);
            this.admin_lbl.TabIndex = 9;
            this.admin_lbl.Text = "LOGGER";
            this.admin_lbl.Click += new System.EventHandler(this.admin_lbl_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 396);
            this.Controls.Add(this.admin_lbl);
            this.Controls.Add(this.userlist_btn);
            this.Controls.Add(this.logout_btn);
            this.Controls.Add(this.adminlist_btn);
            this.Controls.Add(this.adnewfair_btn);
            this.Name = "AdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPanel";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button adnewfair_btn;
        private System.Windows.Forms.Button adminlist_btn;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Button userlist_btn;
        private System.Windows.Forms.Label admin_lbl;
    }
}
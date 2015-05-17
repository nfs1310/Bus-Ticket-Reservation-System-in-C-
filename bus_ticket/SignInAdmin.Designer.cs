namespace bus_ticket
{
    partial class SignInAdmin
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
            this.cncl_btn = new System.Windows.Forms.Button();
            this.login_btn = new System.Windows.Forms.Button();
            this.password_txt = new System.Windows.Forms.TextBox();
            this.username_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cncl_btn
            // 
            this.cncl_btn.BackColor = System.Drawing.Color.SkyBlue;
            this.cncl_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cncl_btn.ForeColor = System.Drawing.Color.Black;
            this.cncl_btn.Location = new System.Drawing.Point(223, 234);
            this.cncl_btn.Name = "cncl_btn";
            this.cncl_btn.Size = new System.Drawing.Size(112, 39);
            this.cncl_btn.TabIndex = 21;
            this.cncl_btn.Text = "Cancel";
            this.cncl_btn.UseVisualStyleBackColor = false;
            this.cncl_btn.Click += new System.EventHandler(this.cncl_btn_Click);
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.SkyBlue;
            this.login_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.ForeColor = System.Drawing.Color.Black;
            this.login_btn.Location = new System.Drawing.Point(105, 234);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(112, 39);
            this.login_btn.TabIndex = 20;
            this.login_btn.Text = "Login";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // password_txt
            // 
            this.password_txt.Location = new System.Drawing.Point(151, 178);
            this.password_txt.Name = "password_txt";
            this.password_txt.Size = new System.Drawing.Size(226, 20);
            this.password_txt.TabIndex = 19;
            // 
            // username_txt
            // 
            this.username_txt.Location = new System.Drawing.Point(151, 130);
            this.username_txt.Name = "username_txt";
            this.username_txt.Size = new System.Drawing.Size(226, 20);
            this.username_txt.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(34, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 23);
            this.label5.TabIndex = 17;
            this.label5.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(32, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 23);
            this.label2.TabIndex = 16;
            this.label2.Text = "Username:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(175, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Sign In";
            // 
            // SignInAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 334);
            this.Controls.Add(this.cncl_btn);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.password_txt);
            this.Controls.Add(this.username_txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SignInAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign In Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cncl_btn;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.TextBox password_txt;
        private System.Windows.Forms.TextBox username_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
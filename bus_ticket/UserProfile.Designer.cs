namespace bus_ticket
{
    partial class UserProfile
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cncl_btn = new System.Windows.Forms.Button();
            this.load_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.email_txt = new System.Windows.Forms.TextBox();
            this.username_txt = new System.Windows.Forms.TextBox();
            this.pass_txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(105, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(136, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "E-mail:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cncl_btn
            // 
            this.cncl_btn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.cncl_btn.Location = new System.Drawing.Point(307, 360);
            this.cncl_btn.Name = "cncl_btn";
            this.cncl_btn.Size = new System.Drawing.Size(72, 32);
            this.cncl_btn.TabIndex = 74;
            this.cncl_btn.Text = "Cancel";
            this.cncl_btn.UseVisualStyleBackColor = false;
            this.cncl_btn.Click += new System.EventHandler(this.cncl_btn_Click);
            // 
            // load_btn
            // 
            this.load_btn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.load_btn.Location = new System.Drawing.Point(175, 360);
            this.load_btn.Name = "load_btn";
            this.load_btn.Size = new System.Drawing.Size(82, 32);
            this.load_btn.TabIndex = 75;
            this.load_btn.Text = "Load";
            this.load_btn.UseVisualStyleBackColor = false;
            this.load_btn.Click += new System.EventHandler(this.load_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(107, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 23);
            this.label4.TabIndex = 76;
            this.label4.Text = "Password:";
            // 
            // name_txt
            // 
            this.name_txt.Enabled = false;
            this.name_txt.Location = new System.Drawing.Point(220, 113);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(247, 20);
            this.name_txt.TabIndex = 77;
            this.name_txt.TextChanged += new System.EventHandler(this.name_txt_TextChanged);
            // 
            // email_txt
            // 
            this.email_txt.Enabled = false;
            this.email_txt.Location = new System.Drawing.Point(220, 174);
            this.email_txt.Name = "email_txt";
            this.email_txt.Size = new System.Drawing.Size(247, 20);
            this.email_txt.TabIndex = 78;
            // 
            // username_txt
            // 
            this.username_txt.Enabled = false;
            this.username_txt.Location = new System.Drawing.Point(220, 224);
            this.username_txt.Name = "username_txt";
            this.username_txt.Size = new System.Drawing.Size(247, 20);
            this.username_txt.TabIndex = 79;
            // 
            // pass_txt
            // 
            this.pass_txt.Enabled = false;
            this.pass_txt.Location = new System.Drawing.Point(220, 276);
            this.pass_txt.Name = "pass_txt";
            this.pass_txt.Size = new System.Drawing.Size(247, 20);
            this.pass_txt.TabIndex = 80;
            // 
            // UserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 423);
            this.Controls.Add(this.pass_txt);
            this.Controls.Add(this.username_txt);
            this.Controls.Add(this.email_txt);
            this.Controls.Add(this.name_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.load_btn);
            this.Controls.Add(this.cncl_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UserProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserProfile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cncl_btn;
        private System.Windows.Forms.Button load_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.TextBox email_txt;
        private System.Windows.Forms.TextBox username_txt;
        private System.Windows.Forms.TextBox pass_txt;
    }
}
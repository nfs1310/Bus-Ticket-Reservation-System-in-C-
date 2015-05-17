namespace bus_ticket
{
    partial class GuestMenu
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
            this.button1 = new System.Windows.Forms.Button();
            this.routedetail_btn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.mainmenu_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(224, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "GUEST USER";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SkyBlue;
            this.button1.Location = new System.Drawing.Point(208, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "CHECK FAIRLIST";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.checkfairlist_Click);
            // 
            // routedetail_btn
            // 
            this.routedetail_btn.BackColor = System.Drawing.Color.SkyBlue;
            this.routedetail_btn.Location = new System.Drawing.Point(208, 230);
            this.routedetail_btn.Name = "routedetail_btn";
            this.routedetail_btn.Size = new System.Drawing.Size(157, 44);
            this.routedetail_btn.TabIndex = 2;
            this.routedetail_btn.Text = "ROUTE DETAIL";
            this.routedetail_btn.UseVisualStyleBackColor = false;
            this.routedetail_btn.Click += new System.EventHandler(this.routedetail_btn_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SkyBlue;
            this.button3.Location = new System.Drawing.Point(208, 298);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(157, 44);
            this.button3.TabIndex = 3;
            this.button3.Text = "REGISTER";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.register_Click);
            // 
            // mainmenu_btn
            // 
            this.mainmenu_btn.BackColor = System.Drawing.Color.SkyBlue;
            this.mainmenu_btn.Location = new System.Drawing.Point(208, 363);
            this.mainmenu_btn.Name = "mainmenu_btn";
            this.mainmenu_btn.Size = new System.Drawing.Size(157, 44);
            this.mainmenu_btn.TabIndex = 4;
            this.mainmenu_btn.Text = "MAIN MENU";
            this.mainmenu_btn.UseVisualStyleBackColor = false;
            this.mainmenu_btn.Click += new System.EventHandler(this.mainmenu_btn_Click);
            // 
            // GuestMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(596, 433);
            this.Controls.Add(this.mainmenu_btn);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.routedetail_btn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "GuestMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GuestUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button routedetail_btn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button mainmenu_btn;
    }
}
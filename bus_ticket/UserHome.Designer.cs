namespace bus_ticket
{
    partial class UserHome
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
            this.LogOut_Btn = new System.Windows.Forms.Button();
            this.Schedule_Btn = new System.Windows.Forms.Button();
            this.Booking_Btn = new System.Windows.Forms.Button();
            this.Profile_Btn = new System.Windows.Forms.Button();
            this.logger_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LogOut_Btn
            // 
            this.LogOut_Btn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.LogOut_Btn.Location = new System.Drawing.Point(235, 362);
            this.LogOut_Btn.Name = "LogOut_Btn";
            this.LogOut_Btn.Size = new System.Drawing.Size(132, 43);
            this.LogOut_Btn.TabIndex = 7;
            this.LogOut_Btn.Text = "Log Out";
            this.LogOut_Btn.UseVisualStyleBackColor = false;
            this.LogOut_Btn.Click += new System.EventHandler(this.LogOut_Btn_Click);
            // 
            // Schedule_Btn
            // 
            this.Schedule_Btn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Schedule_Btn.Location = new System.Drawing.Point(235, 280);
            this.Schedule_Btn.Name = "Schedule_Btn";
            this.Schedule_Btn.Size = new System.Drawing.Size(132, 43);
            this.Schedule_Btn.TabIndex = 6;
            this.Schedule_Btn.Text = "My Schedule";
            this.Schedule_Btn.UseVisualStyleBackColor = false;
            this.Schedule_Btn.Click += new System.EventHandler(this.Schedule_Btn_Click);
            // 
            // Booking_Btn
            // 
            this.Booking_Btn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Booking_Btn.Location = new System.Drawing.Point(235, 195);
            this.Booking_Btn.Name = "Booking_Btn";
            this.Booking_Btn.Size = new System.Drawing.Size(132, 43);
            this.Booking_Btn.TabIndex = 5;
            this.Booking_Btn.Text = "Booking";
            this.Booking_Btn.UseVisualStyleBackColor = false;
            this.Booking_Btn.Click += new System.EventHandler(this.Booking_Btn_Click);
            // 
            // Profile_Btn
            // 
            this.Profile_Btn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Profile_Btn.Location = new System.Drawing.Point(235, 114);
            this.Profile_Btn.Name = "Profile_Btn";
            this.Profile_Btn.Size = new System.Drawing.Size(132, 43);
            this.Profile_Btn.TabIndex = 4;
            this.Profile_Btn.Text = "Profile";
            this.Profile_Btn.UseVisualStyleBackColor = false;
            this.Profile_Btn.EnabledChanged += new System.EventHandler(this.Profile_Btn_EnabledChanged);
            this.Profile_Btn.Click += new System.EventHandler(this.Profile_Btn_Click);
            // 
            // logger_lbl
            // 
            this.logger_lbl.AutoSize = true;
            this.logger_lbl.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logger_lbl.Location = new System.Drawing.Point(533, 9);
            this.logger_lbl.Name = "logger_lbl";
            this.logger_lbl.Size = new System.Drawing.Size(59, 17);
            this.logger_lbl.TabIndex = 8;
            this.logger_lbl.Text = "LOGGER";
            this.logger_lbl.EnabledChanged += new System.EventHandler(this.logger_lbl_Load);
            this.logger_lbl.Click += new System.EventHandler(this.logger_lbl_Click);
            this.logger_lbl.MouseHover += new System.EventHandler(this.logger_lbl_MouseHover);
            // 
            // UserHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 474);
            this.Controls.Add(this.logger_lbl);
            this.Controls.Add(this.LogOut_Btn);
            this.Controls.Add(this.Schedule_Btn);
            this.Controls.Add(this.Booking_Btn);
            this.Controls.Add(this.Profile_Btn);
            this.Name = "UserHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserHome";
            this.Load += new System.EventHandler(this.UserHome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void logger_lbl_Load(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button LogOut_Btn;
        private System.Windows.Forms.Button Schedule_Btn;
        private System.Windows.Forms.Button Booking_Btn;
        private System.Windows.Forms.Button Profile_Btn;
        private System.Windows.Forms.Label logger_lbl;
    }
}
namespace bus_ticket
{
    partial class UserSchedule
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
            this.userScheduleGrid = new System.Windows.Forms.DataGridView();
            this.ok_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.userScheduleGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // userScheduleGrid
            // 
            this.userScheduleGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userScheduleGrid.Location = new System.Drawing.Point(12, 0);
            this.userScheduleGrid.Name = "userScheduleGrid";
            this.userScheduleGrid.Size = new System.Drawing.Size(648, 289);
            this.userScheduleGrid.TabIndex = 0;
            // 
            // ok_btn
            // 
            this.ok_btn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ok_btn.Location = new System.Drawing.Point(290, 315);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(82, 32);
            this.ok_btn.TabIndex = 76;
            this.ok_btn.Text = "OK";
            this.ok_btn.UseVisualStyleBackColor = false;
            this.ok_btn.Click += new System.EventHandler(this.ok_btn_Click);
            // 
            // UserSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 373);
            this.Controls.Add(this.ok_btn);
            this.Controls.Add(this.userScheduleGrid);
            this.Name = "UserSchedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserSchedule";
            ((System.ComponentModel.ISupportInitialize)(this.userScheduleGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView userScheduleGrid;
        private System.Windows.Forms.Button ok_btn;
    }
}
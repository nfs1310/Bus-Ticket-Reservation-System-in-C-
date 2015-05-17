namespace bus_ticket
{
    partial class AllUserList
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
            this.ok_btn = new System.Windows.Forms.Button();
            this.adminListGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.adminListGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ok_btn
            // 
            this.ok_btn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ok_btn.Location = new System.Drawing.Point(209, 278);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(114, 49);
            this.ok_btn.TabIndex = 79;
            this.ok_btn.Text = "OK";
            this.ok_btn.UseVisualStyleBackColor = false;
            this.ok_btn.Click += new System.EventHandler(this.ok_btn_Click);
            // 
            // adminListGrid
            // 
            this.adminListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adminListGrid.Location = new System.Drawing.Point(12, 12);
            this.adminListGrid.Name = "adminListGrid";
            this.adminListGrid.Size = new System.Drawing.Size(506, 246);
            this.adminListGrid.TabIndex = 78;
            // 
            // AllUserList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 365);
            this.Controls.Add(this.ok_btn);
            this.Controls.Add(this.adminListGrid);
            this.Name = "AllUserList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AllUserList";
            ((System.ComponentModel.ISupportInitialize)(this.adminListGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ok_btn;
        private System.Windows.Forms.DataGridView adminListGrid;
    }
}
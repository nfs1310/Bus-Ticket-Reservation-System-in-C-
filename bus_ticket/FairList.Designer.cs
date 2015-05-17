namespace bus_ticket
{
    partial class FairList_user
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
            this.UserdataGridView = new System.Windows.Forms.DataGridView();
            this.ok_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UserdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // UserdataGridView
            // 
            this.UserdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserdataGridView.GridColor = System.Drawing.Color.Black;
            this.UserdataGridView.Location = new System.Drawing.Point(12, 12);
            this.UserdataGridView.Name = "UserdataGridView";
            this.UserdataGridView.Size = new System.Drawing.Size(402, 256);
            this.UserdataGridView.TabIndex = 0;
            this.UserdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UserdataGridView_CellContentClick);
            // 
            // ok_btn
            // 
            this.ok_btn.BackColor = System.Drawing.Color.SkyBlue;
            this.ok_btn.ForeColor = System.Drawing.Color.Black;
            this.ok_btn.Location = new System.Drawing.Point(151, 305);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(114, 41);
            this.ok_btn.TabIndex = 2;
            this.ok_btn.Text = "OK";
            this.ok_btn.UseVisualStyleBackColor = false;
            this.ok_btn.Click += new System.EventHandler(this.ok_btn_Click);
            // 
            // FairList_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 378);
            this.Controls.Add(this.ok_btn);
            this.Controls.Add(this.UserdataGridView);
            this.Name = "FairList_user";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fair List for USER";
            ((System.ComponentModel.ISupportInitialize)(this.UserdataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView UserdataGridView;
        private System.Windows.Forms.Button ok_btn;
    }
}
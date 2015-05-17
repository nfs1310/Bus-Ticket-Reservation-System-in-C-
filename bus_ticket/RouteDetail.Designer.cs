namespace bus_ticket
{
    partial class RouteDetail
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
            this.from_cbox = new System.Windows.Forms.ComboBox();
            this.to_cbox = new System.Windows.Forms.ComboBox();
            this.go_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.close_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(57, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "From:";
            // 
            // from_cbox
            // 
            this.from_cbox.FormattingEnabled = true;
            this.from_cbox.Location = new System.Drawing.Point(118, 61);
            this.from_cbox.Name = "from_cbox";
            this.from_cbox.Size = new System.Drawing.Size(121, 21);
            this.from_cbox.TabIndex = 3;
            this.from_cbox.SelectedIndexChanged += new System.EventHandler(this.from_cbox_SelectedIndexChanged);
            // 
            // to_cbox
            // 
            this.to_cbox.FormattingEnabled = true;
            this.to_cbox.Location = new System.Drawing.Point(118, 108);
            this.to_cbox.Name = "to_cbox";
            this.to_cbox.Size = new System.Drawing.Size(121, 21);
            this.to_cbox.TabIndex = 4;
            this.to_cbox.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // go_btn
            // 
            this.go_btn.BackColor = System.Drawing.Color.SkyBlue;
            this.go_btn.Location = new System.Drawing.Point(49, 166);
            this.go_btn.Name = "go_btn";
            this.go_btn.Size = new System.Drawing.Size(92, 33);
            this.go_btn.TabIndex = 5;
            this.go_btn.Text = "FIND ROUTE";
            this.go_btn.UseVisualStyleBackColor = false;
            this.go_btn.Click += new System.EventHandler(this.go_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(57, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "To:";
            // 
            // close_btn
            // 
            this.close_btn.BackColor = System.Drawing.Color.SkyBlue;
            this.close_btn.Location = new System.Drawing.Point(147, 166);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(92, 33);
            this.close_btn.TabIndex = 7;
            this.close_btn.Text = "CLOSE";
            this.close_btn.UseVisualStyleBackColor = false;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // RouteDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 289);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.go_btn);
            this.Controls.Add(this.to_cbox);
            this.Controls.Add(this.from_cbox);
            this.Controls.Add(this.label1);
            this.Name = "RouteDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Route Detail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox from_cbox;
        private System.Windows.Forms.ComboBox to_cbox;
        private System.Windows.Forms.Button go_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button close_btn;

    }
}
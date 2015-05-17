namespace bus_ticket
{
    partial class NewFair
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
            this.UserdataGridView = new System.Windows.Forms.DataGridView();
            this.addnew_btn = new System.Windows.Forms.Button();
            this.from_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.price_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.to_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UserdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ok_btn
            // 
            this.ok_btn.BackColor = System.Drawing.Color.SkyBlue;
            this.ok_btn.ForeColor = System.Drawing.Color.Black;
            this.ok_btn.Location = new System.Drawing.Point(591, 227);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(114, 41);
            this.ok_btn.TabIndex = 4;
            this.ok_btn.Text = "OK";
            this.ok_btn.UseVisualStyleBackColor = false;
            this.ok_btn.Click += new System.EventHandler(this.ok_btn_Click);
            // 
            // UserdataGridView
            // 
            this.UserdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserdataGridView.GridColor = System.Drawing.Color.Black;
            this.UserdataGridView.Location = new System.Drawing.Point(1, 12);
            this.UserdataGridView.Name = "UserdataGridView";
            this.UserdataGridView.Size = new System.Drawing.Size(402, 256);
            this.UserdataGridView.TabIndex = 3;
            this.UserdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UserdataGridView_CellContentClick);
            // 
            // addnew_btn
            // 
            this.addnew_btn.BackColor = System.Drawing.Color.SkyBlue;
            this.addnew_btn.ForeColor = System.Drawing.Color.Black;
            this.addnew_btn.Location = new System.Drawing.Point(461, 227);
            this.addnew_btn.Name = "addnew_btn";
            this.addnew_btn.Size = new System.Drawing.Size(114, 41);
            this.addnew_btn.TabIndex = 5;
            this.addnew_btn.Text = "ADD";
            this.addnew_btn.UseVisualStyleBackColor = false;
            this.addnew_btn.Click += new System.EventHandler(this.addnew_btn_Click);
            // 
            // from_txt
            // 
            this.from_txt.Location = new System.Drawing.Point(532, 68);
            this.from_txt.Name = "from_txt";
            this.from_txt.Size = new System.Drawing.Size(173, 20);
            this.from_txt.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(436, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 23);
            this.label5.TabIndex = 13;
            this.label5.Text = "FROM:";
            // 
            // price_txt
            // 
            this.price_txt.Location = new System.Drawing.Point(532, 153);
            this.price_txt.Name = "price_txt";
            this.price_txt.Size = new System.Drawing.Size(173, 20);
            this.price_txt.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(433, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 23);
            this.label1.TabIndex = 15;
            this.label1.Text = "PRICE:";
            // 
            // to_txt
            // 
            this.to_txt.Location = new System.Drawing.Point(532, 112);
            this.to_txt.Name = "to_txt";
            this.to_txt.Size = new System.Drawing.Size(173, 20);
            this.to_txt.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(457, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 23);
            this.label2.TabIndex = 17;
            this.label2.Text = "TO:";
            // 
            // NewFair
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 359);
            this.Controls.Add(this.to_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.price_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.from_txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.addnew_btn);
            this.Controls.Add(this.ok_btn);
            this.Controls.Add(this.UserdataGridView);
            this.Name = "NewFair";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Fair";
            ((System.ComponentModel.ISupportInitialize)(this.UserdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ok_btn;
        private System.Windows.Forms.DataGridView UserdataGridView;
        private System.Windows.Forms.Button addnew_btn;
        private System.Windows.Forms.TextBox from_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox price_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox to_txt;
        private System.Windows.Forms.Label label2;
    }
}
namespace bus_ticket
{
    partial class UserBooking
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
            this.to_combo = new System.Windows.Forms.ComboBox();
            this.frm_combo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.confirm_btn = new System.Windows.Forms.Button();
            this.Load = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.bookdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.id_txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // to_combo
            // 
            this.to_combo.FormattingEnabled = true;
            this.to_combo.Location = new System.Drawing.Point(170, 123);
            this.to_combo.Name = "to_combo";
            this.to_combo.Size = new System.Drawing.Size(121, 21);
            this.to_combo.TabIndex = 15;
            this.to_combo.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // frm_combo
            // 
            this.frm_combo.FormattingEnabled = true;
            this.frm_combo.Location = new System.Drawing.Point(170, 85);
            this.frm_combo.Name = "frm_combo";
            this.frm_combo.Size = new System.Drawing.Size(121, 21);
            this.frm_combo.TabIndex = 14;
            this.frm_combo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "To:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "From:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SkyBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(247, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 38);
            this.button1.TabIndex = 24;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // confirm_btn
            // 
            this.confirm_btn.BackColor = System.Drawing.Color.SkyBlue;
            this.confirm_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm_btn.ForeColor = System.Drawing.Color.Black;
            this.confirm_btn.Location = new System.Drawing.Point(113, 232);
            this.confirm_btn.Name = "confirm_btn";
            this.confirm_btn.Size = new System.Drawing.Size(101, 38);
            this.confirm_btn.TabIndex = 23;
            this.confirm_btn.Text = "Confirm";
            this.confirm_btn.UseVisualStyleBackColor = false;
            this.confirm_btn.Click += new System.EventHandler(this.confirm_btn_Click_1);
            // 
            // Load
            // 
            this.Load.BackColor = System.Drawing.Color.SkyBlue;
            this.Load.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Load.ForeColor = System.Drawing.Color.Black;
            this.Load.Location = new System.Drawing.Point(297, 85);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(51, 59);
            this.Load.TabIndex = 25;
            this.Load.Text = "Load List";
            this.Load.UseVisualStyleBackColor = false;
            this.Load.Click += new System.EventHandler(this.Load_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(73, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 23);
            this.label5.TabIndex = 26;
            this.label5.Text = "Date:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // bookdateTimePicker
            // 
            this.bookdateTimePicker.Location = new System.Drawing.Point(170, 165);
            this.bookdateTimePicker.Name = "bookdateTimePicker";
            this.bookdateTimePicker.Size = new System.Drawing.Size(178, 20);
            this.bookdateTimePicker.TabIndex = 27;
            this.bookdateTimePicker.ValueChanged += new System.EventHandler(this.bookdateTimePicker_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(167, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 16);
            this.label6.TabIndex = 28;
            this.label6.Text = "mm-DD-yyyy";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(63, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 23);
            this.label7.TabIndex = 29;
            this.label7.Text = "UserId:";
            // 
            // id_txt
            // 
            this.id_txt.Enabled = false;
            this.id_txt.Location = new System.Drawing.Point(170, 49);
            this.id_txt.Name = "id_txt";
            this.id_txt.Size = new System.Drawing.Size(121, 20);
            this.id_txt.TabIndex = 30;
            // 
            // UserBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 322);
            this.Controls.Add(this.id_txt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bookdateTimePicker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Load);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.confirm_btn);
            this.Controls.Add(this.to_combo);
            this.Controls.Add(this.frm_combo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UserBooking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserBooking";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox to_combo;
        private System.Windows.Forms.ComboBox frm_combo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button confirm_btn;
        private System.Windows.Forms.Button Load;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker bookdateTimePicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox id_txt;
    }
}
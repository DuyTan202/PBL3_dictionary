
namespace PBL3
{
    partial class Form3
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
            this.label3 = new System.Windows.Forms.Label();
            this.btTra = new System.Windows.Forms.Button();
            this.btDich = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.btDN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(95, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Từ Điển Anh - Việt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(30, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Chức Năng Thực Hiện:";
            // 
            // btTra
            // 
            this.btTra.BackColor = System.Drawing.Color.White;
            this.btTra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTra.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTra.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btTra.Location = new System.Drawing.Point(78, 125);
            this.btTra.Name = "btTra";
            this.btTra.Size = new System.Drawing.Size(279, 42);
            this.btTra.TabIndex = 13;
            this.btTra.Text = "Tra Từ";
            this.btTra.UseVisualStyleBackColor = false;
            this.btTra.Click += new System.EventHandler(this.btTra_Click);
            // 
            // btDich
            // 
            this.btDich.BackColor = System.Drawing.Color.White;
            this.btDich.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDich.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDich.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btDich.Location = new System.Drawing.Point(78, 195);
            this.btDich.Name = "btDich";
            this.btDich.Size = new System.Drawing.Size(279, 42);
            this.btDich.TabIndex = 14;
            this.btDich.Text = "Dịch Văn Bản";
            this.btDich.UseVisualStyleBackColor = false;
            this.btDich.Click += new System.EventHandler(this.btDich_Click);
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.Color.White;
            this.btExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExit.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btExit.Location = new System.Drawing.Point(78, 341);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(279, 42);
            this.btExit.TabIndex = 15;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btDN
            // 
            this.btDN.BackColor = System.Drawing.Color.White;
            this.btDN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDN.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDN.ForeColor = System.Drawing.Color.Black;
            this.btDN.Location = new System.Drawing.Point(78, 268);
            this.btDN.Name = "btDN";
            this.btDN.Size = new System.Drawing.Size(279, 42);
            this.btDN.TabIndex = 17;
            this.btDN.Text = "Đăng Nhập";
            this.btDN.UseVisualStyleBackColor = false;
            this.btDN.Click += new System.EventHandler(this.btDN_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 412);
            this.Controls.Add(this.btDN);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btDich);
            this.Controls.Add(this.btTra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Guest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btTra;
        private System.Windows.Forms.Button btDich;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btDN;
    }
}
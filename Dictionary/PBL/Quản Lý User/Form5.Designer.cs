
namespace PBL3
{
    partial class Form5
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
            this.btQLTV = new System.Windows.Forms.Button();
            this.btQLUser = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.btLS = new System.Windows.Forms.Button();
            this.btTu = new System.Windows.Forms.Button();
            this.btDich = new System.Windows.Forms.Button();
            this.btTra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(79, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 27);
            this.label1.TabIndex = 17;
            this.label1.Text = "Từ Điển Anh - Việt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(29, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Chức Năng Thực Hiện:";
            // 
            // btQLTV
            // 
            this.btQLTV.BackColor = System.Drawing.Color.White;
            this.btQLTV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btQLTV.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQLTV.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btQLTV.Location = new System.Drawing.Point(32, 121);
            this.btQLTV.Name = "btQLTV";
            this.btQLTV.Size = new System.Drawing.Size(205, 42);
            this.btQLTV.TabIndex = 19;
            this.btQLTV.Text = "Quản Lý Từ Vựng";
            this.btQLTV.UseVisualStyleBackColor = false;
            this.btQLTV.Click += new System.EventHandler(this.btQLTV_Click);
            // 
            // btQLUser
            // 
            this.btQLUser.BackColor = System.Drawing.Color.White;
            this.btQLUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btQLUser.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQLUser.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btQLUser.Location = new System.Drawing.Point(243, 121);
            this.btQLUser.Name = "btQLUser";
            this.btQLUser.Size = new System.Drawing.Size(205, 42);
            this.btQLUser.TabIndex = 19;
            this.btQLUser.Text = "Quản Lý Người Dùng";
            this.btQLUser.UseVisualStyleBackColor = false;
            this.btQLUser.Click += new System.EventHandler(this.btQLUser_Click);
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.Color.White;
            this.btExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExit.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btExit.Location = new System.Drawing.Point(84, 326);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(279, 42);
            this.btExit.TabIndex = 24;
            this.btExit.Text = "EXIT";
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btLS
            // 
            this.btLS.BackColor = System.Drawing.Color.White;
            this.btLS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLS.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLS.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btLS.Location = new System.Drawing.Point(243, 255);
            this.btLS.Name = "btLS";
            this.btLS.Size = new System.Drawing.Size(205, 42);
            this.btLS.TabIndex = 23;
            this.btLS.Text = "Từ Đã Tra";
            this.btLS.UseVisualStyleBackColor = false;
            this.btLS.Click += new System.EventHandler(this.btLS_Click);
            // 
            // btTu
            // 
            this.btTu.BackColor = System.Drawing.Color.White;
            this.btTu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTu.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTu.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btTu.Location = new System.Drawing.Point(32, 255);
            this.btTu.Name = "btTu";
            this.btTu.Size = new System.Drawing.Size(205, 42);
            this.btTu.TabIndex = 22;
            this.btTu.Text = "Từ Của Bạn";
            this.btTu.UseVisualStyleBackColor = false;
            this.btTu.Click += new System.EventHandler(this.btTu_Click);
            // 
            // btDich
            // 
            this.btDich.BackColor = System.Drawing.Color.White;
            this.btDich.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDich.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDich.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btDich.Location = new System.Drawing.Point(243, 190);
            this.btDich.Name = "btDich";
            this.btDich.Size = new System.Drawing.Size(205, 42);
            this.btDich.TabIndex = 26;
            this.btDich.Text = "Dịch Văn Bản";
            this.btDich.UseVisualStyleBackColor = false;
            this.btDich.Click += new System.EventHandler(this.btDich_Click);
            // 
            // btTra
            // 
            this.btTra.BackColor = System.Drawing.Color.White;
            this.btTra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTra.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTra.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btTra.Location = new System.Drawing.Point(32, 190);
            this.btTra.Name = "btTra";
            this.btTra.Size = new System.Drawing.Size(205, 42);
            this.btTra.TabIndex = 25;
            this.btTra.Text = "Tra Từ";
            this.btTra.UseVisualStyleBackColor = false;
            this.btTra.Click += new System.EventHandler(this.btTra_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 382);
            this.Controls.Add(this.btDich);
            this.Controls.Add(this.btTra);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btLS);
            this.Controls.Add(this.btTu);
            this.Controls.Add(this.btQLUser);
            this.Controls.Add(this.btQLTV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.Text = "Chức Năng Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btQLTV;
        private System.Windows.Forms.Button btQLUser;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btLS;
        private System.Windows.Forms.Button btTu;
        private System.Windows.Forms.Button btDich;
        private System.Windows.Forms.Button btTra;
    }
}
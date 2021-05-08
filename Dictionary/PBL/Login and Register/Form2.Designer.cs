
namespace PBL3
{
    partial class Form2
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
            this.label2 = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.tbPass1 = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbPass = new System.Windows.Forms.CheckBox();
            this.btDK = new System.Windows.Forms.Button();
            this.btCLR = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(95, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Get Started";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Purple;
            this.label2.Location = new System.Drawing.Point(44, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Phone";
            // 
            // tbUserName
            // 
            this.tbUserName.BackColor = System.Drawing.Color.LightGray;
            this.tbUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUserName.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUserName.Location = new System.Drawing.Point(47, 122);
            this.tbUserName.Multiline = true;
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(258, 27);
            this.tbUserName.TabIndex = 0;
            // 
            // tbPass
            // 
            this.tbPass.BackColor = System.Drawing.Color.LightGray;
            this.tbPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPass.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPass.Location = new System.Drawing.Point(47, 179);
            this.tbPass.Multiline = true;
            this.tbPass.Name = "tbPass";
            this.tbPass.PasswordChar = '*';
            this.tbPass.Size = new System.Drawing.Size(258, 27);
            this.tbPass.TabIndex = 1;
            // 
            // tbPass1
            // 
            this.tbPass1.BackColor = System.Drawing.Color.LightGray;
            this.tbPass1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPass1.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPass1.Location = new System.Drawing.Point(47, 237);
            this.tbPass1.Multiline = true;
            this.tbPass1.Name = "tbPass1";
            this.tbPass1.PasswordChar = '*';
            this.tbPass1.Size = new System.Drawing.Size(258, 27);
            this.tbPass1.TabIndex = 2;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.ForeColor = System.Drawing.Color.Purple;
            this.Password.Location = new System.Drawing.Point(44, 161);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(75, 15);
            this.Password.TabIndex = 1;
            this.Password.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Purple;
            this.label5.Location = new System.Drawing.Point(44, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Confirm Password";
            // 
            // cbPass
            // 
            this.cbPass.AutoSize = true;
            this.cbPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbPass.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPass.ForeColor = System.Drawing.Color.DimGray;
            this.cbPass.Location = new System.Drawing.Point(161, 283);
            this.cbPass.Name = "cbPass";
            this.cbPass.Size = new System.Drawing.Size(144, 20);
            this.cbPass.TabIndex = 3;
            this.cbPass.Text = "Show PassWord";
            this.cbPass.UseVisualStyleBackColor = true;
            this.cbPass.CheckedChanged += new System.EventHandler(this.cbPass_CheckedChanged);
            // 
            // btDK
            // 
            this.btDK.BackColor = System.Drawing.Color.Purple;
            this.btDK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btDK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDK.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDK.ForeColor = System.Drawing.Color.White;
            this.btDK.Location = new System.Drawing.Point(47, 327);
            this.btDK.Name = "btDK";
            this.btDK.Size = new System.Drawing.Size(258, 33);
            this.btDK.TabIndex = 4;
            this.btDK.Text = "REGISTER";
            this.btDK.UseVisualStyleBackColor = false;
            this.btDK.Click += new System.EventHandler(this.btDK_Click);
            // 
            // btCLR
            // 
            this.btCLR.BackColor = System.Drawing.Color.White;
            this.btCLR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCLR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCLR.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCLR.ForeColor = System.Drawing.Color.Black;
            this.btCLR.Location = new System.Drawing.Point(47, 375);
            this.btCLR.Name = "btCLR";
            this.btCLR.Size = new System.Drawing.Size(258, 33);
            this.btCLR.TabIndex = 4;
            this.btCLR.Text = "CLEAR";
            this.btCLR.UseVisualStyleBackColor = false;
            this.btCLR.Click += new System.EventHandler(this.btCLR_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Purple;
            this.label4.Location = new System.Drawing.Point(133, 427);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Back to LOGIN";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 469);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btCLR);
            this.Controls.Add(this.btDK);
            this.Controls.Add(this.cbPass);
            this.Controls.Add(this.tbPass1);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Đăng Ký";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.TextBox tbPass1;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbPass;
        private System.Windows.Forms.Button btDK;
        private System.Windows.Forms.Button btCLR;
        private System.Windows.Forms.Label label4;
    }
}
namespace WinFormsApp3
{
    partial class frmDangKi
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
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tbPassWord = new System.Windows.Forms.TextBox();
            this.tbRePassWord = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(95, 12);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(125, 27);
            this.tbUserName.TabIndex = 0;
            this.tbUserName.TextChanged += new System.EventHandler(this.tbUserName_TextChanged);
            // 
            // tbPassWord
            // 
            this.tbPassWord.Location = new System.Drawing.Point(95, 48);
            this.tbPassWord.Name = "tbPassWord";
            this.tbPassWord.PasswordChar = '*';
            this.tbPassWord.Size = new System.Drawing.Size(125, 27);
            this.tbPassWord.TabIndex = 1;
            // 
            // tbRePassWord
            // 
            this.tbRePassWord.Location = new System.Drawing.Point(95, 81);
            this.tbRePassWord.Name = "tbRePassWord";
            this.tbRePassWord.PasswordChar = '*';
            this.tbRePassWord.Size = new System.Drawing.Size(125, 27);
            this.tbRePassWord.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(95, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "Đăng kí";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "re PassWord";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "PassWord";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "UserName";
            // 
            // frmDangKi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 169);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbRePassWord);
            this.Controls.Add(this.tbPassWord);
            this.Controls.Add(this.tbUserName);
            this.Name = "frmDangKi";
            this.Text = "frmDangKi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbUserName;
        private TextBox tbPassWord;
        private TextBox tbRePassWord;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
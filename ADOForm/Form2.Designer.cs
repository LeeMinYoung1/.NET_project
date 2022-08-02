namespace ADOForm
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
            this.NameList = new System.Windows.Forms.ListBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.mailLabel = new System.Windows.Forms.Label();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.UpBtn = new System.Windows.Forms.Button();
            this.DownBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameList
            // 
            this.NameList.FormattingEnabled = true;
            this.NameList.ItemHeight = 15;
            this.NameList.Location = new System.Drawing.Point(53, 46);
            this.NameList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NameList.Name = "NameList";
            this.NameList.Size = new System.Drawing.Size(242, 289);
            this.NameList.TabIndex = 0;
            this.NameList.SelectedIndexChanged += new System.EventHandler(this.NameList_SelectedIndexChanged);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(397, 126);
            this.txtid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(157, 25);
            this.txtid.TabIndex = 31;
            this.txtid.TextChanged += new System.EventHandler(this.txtid_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(317, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 19);
            this.label1.TabIndex = 30;
            this.label1.Text = "id";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(397, 250);
            this.txtMail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(157, 25);
            this.txtMail.TabIndex = 29;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(397, 210);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(157, 25);
            this.txtPhone.TabIndex = 28;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(397, 171);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(157, 25);
            this.txtName.TabIndex = 27;
            // 
            // mailLabel
            // 
            this.mailLabel.AutoSize = true;
            this.mailLabel.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mailLabel.Location = new System.Drawing.Point(317, 250);
            this.mailLabel.Name = "mailLabel";
            this.mailLabel.Size = new System.Drawing.Size(60, 19);
            this.mailLabel.TabIndex = 26;
            this.mailLabel.Text = "E-Mail";
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.PhoneLabel.Location = new System.Drawing.Point(317, 210);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(85, 19);
            this.PhoneLabel.TabIndex = 25;
            this.PhoneLabel.Text = "전화번호";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.nameLabel.Location = new System.Drawing.Point(317, 171);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(47, 19);
            this.nameLabel.TabIndex = 24;
            this.nameLabel.Text = "이름";
            // 
            // UpBtn
            // 
            this.UpBtn.Location = new System.Drawing.Point(355, 296);
            this.UpBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UpBtn.Name = "UpBtn";
            this.UpBtn.Size = new System.Drawing.Size(72, 40);
            this.UpBtn.TabIndex = 32;
            this.UpBtn.Text = "위로";
            this.UpBtn.Click += new System.EventHandler(this.UpBtn_Click);
            // 
            // DownBtn
            // 
            this.DownBtn.Location = new System.Drawing.Point(453, 296);
            this.DownBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DownBtn.Name = "DownBtn";
            this.DownBtn.Size = new System.Drawing.Size(72, 40);
            this.DownBtn.TabIndex = 33;
            this.DownBtn.Text = "아래로";
            this.DownBtn.Click += new System.EventHandler(this.DownBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SearchBtn);
            this.groupBox1.Location = new System.Drawing.Point(397, 37);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(157, 69);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "최종";
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(20, 26);
            this.SearchBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(120, 25);
            this.SearchBtn.TabIndex = 1;
            this.SearchBtn.Text = "회원 확인";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 424);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.UpBtn);
            this.Controls.Add(this.DownBtn);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.mailLabel);
            this.Controls.Add(this.PhoneLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.NameList);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form2";
            this.Text = "회원 검색";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox NameList;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label mailLabel;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button UpBtn;
        private System.Windows.Forms.Button DownBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button SearchBtn;
    }
}
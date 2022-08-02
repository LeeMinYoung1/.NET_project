
namespace ADOForm
{
    partial class main
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
            this.btnFind = new System.Windows.Forms.Button();
            this.txtFind1 = new System.Windows.Forms.TextBox();
            this.RadioButton2 = new System.Windows.Forms.RadioButton();
            this.RadioButton1 = new System.Windows.Forms.RadioButton();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPrev = new System.Windows.Forms.Button();
            this.txtFind2 = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.RadioButton4 = new System.Windows.Forms.RadioButton();
            this.RadioButton3 = new System.Windows.Forms.RadioButton();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLentOrReturn = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.GroupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnSortByLending = new System.Windows.Forms.Button();
            this.btnSortByPublisher = new System.Windows.Forms.Button();
            this.btnSotrByAuthor = new System.Windows.Forms.Button();
            this.btnSortByTitle = new System.Windows.Forms.Button();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.GroupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.GroupBox1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.GroupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.GroupBox3.SuspendLayout();
            this.GroupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFind
            // 
            this.btnFind.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFind.Location = new System.Drawing.Point(231, 70);
            this.btnFind.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(53, 29);
            this.btnFind.TabIndex = 3;
            this.btnFind.Text = "확인";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click_1);
            // 
            // txtFind1
            // 
            this.txtFind1.Location = new System.Drawing.Point(23, 72);
            this.txtFind1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFind1.Name = "txtFind1";
            this.txtFind1.Size = new System.Drawing.Size(202, 25);
            this.txtFind1.TabIndex = 2;
            // 
            // RadioButton2
            // 
            this.RadioButton2.AutoSize = true;
            this.RadioButton2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.RadioButton2.Location = new System.Drawing.Point(101, 25);
            this.RadioButton2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RadioButton2.Name = "RadioButton2";
            this.RadioButton2.Size = new System.Drawing.Size(88, 19);
            this.RadioButton2.TabIndex = 1;
            this.RadioButton2.Text = "도서코드";
            this.RadioButton2.UseVisualStyleBackColor = true;
            // 
            // RadioButton1
            // 
            this.RadioButton1.AutoSize = true;
            this.RadioButton1.Checked = true;
            this.RadioButton1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.RadioButton1.Location = new System.Drawing.Point(23, 25);
            this.RadioButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RadioButton1.Name = "RadioButton1";
            this.RadioButton1.Size = new System.Drawing.Size(58, 19);
            this.RadioButton1.TabIndex = 0;
            this.RadioButton1.TabStop = true;
            this.RadioButton1.Text = "제목";
            this.RadioButton1.UseVisualStyleBackColor = true;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.btnPrev);
            this.GroupBox1.Controls.Add(this.btnFind);
            this.GroupBox1.Controls.Add(this.txtFind1);
            this.GroupBox1.Controls.Add(this.RadioButton2);
            this.GroupBox1.Controls.Add(this.RadioButton1);
            this.GroupBox1.ForeColor = System.Drawing.Color.Blue;
            this.GroupBox1.Location = new System.Drawing.Point(12, 13);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupBox1.Size = new System.Drawing.Size(345, 142);
            this.GroupBox1.TabIndex = 7;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "검색";
            // 
            // btnPrev
            // 
            this.btnPrev.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPrev.Location = new System.Drawing.Point(290, 70);
            this.btnPrev.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(45, 29);
            this.btnPrev.TabIndex = 4;
            this.btnPrev.Text = "이전";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click_1);
            // 
            // txtFind2
            // 
            this.txtFind2.Location = new System.Drawing.Point(17, 70);
            this.txtFind2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFind2.Name = "txtFind2";
            this.txtFind2.Size = new System.Drawing.Size(175, 25);
            this.txtFind2.TabIndex = 3;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.ForeColor = System.Drawing.Color.Red;
            this.Label1.Location = new System.Drawing.Point(177, 21);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(86, 15);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "※ 코드입력";
            // 
            // RadioButton4
            // 
            this.RadioButton4.AutoSize = true;
            this.RadioButton4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.RadioButton4.Location = new System.Drawing.Point(90, 25);
            this.RadioButton4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RadioButton4.Name = "RadioButton4";
            this.RadioButton4.Size = new System.Drawing.Size(58, 19);
            this.RadioButton4.TabIndex = 1;
            this.RadioButton4.Text = "반납";
            this.RadioButton4.UseVisualStyleBackColor = true;
            // 
            // RadioButton3
            // 
            this.RadioButton3.AutoSize = true;
            this.RadioButton3.Checked = true;
            this.RadioButton3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.RadioButton3.Location = new System.Drawing.Point(17, 25);
            this.RadioButton3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RadioButton3.Name = "RadioButton3";
            this.RadioButton3.Size = new System.Drawing.Size(58, 19);
            this.RadioButton3.TabIndex = 0;
            this.RadioButton3.TabStop = true;
            this.RadioButton3.Text = "대여";
            this.RadioButton3.UseVisualStyleBackColor = true;
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.btnLentOrReturn);
            this.GroupBox2.Controls.Add(this.txtFind2);
            this.GroupBox2.Controls.Add(this.Label1);
            this.GroupBox2.Controls.Add(this.RadioButton4);
            this.GroupBox2.Controls.Add(this.RadioButton3);
            this.GroupBox2.ForeColor = System.Drawing.Color.Blue;
            this.GroupBox2.Location = new System.Drawing.Point(384, 13);
            this.GroupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupBox2.Size = new System.Drawing.Size(269, 142);
            this.GroupBox2.TabIndex = 8;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "대여/반납";
            // 
            // btnLentOrReturn
            // 
            this.btnLentOrReturn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLentOrReturn.Location = new System.Drawing.Point(198, 68);
            this.btnLentOrReturn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLentOrReturn.Name = "btnLentOrReturn";
            this.btnLentOrReturn.Size = new System.Drawing.Size(58, 29);
            this.btnLentOrReturn.TabIndex = 4;
            this.btnLentOrReturn.Text = "확인";
            this.btnLentOrReturn.UseVisualStyleBackColor = true;
            this.btnLentOrReturn.Click += new System.EventHandler(this.btnLentOrReturn_Click_1);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.ForeColor = System.Drawing.Color.Red;
            this.Label2.Location = new System.Drawing.Point(403, 21);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(66, 15);
            this.Label2.TabIndex = 0;
            this.Label2.Text = "총 000명";
            // 
            // GroupBox5
            // 
            this.GroupBox5.Controls.Add(this.dataGridView2);
            this.GroupBox5.Controls.Add(this.Label2);
            this.GroupBox5.ForeColor = System.Drawing.Color.Blue;
            this.GroupBox5.Location = new System.Drawing.Point(671, 177);
            this.GroupBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupBox5.Name = "GroupBox5";
            this.GroupBox5.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupBox5.Size = new System.Drawing.Size(556, 281);
            this.GroupBox5.TabIndex = 11;
            this.GroupBox5.TabStop = false;
            this.GroupBox5.Text = "대여 회원";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(21, 40);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 27;
            this.dataGridView2.Size = new System.Drawing.Size(516, 226);
            this.dataGridView2.TabIndex = 2;
            // 
            // btnSortByLending
            // 
            this.btnSortByLending.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSortByLending.Location = new System.Drawing.Point(370, 25);
            this.btnSortByLending.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSortByLending.Name = "btnSortByLending";
            this.btnSortByLending.Size = new System.Drawing.Size(86, 29);
            this.btnSortByLending.TabIndex = 3;
            this.btnSortByLending.Text = "대여";
            this.btnSortByLending.UseVisualStyleBackColor = true;
            this.btnSortByLending.Click += new System.EventHandler(this.btnSortByLending_Click_1);
            // 
            // btnSortByPublisher
            // 
            this.btnSortByPublisher.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSortByPublisher.Location = new System.Drawing.Point(259, 25);
            this.btnSortByPublisher.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSortByPublisher.Name = "btnSortByPublisher";
            this.btnSortByPublisher.Size = new System.Drawing.Size(86, 29);
            this.btnSortByPublisher.TabIndex = 2;
            this.btnSortByPublisher.Text = "출판사";
            this.btnSortByPublisher.UseVisualStyleBackColor = true;
            this.btnSortByPublisher.Click += new System.EventHandler(this.btnSortByPublisher_Click_1);
            // 
            // btnSotrByAuthor
            // 
            this.btnSotrByAuthor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSotrByAuthor.Location = new System.Drawing.Point(149, 25);
            this.btnSotrByAuthor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSotrByAuthor.Name = "btnSotrByAuthor";
            this.btnSotrByAuthor.Size = new System.Drawing.Size(86, 29);
            this.btnSotrByAuthor.TabIndex = 1;
            this.btnSotrByAuthor.Text = "저자";
            this.btnSotrByAuthor.UseVisualStyleBackColor = true;
            this.btnSotrByAuthor.Click += new System.EventHandler(this.btnSotrByAuthor_Click_1);
            // 
            // btnSortByTitle
            // 
            this.btnSortByTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSortByTitle.Location = new System.Drawing.Point(38, 25);
            this.btnSortByTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSortByTitle.Name = "btnSortByTitle";
            this.btnSortByTitle.Size = new System.Drawing.Size(86, 29);
            this.btnSortByTitle.TabIndex = 0;
            this.btnSortByTitle.Text = "제목";
            this.btnSortByTitle.UseVisualStyleBackColor = true;
            this.btnSortByTitle.Click += new System.EventHandler(this.btnSortByTitle_Click_1);
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.btnSortByLending);
            this.GroupBox3.Controls.Add(this.btnSortByPublisher);
            this.GroupBox3.Controls.Add(this.btnSotrByAuthor);
            this.GroupBox3.Controls.Add(this.btnSortByTitle);
            this.GroupBox3.ForeColor = System.Drawing.Color.Blue;
            this.GroupBox3.Location = new System.Drawing.Point(12, 177);
            this.GroupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupBox3.Size = new System.Drawing.Size(486, 72);
            this.GroupBox3.TabIndex = 12;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "정렬";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.ForeColor = System.Drawing.Color.Red;
            this.Label3.Location = new System.Drawing.Point(558, 21);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(66, 15);
            this.Label3.TabIndex = 0;
            this.Label3.Text = "총 000권";
            // 
            // GroupBox4
            // 
            this.GroupBox4.Controls.Add(this.dataGridView1);
            this.GroupBox4.Controls.Add(this.Label3);
            this.GroupBox4.ForeColor = System.Drawing.Color.Blue;
            this.GroupBox4.Location = new System.Drawing.Point(10, 267);
            this.GroupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupBox4.Size = new System.Drawing.Size(637, 360);
            this.GroupBox4.TabIndex = 13;
            this.GroupBox4.TabStop = false;
            this.GroupBox4.Text = "목록";
            this.GroupBox4.Enter += new System.EventHandler(this.GroupBox4_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(590, 290);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 640);
            this.Controls.Add(this.GroupBox4);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.GroupBox5);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox1);
            this.Name = "main";
            this.Text = "대여 관리";
            this.Load += new System.EventHandler(this.main_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox5.ResumeLayout(false);
            this.GroupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox4.ResumeLayout(false);
            this.GroupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button btnFind;
        internal System.Windows.Forms.TextBox txtFind1;
        internal System.Windows.Forms.RadioButton RadioButton2;
        internal System.Windows.Forms.RadioButton RadioButton1;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Button btnPrev;
        internal System.Windows.Forms.TextBox txtFind2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.RadioButton RadioButton4;
        internal System.Windows.Forms.RadioButton RadioButton3;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Button btnLentOrReturn;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.GroupBox GroupBox5;
        private System.Windows.Forms.DataGridView dataGridView2;
        internal System.Windows.Forms.Button btnSortByLending;
        internal System.Windows.Forms.Button btnSortByPublisher;
        internal System.Windows.Forms.Button btnSotrByAuthor;
        internal System.Windows.Forms.Button btnSortByTitle;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.GroupBox GroupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
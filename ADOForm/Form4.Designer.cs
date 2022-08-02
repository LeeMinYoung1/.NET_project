
namespace ADOForm
{
    partial class Form4
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
            this.components = new System.ComponentModel.Container();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.DBGrid = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.선택된행업데이트ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.새로운데이터추가ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.선택한행삭제ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.DBGrid)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(678, 469);
            this.SearchBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(139, 25);
            this.SearchBtn.TabIndex = 2;
            this.SearchBtn.Text = "도서 목록";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // DBGrid
            // 
            this.DBGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DBGrid.ContextMenuStrip = this.contextMenuStrip1;
            this.DBGrid.Location = new System.Drawing.Point(51, 50);
            this.DBGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DBGrid.Name = "DBGrid";
            this.DBGrid.RowHeadersWidth = 51;
            this.DBGrid.RowTemplate.Height = 23;
            this.DBGrid.Size = new System.Drawing.Size(766, 390);
            this.DBGrid.TabIndex = 3;
            this.DBGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DBGrid_CellContentClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.선택된행업데이트ToolStripMenuItem,
            this.새로운데이터추가ToolStripMenuItem,
            this.선택한행삭제ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(209, 76);
            // 
            // 선택된행업데이트ToolStripMenuItem
            // 
            this.선택된행업데이트ToolStripMenuItem.Name = "선택된행업데이트ToolStripMenuItem";
            this.선택된행업데이트ToolStripMenuItem.Size = new System.Drawing.Size(208, 24);
            this.선택된행업데이트ToolStripMenuItem.Text = "선택된 행 업데이트";
            this.선택된행업데이트ToolStripMenuItem.Click += new System.EventHandler(this.선택된행업데이트ToolStripMenuItem_Click);
            // 
            // 새로운데이터추가ToolStripMenuItem
            // 
            this.새로운데이터추가ToolStripMenuItem.Name = "새로운데이터추가ToolStripMenuItem";
            this.새로운데이터추가ToolStripMenuItem.Size = new System.Drawing.Size(208, 24);
            this.새로운데이터추가ToolStripMenuItem.Text = "새로운 데이터 추가";
            this.새로운데이터추가ToolStripMenuItem.Click += new System.EventHandler(this.새로운데이터추가ToolStripMenuItem_Click_1);
            // 
            // 선택한행삭제ToolStripMenuItem
            // 
            this.선택한행삭제ToolStripMenuItem.Name = "선택한행삭제ToolStripMenuItem";
            this.선택한행삭제ToolStripMenuItem.Size = new System.Drawing.Size(208, 24);
            this.선택한행삭제ToolStripMenuItem.Text = "선택한 행 삭제";
            this.선택한행삭제ToolStripMenuItem.Click += new System.EventHandler(this.선택한행삭제ToolStripMenuItem_Click_1);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 526);
            this.Controls.Add(this.DBGrid);
            this.Controls.Add(this.SearchBtn);
            this.Name = "Form4";
            this.Text = "최종 회원 확인";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DBGrid)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.DataGridView DBGrid;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 선택된행업데이트ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 새로운데이터추가ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 선택한행삭제ToolStripMenuItem;
    }
}
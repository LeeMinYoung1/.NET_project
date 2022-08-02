﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace ADOForm
{
    public partial class Form4 : Form
    {
        private int intID; //ID 필드 설정
        private string strCommand;
        //데이터 삭제, 추가, 업데이트 인지를 설정할 문자열 필드
        private OracleConnection odpConn = new
         OracleConnection();

        public int getintID
        { get { return intID; } }
        public string getstrCommand
        { get { return strCommand; } }

        private void showDataGridView() //사용자 정의 함수
        {
            try
            {
                odpConn.ConnectionString = "User Id=hong1; Password=1111; Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA = (SERVER =DEDICATED)(SERVICE_NAME = xe))); ";

                odpConn.Open();
                OracleDataAdapter oda = new OracleDataAdapter();
                oda.SelectCommand = new OracleCommand("SELECT * from phone", odpConn);

                DataTable dt = new DataTable();
                oda.Fill(dt);
                odpConn.Close();
                DBGrid.DataSource = dt;

                DBGrid.AutoResizeColumns();
                DBGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                DBGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                DBGrid.AllowUserToAddRows = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("에러 발생 : " + ex.ToString());
                odpConn.Close();
            }
        }

        public Form4()
        {
            InitializeComponent();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Owner = this;
            frm3.ShowDialog();
            frm3.Dispose();
        }

        private void DBGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            showDataGridView();
        }

  
      

  

        private void 선택된행업데이트ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            strCommand = "업데이트";
            intID = Convert.ToInt32(DBGrid.SelectedCells[0].Value); //값 연결
            Form6 form6 = new Form6(this);
            form6.ShowDialog();
            form6.Dispose();
            showDataGridView();
        }

        private void 새로운데이터추가ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            strCommand = "추가";
            Form6 form6 = new Form6(this);
            form6.ShowDialog();
            form6.Dispose();
            showDataGridView();
        }

        private void 선택한행삭제ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            strCommand = "삭제";
            intID = Convert.ToInt32(DBGrid.SelectedCells[0].Value); //값 연결
            Form6 form6 = new Form6(this);
            form6.ShowDialog();
            form6.Dispose();
            showDataGridView();
        }
    }
}
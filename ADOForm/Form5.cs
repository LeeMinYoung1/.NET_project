using System;
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
    public partial class main : Form
    {
        string id_code;     //반납시 사용 변수
        string booksql;    //쿼리문 저장 변수
        int m_lent_v;  //반납시 사용 변수
        DBClass1 dbc = new DBClass1();  //*****DBClass 객체 생성
        DataRow currRow; //DS의 현재 행 저장 변수
        public String TxtFind2  //Form6과 관련
        {
            get { return txtFind2.Text; }
            set { txtFind2.Text = value.ToString(); }
        }

        public main()
        {
            InitializeComponent();
            dbc.DB_ObjCreate(); //*****
            dbc.DB_Open();//*****
            dbc.DB_Access();//***
        }

        public void sql_execute(String sqlstr, DataSet dsstr)    //사용자 함수 정의
        {
            dbc.DCom.CommandText = sqlstr;
            dbc.DA.SelectCommand = dbc.DCom;
            dbc.DA.Fill(dsstr, "book");
            dsstr.Tables["book"].Clear();
            //***** 방법1 :DS를 하나만 정의한 상태에서 기존의 DS의 book만 제거
            //*****  sql_execute()의 방법1은 DS를 하나만 정의할 경우로 테이블 단위로 클리어 한다.
            //dbc.DS.Clear(); 
            //위의 DS를 지우면 dataGridView2까지 클리어 되어서 안 됨! 
            // 이 경우는 dataGridView마다 다른 DS를 사용할 것
            dbc.DA.Fill(dsstr, "book");
            int i;
            i = 0;
            while (i < dsstr.Tables["book"].Rows.Count)
            {
                DataRow currRow = dsstr.Tables["book"].Rows[i];
                if (currRow[6].ToString() == "")  //대여한 회원이 없으면 book테이블의 b_lent필드타입은 varchar(20)
                    currRow[6] = "가능";
                else    ////대여한 회원이 있으면
                    currRow[6] = "불가능";

                i = i + 1;
            }
            dataGridView1.DataSource = dsstr.Tables["book"].DefaultView;
            book_counter();  //함수 호출
            book_header();     //함수 호출 

        }
        public void book_counter()
        {
            int i;
            i = dataGridView1.RowCount;
            Label3.Text = "총 " + i + "권";
        }
        public void book_header()
        {
            dataGridView1.Columns[0].HeaderText = "코드";
            dataGridView1.Columns[1].HeaderText = "제목";
            dataGridView1.Columns[2].HeaderText = "저자";
            dataGridView1.Columns[3].HeaderText = "출판사";
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].HeaderText = "대여";
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;

            dataGridView1.Columns[0].Width = 60;
            dataGridView1.Columns[1].Width = 60;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[6].Width = 60;
        }
        public void list_search(String Find, String Sort)  // 검색과 정렬에 해당하는 SQL 작성 
        {
            if (Find == "" && Sort == "")  //기본
            {
                booksql = "Select * From book ORDER BY b_code ASC";
                sql_execute(booksql, dbc.DS);
            }
            else if (Find == "" && Sort != "")  //정렬
            {
                if (Sort == "title")
                { booksql = "Select * From book ORDER BY b_title ASC"; }
                else if (Sort == "name")
                { booksql = "Select * From book ORDER BY b_name ASC"; }
                else if (Sort == "publishing")
                { booksql = "Select * From book ORDER BY b_publishing ASC"; }
                else if (Sort == "lent")
                { booksql = "Select * From book ORDER BY b_lent ASC"; }

                sql_execute(booksql, dbc.DS);
            }
            else if (Find != "")  //검색
            {
                if (RadioButton1.Checked)  //제목 검색
                { booksql = "Select * From book Where b_title Like '%" + Find + "%'"; }
                else if (RadioButton2.Checked)  //도서 코드 검색
                { booksql = "Select * From book Where b_code = '" + Find + "'"; }

                sql_execute(booksql, dbc.DS);
                if (dbc.DS.Tables["book"].Rows.Count == 0)
                {
                    MessageBox.Show("해당 도서가 없습니다");
                    booksql = "Select * From book ORDER BY b_title ASC";
                    sql_execute(booksql, dbc.DS);
                }
            }
        }

        private void main_Load(object sender, EventArgs e)
        {
            list_search("", "");  //*
            lent_id();  //*
            blacklist();//*
            this.Left = 0;
            this.Top = 0;
        }




        public void sql_execute2(String sqlstr, DataSet dsstr)    //사용자 함수 정의
        {

            dbc.DCom.CommandText = sqlstr;
            dbc.DA.SelectCommand = dbc.DCom;

            dbc.DA.Fill(dsstr, "member");
            dsstr.Tables["member"].Clear();  //***** 방법1 :DS를 하나만 정의한 상태에서 기존의 DS의 book만 제거
            dbc.DA.Fill(dsstr, "member");

            dataGridView2.DataSource = dsstr.Tables["member"].DefaultView;
            lentm_counter();
            lentm_header();

        }

        public void lentm_counter()
        {
            int i;
            i = dataGridView2.RowCount;
            Label2.Text = "총 " + i + "명";
        }
        public void lentm_header()
        {
            dataGridView2.Columns[0].HeaderText = "ID";
            dataGridView2.Columns[1].HeaderText = "이름";
            dataGridView2.Columns[2].Visible = false;
            dataGridView2.Columns[3].Visible = false;
            dataGridView2.Columns[4].Visible = false;
            dataGridView2.Columns[5].Visible = false;
            dataGridView2.Columns[6].HeaderText = "권수";
            dataGridView2.Columns[7].Visible = false;

            dataGridView2.Columns[0].Width = 80;
            dataGridView2.Columns[1].Width = 80;
            dataGridView2.Columns[6].Width = 80;
        }
        public void lent_id()
        {
            booksql = "Select * From member Where m_lent <> 0 ORDER BY m_id ASC";
            sql_execute2(booksql, dbc.DS);
        }



      

        public void blacklist()
        {
            booksql = "Select B.m_name, A.b_code, A.b_title, A.b_lent_date, trunc(sysdate) -trunc(A.b_lent_date + 10) b_delay From book A Inner Join member B on A.b_lent = B.m_id Where trunc(A.b_lent_date + 10)< trunc(sysdate) ORDER BY A.b_lent_date ASC";
            
        }

        
        private void btnFind_Click_1(object sender, EventArgs e)
        {
            if (txtFind1.Text.Trim() == "")
                MessageBox.Show("검색 미입력");
            else
                list_search(txtFind1.Text.Trim(), "");
        }

        private void btnPrev_Click_1(object sender, EventArgs e)
        {
            list_search("", "");
        }

        private void btnSortByTitle_Click_1(object sender, EventArgs e)
        {
            list_search("", "title");
        }

        private void btnSotrByAuthor_Click_1(object sender, EventArgs e)
        {
            list_search("", "name");
        }

        private void btnSortByPublisher_Click_1(object sender, EventArgs e)
        {
            list_search("", "publishing");
        }

        private void btnSortByLending_Click_1(object sender, EventArgs e)
        {
            list_search("", "lent");
        }

        private void btnLentOrReturn_Click_1(object sender, EventArgs e)
        {
            if (txtFind2.Text.Trim() == "")
            {
                MessageBox.Show("도서코드 미입력");
                txtFind2.Focus();
            }
            else
            {  //1 if
                if (RadioButton3.Checked)  //대여
                {
                    dbc.DS.Tables["book"].Clear();
                    dbc.DS.Tables["member"].Clear();
                    booksql = "Select * From book Where b_code = '" + txtFind2.Text + "'";
                    dbc.DCom.CommandText = booksql;
                    dbc.DA.SelectCommand = dbc.DCom;
                    dbc.DA.Fill(dbc.DS, "book");

                    if (dbc.DS.Tables["book"].Rows.Count == 0)
                    {
                        MessageBox.Show("해당되는 도서가 없습니다.");
                        txtFind2.Text = "";
                        txtFind2.Focus();
                    }
                    else
                    {
                        currRow = dbc.DS.Tables["book"].Rows[0];  //대여

                        if (currRow[6].ToString() == "")
                        {
                            //  Form6 연결 => memid.ShowDialog()
                            list_search("", "");
                            lent_id();
                            memid memid = new memid(this);
                            memid.ShowDialog();
                            memid.Dispose();
                        }
                        else
                        {
                            list_search("", "");
                            lent_id();
                            MessageBox.Show("이미 대여된 도서입니다.");
                            txtFind2.Text = "";
                            txtFind2.Focus();

                        }
                    }
                }
                else if (RadioButton4.Checked)  //반납
                {
                    DialogResult rtyes = MessageBox.Show("해당 도서를 반납하시겠습니까?", "반납 확인", MessageBoxButtons.YesNo);
                    dbc.DS.Tables["book"].Clear();
                    dbc.DS.Tables["member"].Clear();
                    if (rtyes == DialogResult.Yes)
                    {
                        booksql = "Select * From book Where b_code='" + txtFind2.Text + "'";
                        dbc.DCom.CommandText = booksql;
                        dbc.DA.SelectCommand = dbc.DCom;
                        dbc.DA.Fill(dbc.DS, "book");
                        currRow = dbc.DS.Tables["book"].Rows[0];  //****
                        id_code = currRow[6].ToString();  //book테이블에서 대여한 회원 id 

                        booksql = "Select * From member Where m_id = '" + id_code + "'";
                        dbc.DCom.CommandText = booksql;
                        dbc.DA.SelectCommand = dbc.DCom;
                        dbc.DA.Fill(dbc.DS, "member");
                        DataRow currRow1 = dbc.DS.Tables["member"].Rows[0];  //****
                        m_lent_v = Convert.ToInt32(currRow1[6]);  //update문에 활용하기 위해

                        if (dbc.DS.Tables["book"].Rows.Count == 0)
                        {
                            MessageBox.Show("해당되는 도서가 없습니다.");
                            txtFind2.Text = "";
                            txtFind2.Focus();
                        }
                        else if (currRow[6].ToString() == "")
                        {
                            MessageBox.Show("대여되지 않은 도서입니다.");
                            txtFind2.Text = "";
                            txtFind2.Focus();
                        }

                        else
                        {
                            booksql = "Update book Set b_lent = null, b_lent_date =null Where b_code = '" + txtFind2.Text + "'";
                            dbc.DCom.CommandText = booksql;
                            dbc.DCom.ExecuteNonQuery();
                            dbc.DS.Tables["book"].Clear();
                            dbc.DA.Fill(dbc.DS, "book");


                            m_lent_v = m_lent_v - 1;  // 변수로 연산하고 쿼리문에 적용
                            booksql = "Update member Set m_lent = " + m_lent_v + "  Where m_id = '" + id_code + "'";
                            dbc.DCom.CommandText = booksql;
                            dbc.DCom.ExecuteNonQuery();
                            dbc.DS.Tables["member"].Clear();
                            dbc.DA.Fill(dbc.DS, "member");


                            txtFind2.Text = "";
                            txtFind2.Focus();
                            // dbc.DS.Clear();
                            list_search("", "");
                            lent_id();
                            blacklist();
                        }
                    } //rtyes == DialogResult.Yes
                }// RadioButton4.Checked
            }  //1if else
        }  //btnLentOrReturn_Click

        private void GroupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GroupBox6_Enter(object sender, EventArgs e)
        {

        }
    }
}
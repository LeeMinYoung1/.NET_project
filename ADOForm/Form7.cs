using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADOForm
{
    public partial class memid : Form
    {

        string sqlstr;    //쿼리문 저장 변수

        int b_lent_num_v;//대여시 사용 변수
        int m_lent_v;  //대여시 사용 변수
        int m_total_lent_v;  //대여시 사용 변수

        DBClass1 dbc = new DBClass1();  //*****DBClass1 객체 생성      
        DataRow currRow1; //DS의 현재 행 저장 변수 
        DataRow currRow2; //DS의 현재 행 저장 변수 
        main parent;


        public memid(main mainform)
        {
            InitializeComponent();
            parent = mainform;
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            dbc.DB_ObjCreate(); //*****
            dbc.DB_Open();//*****
            dbc.DB_Access();//***
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Trim() == "")
            {
                MessageBox.Show("ID를 입력하세요");
                txtID.Text = "";
                txtID.Focus();
            }
            else  //대여
            {
                DialogResult rtyes = MessageBox.Show("해당 도서를 대여하시겠습니까?", "대여 확인", MessageBoxButtons.YesNo);
                // dbc.DS.Tables["book"].Clear();
                // dbc.DS.Tables["member"].Clear();

                if (rtyes == DialogResult.Yes)
                {
                    sqlstr = "Select * From member Where m_id = '" + txtID.Text + "'";
                    dbc.DCom.CommandText = sqlstr;
                    dbc.DA.SelectCommand = dbc.DCom;
                    dbc.DA.Fill(dbc.DS, "member");
                    dbc.DS.Tables["member"].Clear();
                    dbc.DA.Fill(dbc.DS, "member");

                    if (dbc.DS.Tables["member"].Rows.Count == 0)
                    {
                        MessageBox.Show("등록된 회원이 아닙니다.");
                        txtID.Text = "";
                        txtID.Focus();
                    }
                    else
                    {
                        P_BookLent(txtID.Text, parent.TxtFind2);  //대여 쿼리문 처리하는 함수 호출(대여 회원id, 대여 도서code)
                        parent.list_search("", "");


                        MessageBox.Show("대여되었습니다." + "\n" + "반납일을 꼭 지켜주세요");
                        parent.lent_id();
                        this.Close();
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            parent.list_search("", "");
            this.Close();
        }

        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.btnOK_Click(this, new EventArgs()); //***이벤트 프로시저 호출
            }
        }

        public void P_BookLent(string Mid, string Bcode)
        {
            label2.Text = Mid; //대여 회원id
            label3.Text = Bcode; //대여 도서code

            sqlstr = "Select * From book Where b_code='" + Bcode + "'";
            dbc.DCom.CommandText = sqlstr;
            dbc.DA.SelectCommand = dbc.DCom;
            dbc.DA.Fill(dbc.DS, "book");
            currRow1 = dbc.DS.Tables["book"].Rows[0];
            b_lent_num_v = Convert.ToInt32(currRow1[7]);  //book테이블의 Mid에 대한 대여 횟수 

            sqlstr = "Select * From member Where m_id = '" + Mid + "'";
            dbc.DCom.CommandText = sqlstr;
            dbc.DA.SelectCommand = dbc.DCom;
            dbc.DA.Fill(dbc.DS, "member");
            currRow2 = dbc.DS.Tables["member"].Rows[0];  //****
            m_lent_v = Convert.ToInt32(currRow2[6]);
            m_total_lent_v = Convert.ToInt32(currRow2[7]);

            b_lent_num_v = b_lent_num_v + 1;  // 변수로 연산하고 쿼리문에 적용
            sqlstr = "Update book Set b_lent = '" + Mid + "' , b_lent_date = sysdate , b_lent_num = " + b_lent_num_v + " Where b_code = '" + Bcode + "'";
            dbc.DCom.CommandText = sqlstr;
            dbc.DCom.ExecuteNonQuery();
            dbc.DA.SelectCommand = dbc.DCom;
            dbc.DA.Fill(dbc.DS, "book");
            dbc.DS.Tables["book"].Clear();
            dbc.DA.Fill(dbc.DS, "book");


            m_lent_v = m_lent_v + 1;
            m_total_lent_v = m_total_lent_v + 1;
            sqlstr = "Update member Set m_lent =" + m_lent_v + " , m_total_lent = " + m_total_lent_v + "  Where m_id = '" + Mid + "'";
            dbc.DCom.CommandText = sqlstr;
            dbc.DCom.ExecuteNonQuery();
            dbc.DA.SelectCommand = dbc.DCom;
            dbc.DA.Fill(dbc.DS, "member");
            dbc.DS.Tables["member"].Clear();
            dbc.DA.Fill(dbc.DS, "member");
        }
    }
}

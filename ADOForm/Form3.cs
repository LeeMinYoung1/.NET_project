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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string connectionString = "User id=hong1; Password=1111; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL =TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = xe)) ); ";
            OracleConnection myConnection = new OracleConnection(connectionString);
            string commandString = "select * from BOOK ";
            OracleCommand myCommand = new OracleCommand();
            myCommand.Connection = myConnection;
            myCommand.CommandText = commandString;
            myConnection.Open(); //
            OracleDataReader MR;
            MR = myCommand.ExecuteReader();
            while (MR.Read())
            {
                ListViewItem item = new ListViewItem(MR[0].ToString());
                item.SubItems.Add(MR[1].ToString());
                item.SubItems.Add(MR[2].ToString());
                item.SubItems.Add(MR[3].ToString());
                item.SubItems.Add(MR[4].ToString());
                listView1.Items.Add(item);
            }
            MR.Close();
            myConnection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = "User id=hong1; Password=1111; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL =TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = xe)) ); ";
            OracleConnection myConnection = new OracleConnection(connectionString);
            string commandString = "select * from BOOK";
            OracleCommand myCommand = new OracleCommand();
            myCommand.Connection = myConnection;
            myCommand.CommandText = commandString;
            OracleDataAdapter DBAdapter = new OracleDataAdapter();
            DBAdapter.SelectCommand = myCommand;
            DataSet DS = new DataSet();
            DBAdapter.Fill(DS, "RelTable"); //
            DataTable RelTable = DS.Tables["RelTable"];
            DataRowCollection rows = RelTable.Rows;
            foreach (DataRow dr in rows)
            {
                ListViewItem item = new ListViewItem(dr[0].ToString());
                for (int i = 1; i < RelTable.Columns.Count; i++)
                {
                    item.SubItems.Add(dr[i].ToString());
                }
                listView3.Items.Add(item);
            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            main frm5 = new main();
            frm5.Owner = this;
            frm5.ShowDialog();
            frm5.Dispose();
        }
  
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

   
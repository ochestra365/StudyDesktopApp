using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressInfoApp
{
    public partial class FrmMain : Form
    {
        string connString = "Data Source=127.0.0.1;Initial Catalog=PMS;Persist Security Info=True;" +
            "User ID=sa; Password=mssql_p@ssw0rd!";

        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearInput();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            int.TryParse(TxtIdx.Text, out int result);
            if (result == 0)
            {
                MessageBox.Show("수정하려면 데이터를 선택.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connString))
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                string query = $"UPDATE Address " +
                    $" SET " +
                    $" FullName = '{TxtFullName.Text}', " +
                    $" Mobile = '{MskMobile.Text.Replace("-", "")}'," +
                    $" Addr = '{TxtAddr.Text}'," +
                    $" ModID =  'admin', " +
                    $" ModDate = GETDATE() " +
                    $" WHERE Idx = {result} ";

                SqlCommand cmd = new SqlCommand(query, conn);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("수정 성공");
                }
                else
                {
                    MessageBox.Show("수정 실패!");
                }
                // sql 연결과 명령을 해주는 절차가 하나의 메서드에 포함된다.
            }
            ClearInput();
            RefreshData();
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            int.TryParse(TxtIdx.Text, out int result);
            if (result > 0)
            {
                MessageBox.Show("초기화를 하십시오.");
                return;
            }

            if (string.IsNullOrEmpty(TxtFullName.Text) || string.IsNullOrEmpty(MskMobile.Text))
            {
                MessageBox.Show("값을 입력하세요.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connString))
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                string query = $"INSERT INTO dbo.Address " +
                               $" ( FullName, " +
                               $" Mobile, " +
                               $" Addr, " +
                               $" RegId, " +
                               $" RegDate) " +
                               $" VALUES " +
                               $" ( '{TxtFullName.Text}'," +
                               $"  '{MskMobile.Text.Replace("-", "")}'," +
                               $"  '{TxtAddr.Text}'," +
                               $"  'admin', " +
                               $"  GETDATE()  );  ";
                //보안적으로 큰 문제가 생길 수 있기 때문에 Secure Coding이 필요하다.
                //쿼리에 넣을 때는 SSMS의 속성값을 적어줘야 한다.
                SqlCommand cmd = new SqlCommand(query, conn);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("입력 성공");
                }
                else
                {
                    MessageBox.Show("입력 실패");
                }
            }
            RefreshData();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int.TryParse(TxtIdx.Text, out int result);
            if(result==0)
            {
                MessageBox.Show("삭제하려면 데이터를 선택");
                return;
            }

            using(SqlConnection conn=new SqlConnection(connString))
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                string query = $"DELETE FROM Address WHERE idx = {result}";

                SqlCommand cmd = new SqlCommand(query, conn);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("삭제 성공");
                }
                else
                {
                    MessageBox.Show("삭제 실패!");
                }
            }
            ClearInput();
            RefreshData();
        }

        private void TxtFullName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)//엔터
            {
                MskMobile.Focus();
            }
        }

        private void MskMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)//엔터
            {
                TxtAddr.Focus();
            }
        }

        private void TxtAddr_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            RefreshData();
            ClearInput();
        }

        private void RefreshData()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                //SSMS 테이블 스크립팅 메뉴 활용하기
                string query = "SELECT  Idx" +
                               "      , FullName " +
                               "       , Mobile  " +
                               "         , Addr  " +
                               "   FROM dbo.Address ";

                //반드시 쿼리 앞뒤에 여백이 있어야 한다.
                //SqlCommand cmd = new SqlCommand(query, conn);
                //SqlCommand, SqlDataReader or Object 사용방법 1
                //SqlDataAdapter, DataSet
                //Adapter를 쓰게 되면 복잡한 내용을 쓸 필요 없이 바로 쓸 수 있다.
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds);

                DgvAddress.DataSource = ds.Tables[0];
            }
        }

        private void ClearInput()
        {
            TxtIdx.Text = TxtFullName.Text = MskMobile.Text = TxtAddr.Text = "";
        }

        private void DgvAddress_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var selData = DgvAddress.Rows[e.RowIndex].Cells;

            TxtIdx.Text = selData[0].Value.ToString();
            TxtFullName.Text = selData[1].Value.ToString();
            MskMobile.Text = selData[2].Value.ToString();
            TxtAddr.Text = selData[3].Value.ToString();
        }
    }
}

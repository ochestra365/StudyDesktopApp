using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BookRentalShopApp
{
    public partial class FrmLogin : MetroForm
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            var strUserId = "";
            //MessageBox.Show("로그인 처리");
            if (string.IsNullOrEmpty(TxtUserId.Text) || string.IsNullOrEmpty(TxtPassword.Text))
            {
                MetroMessageBox.Show(this, "아이디/패스워드를 입력하세요", "오류",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                //SqlConnection 연결
                using (SqlConnection conn = new SqlConnection(Helper.Common.ConnString))//어떤 솔루션이든 지 공통으로 쓸 값들은 Static으로 따로 빼서 사용한다.
                {
                    if (conn.State == ConnectionState.Closed) conn.Open();

                    var query = "SELECT userID FROM membertbl " +
                        " WHERE userID = @userID " +
                        " AND passwords = @passwords " +
                        " AND levels = 'S' ";

                    //SqlCommand 생성
                    SqlCommand cmd = new SqlCommand(query, conn);
                    //SQLInjection 해킹 막기 위해서 사용하는 부분이다.
                    SqlParameter pUserID = new SqlParameter("@userId", SqlDbType.VarChar, 20);
                    pUserID.Value = TxtUserId.Text;
                    cmd.Parameters.Add(pUserID);

                    SqlParameter pPasswords = new SqlParameter("@passwords", SqlDbType.VarChar, 20);
                    pPasswords.Value = TxtPassword.Text;
                    cmd.Parameters.Add(pPasswords);
                    //sql Injection을 방어하기 위한 것이다. 파라미터를 생성해서 사용한다.
                    //Secure Coding
            
                    SqlDataReader reader = cmd.ExecuteReader();
                    //reader로 처리..
                    reader.Read();
                    strUserId = reader["userID"] != null ? reader["userID"].ToString() : "";
                    reader.Close();//1
                    // 확인MessageBox.Show(strUserId);
                    if (string.IsNullOrEmpty(strUserId))
                    {
                        MetroMessageBox.Show(this, "접속실패", "로그인실패", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        var updateQuery = $@"UPDATE membertbl SET
                                              lastLoginDt = GETDATE()
                                              ,loginIpAddr = '{Helper.Common.GetLocalIP()}';   
                                              WHERE userId ='{strUserId}' ";//로그인 정보 남기기
                        cmd.CommandText = updateQuery;
                        cmd.ExecuteNonQuery();
                        MetroMessageBox.Show(this, "접속성공", "로그인실패", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();//닫아주고 메인 화면만 쓸 수 있게 해주는 것이다!
                    }
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, $"Error: {ex.Message}", "오류",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void BtnCancle_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);//완전 종료
        }

        private void TxtUserId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) TxtPassword.Focus();
        }
        private void TxtPassword_Click(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) BtnLogin_Click(sender, e);
        }
    }
}
//연결string이 가장 중요하다.
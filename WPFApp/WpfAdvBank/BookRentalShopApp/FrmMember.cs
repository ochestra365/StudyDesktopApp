using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BookRentalShopApp
{
    public partial class FrmMember : MetroForm
    {
        #region 전역변수
        private bool IsNew { get; set; }//수정, false 신규
        #endregion 전역변수 영역
        
       


        #region 이벤트 영역
        public FrmMember()
        {
            InitializeComponent();
        }

        private void FrmMember_Load(object sender, EventArgs e)
        {
            IsNew = true; // 신규 초기화
            RefreshData();
        }
        private void FrmDivCode_Resize(object sender, EventArgs e)
        {
            DgvData.Height = this.ClientRectangle.Height - 90;
            GrbDetail.Height = this.ClientRectangle.Height - 90;
        }
        private void DgvData_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)//선택된 값이 존재하면
            {
                var selData = DgvData.Rows[e.RowIndex];
                TxtIdx.Text = selData.Cells[0].Value.ToString();
                TxtNames.Text = selData.Cells[1].Value.ToString();
                CboLevels.SelectedItem = selData.Cells[2].Value;

                TxtAddr.Text = selData.Cells[3].Value.ToString();
                TxtMobile.Text = selData.Cells[4].Value.ToString();
                TxtEmail.Text = selData.Cells[5].Value.ToString();
                TxtUserId.Text = selData.Cells[6].Value.ToString();
                TxtIdx.ReadOnly = true;
                IsNew = false;
            }
        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (CheckValidation() == false) return;

            if (MessageBox.Show(this, "삭제?", "삭제", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            DeleteData();
            RefreshData();
            ClearInput();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            ClearInput();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (CheckValidation() == false) return;
            //Validation 체크(유효성 체크)개발자가 알아야 할 역할 중 하나이다.
            SaveData();
            RefreshData();
            ClearInput();
        }

        #endregion
        #region 사용자 영역
        /// <summary>
        /// 삭제처리 프로세스
        /// </summary>
        private void DeleteData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Helper.Common.ConnString))
                {
                    if (conn.State == ConnectionState.Closed) conn.Open();//연결이 닫혀 있다면 연결을 뚫어라
                    SqlCommand cmd = new SqlCommand();//cmd라는 것은 sql 명령의 집합체이다.
                    cmd.Connection = conn;//해당 명령 중 연결이라는 것을 conn에 할당한다.

                    var query = "";
                        query = " DELETE INTO [dbo].[membertbl] " +
                                " WHERE [Idx]=@Idx ";
                        cmd.CommandText = query;

                    var pIdx = new SqlParameter("@Idx", SqlDbType.Int);
                    pIdx.Value = TxtNames.Text;
                    cmd.Parameters.Add(pIdx);

                    var result = cmd.ExecuteNonQuery();
                    if (result == 1)
                    {
                        MetroMessageBox.Show(this, "삭제 성공", "삭제", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "삭제 실패", "삭제", MessageBoxButtons.OK,
                             MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, $"예외발생 : {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void RefreshData()//화면 조회시 사용하는 것.
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Helper.Common.ConnString))//파라미터를 핼퍼 폴더를 통해서 연결해준다.(파라미터 뿐만이 아니라 자세한 지시사항도 해당되는 듯하다.)
                {
                    if (conn.State == ConnectionState.Closed) conn.Open();
                    //버바킹 스크립팅은 @를 붙여서 문자열로 만들어 주는 것이다.
                    var query = @"SELECT [Idx]
                                          ,[Names]
                                          ,[Levels]
                                          ,[Addr]
                                          ,[Mobile]
                                          ,[Email]
                                          ,[userID]
                                          ,[lastLoginDt]
                                          ,[loginIpAddr]
                                      FROM [dbo].[membertbl]";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "membertbl");

                    DgvData.DataSource = ds;
                    DgvData.DataMember = "membertbl";
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, $"예외발생 : {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //사용자 편의를 위해 가장 많이 쓸 항목이다.
            }
        }
        private void SaveData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Helper.Common.ConnString))
                {
                    if (conn.State == ConnectionState.Closed) conn.Open();//연결이 닫혀 있다면 연결을 뚫어라
                    SqlCommand cmd = new SqlCommand();//cmd라는 것은 sql 명령의 집합체이다.
                    cmd.Connection = conn;//해당 명령 중 연결이라는 것을 conn에 할당한다.
                    var query = "";
                    if (IsNew == true) // ISNERT
                    {
                        query = @"INSERT INTO [dbo].[membertbl]
                                       ([Names]
                                       ,[Levels]
                                       ,[Addr]
                                       ,[Mobile]
                                       ,[Email]
                                       ,[userID]
                                       ,[passwords])
                                 VALUES
                                       (@Names
                                       ,@Levels
                                       ,@Addr
                                       ,@Mobile
                                       ,@Email
                                       ,@userID
                                       ,@passwords) ";
                    }
                    else //UPDATE
                    {
                        query = @"UPDATE [dbo].[membertbl]
                                       SET [Names] = @Names
                                          ,[Levels] = @Levels
                                          ,[Addr] = @Addr
                                          ,[Mobile] = @Mobile
                                          ,[Email] = @Email
                                          ,[userID] = @userID
                                          ,[passwords] = @passwords
                                     WHERE Idx = @Idx ";
                    }
                    cmd.CommandText = query;

                    var pNames = new SqlParameter("@Names", SqlDbType.NVarChar, 50);
                    pNames.Value = TxtNames.Text;
                    cmd.Parameters.Add(pNames);

                    var pLevels = new SqlParameter("@Levels", SqlDbType.Char, 1);
                    pLevels.Value = CboLevels.SelectedItem.ToString();
                    cmd.Parameters.Add(pLevels);

                    var pAddr = new SqlParameter("@Addr", SqlDbType.NVarChar, 100);
                    pAddr.Value = TxtAddr.Text;
                    cmd.Parameters.Add(pAddr);

                    var pMobile = new SqlParameter("@Mobile", SqlDbType.NVarChar, 13);
                    pMobile.Value = TxtMobile.Text;
                    cmd.Parameters.Add(pMobile);

                    var pEmail = new SqlParameter("@Email", SqlDbType.VarChar, 50);
                    pEmail.Value = TxtEmail.Text;
                    cmd.Parameters.Add(pEmail);

                    var pUserId = new SqlParameter("@userId", SqlDbType.VarChar, 20);
                    pUserId.Value = TxtUserId.Text;
                    cmd.Parameters.Add(pUserId);

                    var pPasswords = new SqlParameter("@passwords", SqlDbType.VarChar, 100);
                    pPasswords.Value = TxtPasswords.Text;
                    cmd.Parameters.Add(pPasswords);

                    var pIdx = new SqlParameter("@Idx", SqlDbType.Int);
                    pIdx.Value = TxtIdx.Text;
                    cmd.Parameters.Add(pIdx);

                    if (IsNew == false) // Update 일때만 처리
                    {
                        var pIdx = new SqlParameter("@Idx", SqlDbType.Int);
                        pIdx.Value = TxtIdx.Text;
                        cmd.Parameters.Add(pIdx);
                    }

                    var result = cmd.ExecuteNonQuery();
                    if (result == 1)
                    {
                        MetroMessageBox.Show(this, "저장 성공", "저장",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "저장 실패", "저장",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, $"예외발생 : {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearInput()//여기서 오류발생함!! 
        {
            TxtIdx.Text = TxtNames.Text = "";
            TxtMobile.Text = TxtAddr.Text = TxtEmail.Text = "";
            TxtUserId.Text = "";
            TxtPasswords.Text = "";
            CboLevels.SelectedIndex = -1;
            TxtIdx.ReadOnly = true;
            IsNew = true;
        }

        private bool CheckValidation()
        {
            if (string.IsNullOrEmpty(TxtIdx.Text) || string.IsNullOrEmpty(TxtNames.Text) ||
                string.IsNullOrEmpty(TxtAddr.Text) || string.IsNullOrEmpty(TxtMobile.Text) ||
                string.IsNullOrEmpty(TxtEmail.Text) || CboLevels.SelectedIndex == -1 ||
                string.IsNullOrEmpty(TxtUserId.Text))
            {
                MetroMessageBox.Show(this, "빈값삭제불가", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

       

      

      
        #endregion


    }
}
//값을 구분할 수 있게 가장 많이 쓰는 값은 flag이다.
//region과 endregion으로 캡슐화 해준다.

/*
 INSERT INTO [dbo].[membertbl]
           ([Names]
           ,[Levels]
           ,[Addr]
           ,[Mobile]
           ,[Email]
           ,[userID]
           ,[passwords]
           ,[lastLoginDt]
           ,[loginIpAddr])
     VALUES
           (@Names
           ,@Levels
           ,@Addr
           ,@Mobile
           ,@Email
           ,@userID
           ,@passwords*/
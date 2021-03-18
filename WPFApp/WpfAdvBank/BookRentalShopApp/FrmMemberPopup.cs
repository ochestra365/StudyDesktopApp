using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BookRentalShopApp
{
    public partial class FrmMemberPopup : MetroForm
    {
        public int SelIdx { get; set; }
        public string SellName { get; set; }

        #region 전역변수
        private bool IsNew { get; set; }//수정, false 신규
        #endregion 전역변수 영역
        #region 이벤트 영역
        public FrmMemberPopup()
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
            
        }
        private void DgvData_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
           

            if (MessageBox.Show(this, "삭제?", "삭제", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            DeleteData();
            RefreshData();
         
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            //Validation 체크(유효성 체크)개발자가 알아야 할 역할 중 하나이다.
            
            RefreshData();
            
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

            DgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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
        #endregion

        private void BtnSearchMember_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            if(DgvData.SelectedRows.Count==0)
            {
                MetroMessageBox.Show(this, "데이터를 선택하세요", "경고",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            SelIdx = (int)DgvData.SelectedRows[0].Cells[0].Value;
            SellName = DgvData.SelectedRows[0].Cells[1].ToString();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

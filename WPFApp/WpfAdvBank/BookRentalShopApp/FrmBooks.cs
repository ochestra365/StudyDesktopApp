using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BookRentalShopApp
{
    public partial class FrmBooks : MetroForm
    {
        #region 전역변수
        private bool IsNew { get; set; }//수정, false 신규
        #endregion 전역변수 영역

        #region 이벤트 영역
        public FrmBooks()
        {
            InitializeComponent();
        }

        private void FrmBooks_Load(object sender, EventArgs e)
        {
            IsNew = true; // 신규 초기화
            InitCboData();//콤보박스 들어가는 데이터 초기화
            RefreshData();

            DtpReleaseDate.CustomFormat = "yyyy-MM-dd";
            DtpReleaseDate.Format = DateTimePickerFormat.Custom;
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
                AsignToControls(selData);
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
        private void InitCboData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Helper.Common.ConnString))//한쿼리창에서의 연산
                {
                    if (conn.State == ConnectionState.Closed) conn.Open();//연결상태가 닫혀있으면 열어라
                    var query = @"SELECT Division, Names FROM dbo.divtbl ";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    var temp = new Dictionary<string, string>();
                    while (reader.Read())
                    {
                        temp.Add(reader[0].ToString(), reader[1].ToString());//B001, 공포/스릴러//object형식을 string 문자타입으로 바꿔준다.
                    }
                    CboDivision.DataSource = new BindingSource(temp, null);
                    CboDivision.DisplayMember = "Value";
                    CboDivision.ValueMember = "Key";
                    CboDivision.SelectedIndex = -1;
                }
            }
            catch { }
        }
        private void AsignToControls(DataGridViewRow selData)
        {
            TxtIdx.Text = selData.Cells[0].Value.ToString();
            TxtAuthor.Text = selData.Cells[1].Value.ToString();
            CboDivision.SelectedValue = selData.Cells[2].Value;//B001 = 값이 매칭된다.
            // sleData.Cell[3] X
            Cbobook.Text = selData.Cells[4].Value.ToString();
            // RealeseDate
            DtpReleaseDate.Value = (DateTime)selData.Cells[5].Value;
            TxtISBN.Text = selData.Cells[5].Value.ToString();
            TxtPrice.Text = selData.Cells[6].Value.ToString();
            TxtDescriptions.Text = selData.Cells[7].Value.ToString();
            TxtIdx.ReadOnly = true;
        }

        /// <summary>
        /// 삭제처리프로세스
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

                    var query = " DELETE INTO [dbo].[membertbl] " +
                                " WHERE [Idx]=@Idx ";
                    cmd.CommandText = query;


                    var pIdx = new SqlParameter("@Idx", SqlDbType.Int);
                    pIdx.Value = TxtIdx.Text;
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
                    var query = @"SELECT b.Idx
                                          ,b.Author
                                          ,d.Division
	                                      ,d.Names as DivName
                                          ,b.Names
                                          ,b.ReleaseDate
                                          ,b.ISBN
                                          ,b.Price
                                          ,b.Descriptions
                                      FROM dbo.bookstbl as b
                                      INNER JOIN dbo.divtbl as d
                                        ON b.Division=d.Divisio"; // 210318 Descriptions 컬럼추가
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "bookstbl");

                    DgvData.DataSource = ds;
                    DgvData.DataMember = "bookstbl";
                }
            }

            catch (Exception ex)
            {
                MetroMessageBox.Show(this, $"예외발생 : {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //사용자 편의를 위해 가장 많이 쓸 항목이다.
            }

            //데이터그리드뷰 컬럼 화면에서 안 보이게
            var column = DgvData.Columns[2];//Division 컬럼
            column.Visible = false;
            column = DgvData.Columns[8];// Descriptions
            column.Visible = false;

            column = DgvData.Columns[4];
            column.Width = 250;
            column.HeaderText = "도서명";

            column = DgvData.Columns[0];
            column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }
        /// <summary>
        /// 입력(수정)처리 프로세스
        /// </summary>
        /// 
        private void SaveData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Helper.Common.ConnString))
                {
                    if (conn.State == ConnectionState.Closed) conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;

                    var query = "";

                    if (IsNew == true) // ISNERT
                    {
                        query = @"INSERT INTO [dbo].[bookstbl]
                                       ([Author]
                                       ,[Division]
                                       ,[Names]
                                       ,[ReleaseDate]
                                       ,[ISBN]
                                       ,[Price]
                                       ,[Descriptions])
                                 VALUES
                                       (@Author
                                       ,@Division
                                       ,@Names
                                       ,@ReleaseDate
                                       ,@ISBN
                                       ,@Price
                                       ,@Descriptions) ";
                    }
                    else // UPDATE
                    {
                        query = @"UPDATE [dbo].[bookstbl]
                                       SET [Author] = @Author
                                          ,[Division] = @Division
                                          ,[Names] = @Names
                                          ,[ReleaseDate] = @ReleaseDate
                                          ,[ISBN] = @ISBN
                                          ,[Price] = @Price
                                          ,[Descriptions] = @Descriptions
                                     WHERE Idx = @Idx ";
                    }
                    cmd.CommandText = query;

                    var pAuthor = new SqlParameter("@Author", SqlDbType.NVarChar, 50);
                    pAuthor.Value = TxtAuthor.Text;
                    cmd.Parameters.Add(pAuthor);

                    var pDivision = new SqlParameter("@Division", SqlDbType.VarChar, 8);
                    pDivision.Value = CboDivision.SelectedValue; // B001
                    cmd.Parameters.Add(pDivision);

                    var pNames = new SqlParameter("@Names", SqlDbType.NVarChar, 100);
                    pNames.Value = TxtAuthor.Text;
                    cmd.Parameters.Add(pNames);

                    var pReleaseDate = new SqlParameter("@ReleaseDate", SqlDbType.Date);
                    pReleaseDate.Value = DtpReleaseDate.Value;
                    cmd.Parameters.Add(pReleaseDate);

                    var pISBN = new SqlParameter("@ISBN", SqlDbType.VarChar, 200);
                    pISBN.Value = TxtISBN.Text;
                    cmd.Parameters.Add(pISBN);

                    var pPrice = new SqlParameter("@Price", SqlDbType.Decimal);
                    pPrice.Value = TxtPrice.Text;
                    cmd.Parameters.Add(pPrice);

                    var pDescriptions = new SqlParameter("@Descriptions", SqlDbType.NVarChar);
                    pDescriptions.Value = TxtDescriptions.Text;
                    cmd.Parameters.Add(pDescriptions);

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
                MetroMessageBox.Show(this, $"예외발생 : {ex.Message}", "오류", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// 입력값유효성 체크 메서드
        /// </summary>
        private bool CheckValidation()
        {
            if (
                string.IsNullOrEmpty(TxtAuthor.Text) ||
                string.IsNullOrEmpty(Cbobook.Text) ||
                  //string.IsNullOrEmpty(TxtMobile.Text) ||
                  CboDivision.SelectedIndex == -1 ||
               DtpReleaseDate.Value == null)
            {
                MetroMessageBox.Show(this, "빈값삭제불가", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void ClearInput()
        {
            TxtIdx.Text = TxtAuthor.Text = "";
            TxtAuthor.Text = TxtISBN.Text = "";
            TxtPrice.Text = TxtDescriptions.Text = "";
            CboDivision.SelectedIndex = -1; // ?
            DtpReleaseDate.Value = DateTime.Now; // 오늘 날짜로 초기화
            TxtIdx.ReadOnly = true;
            IsNew = true;
        }
        #endregion
    }
}
/*FrmBooks에서 오류가 가장 많이 누적됨. 나머지는 디버깅(그래봐야.. 소스코드 복붙) 해보았다.
cs0136 에러는 지역변수명을 연산에 중첩해서 사용할 수 없을 때 발생함
FrmBooks 점심시간에 선생님 코드보고 고쳐볼것.
오히려 미니 프로젝트나 회사에서 이러한 실수를 할 수 있었는 데 미리 잡을 수 있어서 다행으로 생각하자
로그인 화면이 안 뜨는 것도 잡아 보아야 한다.
잘못된 프로젝트를 생성해놓고 따라가면 일이 엄청나게 꼬여버리게 됨. */
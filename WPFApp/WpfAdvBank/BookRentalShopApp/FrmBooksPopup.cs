using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BookRentalShopApp
{
    public partial class FrmBooksPopup : MetroForm
    {
        #region 전역변수
      
        #endregion 전역변수 영역

        #region 이벤트 영역
        public FrmBooksPopup()
        {
            InitializeComponent();
        }

        private void FrmBooks_Load(object sender, EventArgs e)
        {
            RefreshData();

        }
        private void FrmDivCode_Resize(object sender, EventArgs e)
        {
        }
        private void DgvData_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)//선택된 값이 존재하면
            {
                var selData = DgvData.Rows[e.RowIndex];
            }
        }
        #endregion
        #region 사용자 영역
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
        #endregion
    }
}
/*FrmBooks에서 오류가 가장 많이 누적됨. 나머지는 디버깅(그래봐야.. 소스코드 복붙) 해보았다.
cs0136 에러는 지역변수명을 연산에 중첩해서 사용할 수 없을 때 발생함
FrmBooks 점심시간에 선생님 코드보고 고쳐볼것.
오히려 미니 프로젝트나 회사에서 이러한 실수를 할 수 있었는 데 미리 잡을 수 있어서 다행으로 생각하자
로그인 화면이 안 뜨는 것도 잡아 보아야 한다.
잘못된 프로젝트를 생성해놓고 따라가면 일이 엄청나게 꼬여버리게 됨. */
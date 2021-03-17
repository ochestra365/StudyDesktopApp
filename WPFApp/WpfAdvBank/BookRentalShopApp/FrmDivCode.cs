using MetroFramework;
using MetroFramework.Forms;
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

namespace BookRentalShopApp
{
    public partial class FrmDivCode : MetroForm
    {
        private bool IsNew { get; set; }//수정, false 신규

        public FrmDivCode()
        {
            InitializeComponent();
        }

        private void FrmDivCode_Load(object sender, EventArgs e)
        {
            IsNew = true;//신규로 
            RefreshData();
        }

        private void RefreshData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Helper.Common.ConnString))
                {
                    if (conn.State == ConnectionState.Closed) conn.Open();

                    var query = "SELECT [Division]" +
                        "  , [Names] " +
                        " FROM [dbo].[divtbl] ";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "divtbl");

                    DgvData.DataSource = ds;
                    DgvData.DataMember = "divtbl";
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, $"예외발생 : {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //사용자 편의를 위해 가장 많이 쓸 항목이다.
            }
        }

        private void FrmDivCode_Resize(object sender, EventArgs e)
        {
            DgvData.Height = this.ClientRectangle.Height - 90;
            GrbDetail.Height = this.ClientRectangle.Height - 90;
        }

        private void DgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > -1)//선택된 값이 존재하면
            {
                var selData=DgvData.Rows[e.RowIndex];
                TxtDivision.Text = selData.Cells[0].Value.ToString();
                TxtNames.Text = selData.Cells[1].Value.ToString();
                TxtDivision.ReadOnly = true;

                IsNew = false;//수정
            }
        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {

        }

        private void BtnNew_Click(object sender, EventArgs e)
        {

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtDivision.Text) || string.IsNullOrEmpty(TxtNames.Text))
            {
                MetroMessageBox.Show(this, "빈값을 저장 불가", "경고",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using(SqlConnection conn = new SqlConnection(Helper.Common.ConnString))
                {
                    if (conn.State == ConnectionState.Closed) conn.Open();//연결이 닫혀 있다면 연결을 뚫어라
                    SqlCommand cmd = new SqlCommand();//cmd라는 것은 sql 명령의 집합체이다.
                    cmd.Connection = conn;//해당 명령 중 연결이라는 것을 conn에 할당한다.
                    var query = "UPDATE [dbo].[divtbl]" +
                        " SET [Names] = @Names " +
                        " WHERE [Division] = @Division ";//쿼리 날린다.
                    cmd.CommandText = query;

                    SqlParameter pNames = new SqlParameter("@Names", SqlDbType.NVarChar, 45);
                    pNames.Value = TxtNames.Text;
                    cmd.Parameters.Add(pNames);

                    SqlParameter pDivision = new SqlParameter("@Division", SqlDbType.NVarChar, 8);
                    pDivision.Value = TxtNames.Text;
                    cmd.Parameters.Add(pDivision);

                    var result = cmd.ExecuteNonQuery();
                    if (result == 1)
                    {
                        //저장성공
                    }
                    else
                    {
                       //저장실패
                    }
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, $"예외발생 : {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Validation 체크(유효성 체크)개발자가 알아야 할 역할 중 하나이다.
            
        }
    }
}
//값을 구분할 수 있게 가장 많이 쓰는 값은 flag이다.
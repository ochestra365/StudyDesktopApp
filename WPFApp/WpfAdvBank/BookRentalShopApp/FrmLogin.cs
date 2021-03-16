﻿using MetroFramework;
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

                    //SqlCommand 생성
                    SqlCommand cmd = new SqlCommand();
                    //SQLInjection 해킹 막기 위해서 사용하는 부분이다.
                    SqlParameter param;
                    //SqlDataReader 실행(1)
                    SqlDataReader reader = cmd.ExecuteReader();
                    //reader로 처리..
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
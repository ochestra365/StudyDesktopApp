using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfLoginApp
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        string connString = "Data Source=127.0.0.1;Initial Catalog=PMS;Persist Security Info=True;" +
            "User ID=sa; Password=mssql_p@ssw0rd!";//연결 문자열이 가장 중요하다.
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Initialized(object sender, EventArgs e)
        {
            TxtUserid.Focus();
        }

        private void TxtUserid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
                TxtPassword.Focus();
        }

        private void TxtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
                BtnLogin_Click(sender, e);
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connString))//sql커넥션
            {
                if (conn.State == System.Data.ConnectionState.Closed)//sql커맨드
                {
                    conn.Open();
                }
                try
                {
                    string query = $"SELECT count(*) " +
                                   $"  FROM Member" +
                                   $" WHERE UserId = '{TxtUserid.Text}' " +
                                   $"   AND Password = '{TxtPassword.Password}'; ";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    var result = Convert.ToInt32(cmd.ExecuteScalar());
                    //넣을 수 있는 값이 object밖에 되지않는다.
                    //그래서 스트링으로 object로 돌려받을 때는 parameter를 Object로 쓴다.
                    //쿼리문 날릴 떄, 띄어쓰기 매우 중요하다.
                    if (result == 1)
                        MessageBox.Show("로그인 성공");
                    else
                        MessageBox.Show("로그인 실패");
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"예외발생 : {ex}");
                    return;
                }
            }
        }
    }
}

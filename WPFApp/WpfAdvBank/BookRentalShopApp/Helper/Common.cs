using System;
using System.Net;

namespace BookRentalShopApp.Helper
{
    public static class Common//가장 최상위 메모리 스택에 있는 명령문으로 모든 App에 참조된다.
    {
        public static string ConnString = "Data Source=127.0.0.1;" +
            "Initial Catalog=bookrentalshop;" +
            "Persist Security Info=True;" +
            "User ID=sa;" +
            "Password=mssql_p@ssw0rd!";
        //주소를 포괄하여 참조할 수 있게 한다.
        public static string LoginUserId = string.Empty;//로그인 되는 내용이 항상 디폴트될 수 있게 해준다.
        /// <summary>
        /// 아이피주소 받아오는 메서드
        /// </summary>
        /// <returns></returns>
        internal static string GetLocalIP()
        {
            string localIP = "";
            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    localIP = ip.ToString();
                    break;
                }
            }

            return localIP;
        }
    }
}

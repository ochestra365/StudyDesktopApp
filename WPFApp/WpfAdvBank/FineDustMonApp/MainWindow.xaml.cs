using MahApps.Metro.Controls;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows;
using System.Xml;

namespace FineDustMonApp
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        private readonly string excelPath = $@"{AppDomain.CurrentDomain.BaseDirectory}busan_station_list.xls";
        private string openApiUrl = "http://apis.data.go.kr/B552584/ArpltnInforInqireSvc/getMsrstnAcctoRltmMesureDnsty?" +
            "serviceKey=cbuOX7pcf5ks83BOnRHQuesdDZ446xEaHEr5az1XlAcQkkO1YS7LDBD1zEs4YkwqWx0IKRh8G%2FUXmQUYaHkP0Q%3D%3D&" +//서비스 키는 본인의 것이다.
            "returnType=xml&" +
            "numOfRows=100&pageNo=1&" +
            "ver=1.0&"+
            "stationName=";
        //요런 형식으로 바꿔주고, stationName만 읽는 형식으로 고쳐줘야 한다.
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MetroWindow_Loaded(object sender, RoutedEventArgs e)
        {
            //엑셀파일에서 측정소 가져오기
            IWorkbook wb = null;
            ISheet sh = null;

            using(FileStream fs = new FileStream(excelPath, FileMode.Open, FileAccess.Read))//경로 설정, 경로 열고, 경로 읽는다.
            {
                wb = new HSSFWorkbook(fs);
            }

            List<string> lstLabs = new List<string>();//컬렉션 생성

            sh = wb.GetSheetAt(0);//시트 1번에서 데이터를 읽어온다.
            int rowCount = sh.LastRowNum;//마지막까지 행값을 읽는다.

            try
            {
                for (int r = 0; r < rowCount; r++)
                {
                    if (r == 0) continue;
                    lstLabs.Add(sh.GetRow(r).Cells[1].ToString());//리스트에 행들을 다 읽어서 넣어주겠따.ㅇ

                }
                CboStations.ItemsSource = lstLabs;
            }
            catch (Exception ex)
            {
            }
        }

        private void CboStations_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if(CboStations.SelectedItem!=null)//컬랙션에서 선택된 값들이 빈값이 아니면 아래의 로직을 실행한다.
            {
                openApiUrl += CboStations.SelectedItem.ToString();//문자열로 다 날린다.
                XmlDocument xml = new XmlDocument();
                xml.Load(openApiUrl);
                XmlNodeList xnList = xml.SelectNodes("/response/body/items");//xml의 body 부분만 사용해라 head부분은 필요없다.

                foreach (XmlNode item in xnList)
                {
                    //Debug.WriteLine($"dateTime : {item["datetime"].InnerText}");-->시간을 잘 불러오는 가 확인해본 구문이다.
                }
            }
        }

        private List<FineDustInfo> lstResult;
    }
}

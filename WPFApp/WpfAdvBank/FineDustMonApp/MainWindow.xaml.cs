using MahApps.Metro.Controls;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;

namespace FineDustMonApp
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        private readonly string excelPath = $@"{AppDomain.CurrentDomain.BaseDirectory}busan_station_list.xls";

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
          

            for (int r = 0; r < rowCount; r++)
            {
                if (r == 0) continue;
                lstLabs.Add(sh.GetRow(r).Cells[1].ToString());//리스트에 행들을 다 읽어서 넣어주겠따.
                CboStations.ItemsSource = lstLabs;
            }
        }
    }
}

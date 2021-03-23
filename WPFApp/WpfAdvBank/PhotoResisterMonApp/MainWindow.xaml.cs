﻿using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
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
using LiveCharts;
using LiveCharts.Wpf;
using System.Threading;
using System.Windows.Threading;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Data;

namespace PhotoResisterMonApp
{
    public class SensorData
    {
        public int Idx { get; set; }
        public DateTime CurrentDt { get; set; }
        public int Value { get; set; }
        public bool SimulFlag { get; set; }

        public SensorData(int idx, DateTime currentDt, int value, bool simulFlag)
        {
            Idx = idx;
            CurrentDt = currentDt;
            Value = value;
            SimulFlag = simulFlag;
        }
    }
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public ChartValues<int> ChartValues { get;set; }

        public int SensorValue { get; set; }

        public DispatcherTimer CustomTimer { get; set; }

        private string connString = "Data Source=127.0.0.1;" +
                                    "Initial Catalog=IoTData;" +
                                    "Persist Security Info=True;" +
                                    "User ID=sa;Password=mssql_p@ssw0rd!";

        public SensorData GetRealTimeSensor()
        {

            SensorData result = null;
            
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    if (conn.State == System.Data.ConnectionState.Closed) conn.Open();

                    var query = @"SELECT TOP 1 Idx
                                          ,CurrentDt
                                          ,Value
                                          ,SimulFlag
                                      FROM Tbl_PhotoResister
                                      ORDER BY Idx DESC;";

                    SqlCommand cmd = new SqlCommand(query, conn);//conn에 있는 쿼리를 사용하겠다.
                    var temp = cmd.ExecuteReader();
                    if (temp.Read())
                    {
                        result = new SensorData(Convert.ToInt32(temp["Idx"]), 
                                                Convert.ToDateTime(temp["CurrentDt"]),
                                                Convert.ToInt32( temp["Value"]),
                                                Convert.ToBoolean(temp["SimulFlag"]));
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"예외발생: {ex.Message}");
            }

            return result;
        }


        private void Window_Initialized(object sender, EventArgs e)
        {
            //var x = Enumerable.Range(0, 1001).Select(i => i / 10.0).ToArray();
            //var y = x.Select(v => Math.Abs(v) < 1e-1 ? 1 : Math.Sin(v) / v).ToArray();
            //ChtLine.Plot(x, y);
            ChartValues = new ChartValues<int>();// { 5, 8, 3, 2, 5, 3, 9 };
            GrdHistory.DataContext = ChartValues;

            CustomTimer = new DispatcherTimer();
            CustomTimer.Interval = TimeSpan.FromSeconds(1);
            CustomTimer.Tick += CustomTimer_Tick;
            //CustomTimer.Start();
        }

        private void CustomTimer_Tick(object sender, EventArgs e)//db 연동
        {
            GrdRealTime.DataContext = GetRealTimeSensor().Value;//new Random().Next(0, 1023);
        }

        private void MnuStart_Click(object sender, RoutedEventArgs e)
        {
            CustomTimer.Start();
        }

        private void MnuStop_Click(object sender, RoutedEventArgs e)
        {
            CustomTimer.Stop();
        }

        private void MnuExit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void MnuLoad_Click(object sender, RoutedEventArgs e)
        {
            ChartValues= GetHistorySensors();
            GrdHistory.DataContext = ChartValues;
        }

        private ChartValues<int> GetHistorySensors()
        {
            ChartValues<int> result = new ChartValues<int>();
            try
            {
                using(SqlConnection conn = new SqlConnection(connString))
                {
                    if (conn.State == System.Data.ConnectionState.Closed) conn.Open();

                    var query = $@"SELECT Value
                                        FROM Tbl_PhotoResister
                                      WHERE CurrentDt > CONVERT(DATETIME, '{DateTime.Now.ToString("yyyy-MM-dd")}')
                                      ORDER BY Idx;";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        result.Add(Convert.ToInt32(reader[0]));
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"예외 발생 : {ex.Message}");
            }
            return result;
        }
    }
}

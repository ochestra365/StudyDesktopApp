using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace IoTSensorMonApp
{
    public partial class FrmMain : Form
    {
        private Timer timerSimul = new Timer();
        private Random randPhoto = new Random();
        private bool IsSimulation = false;
        private List<SensorData> sensors = new List<SensorData>();//차트, 리스트박스에 계속 출력됨.
        private double xCount = 200;//차트에 보이는 데이터 수.
        private string connString = " Data Source=127.0.0.1; " +
                                    " Initial Catalog=IoTData; " +
                                    " Persist Security Info=True; " +
                                    " User ID=sa; " +
                                    " Password=mssql_p@ssw0rd!" ;
        public FrmMain()
        {
            InitializeComponent();
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            //ComboBox 초기화(로직부분)
            foreach (var port in SerialPort.GetPortNames())//내 컴퓨터에서 사용하고 있지 않은 포트까지 다 나온다.
            {
                CboSeriealPort.Items.Add(port);//?
            }
            CboSeriealPort.Text = "Select Port";

            //IoT 장비에서 받을 값의 범위
            PrbPhotoResister.Minimum = 0;
            PrbPhotoResister.Maximum =1023;
            PrbPhotoResister.Value = 0;
            //차트모양 초기화
            InitChartStyle();

            //BtnDisplay 초기화
            BtnDisplay.BackColor = Color.BlueViolet;
            BtnDisplay.ForeColor = Color.WhiteSmoke;
            BtnDisplay.Text = "NONE";
            BtnDisplay.Font = new Font("맑은 고딕", 14, FontStyle.Bold);

            //나머지 초기화
            LblConnecTime.Text = "Connection Time : ";
            TxtSenSorNumj.TextAlign = HorizontalAlignment.Right;
            TxtSenSorNumj.Text = "0";
            BtnConnect.Enabled = BtnDisconnect.Enabled = false;
        }
        /// <summary>
        /// 차트 초기설정-->초기화를 해주는 이유는 실제 데이터를 측량하고 연산이 끝난 후 디폴트 값으로 회귀할 로직이 필요하기 때문이다.
        /// </summary>
        private void InitChartStyle()//배열 (차트 관련 메모리 0번에 해당 스타일을 저장하는 것이다.)
        {
            ChtPhotoResisters.ChartAreas[0].BackColor = Color.Blue;
            ChtPhotoResisters.ChartAreas[0].AxisX.Minimum = 0;
            ChtPhotoResisters.ChartAreas[0].AxisX.Maximum = xCount;
            ChtPhotoResisters.ChartAreas[0].AxisX.Interval = xCount / 4;
            ChtPhotoResisters.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.WhiteSmoke;
            ChtPhotoResisters.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dash;//선 스타일, 현재 x축의 설정을 해주는 것이다.

            ChtPhotoResisters.ChartAreas[0].AxisY.Minimum = 0;
            ChtPhotoResisters.ChartAreas[0].AxisY.Maximum = 1024;
            ChtPhotoResisters.ChartAreas[0].AxisY.Interval = 200;
            ChtPhotoResisters.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.WhiteSmoke;
            ChtPhotoResisters.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash;

            ChtPhotoResisters.ChartAreas[0].CursorX.AutoScroll = true;
            ChtPhotoResisters.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            ChtPhotoResisters.ChartAreas[0].AxisX.ScrollBar.ButtonStyle = ScrollBarButtonStyles.SmallScroll;
            ChtPhotoResisters.ChartAreas[0].AxisX.ScrollBar.ButtonColor = Color.LightSteelBlue;

            ChtPhotoResisters.Series.Clear();//Series 1 값 삭제
            ChtPhotoResisters.Series.Add("PhotoValue");
            ChtPhotoResisters.Series[0].ChartType = SeriesChartType.Line;
            ChtPhotoResisters.Series[0].Color = Color.LightCoral;
            ChtPhotoResisters.Series[0].BorderWidth = 3;

            // 범례 삭제
            if (ChtPhotoResisters.Legends.Count > 0)
            {
                for (int i = 0; i < ChtPhotoResisters.Legends.Count; i++)
                {
                    ChtPhotoResisters.Legends.RemoveAt(i);
                }
            }
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            //TODO 나중에 실제 작업시 작성
        }

        private void BtnDisconnect_Click(object sender, EventArgs e)
        {
            //TODO 나중에 실제 작업시 작성
        }

        /// <summary>
        /// 시뮬레이션 시작
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MnuBeginSimulation_Click(object sender, EventArgs e)
        {
            IsSimulation = true;
            timerSimul.Enabled = true;
            timerSimul.Interval = 1000;//1초
            timerSimul.Tick += TimerSimul_Tick;
            timerSimul.Start();
        }

        private long timeSpan = 0;//시간흐름값
        private int randMaxVal = 0;//랜덤값을 담을 변수.
        //프로그레스바와 리스트, 차트에 기입해줘야 한다.
        private void TimerSimul_Tick(object sender, EventArgs e)//1초에 한번씩 데이터를 출력하는 것이다.
        {
            timeSpan += 1;
            var temp = timeSpan & 30;//10,11,12,29,30-->0

            if(temp.ToString().Length==2)
            {
                randMaxVal = 980;
            }
            else
            {
                randMaxVal = 120;
            }

            int value = randPhoto.Next(randMaxVal-40, 1023);//1부터 1023까지 사이의 값을 받는다.
            ShowSensorValue(value.ToString());//value값을 문자타입으로 넘겨준다.
        }
        /// <summary>
        /// 센서값 화면 출력
        /// </summary>
        private void ShowSensorValue(string value)//파라미터는 문자타입
        {
            int.TryParse(value, out int v);

            var currentTime = DateTime.Now;
            SensorData data = new SensorData(currentTime, v, IsSimulation);
            sensors.Add(data);
            InsertTable(data);

            // 센서값 갯수
            TxtSenSorNumj.Text = $"{sensors.Count}";
            //프로그레스바 현재값 출력
            PrbPhotoResister.Value = v;
            // 리스트박스에 데이터 출력
            var item = $"{currentTime.ToString("yyyy-MM-dd HH:mm:ss")}\t{v}";
            LsbPhotoResisters.Items.Add(item);
            LsbPhotoResisters.SelectedIndex = LsbPhotoResisters.Items.Count - 1;//스크롤로 마지막까지 감.
            //RealTime Task에서 스크롤로 내리는 것이 반드시 필요하다. 쓰레드의 Overflow개념이다.(-1)

            //차트에 데이터 출력-->흐르는 데이터는 항상 흘러줘야 한다. 출력은 잘된다.
            ChtPhotoResisters.Series[0].Points.Add(v);

            //200개 넘으면 
            ChtPhotoResisters.ChartAreas[0].AxisX.Minimum = 0;
            ChtPhotoResisters.ChartAreas[0].AxisX.Maximum = (sensors.Count >= xCount) ? sensors.Count : xCount;

            // Zoom 처리 
            if (sensors.Count > xCount)
                ChtPhotoResisters.ChartAreas[0].AxisX.ScaleView.Zoom(sensors.Count - xCount, sensors.Count);
            else
                ChtPhotoResisters.ChartAreas[0].AxisX.ScaleView.Zoom(0, xCount);

            // BtnDisplay 표시
            if (IsSimulation)
                BtnDisplay.Text = v.ToString();
            else
                BtnDisplay.Text = "~" + "\n" + v.ToString();
        }
        /// <summary>
        /// IoT데이터베이스 내에 있는 Tbl_PhotoResister 테이블에 센서데이터 입력
        /// </summary>
        /// <param name="data"></param>
        private void InsertTable(SensorData data)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))//sql과의 연결을 터준다.
                {
                    if (conn.State == ConnectionState.Closed)//파라미터의 상태값이 연결된 상태의 닫힌 값과 같으면
                        conn.Open();//참일 때 sql커넥션 연결을 튼다. 거짓은 필요없다. 오로지 측정된 참값만 넣으니까

                    var query = $" insert into Tbl_PhotoResister " +
                                $" (CurrentDt, value, SimulFlag) " +
                                $" values " +
                                $" ('{data.Current.ToString("yyyy-MM-dd HH:mm:ss")}','{data.Value}','{(data.SimulFlag==true ? "1" : "0")}'); ";
                    //sql로 옮기면서 해당 부분의 데이터 타입이 1,0 출력이 아닌 true,false부분으로 나뉜다.
                    //value뒷부분은 쿼리문에서 들어가는 실제 데이터값에 해당하면 이를 측정하여 날리는 경로는 C#에서 한다.
                    //라즈베리파이에서 측정한 값을 C#에서 측정하고, 이를 query 문자데이터타입으로 ssms에 날려서 기입하게 만든다.
                    SqlCommand cmd = new SqlCommand(query, conn);//cmd라는 것은 쿼리문 날린 것을 연결해주는 클래스(기능)을 의미한다.
                    cmd.ExecuteNonQuery(); //메서드 연산을 호출해 주는 곳이 없으니 여기서 호출해준다.
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"예외발생 : {ex.Message}");//오류가 발생하면 디버그를 하고 메세지를 사용자에게 알린다.
            }
        }

        /// <summary>
        /// 시뮬레이션 끝
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MnuendSimulation_Click(object sender, EventArgs e)
        {
            IsSimulation = false;
            timerSimul.Stop();
        }
        /// <summary>
        /// 종료버튼 클릭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MnuExit_Click(object sender, EventArgs e)
        {
            if (IsSimulation)
            {
                MessageBox.Show("시뮬레이션 멈춘 후 프로그램을 종료하세요","종료",
                    MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;//연산후 반드시 호출해줘야 한다. 그러나 해당 프로젝트에서는 이를 호출해주는 
                //곳이 없기때문에 메서드 내에서 호출해준다.
            }

            Environment.Exit(0);
        }

        private void BtnViewAll_Click(object sender, EventArgs e)
        {
            ChtPhotoResisters.ChartAreas[0].AxisX.Minimum = 0;
            ChtPhotoResisters.ChartAreas[0].AxisX.Maximum = sensors.Count;

            ChtPhotoResisters.ChartAreas[0].AxisX.ScaleView.Zoom(0, sensors.Count);
            ChtPhotoResisters.ChartAreas[0].AxisX.Interval = sensors.Count / 4;
        }

        private void BtnZoom_Click(object sender, EventArgs e)
        {
            ChtPhotoResisters.ChartAreas[0].AxisX.Minimum = 0;
            ChtPhotoResisters.ChartAreas[0].AxisX.Maximum = sensors.Count;

            ChtPhotoResisters.ChartAreas[0].AxisX.ScaleView.Zoom(sensors.Count-xCount, sensors.Count);
            ChtPhotoResisters.ChartAreas[0].AxisX.Interval = xCount / 4;
        }
    }
}
//ChartArea는 차트1개의 차트면적 속성 디폴트값을 설정, ChartSeries는 차트 2개 범례에 대한 디폴트 값
//프로그램 알고리즘 작성 시 항상 디폴트 로직 및 UI를 먼저 생각하고 작성하는 편이 편하다. 
//즉, 하향식 개발을 하는 것이 초기 개발엔 좋고, 유지 보수시에 모듈화된 소스코드를 이용하는 것이 좋다.
//메서드의 파라미터는 소괄호 안에 써주는 것이고 데이터 타입을 명시해준다.
//중괄호에는 메서드의 연산을 파라미터를 사용해서 기입해준다.
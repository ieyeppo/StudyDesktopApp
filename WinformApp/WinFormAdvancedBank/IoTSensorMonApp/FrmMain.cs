using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace IoTSensorMonApp
{
    public partial class FrmMain : Form
    {
        private double xCount = 200;    //차트에 보이는 데이터 수
        private double yCount = 1024;

        private Timer timerSimul = new Timer();
        private Random randPhoto = new Random();
        private bool isSimulation = false;
        private List<SensorData> sensors = new List<SensorData>();  //차트, 리스트박스 출력

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            //ComboBox 초기화
            foreach(var port in SerialPort.GetPortNames())
            {
                CboSerialPort.Items.Add(port);
            }
            CboSerialPort.Text = "Select Port";

            //Iot장비에서 받을 값의 범위
            PrbPhotoResistor.Minimum = 0;
            PrbPhotoResistor.Maximum = 1023;
            PrbPhotoResistor.Value = 0;

            //차트모양 초기화
            InitChartSytle();

            //BtnDisplay 초기화
            BtnDisplay.BackColor = Color.BlueViolet;
            BtnDisplay.ForeColor = Color.White;
            BtnDisplay.Text = "NONE";
            BtnDisplay.Font = new Font("맑은 고딕", 16, FontStyle.Bold);

            //나머지 초기화
            LblConnectTime.Text = "Connection Time : ";
            TxtSensorNum.TextAlign = HorizontalAlignment.Right;
            TxtSensorNum.Text = "0";
            BtnConnect.Enabled = BtnDisconnect.Enabled = false;
        }

        /// <summary>
        /// 차트 초기설정
        /// </summary>
        private void InitChartSytle()
        {
            ChtPhotoResistors.ChartAreas[0].BackColor = Color.Black;
            ChtPhotoResistors.ChartAreas[0].AxisX.Minimum = 0;
            ChtPhotoResistors.ChartAreas[0].AxisX.Maximum = xCount;
            ChtPhotoResistors.ChartAreas[0].AxisX.Interval = xCount / 4;
            ChtPhotoResistors.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.WhiteSmoke;
            ChtPhotoResistors.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dash;

            ChtPhotoResistors.ChartAreas[0].AxisY.Minimum = 0;
            ChtPhotoResistors.ChartAreas[0].AxisY.Maximum = yCount;
            ChtPhotoResistors.ChartAreas[0].AxisY.Interval = xCount;
            ChtPhotoResistors.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.WhiteSmoke;
            ChtPhotoResistors.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash;

            ChtPhotoResistors.ChartAreas[0].CursorX.AutoScroll = true;
            ChtPhotoResistors.ChartAreas[0].AxisX.ScaleView.Zoomable = true;    //화면 줌인 줌아웃
            ChtPhotoResistors.ChartAreas[0].AxisX.ScrollBar.ButtonStyle = ScrollBarButtonStyles.SmallScroll;
            ChtPhotoResistors.ChartAreas[0].AxisX.ScrollBar.ButtonColor = Color.LightSteelBlue;

            ChtPhotoResistors.Series.Clear();
            ChtPhotoResistors.Series.Add("Photo Value");
            ChtPhotoResistors.Series[0].ChartType = SeriesChartType.Line;
            ChtPhotoResistors.Series[0].Color = Color.HotPink;
            ChtPhotoResistors.Series[0].BorderWidth = 3;
            
            //범례 삭제
            if(ChtPhotoResistors.Legends.Count > 0)
            {
                for(int i = 0; i < ChtPhotoResistors.Legends.Count; i++)
                {
                    ChtPhotoResistors.Legends.RemoveAt(i);
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
            TxtSensorNum.Text = "0";
            isSimulation = true;
            timerSimul.Enabled = true;
            timerSimul.Interval = 1000; //1초에 한번
            timerSimul.Tick += TimerSimul_Tick;
            timerSimul.Start();
        }

        private void TimerSimul_Tick(object sender, EventArgs e)
        {
            int value = randPhoto.Next(1, 1023);    //1부터 1023 사이의 값
            ShowSensorValue(value.ToString());
        }

        /// <summary>
        /// 센서값 화면 출력
        /// </summary>
        /// <param name="value"></param>
        private void ShowSensorValue(string value)
        {
            int.TryParse(value, out int v);
            var currentTime = DateTime.Now;

            SensorData data = new SensorData( DateTime.Now, v, isSimulation );
            sensors.Add(data);

            //센서값 개 수
            TxtSensorNum.Text = sensors.Count.ToString();

            //프로그레스바 현재값 출력
            PrbPhotoResistor.Value = v;

            //리스트박스에 데이터 출력
            var item = $"{currentTime.ToString("yyyy-MM-dd HH:mm:ss")}\t{v}";
            LsbPhotoResistors.Items.Add(item);
            LsbPhotoResistors.SelectedIndex = LsbPhotoResistors.Items.Count - 1;    //스크롤 처리
            LblConnectTime.Text = $"Connection Time : {currentTime.ToString("yyyy-MM-dd HH:mm:ss")}";

            //차트에 데이터 출력
            ChtPhotoResistors.Series[0].Points.Add(v);
        }

        /// <summary>
        /// 시뮬레이션 끝내기
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MnuEndSimulation_Click(object sender, EventArgs e)
        {
            isSimulation = false;
            timerSimul.Stop();
        }

        private void MnuExit_Click(object sender, EventArgs e)
        {
            if (isSimulation)
            {
                MessageBox.Show("시뮬레이션을 멈춘 후 프로그램을 종료하세요.", "종료", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Environment.Exit(0);
        }
    }
}

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
using System.Windows.Threading;

namespace AnalogClockApp
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public Point Center { get; set; }
        public double Radius { get; set; }
        public int HourHand { get; set; }
        public int MinHand { get; set; }
        public int SecHand { get; set; }

        public MainWindow()
        {
            InitializeComponent();
        }
        private void Window_Initialized(object sender, EventArgs e)
        {
            SetColck();
            SetTimer();
        }

        private void SetColck()
        {
            Center = new Point(CvsColck.Width / 2, CvsColck.Height / 2);    //시계중심
            Radius = CvsColck.Width / 2;                                    //시계 반지름
            HourHand = (int)(Radius * 0.45);                                 //시계 시침
            MinHand = (int)(Radius * 0.55);                                  //시계 분침
            SecHand = (int)(Radius * 0.75);                                  //시계 초침
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            DateTime curTime = DateTime.Now;

            CvsColck.Children.Clear();

            DrawClockFace();    //시계판 그리기

            double radHour = (curTime.Hour % 12 + curTime.Minute / 60.0) * 30 * Math.PI / 180;  //시침 각도
            double radMin = (curTime.Minute + curTime.Second / 60.0) * 6 * Math.PI / 180;       //분침 각도
            double radSec = (curTime.Second + curTime.Millisecond / 1000.0) * 6 * Math.PI / 180;    //초침 각도

            DrawHands(radHour, radMin, radSec);
        }

        private void DrawHands(double radHour, double radMin, double radSec)
        {
            //시침
            DrawLine(HourHand * Math.Sin(radHour), -HourHand * Math.Cos(radHour), 0, 0, Brushes.Pink, 8, new Thickness(Center.X, Center.Y, 0, 0));
            //분침
            DrawLine(MinHand * Math.Sin(radMin), -MinHand * Math.Cos(radMin), 0, 0, Brushes.HotPink, 6, new Thickness(Center.X, Center.Y, 0, 0));
            //초침
            DrawLine(SecHand * Math.Sin(radSec), -SecHand * Math.Cos(radSec), 0, 0, Brushes.Violet, 3, new Thickness(Center.X, Center.Y, 0, 0));

            Ellipse core = new Ellipse();
            core.Margin = new Thickness(CvsColck.Width / 2 - 10, CvsColck.Height / 2 - 10, 0, 0);
            core.Stroke = Brushes.DeepPink;
            core.Fill = Brushes.DeepPink;
            core.Width = 20;
            core.Height = 20;
            CvsColck.Children.Add(core);
        }

        private void DrawLine(double x1, double y1, int x2, int y2, SolidColorBrush color, int thick, Thickness margin)
        {
            Line line = new Line();
            line.X1 = x1;
            line.Y1 = y1;
            line.X2 = x2;
            line.Y2 = y2;
            line.Stroke = color;
            line.StrokeThickness = thick;
            line.Margin = margin;
            line.StrokeStartLineCap = PenLineCap.Triangle;
            CvsColck.Children.Add(line);
        }

        private void DrawClockFace()
        {
            ElsClock.Stroke = Brushes.DeepPink;
            ElsClock.StrokeThickness = 20;
            CvsColck.Children.Add(ElsClock);
        }

        private void SetTimer()
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 0, 0, 10); //0.01초
            timer.Tick += Timer_Tick;
            timer.Start();
        }
    }
}

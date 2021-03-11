using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Threading;

namespace BlinkerApp
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnStarBlink_Click(object sender, RoutedEventArgs e)
        {
            timer.Start();
        }

        private void BtnStopBlink_Click(object sender, RoutedEventArgs e)
        {
            timer.Stop();
        }

        private void Window_Load(object sender, RoutedEventArgs e)
        {
            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(1000000);//0.1초
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if(BtnStarBlink.Background == Brushes.Pink)
            {
                BtnStarBlink.ClearValue(Button.BackgroundProperty);
                BtnStopBlink.Background = Brushes.Pink;
            }
            else
            {
                BtnStopBlink.ClearValue(Button.BackgroundProperty);
                BtnStarBlink.Background = Brushes.HotPink;
            }
        }
    }
}

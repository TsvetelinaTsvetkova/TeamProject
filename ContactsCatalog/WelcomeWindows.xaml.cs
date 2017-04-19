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
using System.Windows.Shapes;
using System.Windows.Threading;

namespace ContactsCatalog
{
    /// <summary>
    /// Interaction logic for WelcomeWindows.xaml
    /// </summary>
    public partial class WelcomeWindows : Window
    {
        private int time = 11;
        private DispatcherTimer Timer;
        public WelcomeWindows()
        {
            InitializeComponent();
            Timer = new DispatcherTimer();
            Timer.Interval = new TimeSpan(0, 0, 1);
            Timer.Tick += Timer_Tick;
            Timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (time > 0)
            {
                TBCountDown.Foreground = Brushes.White;
                if (time <= 5)
                {

                    if (time % 2 == 0)
                    {
                        TBCountDown.Foreground = Brushes.White;
                    }
                    else
                    {
                        TBCountDown.Foreground = Brushes.Black;
                    }
                    time--;
                    TBCountDown.Text = string.Format($"{time % 60}");

                }
                else
                {
                    time--;
                TBCountDown.Text = string.Format($"{time % 60}");
                }
            }
            else
            {
                TBCountDown.Foreground = Brushes.White;
                Timer.Stop();
                TBCountDown.Text = string.Format("Welcome to CC");
            }

        }

        private void Welcome_Click(object sender, RoutedEventArgs e)
        {
            MainWindow ww = new MainWindow();
            ww.Show();
            this.Close();
        }
    }
}

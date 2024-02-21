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

using System.Threading;
using System.Windows.Threading;

namespace _2324_2Y_Integ1_2B_DispatcherTimer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer _dt = null;
        bool _dtStatus = false;

        public MainWindow()
        {
            InitializeComponent();
            _dt = new DispatcherTimer();
            _dt.Interval = new TimeSpan(0, 0, 0, 0, 100);
            _dt.Tick += _dt_Tick;
        }

        private void _dt_Tick(object sender, EventArgs e)
        {
            int num = int.Parse(lblDisplay.Content.ToString());
            num++;
            lblDisplay.Content = num.ToString();

            if (num > 0 && num % 50 == 0)
            {
                MessageBox.Show("Derrek told me to appear");
                _dt.Stop();

                _dtStatus = !_dtStatus;

                if (_dtStatus)
                    btnClick.Content = "Stop";
                else
                    btnClick.Content = "Start";

            }
        }

        private void btnClick_Click(object sender, RoutedEventArgs e)
        {
            if (!_dtStatus)
                _dt.Start();
            else
                _dt.Stop();

            _dtStatus = !_dtStatus;

            if (_dtStatus)
                btnClick.Content = "Stop";
            else
                btnClick.Content = "Start";
        }
    }
}

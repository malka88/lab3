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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DateTime date;
        TimeSpan ts;
        System.Windows.Threading.DispatcherTimer Timer;

        public MainWindow()
        {
            InitializeComponent();
            Timer = new System.Windows.Threading.DispatcherTimer();
            Timer.Tick += new EventHandler(dispatcherTimer_Tick);
            Timer.Interval = new TimeSpan(0, 0, 1);
        }

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {

        }

        public Dictionary<string, DateTime> list = new Dictionary<string, DateTime>();

        private void create_Click(object sender, RoutedEventArgs e)
        {
            Dialog create_timer = new Dialog();
            if (create_timer.ShowDialog() == true)
            {
                date = new DateTime(create_timer.cal.SelectedDate.Value.Year, create_timer.cal.SelectedDate.Value.Month, create_timer.cal.SelectedDate.Value.Day, int.Parse(create_timer.tH.Text), int.Parse(create_timer.tM.Text), int.Parse(create_timer.tS.Text));
                lb.Items.Add(create_timer.tText.Text);
                list.Add(create_timer.tText.Text, new DateTime(create_timer.cal.SelectedDate.Value.Year, create_timer.cal.SelectedDate.Value.Month, create_timer.cal.SelectedDate.Value.Day, int.Parse(create_timer.tH.Text), int.Parse(create_timer.tM.Text), int.Parse(create_timer.tS.Text)));
            }
        }

        private void look_Click(object sender, RoutedEventArgs e)
        {
            string str = lb.SelectedValue as string;
            ts = list[str] - DateTime.Now;
            MessageBox.Show("Дни:" + ts.Days + " Время: " + ts.Hours + ":" + ts.Minutes + ":" + ts.Seconds);
        }

        private void mo_Click(object sender, RoutedEventArgs e)
        {

        }

        private void so_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

using System.Timers;
using System.Windows.Controls;

namespace WPF_containers
{

    public partial class ucDockPanel : UserControl
    {
        public ucDockPanel()
        {
            InitializeComponent();
            UpdateTime();
            TimerBeheren();
        }

        private void TimerBeheren()
        {
            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += OnTimedEvent;
            timer.AutoReset = true;
            timer.Enabled = true;
        }

        private void OnTimedEvent(Object? source, ElapsedEventArgs e)
        {
            Dispatcher.Invoke(UpdateTime);            
        }

        private void UpdateTime()
        {
            txtDatum.Text = DateTime.Now.ToString();
        }
    }
}

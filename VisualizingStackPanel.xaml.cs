using System.Collections.ObjectModel;
using System.Windows.Controls;

namespace WPF_containers
{

    public partial class ucVisualizingStackPanel : UserControl
    {
        public ucVisualizingStackPanel()
        {
            InitializeComponent();

            ObservableCollection<int> obs = new ObservableCollection<int>();
            Random random = new Random(1000);
            for (int i = 0; i < 10000; i++)
            {
                obs.Add(random.Next());
            }
            this.cboBigData.DataContext = obs;
            this.lstBigData.DataContext = obs;
        }
    }
}

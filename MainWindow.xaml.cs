using System.Windows;
using System.Windows.Controls;

namespace WPF_containers
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnStackpanel_Click(object sender, RoutedEventArgs e)
        {
            ucStackpanel _ucStackpanel = new ucStackpanel();
            OpenMyUserControl(_ucStackpanel);
        }

        private void btnStackpanelBorder_Click(object sender, RoutedEventArgs e)
        {
            ucStackpanelBorder _ucStackpanelBorder = new ucStackpanelBorder();
            OpenMyUserControl(_ucStackpanelBorder);
        }

        private void btnWrappanel_Click(object sender, RoutedEventArgs e)
        {
            ucWrappanel _ucWrappanel = new ucWrappanel();
            OpenMyUserControl(_ucWrappanel);
        }

        private void btnScrollViewer_Click(object sender, RoutedEventArgs e)
        {
            ucScrollViewer _ucScrollViewer = new ucScrollViewer();
            OpenMyUserControl(_ucScrollViewer);
        }

        private void btnSimpleDockPanel_Click(object sender, RoutedEventArgs e)
        {
            ucSimpleDockPanel _ucSimpleDockPanel = new ucSimpleDockPanel();
            OpenMyUserControl(_ucSimpleDockPanel);
        }

        private void btnDockPanel_Click(object sender, RoutedEventArgs e)
        {
            ucDockPanel _ucDockPanel = new ucDockPanel();
            OpenMyUserControl(_ucDockPanel);
        }

        private void btnCanvas_Click(object sender, RoutedEventArgs e)
        {
            ucCanvas _ucCanvas = new ucCanvas();
            OpenMyUserControl(_ucCanvas);
        }

        private void btnInkCanvas_Click(object sender, RoutedEventArgs e)
        {
            ucInkCanvas _ucInkCanvas = new ucInkCanvas();
            OpenMyUserControl(_ucInkCanvas);
        }

        private void btnGrid1_Click(object sender, RoutedEventArgs e)
        {
            ucGrid1 _ucGrid1 = new ucGrid1();
            OpenMyUserControl(_ucGrid1);
        }

        private void btnGrid2_Click(object sender, RoutedEventArgs e)
        {
            ucGrid2 _ucGrid2 = new ucGrid2();
            OpenMyUserControl(_ucGrid2);
        }

        private void btnGridSplitter_Click(object sender, RoutedEventArgs e)
        {
            ucGridSplitter _ucGridSplitter = new ucGridSplitter();
            OpenMyUserControl(_ucGridSplitter);
        }

        private void btnSharedSizeScope_Click(object sender, RoutedEventArgs e)
        {
            ucSharedSizeScope _ucSharedSizeScope = new ucSharedSizeScope();
            OpenMyUserControl(_ucSharedSizeScope);
        }

        private void btnUniformGrid_Click(object sender, RoutedEventArgs e)
        {
            ucUniformGrid _ucUniformGrid = new ucUniformGrid();
            OpenMyUserControl(_ucUniformGrid);
        }

        private void btnVisualizingStackPanel_Click(object sender, RoutedEventArgs e)
        {
            ucVisualizingStackPanel _ucVisualizingStackPanel = new ucVisualizingStackPanel();
            OpenMyUserControl(_ucVisualizingStackPanel);
        }

        private void OpenMyUserControl(UserControl activeUC)
        {
            if (mainGrid.Children.Count > 1)
            {
                mainGrid.Children.RemoveAt(1);
            }

            Grid.SetColumn(activeUC, 1);
            Grid.SetRow(activeUC, 0);
            mainGrid.Children.Add(activeUC);
        }

        
    }
}
using System.Windows.Controls;

namespace WPF_containers
{
    public partial class ucInkCanvas : UserControl
    {
        public ucInkCanvas()
        {
            InitializeComponent();
            foreach (InkCanvasEditingMode mode in System.Enum.GetValues(typeof(InkCanvasEditingMode)))
            {
                lstEditingMode.Items.Add(mode);
                lstEditingMode.SelectedItem = inkCanvas.EditingMode;
            }            
        }
    }
}

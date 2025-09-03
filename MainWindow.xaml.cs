using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CalucatorGit
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        string Op = "";
        string Mewmory_out;

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            if(Output.Focus() == true)
            {
                Output.Text += ((Button)(sender)).Content.ToString();
            }
            else
            {
                Output1.Text += ((Button)(sender)).Content.ToString();
            }
        }
    }
}
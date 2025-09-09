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

        private void Button_Click_Multiple(object sender, RoutedEventArgs e)
        {

            Answer.Content = Convert.ToInt32(Output.Text) * Convert.ToInt32(Output1.Text);
            Output.Text = "";
            Output1.Text = "";
        }

        private void Button_Click_Division(object sender, RoutedEventArgs e)
        {
            if (Convert.ToInt32(Output1.Text) != 0)
            {
                Answer.Content = Convert.ToInt32(Output.Text) / Convert.ToInt32(Output1.Text);
                Output.Text = "";
                Output1.Text = "";
            }
        }

        private void Button_Click_Equal(object sender, RoutedEventArgs e)
        {
            if (((Button)(sender)).Content == "=")
            {
                ((Button)(sender)).Content = ":D";
            }
            else
            {
                ((Button)(sender)).Content = "=";
            }
        }

        private void Button_Click_Clear(object sender, RoutedEventArgs e)
        {
            Output.Text = "";
            Output.Text = "";
            Answer.Content = "";

        }

        private void Button_cifri(object sender, RoutedEventArgs e)
        {
            if (Output.Focus() == true)
            {
                Output.Text = Convert.ToString(((Button)(sender)).Content);
            }
            else if (Output1.Focus() == true)
            {
                Output1.Text = Convert.ToString(((Button)(sender)).Content);
            }
        }
    }
}
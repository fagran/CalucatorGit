using System.Security.AccessControl;
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

        bool Mewmory_out = false;

        private void Button_Click_Multiple(object sender, RoutedEventArgs e)
        {
            if(Output.Text != "" && Output1.Text != "")
            {
                Answer.Content = Convert.ToInt32(Output.Text) * Convert.ToInt32(Output1.Text);
                Output.Text = "";
                Output1.Text = "";
            }
            
        }

        private void Button_Click_Division(object sender, RoutedEventArgs e)
        {
            if (Output.Text != "" && Output1.Text != "")
            {
                if (Convert.ToInt32(Output1.Text) == 0)
                {
                    Answer.Content = "Орефки макадамья";
                }
                else
                {
                    Answer.Content = Convert.ToInt32(Output.Text) / Convert.ToInt32(Output1.Text);
                    Output.Text = "";
                    Output1.Text = "";
                }

            }
        }

        private void Button_Sloj(object sender, RoutedEventArgs e)
        {
            if (Output.Text != "" && Output1.Text != "")
            {
                Answer.Content = Convert.ToInt32(Output.Text) + Convert.ToInt32(Output1.Text);
                Output.Text = "";
                Output1.Text = "";
            }
        }

        private void Button_manus(object sender, RoutedEventArgs e)
        {
            if (Output.Text != "" && Output1.Text != "")
            {
                Answer.Content = Convert.ToInt32(Output.Text) - Convert.ToInt32(Output1.Text);
                Output.Text = "";
                Output1.Text = "";
            }
        }

        private void Button_Click_Equal(object sender, RoutedEventArgs e)
        {
            if (((Button)(sender)).Content == "=")
            {
                Mewmory_out = true;
                ((Button)(sender)).Content = ":D";
            }
            else
            {
                Mewmory_out = false;
                ((Button)(sender)).Content = "=";
            }
        }

        private void Button_Click_Clear(object sender, RoutedEventArgs e)
        {
            Output.Text = "";
            Output1.Text = "";
            Answer.Content = "";

        }


        private void Button_cifri(object sender, RoutedEventArgs e)
        {
            if (Mewmory_out == false)
            {
               
                Output.Text += Convert.ToString(((Button)(sender)).Content);
            }
            else if (Mewmory_out == true)
            {
                
                Output1.Text += Convert.ToString(((Button)(sender)).Content);
            }
        }
    }
}
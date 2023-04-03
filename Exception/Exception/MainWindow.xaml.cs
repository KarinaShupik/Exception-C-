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

namespace Exception
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

        private void btn_res_Click(object sender, RoutedEventArgs e)
        {
            int a = Convert.ToInt32(input_a.Text);
            int q = Convert.ToInt32(input_q.Text);
            int n = Convert.ToInt32(input_n.Text);

            
            try
            {
                if (n < 0)
                {
                    throw new ArgumentException("The number of terms in the progression must be a non-negative integer.");
                }

                if (q == 1)
                {
                    input_res.Text = Convert.ToString(a * n);
                }
                else
                {
                    input_res.Text = Convert.ToString(a * (Math.Pow(q, n) - 1) / (q - 1));
                }
            }
            catch (ArgumentException ex)
            {
               
                input_res.Text = Convert.ToString( $"Error: {ex.Message}\n " );
            }
        }
    }
}

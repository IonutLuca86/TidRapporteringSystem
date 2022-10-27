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

namespace TidRapporteringSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> jobbs = new List<string>();
        string[] times = { "8:00", "9:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00" };
        public MainWindow()
        {
            InitializeComponent();
            timesBox.ItemsSource = times;   
            DisplayContent();   
        }

        private void sparaBtn_Click(object sender, RoutedEventArgs e)
        {
            raportlistBox.Items.Clear();
            raportlistBox.Items.Add(jobbDescription.Text + " " + datum.Text + " " + timesBox.Text);
            jobbs.Add(jobbDescription.Text + " " + datum.Text + " " + timesBox.Text);
           
        }
        public void DisplayContent()
        {
            raportlistBox.Items.Clear();
            foreach (string job in jobbs)
                raportlistBox.Items.Add(job);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DisplayContent();
        }
    }
}

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

namespace TrainingWpf1
{
    /// <summary>
    /// Interaction logic for SimpleForm.xaml
    /// </summary>
    public partial class SimpleForm : Page
    {
        public SimpleForm()
        {
            InitializeComponent();
        }

        private void Click_for_saveTheForm(object sender, RoutedEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Signer Name: ");
            sb.Append(SignerName.Text);
            sb.Append(Environment.NewLine);
            sb.Append("Sex: ");
            sb.Append((bool)SexMale.IsChecked ? "Male" : "Female");
            sb.Append(Environment.NewLine);
            sb.Append("Computer type: ");
            sb.Append((bool)Desktop.IsChecked ? "Desktop, " : "");
            sb.Append((bool)Laptop.IsChecked ? "Laptop, " : "");
            sb.Append((bool)Tablet.IsChecked ? "Tablet" : "");
            sb.Append(Environment.NewLine);
            sb.Append("Job: ");
            sb.Append(Job.SelectedItem.ToString());
            sb.Append(Environment.NewLine);
            sb.Append("Selected date: ");
            sb.Append(CalDate.SelectedDate.ToString());
            MessageBox.Show(sb.ToString());
        }

        private void Job_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var newlyselectedItem = e.AddedItems[0];
            MessageBox.Show(newlyselectedItem.ToString());
        }
    }
}

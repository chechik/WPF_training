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
    /// Interaction logic for INPC.xaml
    /// </summary>
    public partial class DataBindingTwoWay : Page
    {
        private Employee emp;
        public DataBindingTwoWay()
        {
            InitializeComponent();
            emp = new Employee()
            {
                Name = "Joe",
                Title = "QA"
            };
            DataContext = emp;
        }

        private void Button_Click_Update(object sender, RoutedEventArgs e)
        {
            emp.Name = NewName.Text;
            emp.Title = "Buddist";

        }

        
    }
}

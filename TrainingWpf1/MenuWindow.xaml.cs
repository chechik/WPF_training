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
    /// Interaction logic for MenuWindow.xaml
    /// </summary>
    public partial class MenuWindow : Page
    {
        public MenuWindow()
        {
            InitializeComponent();
        }

        private void Click_for_ex1(object sender, RoutedEventArgs e)
        {
            //View example 1 - Grid Rows and Columns Demo
            ex1 exercise1 = new ex1();
            this.NavigationService.Navigate(exercise1);
        }

        private void Click_for_ex2(object sender, RoutedEventArgs e)
        {
            //View example 2 Layout With Stack Panel Demo
            ex2 exercise2 = new ex2();
            this.NavigationService.Navigate(exercise2);
        }
        private void Click_for_WrapPanelDemo(object sender, RoutedEventArgs e)
        {
            //View example 3 Wrap Panel Demo
            WrapPanelDemo wrapPanelDemo = new WrapPanelDemo();
            this.NavigationService.Navigate(wrapPanelDemo);
        }
        private void Click_for_DockPanelDemo(object sender, RoutedEventArgs e)
        {
            //View example 3 Wrap Panel Demo
            DockPanelDemo dockPanelDemo = new DockPanelDemo();
            this.NavigationService.Navigate(dockPanelDemo);
        }
        private void Click_for_CanvasDemo(object sender, RoutedEventArgs e)
        {
            //View example 3 Wrap Panel Demo
            CanvasDemo canvasDemo = new CanvasDemo();
            this.NavigationService.Navigate(canvasDemo);
        }

        private void Click_for_SimlpeForm(object sender, RoutedEventArgs e)
        {
            //View example 3 Wrap Panel Demo
            SimpleForm simpleForm = new SimpleForm();
            this.NavigationService.Navigate(simpleForm);
        }

        private void Click_for_DataBindingOneWay(object sender, RoutedEventArgs e)
        {
            DataBindingOneWay dataBindingOneWay = new DataBindingOneWay();
            this.NavigationService.Navigate(dataBindingOneWay);
        }

        private void Click_for_INPC(object sender, RoutedEventArgs e)
        {
            INPC inpc = new INPC();
            this.NavigationService.Navigate(inpc);
        }

        private void Click_for_DataBindingTwoWay(object sender, RoutedEventArgs e)
        {
            DataBindingTwoWay dataBindingTwoWay = new DataBindingTwoWay();
            this.NavigationService.Navigate(dataBindingTwoWay);
        }
    }
}

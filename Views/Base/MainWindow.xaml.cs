using NinjaWorld_Encyclopedia.Views.Pages.Calculator;
using System.Windows;

namespace NinjaWorld_Encyclopedia
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Content = new CalculatorBase();
        }
    }
}

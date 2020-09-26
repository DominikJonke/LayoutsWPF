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

namespace Layouts
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            btnStackPanel.Click += Btn_Click;
            btnDock.Click += Btn_Click;
            btnGrid.Click += Btn_Click;
            btnGridSplitter.Click += Btn_Click;
        }

        public void Btn_Click(object sender, RoutedEventArgs e)
        {
            Button newWindow = (Button)sender;

            switch (newWindow.Content.ToString())
            {
                case "StackPanel":
                    {
                        Layout.StackPanel btnStackPanel = new Layout.StackPanel();
                        btnStackPanel.Show();
                        break;
                    }

                case "Dock":
                    {
                        Layout.Dock btnDock = new Layout.Dock();
                        btnDock.Show();
                        break;
                    }

                case "Grid":
                    {
                        Layout.Grid btnGrid = new Layout.Grid();
                        btnGrid.Show();
                        break;
                    }

                case "GridSplitter":
                    {
                        Layout.GridSplitter btnGridSplitter = new Layout.GridSplitter();
                        btnGridSplitter.Show();
                        break;
                    }
            }
        }
    }
}

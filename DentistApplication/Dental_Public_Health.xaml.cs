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
using System.Windows.Shapes;

namespace DentistApplication
{
    /// <summary>
    /// Interaction logic for Dental_Public_Health.xaml
    /// </summary>
    public partial class Dental_Public_Health : Window
    {
        private MainWindow mainWindow;

        public Dental_Public_Health(MainWindow mainWindow)
        {
            // TODO: Complete member initialization
            this.mainWindow = mainWindow;
            InitializeComponent();
        }
    }
}

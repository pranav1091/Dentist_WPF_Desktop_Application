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

namespace DentalApp
{
    /// <summary>
    /// Interaction logic for DentistInformation.xaml
    /// </summary>
    public partial class DentistInformation : Window
    {
        private MainWindow mainWindow;


        public DentistInformation(MainWindow mainWindow)
        {
            // TODO: Complete member initialization
            this.mainWindow = mainWindow;
            InitializeComponent();
        }
    }
}

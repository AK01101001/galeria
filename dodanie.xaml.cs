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
using Microsoft.Win32;

namespace galeria
{
    /// <summary>
    /// Logika interakcji dla klasy dodanie.xaml
    /// </summary>
    public partial class dodanie : Window
    {
        public zdjecie zdj { get; set; }
        public dodanie()
        {
            InitializeComponent();
        }
        private void dodaj(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog()==true)
            {
               
            }
            
        }
    }
}

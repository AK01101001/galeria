using System.ComponentModel;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace galeria
{
    public partial class MainWindow : Window
    {
        public List<zdjecie> zdjecia { get; set; } = new List<zdjecie>();
        string path = "../../../Data.txt";
        int index = 0;
        public MainWindow()
        {
            InitializeComponent();
            otworz();
            this.Closing += OnClose;
        }

        private void OnClose(object? sender, CancelEventArgs e)
        {
            zapisz();
        }

        private void otworz()
        {
            string[] dane = File.ReadAllLines(path);
            for (int i = 0; i < dane.Count(); i+=2)
            {
                zdjecia.Add(new zdjecie(int.Parse(dane[i]), int.Parse(dane[i + 1])));
            }
            wyswietl();
        }
        private void zapisz()
        {
            List<string> dane = new List<string>();            
            for (int i = 0; i < zdjecia.Count(); i++)
            {
                dane.Add(zdjecia.ElementAt(i).lWyswietlen.ToString());
                dane.Add(zdjecia.ElementAt(i).lPolubien.ToString());
            }
            File.WriteAllLines(path,dane);
        }

        private void prawo(object sender, RoutedEventArgs e)
        {
            index++;
            if (index > zdjecia.Count()-1)
            {
                index = 0;
            }
            wyswietl();
        }

        

        private void lewo(object sender, RoutedEventArgs e)
        {
            index--;
            if (index <0)
            {
                index = zdjecia.Count()-1;
            }
            wyswietl();
        }
        private void wyswietl()
        {
            zdjecia.ElementAt(index).lWyswietlen++;
            obraz.Source = new BitmapImage(new Uri( zdjecia.ElementAt(index).source,UriKind.Relative));
            wyswietlenia.Text = zdjecia.ElementAt(index).lWyswietlen.ToString();
            polubienia.Text = zdjecia.ElementAt(index).lPolubien.ToString();
        }

        private void polub(object sender, RoutedEventArgs e)
        {
            zdjecia.ElementAt(index).lPolubien++;
            polubienia.Text = zdjecia.ElementAt(index).lPolubien.ToString();
        }
    }
}
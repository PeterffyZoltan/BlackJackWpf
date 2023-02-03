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
using static System.Net.Mime.MediaTypeNames;

namespace FeketeJanos
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Kartya[] selectedCards = new Kartya[4];
        List<Kartya> kartyak = new List<Kartya>();
        public MainWindow()
        {
            InitializeComponent();
            
            for (int i = 1; i <= 52; i++)
            {
                Kartya k = new Kartya(i);
                kartyak.Add(k);
                
            }
            Play();
        }

        private void Play()
        {
            getRandomCards();
            displayCards();
        }

        private void getRandomCards()
        {
            for (int i = 0; i < 4; i++)
            {
                Random r = new Random();
                int kIndex =  r.Next(0, kartyak.Count-1);
                selectedCards[i] = kartyak[kIndex];
                kartyak.RemoveAt(kIndex);


            }
        }

        private void displayCards()
        {
            
                
                ImgLap1.Source = new BitmapImage(new Uri(selectedCards[0].src, UriKind.Absolute));
            ImgLap2.Source = new BitmapImage(new Uri(selectedCards[1].src, UriKind.Absolute));
            ImgLap3.Source = new BitmapImage(new Uri(selectedCards[2].src, UriKind.Absolute));
            ImgLap4.Source = new BitmapImage(new Uri(selectedCards[3].src, UriKind.Absolute));






        }
    }
}

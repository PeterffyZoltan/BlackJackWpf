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
    /// 
    public partial class MainWindow : Window
    {
        int playerWin = 0;
        int machineWin = 0;
        Kartya[] selectedCards = new Kartya[4];
        List<Kartya> kartyak = new List<Kartya>();
        public MainWindow()
        {
            InitializeComponent();
            InitializeCards();
            
            Play();
        }

        private void InitializeCards()
        {
            for (int i = 1; i <= 52; i++)
            {
                Kartya k = new Kartya(i);
                kartyak.Add(k);

            }
        }

        private void Play()
        {
            getRandomCards();
            displayCards();
            calcWinner();
        }

        private void calcWinner()
        {
            int machineSum = selectedCards[0].Value + selectedCards[1].Value;
            int playerSum = selectedCards[2].Value + selectedCards[3].Value;
            if (playerSum <= 21 && (playerSum > machineSum || machineSum > 21))
            {
                playerWin += 1;
                displayWinner("Győztél");
            }
            else
            {
                machineWin += 1;
                displayWinner("Vesztettél");
            }

        }

        private void displayWinner(string msg)
        {
            lblEredmeny.Content = msg;
            lblOsztoWin.Content = $"Osztó győzelmei: {machineWin}";
            lblJatekosWin.Content = $"Játékos győzelmei: {playerWin}";
        }

        private void getRandomCards()
        {
            for (int i = 0; i < 4; i++)
            {
                Random r = new Random();
                if (kartyak.Count < 4)
                {
                    InitializeCards();
                }
                int kIndex = r.Next(0, kartyak.Count - 1);
                selectedCards[i] = kartyak[kIndex];
                kartyak.RemoveAt(kIndex);


            }
        }

        private void displayCards()
        {


            ImgLap1.Source = new ImageSourceConverter().ConvertFromString("Imgs/" + selectedCards[0].src) as ImageSource;
            ImgLap2.Source = new ImageSourceConverter().ConvertFromString("Imgs/" + selectedCards[1].src) as ImageSource;
            ImgLap3.Source = new ImageSourceConverter().ConvertFromString("Imgs/" + selectedCards[2].src) as ImageSource;
            ImgLap4.Source = new ImageSourceConverter().ConvertFromString("Imgs/" + selectedCards[3].src) as ImageSource;






        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Play();
        }
    }
}

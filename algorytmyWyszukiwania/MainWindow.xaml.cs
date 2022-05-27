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
using System.IO;
using Microsoft.Win32;

namespace algorytmyWyszukiwania
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            string text = File.ReadAllText(@"text.txt");
            textbox.Text = text;
        }
			
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //Boyer'a-Moore'a
            output.Text = "";
            string text = File.ReadAllText(@"text.txt"); //s
            int dlugosc = text.Length;
            string wzorzec = textWzorzec.Text;
            int dlugoscWzorca = wzorzec.Length;
            
            
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            output.Text = "";
            // Rabina-Karpa
            /* string text = File.ReadAllText(@"text.txt"); //s
             int N = text.Length;  // długość łańcucha s
             int M = 4;  // długość wzorca p
             int zp = 65;  // kod pierwszego znaku alfabetu
             int zk = 67;  // kod ostatniego znaku alfabetu
             string x;

             int h(string & x){
                 int i, hx;

                 hx = 0;
                 for (i = 0; i < M; i++)
                 {
                     hx = 3 * hx + (x[i] - 65);
                     return hx;
                 }
             } */

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //bruteforce
            var timer = System.Diagnostics.Stopwatch.StartNew();
            output.Text = "";
            string text = File.ReadAllText(@"text.txt");
            int N = text.Length;
            string wzorzec = textWzorzec.Text;
            int M = wzorzec.Length;
            int i;
            
            for(i=1; i < N - M; i++)
            {
                if (wzorzec == text.Substring(i, M))
                {
                    output.Text = output.Text + " " + i + ": " + wzorzec;
                }
            }
            timer.Stop();
            var czasMS = timer.ElapsedMilliseconds;
            czas.Text = "Wykonano w: " + czasMS.ToString() + " milisekund";

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            //KMP
            output.Text = "";
            string text = File.ReadAllText(@"text.txt");
            int N = text.Length;
            string wzorzec = textWzorzec.Text;
            int M = wzorzec.Length;
            int i;

            
                    
                
            

        }
    }
    }


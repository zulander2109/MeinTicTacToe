using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Remoting.Channels;
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

namespace MeinTicTacToe
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        int spielerX=0;
                
        private void Kaestchen_0_0_Click(object sender, RoutedEventArgs e)
        {
            Button geklickt = (Button)sender;
            NewMethod();
            

            void NewMethod()
            {
                if (spielerX % 2 == 0)
                {
                    geklickt.Content = "X";
                    var urspuenglicheFarbe = geklickt.Foreground;
                    geklickt.Foreground = geklickt.Background;
                    geklickt.Background = urspuenglicheFarbe;
                }
                else
                {
                    geklickt.Content = "O";
                    var ursuenglicheFarbe = geklickt.Foreground;
                    geklickt.Foreground = geklickt.Background;
                    geklickt.Background = ursuenglicheFarbe;

                }
                spielerX += 1;
            }
        }

        private void kaestchen_0_1_Click(object sender, RoutedEventArgs e)
        {
            Button geklickt = (Button)sender;
            NewMethod();


            void NewMethod()
            {
                if (spielerX % 2 == 0)
                {
                    geklickt.Content = "X";
                    var urspuenglicheFarbe = geklickt.Foreground;
                    geklickt.Foreground = geklickt.Background;
                    geklickt.Background = urspuenglicheFarbe;
                }
                else
                {
                    geklickt.Content = "O";
                    var ursuenglicheFarbe = geklickt.Foreground;
                    geklickt.Foreground = geklickt.Background;
                    geklickt.Background = ursuenglicheFarbe;

                }
                spielerX += 1;
            }
        }

        private void kaestchen_0_2_Click(object sender, RoutedEventArgs e)
        {
            Button geklickt = (Button)sender;
            NewMethod();


            void NewMethod()
            {
                if (spielerX % 2 == 0)
                {
                    geklickt.Content = "X";
                    var urspuenglicheFarbe = geklickt.Foreground;
                    geklickt.Foreground = geklickt.Background;
                    geklickt.Background = urspuenglicheFarbe;
                }
                else
                {
                    geklickt.Content = "O";
                    var ursuenglicheFarbe = geklickt.Foreground;
                    geklickt.Foreground = geklickt.Background;
                    geklickt.Background = ursuenglicheFarbe;

                }
                spielerX += 1;
            }
        }

        private void kaestchen_1_0_Click(object sender, RoutedEventArgs e)
        {
            Button geklickt = (Button)sender;
            NewMethod();


            void NewMethod()
            {
                if (spielerX % 2 == 0)
                {
                    geklickt.Content = "X";
                    var urspuenglicheFarbe = geklickt.Foreground;
                    geklickt.Foreground = geklickt.Background;
                    geklickt.Background = urspuenglicheFarbe;
                }
                else
                {
                    geklickt.Content = "O";
                    var ursuenglicheFarbe = geklickt.Foreground;
                    geklickt.Foreground = geklickt.Background;
                    geklickt.Background = ursuenglicheFarbe;

                }
                spielerX += 1;
            }
        }

        private void kaestchen_1_1_Click(object sender, RoutedEventArgs e)
        {
            Button geklickt = (Button)sender;
            NewMethod();


            void NewMethod()
            {
                if (spielerX % 2 == 0)
                {
                    geklickt.Content = "X";
                    var urspuenglicheFarbe = geklickt.Foreground;
                    geklickt.Foreground = geklickt.Background;
                    geklickt.Background = urspuenglicheFarbe;
                }
                else
                {
                    geklickt.Content = "O";
                    var ursuenglicheFarbe = geklickt.Foreground;
                    geklickt.Foreground = geklickt.Background;
                    geklickt.Background = ursuenglicheFarbe;

                }
                spielerX += 1;
            }
        }

        private void kaestchen_1_2_Click(object sender, RoutedEventArgs e)
        {
            Button geklickt = (Button)sender;
            NewMethod();


            void NewMethod()
            {
                if (spielerX % 2 == 0)
                {
                    geklickt.Content = "X";
                    var urspuenglicheFarbe = geklickt.Foreground;
                    geklickt.Foreground = geklickt.Background;
                    geklickt.Background = urspuenglicheFarbe;
                }
                else
                {
                    geklickt.Content = "O";
                    var ursuenglicheFarbe = geklickt.Foreground;
                    geklickt.Foreground = geklickt.Background;
                    geklickt.Background = ursuenglicheFarbe;

                }
                spielerX += 1;
            }
        }

        private void kaestchen_2_0_Click(object sender, RoutedEventArgs e)
        {
            Button geklickt = (Button)sender;
            NewMethod();


            void NewMethod()
            {
                if (spielerX % 2 == 0)
                {
                    geklickt.Content = "X";
                    var urspuenglicheFarbe = geklickt.Foreground;
                    geklickt.Foreground = geklickt.Background;
                    geklickt.Background = urspuenglicheFarbe;
                }
                else
                {
                    geklickt.Content = "O";
                    var ursuenglicheFarbe = geklickt.Foreground;
                    geklickt.Foreground = geklickt.Background;
                    geklickt.Background = ursuenglicheFarbe;

                }
                spielerX += 1;
            }
        }

        private void kaestchen_2_1_Click(object sender, RoutedEventArgs e)
        {
            Button geklickt = (Button)sender;
            NewMethod();


            void NewMethod()
            {
                if (spielerX % 2 == 0)
                {
                    geklickt.Content = "X";
                    var urspuenglicheFarbe = geklickt.Foreground;
                    geklickt.Foreground = geklickt.Background;
                    geklickt.Background = urspuenglicheFarbe;
                }
                else
                {
                    geklickt.Content = "O";
                    var ursuenglicheFarbe = geklickt.Foreground;
                    geklickt.Foreground = geklickt.Background;
                    geklickt.Background = ursuenglicheFarbe;

                }
                spielerX += 1;
            }
        }

        private void kaestchen_2_2_Click(object sender, RoutedEventArgs e)
        {
            Button geklickt = (Button)sender;
            NewMethod();


            void NewMethod()
            {
                if (spielerX % 2 == 0)
                {
                    geklickt.Content = "X";
                    var urspuenglicheFarbe = geklickt.Foreground;
                    geklickt.Foreground = geklickt.Background;
                    geklickt.Background = urspuenglicheFarbe;
                }
                else
                {
                    geklickt.Content = "O";
                    var ursuenglicheFarbe = geklickt.Foreground;
                    geklickt.Foreground = geklickt.Background;
                    geklickt.Background = ursuenglicheFarbe;

                }
                spielerX += 1;
            }
        }
    }
}

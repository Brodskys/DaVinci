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
using System.Windows.Media.Animation;
using System.Windows.Controls.Primitives;

namespace DaVinci
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        void NewWindowAsDialog(object sender, RoutedEventArgs e)
        {
            MainWindow myOwnedDialog = new MainWindow();
            myOwnedDialog.Owner = this;
            myOwnedDialog.ShowDialog();

            
        }
        void NormalNewWindow(object sender, RoutedEventArgs e)
        {
            MainWindow myOwnedWindow = new MainWindow();
            myOwnedWindow.Owner = this;
            myOwnedWindow.Show();
        }

        public MainWindow()
        {
            InitializeComponent();
            _1.Visibility = Visibility.Hidden;
            _2.Visibility = Visibility.Hidden;
            _3.Visibility = Visibility.Hidden;
            _4.Visibility = Visibility.Hidden;
            _5.Visibility = Visibility.Hidden;
            O_pr.Visibility = Visibility.Hidden;
        }


        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
    
            Closing -= Window_Closing;
            e.Cancel = true;
            var animation = new DoubleAnimation(0, (Duration)TimeSpan.FromSeconds(1));
            animation.Completed += (s, _) => System.Windows.Application.Current.Shutdown();
            BeginAnimation(UIElement.OpacityProperty, animation);
        }

        private void RF_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            RF f1 = new RF();
            f1.Show(); 
            Hide();
        }

        private void It_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            It f2 = new It();
            f2.Show();
            Hide();
        }

        private void Is_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Is f3 = new Is();
            f3.Show();
            Hide();
        }     

        private void Be_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Be f5 = new Be();
            f5.Show();
            Hide();
        }

        private void Nl_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Nl f6 = new Nl();
            f6.Show();
            Hide();
        }

        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            
                if (_1.Visibility == Visibility.Visible)
                {
                    _1.Visibility = Visibility.Hidden;
                    _2.Visibility = Visibility.Hidden;
                    _3.Visibility = Visibility.Hidden;
                    _4.Visibility = Visibility.Hidden;
                    _5.Visibility = Visibility.Hidden;
                O_pr.Visibility = Visibility.Hidden;
            }


                else
                {
                    _1.Visibility = Visibility.Visible;
                    _2.Visibility = Visibility.Visible;
                    _3.Visibility = Visibility.Visible;
                    _4.Visibility = Visibility.Visible;
                    _5.Visibility = Visibility.Visible;
                O_pr.Visibility = Visibility.Visible;
            }

            
            
               
                  
                
               
                

            
        }
        static public bool odin = false;
        private void O_pr_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (odin==false)
            {
                O_pr_ f = new O_pr_();
                f.Show();
                odin = true;
            }
        }
    }
}

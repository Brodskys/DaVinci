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
namespace DaVinci
{
    
    public partial class It : Window
    {
        public It()
        {
            InitializeComponent();

            History.Visibility = Visibility.Hidden;
            Ph1.Visibility = Visibility.Hidden;
            Ph2.Visibility = Visibility.Hidden;

            _1.Visibility = Visibility.Hidden;
            _2.Visibility = Visibility.Hidden;
            _3.Visibility = Visibility.Hidden;
        }
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Closing -= Window_Closing;
            e.Cancel = true;
            var animation = new DoubleAnimation(0, (Duration)TimeSpan.FromSeconds(1));
            animation.Completed += (s, _) => Close();
            BeginAnimation(UIElement.OpacityProperty, animation);

            MainWindow form = new MainWindow();
            form.Show();
        }    
        private void History_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            if (History.Margin.Top == 32)
            {
                It_tvor.Hs_Dav f = new It_tvor.Hs_Dav();
                f.Show();
            }
            if (History.Margin.Top == 77)
            {
                It_tvor.Hs_Botich f = new It_tvor.Hs_Botich();
                f.Show();
            }
            if (History.Margin.Top == 127)
            {
                It_tvor.Hs_San f = new It_tvor.Hs_San();
                f.Show();
            }
            if (History.Margin.Top == 178)
            {
                It_tvor.Hs_mik f = new It_tvor.Hs_mik();
                f.Show();
            }
            if (History.Margin.Top == 233)
            {
                It_tvor.Hs_Maz f = new It_tvor.Hs_Maz();
                f.Show();
            }
            if (History.Margin.Top == 278)
            {
                It_tvor.Hs_Kar f = new It_tvor.Hs_Kar();
                f.Show();
            }
        }

        private void Ph1_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            if (Ph1.Margin.Top == 77)
            {
                It_tvor.Ph_Dav f = new It_tvor.Ph_Dav();
                f.Show();
            }
            if (Ph1.Margin.Top == 122)
            {
                It_tvor.Ph_Botich f = new It_tvor.Ph_Botich();
                f.Show();
            }
            if (Ph1.Margin.Top == 172)
            {
                It_tvor.Ph_San f = new It_tvor.Ph_San();
                f.Show();
            }
            if (Ph1.Margin.Top == 223)
            {
                It_tvor.Ph_mik f = new It_tvor.Ph_mik();
                f.Show();
            }
            if (Ph1.Margin.Top == 278)
            {
                It_tvor.Ph_Maz f = new It_tvor.Ph_Maz();
                f.Show();
            }


            if (Ph1.Margin.Top == 323) 
            {
                It_tvor.Ph_Kar f = new It_tvor.Ph_Kar();
                f.Show();
            }
        }
        private void Ph2_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            if (Ph2.Margin.Top == 122)
            {
                It_tvor.Dav_kart f = new It_tvor.Dav_kart();
                f.Show();
            }
            if (Ph2.Margin.Top == 167)
            {
                It_tvor.Botich_kart f = new It_tvor.Botich_kart();
                f.Show();
            }
            if (Ph2.Margin.Top == 217)
            {
                It_tvor.San_kart f = new It_tvor.San_kart();
                f.Show();
            }
            if (Ph2.Margin.Top == 268)
            {
                It_tvor.Mik_kart f = new It_tvor.Mik_kart();
                f.Show();
            }
            if (Ph2.Margin.Top == 323)
            {
                It_tvor.Maz_kart f = new It_tvor.Maz_kart();
                f.Show();
            }
            if (Ph2.Margin.Top == 368)
            {
                It_tvor.Kar_kart f = new It_tvor.Kar_kart();
                f.Show();
            }
        }
        private void Dav_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                History.Visibility = Visibility.Hidden;
                Ph1.Visibility = Visibility.Hidden;
                Ph2.Visibility = Visibility.Hidden;

                History.Margin = new Thickness(618, 32, 0, 378);
                Ph1.Margin = new Thickness(618, 77, 0, 333);
                Ph2.Margin = new Thickness(618, 122, 0, 288);

                It_im.Source = new BitmapImage(new Uri(@"pack://application:,,,/Im/It_artists/Vinci.png"));
                if (rct.Margin.Top == 72)
                {
                    ThicknessAnimation ta = new ThicknessAnimation();
                    ta.From = new Thickness(618, 72, 0, 0);
                    ta.To = new Thickness(618, 72, 0, 0);
                    ta.Duration = TimeSpan.FromSeconds(0.2);
                    this.rct.BeginAnimation(Rectangle.MarginProperty, ta);                
                }
                else if (rct.Margin.Top == 122)
                {
                    ThicknessAnimation ta = new ThicknessAnimation();
                    ta.From = new Thickness(618, 122, 0, 0);
                    ta.To = new Thickness(618, 72, 0, 0);
                    ta.Duration = TimeSpan.FromSeconds(0.2);
                    this.rct.BeginAnimation(Rectangle.MarginProperty, ta);
                }
                else if (rct.Margin.Top == 172)
                {
                    ThicknessAnimation ta = new ThicknessAnimation();
                    ta.From = new Thickness(618, 172, 0, 0);
                    ta.To = new Thickness(618, 72, 0, 0);
                    ta.Duration = TimeSpan.FromSeconds(0.2);
                    this.rct.BeginAnimation(Rectangle.MarginProperty, ta);
                }
                else if (rct.Margin.Top == 223)
                {
                    ThicknessAnimation ta = new ThicknessAnimation();
                    ta.From = new Thickness(618, 223, 0, 0);
                    ta.To = new Thickness(618, 72, 0, 0);
                    ta.Duration = TimeSpan.FromSeconds(0.2);
                    this.rct.BeginAnimation(Rectangle.MarginProperty, ta);
                }
                else if (rct.Margin.Top == 273)
                {
                    ThicknessAnimation ta = new ThicknessAnimation();
                    ta.From = new Thickness(618, 273, 0, 0);
                    ta.To = new Thickness(618, 72, 0, 0);
                    ta.Duration = TimeSpan.FromSeconds(0.2);
                    this.rct.BeginAnimation(Rectangle.MarginProperty, ta);
                }
                else if (rct.Margin.Top == 323)
                {
                    ThicknessAnimation ta = new ThicknessAnimation();
                    ta.From = new Thickness(618, 323, 0, 0);
                    ta.To = new Thickness(618, 72, 0, 0);
                    ta.Duration = TimeSpan.FromSeconds(0.2);
                    this.rct.BeginAnimation(Rectangle.MarginProperty, ta);
                }
            }
            else
            {
                if (rct.Margin.Top == 72)
                {
                    History.Visibility = Visibility.Visible;
                    Ph1.Visibility = Visibility.Visible;
                    Ph2.Visibility = Visibility.Visible;
                }
            }
        }

        private void Bot_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                History.Visibility = Visibility.Hidden;
                Ph1.Visibility = Visibility.Hidden;
                Ph2.Visibility = Visibility.Hidden;

                History.Margin = new Thickness(618, 77, 0, 333);
                Ph1.Margin = new Thickness(618, 122, 0, 288);
                Ph2.Margin = new Thickness(618, 167, 0, 243);
                It_im.Source = new BitmapImage(new Uri(@"pack://application:,,,/Im/It_artists/Botticelli.png"));

                if (rct.Margin.Top == 72)
                {
                    ThicknessAnimation ta = new ThicknessAnimation();
                    ta.From = new Thickness(618, 72, 0, 0);
                    ta.To = new Thickness(618, 122, 0, 0);
                    ta.Duration = TimeSpan.FromSeconds(0.2);
                    this.rct.BeginAnimation(Rectangle.MarginProperty, ta);
                }
                else if (rct.Margin.Top == 122)
                {
                    ThicknessAnimation ta = new ThicknessAnimation();
                    ta.From = new Thickness(618, 122, 0, 0);
                    ta.To = new Thickness(618, 122, 0, 0);
                    ta.Duration = TimeSpan.FromSeconds(0.2);
                    this.rct.BeginAnimation(Rectangle.MarginProperty, ta);           
                }
                else if (rct.Margin.Top == 172)
                {
                    ThicknessAnimation ta = new ThicknessAnimation();
                    ta.From = new Thickness(618, 172, 0, 0);
                    ta.To = new Thickness(618, 122, 0, 0);
                    ta.Duration = TimeSpan.FromSeconds(0.2);
                    this.rct.BeginAnimation(Rectangle.MarginProperty, ta);
                }
                else if (rct.Margin.Top == 223)
                {
                    ThicknessAnimation ta = new ThicknessAnimation();
                    ta.From = new Thickness(618, 223, 0, 0);
                    ta.To = new Thickness(618, 122, 0, 0);
                    ta.Duration = TimeSpan.FromSeconds(0.2);
                    this.rct.BeginAnimation(Rectangle.MarginProperty, ta);
                }
                else if (rct.Margin.Top == 273)
                {
                    ThicknessAnimation ta = new ThicknessAnimation();
                    ta.From = new Thickness(618, 273, 0, 0);
                    ta.To = new Thickness(618, 122, 0, 0);
                    ta.Duration = TimeSpan.FromSeconds(0.2);
                    this.rct.BeginAnimation(Rectangle.MarginProperty, ta);
                }
                else if (rct.Margin.Top == 323)
                {
                    ThicknessAnimation ta = new ThicknessAnimation();
                    ta.From = new Thickness(618, 323, 0, 0);
                    ta.To = new Thickness(618, 122, 0, 0);
                    ta.Duration = TimeSpan.FromSeconds(0.2);
                    this.rct.BeginAnimation(Rectangle.MarginProperty, ta);
                }
            }
            else
            {
                if (rct.Margin.Top == 122)
                {
                    History.Visibility = Visibility.Visible;
                    Ph1.Visibility = Visibility.Visible;
                    Ph2.Visibility = Visibility.Visible;
                }
            }
        }

        private void San_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                History.Visibility = Visibility.Hidden;
                Ph1.Visibility = Visibility.Hidden;
                Ph2.Visibility = Visibility.Hidden;

                History.Margin = new Thickness(618, 127, 0, 283);
                Ph1.Margin = new Thickness(618, 172, 0, 238);
                Ph2.Margin = new Thickness(618, 217, 0, 193);
                It_im.Source = new BitmapImage(new Uri(@"pack://application:,,,/Im/It_artists/Santi.png"));
                if (rct.Margin.Top == 72)
                {
                    ThicknessAnimation ta = new ThicknessAnimation();
                    ta.From = new Thickness(618, 72, 0, 0);
                    ta.To = new Thickness(618, 172, 0, 0);
                    ta.Duration = TimeSpan.FromSeconds(0.2);
                    this.rct.BeginAnimation(Rectangle.MarginProperty, ta);
                }
                else if (rct.Margin.Top == 122)
                {
                    ThicknessAnimation ta = new ThicknessAnimation();
                    ta.From = new Thickness(618, 122, 0, 0);
                    ta.To = new Thickness(618, 172, 0, 0);
                    ta.Duration = TimeSpan.FromSeconds(0.2);
                    this.rct.BeginAnimation(Rectangle.MarginProperty, ta);
                }
                else if (rct.Margin.Top == 172)
                {
                    ThicknessAnimation ta = new ThicknessAnimation();
                    ta.From = new Thickness(618, 172, 0, 0);
                    ta.To = new Thickness(618, 172, 0, 0);
                    ta.Duration = TimeSpan.FromSeconds(0.2);
                    this.rct.BeginAnimation(Rectangle.MarginProperty, ta);                  
                }
                else if (rct.Margin.Top == 223)
                {
                    ThicknessAnimation ta = new ThicknessAnimation();
                    ta.From = new Thickness(618, 223, 0, 0);
                    ta.To = new Thickness(618, 172, 0, 0);
                    ta.Duration = TimeSpan.FromSeconds(0.2);
                    this.rct.BeginAnimation(Rectangle.MarginProperty, ta);
                }
                else if (rct.Margin.Top == 273)
                {
                    ThicknessAnimation ta = new ThicknessAnimation();
                    ta.From = new Thickness(618, 273, 0, 0);
                    ta.To = new Thickness(618, 172, 0, 0);
                    ta.Duration = TimeSpan.FromSeconds(0.2);
                    this.rct.BeginAnimation(Rectangle.MarginProperty, ta);
                }
                else if (rct.Margin.Top == 323)
                {
                    ThicknessAnimation ta = new ThicknessAnimation();
                    ta.From = new Thickness(618, 323, 0, 0);
                    ta.To = new Thickness(618, 172, 0, 0);
                    ta.Duration = TimeSpan.FromSeconds(0.2);
                    this.rct.BeginAnimation(Rectangle.MarginProperty, ta);
                }
            }
            else
            {
                if (rct.Margin.Top == 172)
                {
                    History.Visibility = Visibility.Visible;
                    Ph1.Visibility = Visibility.Visible;
                    Ph2.Visibility = Visibility.Visible;
                }
            }
        }

        private void Mik_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                History.Visibility = Visibility.Hidden;
                Ph1.Visibility = Visibility.Hidden;
                Ph2.Visibility = Visibility.Hidden;

                History.Margin = new Thickness(618, 178, 0, 232);
                Ph1.Margin = new Thickness(618, 223, 0, 187);
                Ph2.Margin = new Thickness(618, 268, 0, 142);
                It_im.Source = new BitmapImage(new Uri(@"pack://application:,,,/Im/It_artists/Michelangelo.png"));

                if (rct.Margin.Top == 72)
                {
                    ThicknessAnimation ta = new ThicknessAnimation();
                    ta.From = new Thickness(618, 72, 0, 0);
                    ta.To = new Thickness(618, 223, 0, 0);
                    ta.Duration = TimeSpan.FromSeconds(0.2);
                    this.rct.BeginAnimation(Rectangle.MarginProperty, ta);
                }
                else if (rct.Margin.Top == 122)
                {
                    ThicknessAnimation ta = new ThicknessAnimation();
                    ta.From = new Thickness(618, 122, 0, 0);
                    ta.To = new Thickness(618, 223, 0, 0);
                    ta.Duration = TimeSpan.FromSeconds(0.2);
                    this.rct.BeginAnimation(Rectangle.MarginProperty, ta);
                }
                else if (rct.Margin.Top == 172)
                {
                    ThicknessAnimation ta = new ThicknessAnimation();
                    ta.From = new Thickness(618, 172, 0, 0);
                    ta.To = new Thickness(618, 223, 0, 0);
                    ta.Duration = TimeSpan.FromSeconds(0.2);
                    this.rct.BeginAnimation(Rectangle.MarginProperty, ta);
                }
                else if (rct.Margin.Top == 223)
                {
                    ThicknessAnimation ta = new ThicknessAnimation();
                    ta.From = new Thickness(618, 223, 0, 0);
                    ta.To = new Thickness(618, 223, 0, 0);
                    ta.Duration = TimeSpan.FromSeconds(0.2);
                    this.rct.BeginAnimation(Rectangle.MarginProperty, ta);                  
                }
                else if (rct.Margin.Top == 273)
                {
                    ThicknessAnimation ta = new ThicknessAnimation();
                    ta.From = new Thickness(618, 273, 0, 0);
                    ta.To = new Thickness(618, 223, 0, 0);
                    ta.Duration = TimeSpan.FromSeconds(0.2);
                    this.rct.BeginAnimation(Rectangle.MarginProperty, ta);
                }
                else if (rct.Margin.Top == 323)
                {
                    ThicknessAnimation ta = new ThicknessAnimation();
                    ta.From = new Thickness(618, 323, 0, 0);
                    ta.To = new Thickness(618, 223, 0, 0);
                    ta.Duration = TimeSpan.FromSeconds(0.2);
                    this.rct.BeginAnimation(Rectangle.MarginProperty, ta);
                }
            }
            else
            {
                if (rct.Margin.Top == 223)
                {
                    History.Visibility = Visibility.Visible;
                    Ph1.Visibility = Visibility.Visible;
                    Ph2.Visibility = Visibility.Visible;
                }
            }
        }

        private void Maz_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                History.Visibility = Visibility.Hidden;
                Ph1.Visibility = Visibility.Hidden;
                Ph2.Visibility = Visibility.Hidden;

                History.Margin = new Thickness(618, 233, 0, 177);
                Ph1.Margin = new Thickness(618, 278, 0, 132);
                Ph2.Margin = new Thickness(618, 323, 0, 87);
                It_im.Source = new BitmapImage(new Uri(@"pack://application:,,,/Im/It_artists/Mazachcho.png"));

                if (rct.Margin.Top == 72)
                {
                    ThicknessAnimation ta = new ThicknessAnimation();
                    ta.From = new Thickness(618, 72, 0, 0);
                    ta.To = new Thickness(618, 273, 0, 0);
                    ta.Duration = TimeSpan.FromSeconds(0.2);
                    this.rct.BeginAnimation(Rectangle.MarginProperty, ta);
                }
                else if (rct.Margin.Top == 122)
                {
                    ThicknessAnimation ta = new ThicknessAnimation();
                    ta.From = new Thickness(618, 122, 0, 0);
                    ta.To = new Thickness(618, 273, 0, 0);
                    ta.Duration = TimeSpan.FromSeconds(0.2);
                    this.rct.BeginAnimation(Rectangle.MarginProperty, ta);
                }
                else if (rct.Margin.Top == 172)
                {
                    ThicknessAnimation ta = new ThicknessAnimation();
                    ta.From = new Thickness(618, 172, 0, 0);
                    ta.To = new Thickness(618, 273, 0, 0);
                    ta.Duration = TimeSpan.FromSeconds(0.2);
                    this.rct.BeginAnimation(Rectangle.MarginProperty, ta);
                }
                else if (rct.Margin.Top == 223)
                {
                    ThicknessAnimation ta = new ThicknessAnimation();
                    ta.From = new Thickness(618, 223, 0, 0);
                    ta.To = new Thickness(618, 273, 0, 0);
                    ta.Duration = TimeSpan.FromSeconds(0.2);
                    this.rct.BeginAnimation(Rectangle.MarginProperty, ta);
                }
                else if (rct.Margin.Top == 273)
                {
                    ThicknessAnimation ta = new ThicknessAnimation();
                    ta.From = new Thickness(618, 273, 0, 0);
                    ta.To = new Thickness(618, 273, 0, 0);
                    ta.Duration = TimeSpan.FromSeconds(0.2);
                    this.rct.BeginAnimation(Rectangle.MarginProperty, ta);                  
                }
                else if (rct.Margin.Top == 323)
                {
                    ThicknessAnimation ta = new ThicknessAnimation();
                    ta.From = new Thickness(618, 323, 0, 0);
                    ta.To = new Thickness(618, 273, 0, 0);
                    ta.Duration = TimeSpan.FromSeconds(0.2);
                    this.rct.BeginAnimation(Rectangle.MarginProperty, ta);
                }
            }
            else
            {
                if (rct.Margin.Top == 273)
                {
                    History.Visibility = Visibility.Visible;
                    Ph1.Visibility = Visibility.Visible;
                    Ph2.Visibility = Visibility.Visible;
                }
            }
        }

        private void Kar_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                History.Visibility = Visibility.Hidden;
                Ph1.Visibility = Visibility.Hidden;
                Ph2.Visibility = Visibility.Hidden;

                History.Margin = new Thickness(617, 278, 1, 132);
                Ph1.Margin = new Thickness(617, 323, 1, 87);
                Ph2.Margin = new Thickness(617, 368, 1, 42);
                It_im.Source = new BitmapImage(new Uri(@"pack://application:,,,/Im/It_artists/Karavadzho.png"));
                if (rct.Margin.Top == 72)
                {
                    ThicknessAnimation ta = new ThicknessAnimation();
                    ta.From = new Thickness(618, 72, 0, 0);
                    ta.To = new Thickness(618, 323, 0, 0);
                    ta.Duration = TimeSpan.FromSeconds(0.2);
                    this.rct.BeginAnimation(Rectangle.MarginProperty, ta);
                }
                else if (rct.Margin.Top == 122)
                {
                    ThicknessAnimation ta = new ThicknessAnimation();
                    ta.From = new Thickness(618, 122, 0, 0);
                    ta.To = new Thickness(618, 323, 0, 0);
                    ta.Duration = TimeSpan.FromSeconds(0.2);
                    this.rct.BeginAnimation(Rectangle.MarginProperty, ta);
                }
                else if (rct.Margin.Top == 172)
                {
                    ThicknessAnimation ta = new ThicknessAnimation();
                    ta.From = new Thickness(618, 172, 0, 0);
                    ta.To = new Thickness(618, 323, 0, 0);
                    ta.Duration = TimeSpan.FromSeconds(0.2);
                    this.rct.BeginAnimation(Rectangle.MarginProperty, ta);
                }
                else if (rct.Margin.Top == 223)
                {
                    ThicknessAnimation ta = new ThicknessAnimation();
                    ta.From = new Thickness(618, 223, 0, 0);
                    ta.To = new Thickness(618, 323, 0, 0);
                    ta.Duration = TimeSpan.FromSeconds(0.2);
                    this.rct.BeginAnimation(Rectangle.MarginProperty, ta);
                }
                else if (rct.Margin.Top == 273)
                {
                    ThicknessAnimation ta = new ThicknessAnimation();
                    ta.From = new Thickness(618, 273, 0, 0);
                    ta.To = new Thickness(618, 323, 0, 0);
                    ta.Duration = TimeSpan.FromSeconds(0.2);
                    this.rct.BeginAnimation(Rectangle.MarginProperty, ta);
                }
                else if (rct.Margin.Top == 323)
                {
                    ThicknessAnimation ta = new ThicknessAnimation();
                    ta.From = new Thickness(618, 323, 0, 0);
                    ta.To = new Thickness(618, 323, 0, 0);
                    ta.Duration = TimeSpan.FromSeconds(0.2);
                    this.rct.BeginAnimation(Rectangle.MarginProperty, ta);
                }
            }
            else
            {
                if (rct.Margin.Top == 323)
                {
                    History.Visibility = Visibility.Visible;
                    Ph1.Visibility = Visibility.Visible;
                    Ph2.Visibility = Visibility.Visible;
                }
            }
        }

        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (_1.Visibility == Visibility.Visible)
            {
                _1.Visibility = Visibility.Hidden;
                _2.Visibility = Visibility.Hidden;
                _3.Visibility = Visibility.Hidden;
            }

            else
            {
                _1.Visibility = Visibility.Visible;
                _2.Visibility = Visibility.Visible;
                if (History.Visibility == Visibility.Visible)
                {
                    _3.Visibility = Visibility.Visible;
                }

            }

        }
    }
    
}


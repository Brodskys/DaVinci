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
    /// <summary>
    /// Логика взаимодействия для RF.xaml
    /// </summary>
    public partial class RF : Window
    {
        public RF()
        {
            InitializeComponent();

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

        private void Ivaz_Click(object sender, RoutedEventArgs e)
        {
            
            RF_im.Source = new BitmapImage(new Uri(@"pack://application:,,,/Im/RF_artists/Ivaz.png"));
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
          
        private void Kz_Mal_Click(object sender, RoutedEventArgs e)
        {
           RF_im.Source = new BitmapImage(new Uri(@"pack://application:,,,/Im/RF_artists/Kz_Mal.png"));
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

        private void Repin_Click(object sender, RoutedEventArgs e)
        {
            RF_im.Source = new BitmapImage(new Uri(@"pack://application:,,,/Im/RF_artists/Repin.png"));
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

        private void Shihkin_Click(object sender, RoutedEventArgs e)
        {
             RF_im.Source = new BitmapImage(new Uri(@"pack://application:,,,/Im/RF_artists/Shihkin.png"));
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

        private void Syrikov_Click(object sender, RoutedEventArgs e)
        {
             RF_im.Source = new BitmapImage(new Uri(@"pack://application:,,,/Im/RF_artists/Syrikov.png"));
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

        private void Serov_Click(object sender, RoutedEventArgs e)
        {
             RF_im.Source = new BitmapImage(new Uri(@"pack://application:,,,/Im/RF_artists/Serov.png"));
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
                //if (History.Visibility == Visibility.Visible)
                //{
                //    _3.Visibility = Visibility.Visible;
                //}
            }

        }
    }
}

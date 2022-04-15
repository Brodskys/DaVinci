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
    /// Логика взаимодействия для Nl.xaml
    /// </summary>
    public partial class Nl : Window
    {
        public Nl()
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

        private void V_Gog_Click(object sender, RoutedEventArgs e)
        {
        
            Nl_im.Source = new BitmapImage(new Uri(@"pack://application:,,,/Im/NI_artists/V_Gog.png"));
            if (rct.Margin.Top == 63)
            {
                ThicknessAnimation ta = new ThicknessAnimation();
                ta.To = new Thickness(642, 63, -64, 0);
                ta.To = new Thickness(642, 63, -64, 0);
                ta.Duration = TimeSpan.FromSeconds(0.2);
                this.rct.BeginAnimation(Rectangle.MarginProperty, ta);
            }
            else if (rct.Margin.Top == 113)
            {
                ThicknessAnimation ta = new ThicknessAnimation();
                ta.From = new Thickness(642, 113, -64, 0);
                ta.To = new Thickness(642, 63, -64, 0);
                ta.Duration = TimeSpan.FromSeconds(0.2);
                this.rct.BeginAnimation(Rectangle.MarginProperty, ta);
            }
            else if (rct.Margin.Top == 163)
            {
                ThicknessAnimation ta = new ThicknessAnimation();
                ta.From = new Thickness(642, 163, -64, 0);
                ta.To = new Thickness(642, 63, -64, 0);
                ta.Duration = TimeSpan.FromSeconds(0.2);
                this.rct.BeginAnimation(Rectangle.MarginProperty, ta);
            }
            else if (rct.Margin.Top == 213)
            {
                ThicknessAnimation ta = new ThicknessAnimation();
                ta.From = new Thickness(642, 213, -64, 0);
                ta.To = new Thickness(642, 63, -64, 0);
                ta.Duration = TimeSpan.FromSeconds(0.2);
                this.rct.BeginAnimation(Rectangle.MarginProperty, ta);
            }
            else if (rct.Margin.Top == 263)
            {
                ThicknessAnimation ta = new ThicknessAnimation();
                ta.From = new Thickness(642, 263, -64, 0);
                ta.To = new Thickness(642, 63, -64, 0);
                ta.Duration = TimeSpan.FromSeconds(0.2);
                this.rct.BeginAnimation(Rectangle.MarginProperty, ta);
            }
            else if (rct.Margin.Top == 313)
            {
                ThicknessAnimation ta = new ThicknessAnimation();
                ta.From = new Thickness(642, 313, -64, 0);
                ta.To = new Thickness(642, 63, -64, 0);
                ta.Duration = TimeSpan.FromSeconds(0.2);
                this.rct.BeginAnimation(Rectangle.MarginProperty, ta);
            }
        }

        private void Reb_Click(object sender, RoutedEventArgs e)
        {
            Nl_im.Source = new BitmapImage(new Uri(@"pack://application:,,,/Im/NI_artists/Rebr.png"));

            if (rct.Margin.Top == 63)
            {
                ThicknessAnimation ta = new ThicknessAnimation();
                ta.From = new Thickness(642, 63, -64, 0);
                ta.To = new Thickness(642, 113, -64, 0);
                ta.Duration = TimeSpan.FromSeconds(0.2);
                this.rct.BeginAnimation(Rectangle.MarginProperty, ta);
            }
            else if (rct.Margin.Top == 113)
            {
                ThicknessAnimation ta = new ThicknessAnimation();
                ta.From = new Thickness(642, 113, -64, 0);
                ta.To = new Thickness(642, 113, -64, 0);
                ta.Duration = TimeSpan.FromSeconds(0.2);
                this.rct.BeginAnimation(Rectangle.MarginProperty, ta);
            }
            else if (rct.Margin.Top == 163)
            {
                ThicknessAnimation ta = new ThicknessAnimation();
                ta.From = new Thickness(642, 163, -64, 0);
                ta.To = new Thickness(642, 113, -64, 0);
                ta.Duration = TimeSpan.FromSeconds(0.2);
                this.rct.BeginAnimation(Rectangle.MarginProperty, ta);
            }
            else if (rct.Margin.Top == 213)
            {
                ThicknessAnimation ta = new ThicknessAnimation();
                ta.From = new Thickness(642, 213, -64, 0);
                ta.To = new Thickness(642, 113, -64, 0);
                ta.Duration = TimeSpan.FromSeconds(0.2);
                this.rct.BeginAnimation(Rectangle.MarginProperty, ta);
            }
            else if (rct.Margin.Top == 263)
            {
                ThicknessAnimation ta = new ThicknessAnimation();
                ta.From = new Thickness(642, 263, -64, 0);
                ta.To = new Thickness(642, 113, -64, 0);
                ta.Duration = TimeSpan.FromSeconds(0.2);
                this.rct.BeginAnimation(Rectangle.MarginProperty, ta);
            }
            else if (rct.Margin.Top == 313)
            {
                ThicknessAnimation ta = new ThicknessAnimation();
                ta.From = new Thickness(642, 313, -64, 0);
                ta.To = new Thickness(642, 113, -64, 0);
                ta.Duration = TimeSpan.FromSeconds(0.2);
                this.rct.BeginAnimation(Rectangle.MarginProperty, ta);
            }
        }

        private void Ryb_Click(object sender, RoutedEventArgs e)
        {
            Nl_im.Source = new BitmapImage(new Uri(@"pack://application:,,,/Im/NI_artists/Rybens.png"));
            if (rct.Margin.Top == 63)
            {
                ThicknessAnimation ta = new ThicknessAnimation();
                ta.To = new Thickness(642, 63, -64, 0);
                ta.To = new Thickness(642, 163, -64, 0);
                ta.Duration = TimeSpan.FromSeconds(0.2);
                this.rct.BeginAnimation(Rectangle.MarginProperty, ta);
            }
            else if (rct.Margin.Top == 113)
            {
                ThicknessAnimation ta = new ThicknessAnimation();
                ta.From = new Thickness(642, 113, -64, 0);
                ta.To = new Thickness(642, 163, -64, 0);
                ta.Duration = TimeSpan.FromSeconds(0.2);
                this.rct.BeginAnimation(Rectangle.MarginProperty, ta);
            }
            else if (rct.Margin.Top == 163)
            {
                ThicknessAnimation ta = new ThicknessAnimation();
                ta.From = new Thickness(642, 163, -64, 0);
                ta.To = new Thickness(642, 163, -64, 0);
                ta.Duration = TimeSpan.FromSeconds(0.2);
                this.rct.BeginAnimation(Rectangle.MarginProperty, ta);
            }
            else if (rct.Margin.Top == 213)
            {
                ThicknessAnimation ta = new ThicknessAnimation();
                ta.From = new Thickness(642, 213, -64, 0);
                ta.To = new Thickness(642, 163, -64, 0);
                ta.Duration = TimeSpan.FromSeconds(0.2);
                this.rct.BeginAnimation(Rectangle.MarginProperty, ta);
            }
            else if (rct.Margin.Top == 263)
            {
                ThicknessAnimation ta = new ThicknessAnimation();
                ta.From = new Thickness(642, 263, -64, 0);
                ta.To = new Thickness(642, 163, -64, 0);
                ta.Duration = TimeSpan.FromSeconds(0.2);
                this.rct.BeginAnimation(Rectangle.MarginProperty, ta);
            }
            else if (rct.Margin.Top == 313)
            {
                ThicknessAnimation ta = new ThicknessAnimation();
                ta.From = new Thickness(642, 313, -64, 0);
                ta.To = new Thickness(642, 163, -64, 0);
                ta.Duration = TimeSpan.FromSeconds(0.2);
                this.rct.BeginAnimation(Rectangle.MarginProperty, ta);
            }
        }

        private void Potr_Click(object sender, RoutedEventArgs e)
        {
            Nl_im.Source = new BitmapImage(new Uri(@"pack://application:,,,/Im/NI_artists/potr.png"));
            if (rct.Margin.Top == 63)
            {
                ThicknessAnimation ta = new ThicknessAnimation();
                ta.To = new Thickness(642, 63, -64, 0);
                ta.To = new Thickness(642, 213, -64, 0);
                ta.Duration = TimeSpan.FromSeconds(0.2);
                this.rct.BeginAnimation(Rectangle.MarginProperty, ta);
            }
            else if (rct.Margin.Top == 113)
            {
                ThicknessAnimation ta = new ThicknessAnimation();
                ta.From = new Thickness(642, 113, -64, 0);
                ta.To = new Thickness(642, 213, -64, 0);
                ta.Duration = TimeSpan.FromSeconds(0.2);
                this.rct.BeginAnimation(Rectangle.MarginProperty, ta);
            }
            else if (rct.Margin.Top == 163)
            {
                ThicknessAnimation ta = new ThicknessAnimation();
                ta.From = new Thickness(642, 163, -64, 0);
                ta.To = new Thickness(642, 213, -64, 0);
                ta.Duration = TimeSpan.FromSeconds(0.2);
                this.rct.BeginAnimation(Rectangle.MarginProperty, ta);
            }
            else if (rct.Margin.Top == 213)
            {
                ThicknessAnimation ta = new ThicknessAnimation();
                ta.From = new Thickness(642, 213, -64, 0);
                ta.To = new Thickness(642, 213, -64, 0);
                ta.Duration = TimeSpan.FromSeconds(0.2);
                this.rct.BeginAnimation(Rectangle.MarginProperty, ta);
            }
            else if (rct.Margin.Top == 263)
            {
                ThicknessAnimation ta = new ThicknessAnimation();
                ta.From = new Thickness(642, 263, -64, 0);
                ta.To = new Thickness(642, 213, -64, 0);
                ta.Duration = TimeSpan.FromSeconds(0.2);
                this.rct.BeginAnimation(Rectangle.MarginProperty, ta);
            }
            else if (rct.Margin.Top == 313)
            {
                ThicknessAnimation ta = new ThicknessAnimation();
                ta.From = new Thickness(642, 313, -64, 0);
                ta.To = new Thickness(642, 213, -64, 0);
                ta.Duration = TimeSpan.FromSeconds(0.2);
                this.rct.BeginAnimation(Rectangle.MarginProperty, ta);
            }
        }

        private void Verm_Click(object sender, RoutedEventArgs e)
        {
            Nl_im.Source = new BitmapImage(new Uri(@"pack://application:,,,/Im/NI_artists/Ya_Verm.png"));
            if (rct.Margin.Top == 63)
            {
                ThicknessAnimation ta = new ThicknessAnimation();
                ta.To = new Thickness(642, 63, -64, 0);
                ta.To = new Thickness(642, 263, -64, 0);
                ta.Duration = TimeSpan.FromSeconds(0.2);
                this.rct.BeginAnimation(Rectangle.MarginProperty, ta);
            }
            else if (rct.Margin.Top == 113)
            {
                ThicknessAnimation ta = new ThicknessAnimation();
                ta.From = new Thickness(642, 113, -64, 0);
                ta.To = new Thickness(642, 263, -64, 0);
                ta.Duration = TimeSpan.FromSeconds(0.2);
                this.rct.BeginAnimation(Rectangle.MarginProperty, ta);
            }
            else if (rct.Margin.Top == 163)
            {
                ThicknessAnimation ta = new ThicknessAnimation();
                ta.From = new Thickness(642, 163, -64, 0);
                ta.To = new Thickness(642, 263, -64, 0);
                ta.Duration = TimeSpan.FromSeconds(0.2);
                this.rct.BeginAnimation(Rectangle.MarginProperty, ta);
            }
            else if (rct.Margin.Top == 213)
            {
                ThicknessAnimation ta = new ThicknessAnimation();
                ta.From = new Thickness(642, 213, -64, 0);
                ta.To = new Thickness(642, 263, -64, 0);
                ta.Duration = TimeSpan.FromSeconds(0.2);
                this.rct.BeginAnimation(Rectangle.MarginProperty, ta);
            }
            else if (rct.Margin.Top == 263)
            {
                ThicknessAnimation ta = new ThicknessAnimation();
                ta.From = new Thickness(642, 263, -64, 0);
                ta.To = new Thickness(642, 263, -64, 0);
                ta.Duration = TimeSpan.FromSeconds(0.2);
                this.rct.BeginAnimation(Rectangle.MarginProperty, ta);
            }
            else if (rct.Margin.Top == 313)
            {
                ThicknessAnimation ta = new ThicknessAnimation();
                ta.From = new Thickness(642, 313, -64, 0);
                ta.To = new Thickness(642, 263, -64, 0);
                ta.Duration = TimeSpan.FromSeconds(0.2);
                this.rct.BeginAnimation(Rectangle.MarginProperty, ta);
            }
        }

        private void Ykb_Click(object sender, RoutedEventArgs e)
        {
            Nl_im.Source = new BitmapImage(new Uri(@"pack://application:,,,/Im/NI_artists/Ykb.png"));
            if (rct.Margin.Top == 63)
            {
                ThicknessAnimation ta = new ThicknessAnimation();
                ta.To = new Thickness(642, 63, -64, 0);
                ta.To = new Thickness(642, 313, -64, 0);
                ta.Duration = TimeSpan.FromSeconds(0.2);
                this.rct.BeginAnimation(Rectangle.MarginProperty, ta);
            }
            else if (rct.Margin.Top == 113)
            {
                ThicknessAnimation ta = new ThicknessAnimation();
                ta.From = new Thickness(642, 113, -64, 0);
                ta.To = new Thickness(642, 313, -64, 0);
                ta.Duration = TimeSpan.FromSeconds(0.2);
                this.rct.BeginAnimation(Rectangle.MarginProperty, ta);
            }
            else if (rct.Margin.Top == 163)
            {
                ThicknessAnimation ta = new ThicknessAnimation();
                ta.From = new Thickness(642, 163, -64, 0);
                ta.To = new Thickness(642, 313, -64, 0);
                ta.Duration = TimeSpan.FromSeconds(0.2);
                this.rct.BeginAnimation(Rectangle.MarginProperty, ta);
            }
            else if (rct.Margin.Top == 213)
            {
                ThicknessAnimation ta = new ThicknessAnimation();
                ta.From = new Thickness(642, 213, -64, 0);
                ta.To = new Thickness(642, 313, -64, 0);
                ta.Duration = TimeSpan.FromSeconds(0.2);
                this.rct.BeginAnimation(Rectangle.MarginProperty, ta);
            }
            else if (rct.Margin.Top == 263)
            {
                ThicknessAnimation ta = new ThicknessAnimation();
                ta.From = new Thickness(642, 263, -64, 0);
                ta.To = new Thickness(642, 313, -64, 0);
                ta.Duration = TimeSpan.FromSeconds(0.2);
                this.rct.BeginAnimation(Rectangle.MarginProperty, ta);
            }
            else if (rct.Margin.Top == 313)
            {
                ThicknessAnimation ta = new ThicknessAnimation();
                ta.From = new Thickness(642, 313, -64, 0);
                ta.To = new Thickness(642, 313, -64, 0);
                ta.Duration = TimeSpan.FromSeconds(0.2);
                this.rct.BeginAnimation(Rectangle.MarginProperty, ta);
            }
        }

        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
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

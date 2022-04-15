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
    /// Логика взаимодействия для Is.xaml
    /// </summary>
    public partial class Is : Window
    {
        public Is()
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

        private void Dali_Click(object sender, RoutedEventArgs e)
        {
            Is_im.Source = new BitmapImage(new Uri(@"pack://application:,,,/Im/Is_artists\Dali.png"));
            if (rct.Margin.Top == 72)
            {
                ThicknessAnimation ta = new ThicknessAnimation();
                ta.From = new Thickness(618, 72, -65, 0);
                ta.To = new Thickness(618, 72, -65, 0);
                ta.Duration = TimeSpan.FromSeconds(0.2);
                this.rct.BeginAnimation(Rectangle.MarginProperty, ta);
            }
            else if (rct.Margin.Top == 122)
            {
                ThicknessAnimation ta = new ThicknessAnimation();
                ta.From = new Thickness(618, 122, -65, 0);
                ta.To = new Thickness(618, 72, -65, 0);
                ta.Duration = TimeSpan.FromSeconds(0.2);
                this.rct.BeginAnimation(Rectangle.MarginProperty, ta);
            }
            else if (rct.Margin.Top == 172)
            {
                ThicknessAnimation ta = new ThicknessAnimation();
                ta.From = new Thickness(618, 172, -65, 0);
                ta.To = new Thickness(618, 72, -65, 0);
                ta.Duration = TimeSpan.FromSeconds(0.2);
                this.rct.BeginAnimation(Rectangle.MarginProperty, ta);
            }
            else if (rct.Margin.Top == 223)
            {
                ThicknessAnimation ta = new ThicknessAnimation();
                ta.From = new Thickness(618, 223, -65, 0);
                ta.To = new Thickness(618, 72, -65, 0);
                ta.Duration = TimeSpan.FromSeconds(0.2);
                this.rct.BeginAnimation(Rectangle.MarginProperty, ta);
            }
            else if (rct.Margin.Top == 273)
            {
                ThicknessAnimation ta = new ThicknessAnimation();
                ta.From = new Thickness(618, 273, -65, 0);
                ta.To = new Thickness(618, 72, -65, 0);
                ta.Duration = TimeSpan.FromSeconds(0.2);
                this.rct.BeginAnimation(Rectangle.MarginProperty, ta);
            }
            else if (rct.Margin.Top == 323)
            {
                ThicknessAnimation ta = new ThicknessAnimation();
                ta.From = new Thickness(618, 323, -65, 0);
                ta.To = new Thickness(618, 72, -65, 0);
                ta.Duration = TimeSpan.FromSeconds(0.2);
                this.rct.BeginAnimation(Rectangle.MarginProperty, ta);
            }

        }

        private void Pikasso_Click(object sender, RoutedEventArgs e)
        {
            Is_im.Source = new BitmapImage(new Uri(@"pack://application:,,,/Im/Is_artists\Pikasso.png"));
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

        private void Velaskes_Click(object sender, RoutedEventArgs e)
        {
            Is_im.Source = new BitmapImage(new Uri(@"pack://application:,,,/Im/Is_artists\Velaskes.png"));
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

        private void Myril_Click(object sender, RoutedEventArgs e)
        {
            Is_im.Source = new BitmapImage(new Uri(@"pack://application:,,,/Im/Is_artists\Myril.png"));
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

        private void Goya_Click(object sender, RoutedEventArgs e)
        {
            Is_im.Source = new BitmapImage(new Uri(@"pack://application:,,,/Im/Is_artists\Goya.png"));
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

        private void Greko_Click(object sender, RoutedEventArgs e)
        {
            Is_im.Source = new BitmapImage(new Uri(@"pack://application:,,,/Im/Is_artists\Greko.png"));
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

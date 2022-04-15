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
    /// Логика взаимодействия для Be.xaml
    /// </summary>
    public partial class Be : Window
    {
        public Be()
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

        private void Magrit_Click(object sender, RoutedEventArgs e)
        {
            BE_im.Source = new BitmapImage(new Uri(@"pack://application:,,,/Im/BE_artists/Magrit.png"));
            if (rct.Margin.Top == 89)
            {
                ThicknessAnimation ta = new ThicknessAnimation();
                ta.From = new Thickness(546, 89, 0, 0);
                ta.To = new Thickness(546, 89, 0, 0);
                ta.Duration = TimeSpan.FromSeconds(0.2);
                this.rct.BeginAnimation(Rectangle.MarginProperty, ta);
            }
            else if (rct.Margin.Top == 139)
            {
                ThicknessAnimation ta = new ThicknessAnimation();
                ta.From = new Thickness(546, 139, 0, 0);
                ta.To = new Thickness(546, 89, 0, 0);
                ta.Duration = TimeSpan.FromSeconds(0.2);
                this.rct.BeginAnimation(Rectangle.MarginProperty, ta);
            }
            else if (rct.Margin.Top == 189)
            {
                ThicknessAnimation ta = new ThicknessAnimation();
                ta.From = new Thickness(546, 189, 0, 0);
                ta.To = new Thickness(546, 89, 0, 0);
                ta.Duration = TimeSpan.FromSeconds(0.2);
                this.rct.BeginAnimation(Rectangle.MarginProperty, ta);
            }
            else if (rct.Margin.Top == 239)
            {
                ThicknessAnimation ta = new ThicknessAnimation();
                ta.From = new Thickness(546, 239, 0, 0);
                ta.To = new Thickness(546, 89, 0, 0);
                ta.Duration = TimeSpan.FromSeconds(0.2);
                this.rct.BeginAnimation(Rectangle.MarginProperty, ta);
            }
           
        }

        private void Delvo_Click(object sender, RoutedEventArgs e)
        {
            BE_im.Source = new BitmapImage(new Uri(@"pack://application:,,,/Im/BE_artists/Delvo.png"));
            if (rct.Margin.Top == 89)
            {
                ThicknessAnimation ta = new ThicknessAnimation();
                ta.From = new Thickness(546, 89, 0, 0);
                ta.To = new Thickness(546, 139, 0, 0);
                ta.Duration = TimeSpan.FromSeconds(0.2);
                this.rct.BeginAnimation(Rectangle.MarginProperty, ta);
            }
            else if (rct.Margin.Top == 139)
            {
                ThicknessAnimation ta = new ThicknessAnimation();
                ta.From = new Thickness(546, 139, 0, 0);
                ta.To = new Thickness(546, 139, 0, 0);
                ta.Duration = TimeSpan.FromSeconds(0.2);
                this.rct.BeginAnimation(Rectangle.MarginProperty, ta);
            }
            else if (rct.Margin.Top == 189)
            {
                ThicknessAnimation ta = new ThicknessAnimation();
                ta.From = new Thickness(546, 189, 0, 0);
                ta.To = new Thickness(546, 139, 0, 0);
                ta.Duration = TimeSpan.FromSeconds(0.2);
                this.rct.BeginAnimation(Rectangle.MarginProperty, ta);
            }
            else if (rct.Margin.Top == 239)
            {
                ThicknessAnimation ta = new ThicknessAnimation();
                ta.From = new Thickness(546, 239, 0, 0);
                ta.To = new Thickness(546, 139, 0, 0);
                ta.Duration = TimeSpan.FromSeconds(0.2);
                this.rct.BeginAnimation(Rectangle.MarginProperty, ta);
            }

        }

        private void Ek_Click(object sender, RoutedEventArgs e)
        {
            BE_im.Source = new BitmapImage(new Uri(@"pack://application:,,,/Im/BE_artists/Ek.png"));
            if (rct.Margin.Top == 89)
            {
                ThicknessAnimation ta = new ThicknessAnimation();
                ta.From = new Thickness(546, 89, 0, 0);
                ta.To = new Thickness(546, 189, 0, 0);
                ta.Duration = TimeSpan.FromSeconds(0.2);
                this.rct.BeginAnimation(Rectangle.MarginProperty, ta);
            }
            else if (rct.Margin.Top == 139)
            {
                ThicknessAnimation ta = new ThicknessAnimation();
                ta.From = new Thickness(546, 139, 0, 0);
                ta.To = new Thickness(546, 189, 0, 0);
                ta.Duration = TimeSpan.FromSeconds(0.2);
                this.rct.BeginAnimation(Rectangle.MarginProperty, ta);
            }
            else if (rct.Margin.Top == 189)
            {
                ThicknessAnimation ta = new ThicknessAnimation();
                ta.From = new Thickness(546, 189, 0, 0);
                ta.To = new Thickness(546, 189, 0, 0);
                ta.Duration = TimeSpan.FromSeconds(0.2);
                this.rct.BeginAnimation(Rectangle.MarginProperty, ta);
            }
            else if (rct.Margin.Top == 239)
            {
                ThicknessAnimation ta = new ThicknessAnimation();
                ta.From = new Thickness(546, 239, 0, 0);
                ta.To = new Thickness(546, 189, 0, 0);
                ta.Duration = TimeSpan.FromSeconds(0.2);
                this.rct.BeginAnimation(Rectangle.MarginProperty, ta);
            }
        }

        private void Deik_Click(object sender, RoutedEventArgs e)
        {
            BE_im.Source = new BitmapImage(new Uri(@"pack://application:,,,/Im/BE_artists/Deik.png"));
            if (rct.Margin.Top == 89)
            {
                ThicknessAnimation ta = new ThicknessAnimation();
                ta.From = new Thickness(546, 89, 0, 0);
                ta.To = new Thickness(546, 239, 0, 0);
                ta.Duration = TimeSpan.FromSeconds(0.2);
                this.rct.BeginAnimation(Rectangle.MarginProperty, ta);
            }
            else if (rct.Margin.Top == 139)
            {
                ThicknessAnimation ta = new ThicknessAnimation();
                ta.From = new Thickness(546, 139, 0, 0);
                ta.To = new Thickness(546, 239, 0, 0);
                ta.Duration = TimeSpan.FromSeconds(0.2);
                this.rct.BeginAnimation(Rectangle.MarginProperty, ta);
            }
            else if (rct.Margin.Top == 189)
            {
                ThicknessAnimation ta = new ThicknessAnimation();
                ta.From = new Thickness(546, 189, 0, 0);
                ta.To = new Thickness(546, 239, 0, 0);
                ta.Duration = TimeSpan.FromSeconds(0.2);
                this.rct.BeginAnimation(Rectangle.MarginProperty, ta);
            }
            else if (rct.Margin.Top == 239)
            {
                ThicknessAnimation ta = new ThicknessAnimation();
                ta.From = new Thickness(546, 239, 0, 0);
                ta.To = new Thickness(546, 239, 0, 0);
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

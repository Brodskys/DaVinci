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
namespace DaVinci.It_tvor
{
    /// <summary>
    /// Логика взаимодействия для Botich_kart.xaml
    /// </summary>
    public partial class Botich_kart : Window
    {
        public Botich_kart()
        {
            InitializeComponent();
        }
         
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Closing -= Window_Closing;
            e.Cancel = true;
            var animation = new DoubleAnimation(0, (Duration)TimeSpan.FromSeconds(1));
            animation.Completed += (s, _) => Close();
            BeginAnimation(UIElement.OpacityProperty, animation);

            It form = new It();
            form.Show();
        }
        string[] names = { "Мадонна с младенцем и ангелом", "Христос в терновом венце", "Поклонение волхвов", "Портрет Данте", "Нахождение тела Олоферна", "Воскресший Христос", "Аллегория силы", "Святой Доминик", "Мадонна дель Розето", "Портрет Джулиано Медичи", "Рождество", "Возвращение Юдифи в Ветулию", "Святой Августин в келье", "Мадонна с младенцем на троне", "Портрет молодого человека"};
        int _currentName = 0;
        private void Window_MouseLeave(object sender, MouseEventArgs e)
        {
            rig.Visibility = Visibility.Hidden;
            lef.Visibility = Visibility.Hidden;
        }

        private void Window_MouseEnter(object sender, MouseEventArgs e)
        {
            rig.Visibility = Visibility.Visible;
            lef.Visibility = Visibility.Visible;
        }

        private void Rig_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var main = (MainViewModel_bot)DataContext;
            _currentName++;
            if (_currentName == 15)
                _currentName = 0;
            name_kart.Content = names[_currentName];
            main.SetNextImage();
        }

        private void Lef_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            _currentName--;
            if (_currentName == -1)
                _currentName = 14;
            name_kart.Content = names[_currentName];
            var main = (MainViewModel_bot)DataContext;
            main.SetPreviousImage();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var main = (MainViewModel_bot)DataContext;
            main.Intialize();
        }

    }
}
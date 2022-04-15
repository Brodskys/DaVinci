using System;
using System.Reflection;
using System.Windows.Media.Imaging;


namespace DaVinci.Im.It_artists.car
{
    class ContentProvider_car
    {
        const string UriPack = "pack://application:,,,";
        /// <summary>Uri путь к ресурсам сборки</summary>
        static readonly string ResourcesUri = "/" + Assembly.GetExecutingAssembly().GetName().Name + ";component/Im/It_artists/";

        private static readonly ContentProvider_car _contentProvider;
        private BitmapImage[] _defaultPictures;

        static ContentProvider_car()
        {
            _contentProvider = new ContentProvider_car();
        }

        public static ContentProvider_car Instance
        {
            get { return _contentProvider; }
        }

        public BitmapImage[] GetDefaultPictures()
        {
            if (_defaultPictures == null)
            {
                _defaultPictures = new[]
                    {
                        new BitmapImage(new Uri(ResourcesUri + "Kartini/Natchis.jpg", UriKind.Relative)),
                        new BitmapImage(new Uri(ResourcesUri + "Kartini/Medusa.jpg", UriKind.Relative)),
                        new BitmapImage(new Uri(ResourcesUri + "Kartini/Good_Luck.jpg", UriKind.Relative)),
                        new BitmapImage(new Uri(ResourcesUri + "Kartini/The_Cardsharps.jpg", UriKind.Relative)),
                        new BitmapImage(new Uri(ResourcesUri + "Kartini/Obrshenie_Savla.jpg", UriKind.Relative)),
                        new BitmapImage(new Uri(ResourcesUri + "Kartini/Taking_of_Christ.jpg", UriKind.Relative)), 
                        new BitmapImage(new Uri(ResourcesUri + "Kartini/michelangelo.jpg", UriKind.Relative)),
                          new BitmapImage(new Uri(ResourcesUri + "Kartini/Yshen v Emmayse.jpg", UriKind.Relative)),
                          new BitmapImage(new Uri(ResourcesUri + "Kartini/Madonna_of_the_Rosary.jpg", UriKind.Relative)),
                        new BitmapImage(new Uri(ResourcesUri + "Kartini/Meshestvo.jpg", UriKind.Relative))

                    };
            }

            return _defaultPictures;
        }
    }
}

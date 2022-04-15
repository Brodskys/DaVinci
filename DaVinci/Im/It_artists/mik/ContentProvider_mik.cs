using System;
using System.Reflection;
using System.Windows.Media.Imaging;


namespace DaVinci.Im.It_artists.mik
{
    class ContentProvider_mik
    {
        const string UriPack = "pack://application:,,,";
        /// <summary>Uri путь к ресурсам сборки</summary>
        static readonly string ResourcesUri = "/" + Assembly.GetExecutingAssembly().GetName().Name + ";component/Im/It_artists/";

        private static readonly ContentProvider_mik _contentProvider;
        private BitmapImage[] _defaultPictures;

        static ContentProvider_mik()
        {
            _contentProvider = new ContentProvider_mik();
        }

        public static ContentProvider_mik Instance
        {
            get { return _contentProvider; }
        }

        public BitmapImage[] GetDefaultPictures()
        {
            if (_defaultPictures == null)
            {
                _defaultPictures = new[]
                    {
                        new BitmapImage(new Uri(ResourcesUri + "Kartini/delfiiskaya-sivilla.jpg", UriKind.Relative)),
                        new BitmapImage(new Uri(ResourcesUri + "Kartini/eritreiskaya-sivilla.jpg", UriKind.Relative)),
                        new BitmapImage(new Uri(ResourcesUri + "Kartini/kumskaya-sivilla.jpg", UriKind.Relative)),
                        new BitmapImage(new Uri(ResourcesUri + "Kartini/liviiskaya-sivilla.jpg", UriKind.Relative)),
                        new BitmapImage(new Uri(ResourcesUri + "Kartini/persidskaya-sivilla.jpg", UriKind.Relative)),
                        new BitmapImage(new Uri(ResourcesUri + "Kartini/prorok-ieremiya.jpg", UriKind.Relative)),
                        new BitmapImage(new Uri(ResourcesUri + "Kartini/prorok-isaya.jpg", UriKind.Relative))                   
                    };
            }

            return _defaultPictures;
        }
    }
}
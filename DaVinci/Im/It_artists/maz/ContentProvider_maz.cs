using System;
using System.Reflection;
using System.Windows.Media.Imaging;


namespace DaVinci.Im.It_artists.maz
{
    class ContentProvider_maz
    {
        const string UriPack = "pack://application:,,,";
        /// <summary>Uri путь к ресурсам сборки</summary>
        static readonly string ResourcesUri = "/" + Assembly.GetExecutingAssembly().GetName().Name + ";component/Im/It_artists/";

        private static readonly ContentProvider_maz _contentProvider;
        private BitmapImage[] _defaultPictures;

        static ContentProvider_maz()
        {
            _contentProvider = new ContentProvider_maz();
        }

        public static ContentProvider_maz Instance
        {
            get { return _contentProvider; }
        }

        public BitmapImage[] GetDefaultPictures()
        {
            if (_defaultPictures == null)
            {
                _defaultPictures = new[]
                    {
                        new BitmapImage(new Uri(ResourcesUri + "Kartini/kreschenie-neofitov.jpg", UriKind.Relative)),
                        new BitmapImage(new Uri(ResourcesUri + "Kartini/madonna-s-mladencem-i-sv.-annoy.jpg", UriKind.Relative)),
                        new BitmapImage(new Uri(ResourcesUri + "Kartini/razdacha-imuschestva-i-smert-ananii.jpg", UriKind.Relative)),
                        new BitmapImage(new Uri(ResourcesUri + "Kartini/petr-iscelyaet-bolnogo-svoey-tenyu.jpg", UriKind.Relative)),
                        new BitmapImage(new Uri(ResourcesUri + "Kartini/raspyatie-apostola-petra.jpg", UriKind.Relative)),
                        new BitmapImage(new Uri(ResourcesUri + "Kartini/svyatoy-ieronim-i-svyatoy-ioann-krestitel.jpg", UriKind.Relative)),
                        new BitmapImage(new Uri(ResourcesUri + "Kartini/raspyatie.jpg", UriKind.Relative))
                    };
            }

            return _defaultPictures;
        }
    }
}
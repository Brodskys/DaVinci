using System;
using System.Reflection;
using System.Windows.Media.Imaging;

namespace DaVinci.Im.It_artists.san
{
    class ContentProvider_san
    {

        const string UriPack = "pack://application:,,,";
        /// <summary>Uri путь к ресурсам сборки</summary>
        static readonly string ResourcesUri = "/" + Assembly.GetExecutingAssembly().GetName().Name + ";component/Im/It_artists/";

        private static readonly ContentProvider_san _contentProvider;
        private BitmapImage[] _defaultPictures;

        static ContentProvider_san()
        {
            _contentProvider = new ContentProvider_san();
        }

        public static ContentProvider_san Instance
        {
            get { return _contentProvider; }
        }

        public BitmapImage[] GetDefaultPictures()
        {
            if (_defaultPictures == null)
            {
                _defaultPictures = new[]
                    {
                        new BitmapImage(new Uri(ResourcesUri + "Kartini/sviatoimihailidiavol.jpg", UriKind.Relative)),
                        new BitmapImage(new Uri(ResourcesUri + "Kartini/obruchenie_devi_Marii.jpg", UriKind.Relative)),
                        new BitmapImage(new Uri(ResourcesUri + "Kartini/svyatoy_georgiy_i_drakon.jpg", UriKind.Relative)),
                        new BitmapImage(new Uri(ResourcesUri + "Kartini/La-Donna-Velata.jpg", UriKind.Relative)),
                        new BitmapImage(new Uri(ResourcesUri + "Kartini/portrait_castiglione.jpg", UriKind.Relative)),
                        new BitmapImage(new Uri(ResourcesUri + "Kartini/triumph_Galatei.jpg", UriKind.Relative)),
                        new BitmapImage(new Uri(ResourcesUri + "Kartini/preobrajenie.jpg", UriKind.Relative)),
                        new BitmapImage(new Uri(ResourcesUri + "Kartini/madonna_di_folinio.jpg", UriKind.Relative)),
                        new BitmapImage(new Uri(ResourcesUri + "Kartini/madonnaansidei.jpg", UriKind.Relative)), 
                           new BitmapImage(new Uri(ResourcesUri + "Kartini/sikstinskaya_Madonna.jpg", UriKind.Relative))
                    };
            }

            return _defaultPictures;
        }
    }
}
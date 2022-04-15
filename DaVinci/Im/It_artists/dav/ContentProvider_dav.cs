using System;
using System.Reflection;
using System.Windows.Media.Imaging;


namespace DaVinci.Im.It_artists
{
    public class ContentProvider_dav
    {
        const string UriPack = "pack://application:,,,";
        /// <summary>Uri путь к ресурсам сборки</summary>
        static readonly string ResourcesUri = "/" + Assembly.GetExecutingAssembly().GetName().Name + ";component/Im/It_artists/";

        private static readonly ContentProvider_dav _contentProvider;
        private BitmapImage[] _defaultPictures;

        static ContentProvider_dav()
        {
            _contentProvider = new ContentProvider_dav();
        }

        public static ContentProvider_dav Instance
        {
            get { return _contentProvider; }
        }

        public BitmapImage[] GetDefaultPictures()
        {
            if (_defaultPictures == null)
            {
                _defaultPictures = new[]
                    {
                        new BitmapImage(new Uri(ResourcesUri + "Kartini/Baptism_of_Christ.jpg", UriKind.Relative)),
                        new BitmapImage(new Uri(ResourcesUri + "Kartini/Benois_Madonna.jpg", UriKind.Relative)),
                        new BitmapImage(new Uri(ResourcesUri + "Kartini/Dama_con_ermellino.jpg", UriKind.Relative)),
                        new BitmapImage(new Uri(ResourcesUri + "Kartini/Ginevra_de_Benci.jpg", UriKind.Relative)),
                        new BitmapImage(new Uri(ResourcesUri + "Kartini/Ioann_Krestitel.jpg", UriKind.Relative)),
                        new BitmapImage(new Uri(ResourcesUri + "Kartini/La_Belle_Ferronnière.jpg", UriKind.Relative)),
                        new BitmapImage(new Uri(ResourcesUri + "Kartini/Madonna_Litta.jpg", UriKind.Relative)),
                        new BitmapImage(new Uri(ResourcesUri + "Kartini/Madonna_of_the_Carnation.jpg", UriKind.Relative)),
                        new BitmapImage(new Uri(ResourcesUri + "Kartini/Mona_Lisa.jpg", UriKind.Relative)),
                        new BitmapImage(new Uri(ResourcesUri + "Kartini/Portrait_of_a_Musician.jpg", UriKind.Relative)),
                         new BitmapImage(new Uri(ResourcesUri + "Kartini/Vergine_delle_Rocce.jpg", UriKind.Relative))
                        
                    };
            }

            return _defaultPictures;
        }
    }
}

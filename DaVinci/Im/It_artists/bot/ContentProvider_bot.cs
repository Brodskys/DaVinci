using System;
using System.Reflection;
using System.Windows.Media.Imaging;

namespace DaVinci.Im.It_artists.bot
{
    class ContentProvider_bot
    {
        const string UriPack = "pack://application:,,,";
        /// <summary>Uri путь к ресурсам сборки</summary>
        static readonly string ResourcesUri = "/" + Assembly.GetExecutingAssembly().GetName().Name + ";component/Im/It_artists/";

        private static readonly ContentProvider_bot _contentProvider;
        private BitmapImage[] _defaultPictures;

        static ContentProvider_bot()
        {
            _contentProvider = new ContentProvider_bot();
        }

        public static ContentProvider_bot Instance
        {
            get { return _contentProvider; }
        }

        public BitmapImage[] GetDefaultPictures()
        {
            if (_defaultPictures == null)
            {
                _defaultPictures = new[]
                    {
                        new BitmapImage(new Uri(ResourcesUri + "Kartini/A_Virgem_e_o_Menino_com_um_anjo.jpg", UriKind.Relative)),
                        new BitmapImage(new Uri(ResourcesUri + "Kartini/Accademia_Carrara.jpg", UriKind.Relative)),
                        new BitmapImage(new Uri(ResourcesUri + "Kartini/Adorazione_dei_Magi.jpg", UriKind.Relative)),
                        new BitmapImage(new Uri(ResourcesUri + "Kartini/Dante.jpg", UriKind.Relative)),
                        new BitmapImage(new Uri(ResourcesUri + "Kartini/Descoberta_do_corpo_de_Holofernes.jpg", UriKind.Relative)),
                        new BitmapImage(new Uri(ResourcesUri + "Kartini/Detroit.jpg", UriKind.Relative)),
                        new BitmapImage(new Uri(ResourcesUri + "Kartini/fortezza.jpg", UriKind.Relative)),
                        new BitmapImage(new Uri(ResourcesUri + "Kartini/Hermitage.jpg", UriKind.Relative)),
                        new BitmapImage(new Uri(ResourcesUri + "Kartini/MadonnaRoseto.jpg", UriKind.Relative)),
                        new BitmapImage(new Uri(ResourcesUri + "Kartini/medici_bergamo.jpg", UriKind.Relative)),
                         new BitmapImage(new Uri(ResourcesUri + "Kartini/Nativity.jpg", UriKind.Relative)),
                          new BitmapImage(new Uri(ResourcesUri + "Kartini/Retour_de_Judith.jpg", UriKind.Relative)),
                            new BitmapImage(new Uri(ResourcesUri + "Kartini/Sandro.jpg", UriKind.Relative)),
                              new BitmapImage(new Uri(ResourcesUri + "Kartini/The_Virgin_and_Child_Enthroned.jpg", UriKind.Relative)),
                                   new BitmapImage(new Uri(ResourcesUri + "Kartini/YoungMan.jpg", UriKind.Relative))
                    };
            }

            return _defaultPictures;
        }
    }
}

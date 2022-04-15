using System.Collections.Generic;
using System.Windows.Media.Imaging;
using DaVinci.Mvvm;
using DaVinci.Im.It_artists;
using DaVinci.It_tvor;

namespace DaVinci
{
    public class MainViewModel_dav : ViewModelBase_dav
    {
        private bool _isInitialized;
        private BitmapImage _currentImage;
        private string _currentName;
        private int _currentIndex = -1;

        public MainViewModel_dav()
        {
            
        }

        public void Intialize()
        {
            Images = new List<BitmapImage>(ContentProvider_dav.Instance.GetDefaultPictures());
            SetNextImage();
            IsInitialized = true;
        }
      
        public List<BitmapImage> Images { get; set; }
        
        public BitmapImage CurrentImage
        {
            get { return _currentImage; }
            set
            {
                _currentImage = value;
                
                RaisePropertyChanged("CurrentImage");
            }
        }
        public string CurrentName
        {
            get { return _currentName; }
            set
            { 
                _currentName = value;

                RaisePropertyChanged("CurrentName");
            }
        }
        public bool IsInitialized
        {
            get { return _isInitialized; }
            set
            {
                _isInitialized = value;
                RaisePropertyChanged("IsInitialized");
            }
        }
        
        public void SetNextImage()
        {
            _currentIndex++;
            
            if (_currentIndex == Images.Count)
            {
                _currentIndex = 0;
            }
          

            CurrentImage = Images[_currentIndex];
        }

        public void SetPreviousImage()
        {
            _currentIndex--;

            if (_currentIndex == -1)
            {
                _currentIndex = Images.Count - 1;
            }
      

            CurrentImage = Images[_currentIndex];

        }
    }
}

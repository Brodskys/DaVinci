using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;


namespace DaVinci.Mvvm
{
    class ViewModelBase_mik : INotifyPropertyChanged
    {
        private static bool? _isInDesignMode;
        protected ViewModelBase_mik()
        {
        }
        public virtual String DisplayName { get; protected set; }

        protected virtual bool ThrowOnInvalidPropertyNames { get; private set; }
        public bool IsInDesignMode
        {
            get
            {
                return IsInDesignModeStatic;
            }
        }

        public static bool IsInDesignModeStatic
        {
            get
            {
                if (!_isInDesignMode.HasValue)
                    _isInDesignMode = new bool?((bool)DependencyPropertyDescriptor.FromProperty(
                        DesignerProperties.IsInDesignModeProperty, typeof(FrameworkElement)).Metadata.DefaultValue);
                return _isInDesignMode.Value;
            }
        }

        [field: NonSerialized]
        public event PropertyChangedEventHandler PropertyChanged;

        [Conditional("DEBUG")]
        [DebuggerStepThrough]
        public void VerifyPropertyName(string propertyName)
        {
            if (null == TypeDescriptor.GetProperties(this)[propertyName])
            {
                string msg = "Invalid property name: " + propertyName;
                if (ThrowOnInvalidPropertyNames)
                    throw new Exception(msg);
                else
                    Debug.Fail(msg);
            }
        }

        protected void RaisePropertyChanged(string propertyName)
        {
            VerifyPropertyName(propertyName);
            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
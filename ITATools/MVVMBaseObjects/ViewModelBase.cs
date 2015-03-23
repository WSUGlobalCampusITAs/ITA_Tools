using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace MVVMBaseObjects
{
        /// <summary>
        /// Base class for all project View Models
        /// Provides interface elements for INotify, and IDisposable
        /// </summary>
        public class ViewModelBase : INotifyPropertyChanged, IDisposable
        {
            public event PropertyChangedEventHandler PropertyChanged;

            protected ViewModelBase()
            {
            }

            protected virtual void OnPropertyChanged(string propertyName)
            {
                PropertyChangedEventHandler handler = this.PropertyChanged;
                if (handler != null)
                {
                    var e = new PropertyChangedEventArgs(propertyName);
                    handler(this, e);
                }
            }

            public void Dispose()
            {
                this.OnDispose();
            }

            protected virtual void OnDispose()
            { }
        }
}

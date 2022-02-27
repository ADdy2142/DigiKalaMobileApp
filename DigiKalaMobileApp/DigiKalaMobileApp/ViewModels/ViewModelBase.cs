using DigiKalaMobileApp.Data.UnitOfWork;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiKalaMobileApp.ViewModels
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        public UnitOfWork UnitOfWork => new UnitOfWork();

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVMObjectLibrary;
using ITATools.Properties;

namespace ITATools.ViewModel
{
    public class HomeViewModel : ViewModelBase
    {
        private string _homeMessage;

        public HomeViewModel()
        {
            _homeMessage = Settings.Default.HomeMessage;
        }

        public string WelcomeMessage { get { return _homeMessage; } }
    }
}

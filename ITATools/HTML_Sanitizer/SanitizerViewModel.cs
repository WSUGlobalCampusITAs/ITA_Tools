using Ganss.XSS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Input;
using MVVMObjectLibrary;

namespace HTML_Sanitizer
{
    class SanitizerViewModel
    {
        private HtmlSanitizer _sanitizer;
        private string _htmlCode;
        private ICommand _sanitizeCommand;
        
        public SanitizerViewModel()
        {
            _sanitizer = new HtmlSanitizer();
            _sanitizeCommand = new RelayCommand(Sanitize);
        }

        private void Sanitize(object obj)
        {
           this.HTMLCode = _sanitizer.Sanitize(_htmlCode);
        }

        public ICommand SanitizeCommand { get { return _sanitizeCommand; } }

        public string HTMLCode
        {
            get { return _htmlCode; }
            set { _htmlCode = value; }
        }
    }
}

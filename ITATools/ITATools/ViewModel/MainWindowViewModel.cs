using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVMObjectLibrary;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Calendar_Converter.ViewModel;
using CodeGenerator;

namespace ITATools.ViewModel
{
    public class MainWindowViewModel : ViewModelBase
    {
        #region Member Variables

            private ViewModelBase _currentViewModel;
            private ViewModelBase _ccView;
            private ViewModelBase _hsView;
            private ViewModelBase _cgView;
            private ViewModelBase _home;
            private ICommand _homeCommand;
            private ICommand _ccCommand;
            private ICommand _cgCommand;
            private ICommand _hsCommand;
            private bool _scrollingenabled;

        #endregion

        #region Default Constructor
        public MainWindowViewModel()
        {
            _ccView = new Calendar_Converter.ViewModel.MainWindowViewModel();
            _hsView = new JunkCodeRemover.JunkCodeRemoverViewModel();
            _cgView = new CodeGeneratorViewModel();
            _home = new HomeViewModel();
            _currentViewModel = _home;
            this.SettingsCommand = null;
            _homeCommand = new RelayCommand(Home);
            _ccCommand = new RelayCommand(CalendarConverter);
            _cgCommand = new RelayCommand(CodeGenerator);
            _hsCommand = new RelayCommand(HTMLSanitizer);
            this.SettingsCommand = new RelayCommand(SettingsDisplay);
        }
        #endregion

        #region Event Handlers
        
        #endregion

        #region Properties
        /// <summary>
        /// The CurrentViewModel Property provides the data for the MainWindow that allows the various User Controls to
        /// be populated, and displayed.
        /// </summary>
        public ViewModelBase CurrentViewModel
        {
            get { return _currentViewModel; }
            set 
            { 
                _currentViewModel = value;
                OnPropertyChanged("CurrentViewModel");
            }
        }
        /// <summary>
        /// Command Property for the Home Button
        /// </summary>
        public ICommand CalendarConverterCommand { get { return _ccCommand; } }

        /// <summary>
        /// Command Property for the Home Button
        /// </summary>
        public ICommand CodeGeneratorCommand { get { return _cgCommand; } }

        /// <summary>
        /// Command Property for the Home Button
        /// </summary>
        public ICommand HTMLSanitizeCommand { get { return _hsCommand; } }

        /// <summary>
        /// Command Property for the Home Button
        /// </summary>
        public ICommand HomeCommand { get { return _homeCommand; } }

        public bool ScrollingEnabled 
        { 
            get 
            { 
                return _scrollingenabled; 
            }
            set
            {
                _scrollingenabled = value;
                OnPropertyChanged("ScrollingEnabled");
            }
        }

        #endregion

        #region Member Methods

        private void Home(object obj)
        {
            CurrentViewModel = _home;
            ScrollingEnabled = true;

        }
        
        private void CalendarConverter(object obj)
        {
            CurrentViewModel = _ccView;
            ScrollingEnabled = true;
           
        }

        private void CodeGenerator(object obj)
        {
            CurrentViewModel = _cgView;
        }

        private void HTMLSanitizer(object obj)
        {
            CurrentViewModel = _hsView;
            ScrollingEnabled = false;
        }

        private void SettingsDisplay(object obj)
        {
            try
            {
                CurrentViewModel.SettingsCommand.Execute(this);
            }
            catch (NullReferenceException)
            {

            }
        }
        /// <summary>
        /// OnDispose Overrides the default OnDispose, and causes the collections
        /// instantiated to be cleared.
        /// </summary>
        protected override void OnDispose()
        {

        }
        #endregion
    }
}

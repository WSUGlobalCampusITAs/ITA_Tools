using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVMObjectLibrary;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Calendar_Converter.ViewModel;

namespace ITATools.ViewModel
{
    public class MainWindowViewModel : ViewModelBase
    {
        #region Member Variables

            private ObservableCollection<ViewModelBase> _currentViewModel;
            private ViewModelBase _ccView;
            private ViewModelBase _hsView;
            private ViewModelBase _cgView;
            private ICommand _homeCommand;
            private ICommand _ccCommand;
            private ICommand _cgCommand;
            private ICommand _hsCommand;

        #endregion

        #region Default Constructor
        public MainWindowViewModel()
        {
            _ccView = new Calendar_Converter.ViewModel.MainWindowViewModel();
            _hsView = new JunkCodeRemover.JunkCodeRemoverViewModel();
            _cgView = new Calendar_Converter.ViewModel.MainWindowViewModel();
            _currentViewModel = new ObservableCollection<ViewModelBase>();
            _currentViewModel.Add(_ccView);
            this._settingsCommand = _ccView.SettingsCommand;
            _homeCommand = new RelayCommand(Home);
            _ccCommand = new RelayCommand(CalendarConverter);
            _cgCommand = new RelayCommand(CodeGenerator);
            _hsCommand = new RelayCommand(HTMLSanitizer);
        }
        #endregion

        #region Event Handlers
        
        #endregion

        #region Properties
        /// <summary>
        /// The CurrentViewModel Property provides the data for the MainWindow that allows the various User Controls to
        /// be populated, and displayed.
        /// </summary>
        public ObservableCollection<ViewModelBase> CurrentViewModel
        {
            get { return _currentViewModel; }
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

        #endregion

        #region Member Methods

        private void Home(object obj)
        {
            _currentViewModel.Clear();
        }
        
        private void CalendarConverter(object obj)
        {
            _currentViewModel[0] = _ccView;
            this._settingsCommand = _ccView.SettingsCommand;
        }

        private void CodeGenerator(object obj)
        {
            _currentViewModel[0] = _cgView;
            this._settingsCommand = _cgView.SettingsCommand;
        }

        private void HTMLSanitizer(object obj)
        {
            _currentViewModel[0] = _hsView;
            this._settingsCommand = _hsView.SettingsCommand;
        }
        /// <summary>
        /// OnDispose Overrides the default OnDispose, and causes the collections
        /// instantiated to be cleared.
        /// </summary>
        protected override void OnDispose()
        {
            this.CurrentViewModel.Clear();
        }
        #endregion
    }
}

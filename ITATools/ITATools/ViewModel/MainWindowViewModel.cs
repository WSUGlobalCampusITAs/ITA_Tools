using Calendar_Converter.ViewModel;
using MVVMObjectLibrary;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ITATools.ViewModel
{
    public class MainWindowViewModel : ViewModelBase
    {

        #region Member Variables
        private ObservableCollection<ViewModelBase> _currentViewModel;
        private ViewModelBase _mainView;
        #endregion

        #region Default Constructor
        public MainWindowViewModel()
        {
            _mainView = new MainViewViewModel();
            _currentViewModel = new ObservableCollection<ViewModelBase>();
            _currentViewModel.Add(_mainView);
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

        #endregion

        #region Member Methods
       
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

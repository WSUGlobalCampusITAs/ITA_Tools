using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVMObjectLibrary;
using System.Collections.ObjectModel;

namespace CodeGenerator
{
    public class CodeGeneratorViewModel : ViewModelBase
    {
        private ObservableCollection<CodeModel> _code;
        private CodeRepository _repo;

        public CodeGeneratorViewModel()
        {
            _repo = new CodeRepository();
            _code = new ObservableCollection<CodeModel>(_repo.CodeList);
        }

        public ObservableCollection<CodeModel> CodeCollection { get { return _code; } }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.IO;

namespace CodeGenerator
{
    public class CodeRepository
    {
        private List<CodeModel> _codeList;

        public CodeRepository()
        {
            _codeList = new List<CodeModel>();

            //The following is only for testing. Will add proper xml file read later. 
            _codeList.Add(new CodeModel("Syllabus", CodeGenerator.Properties.Settings.Default.SyllabusCode));
        }

        /// <summary>
        /// To do, create an xml file with titles and content for various code.
        /// Read in the content and populate codeList with CodeModels.
        /// </summary>
        private void LoadXMLFile()
        {
           
        }

        public List<CodeModel> CodeList { get { return _codeList; } }
    }
}

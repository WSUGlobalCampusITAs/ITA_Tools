using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator
{
    public class CodeModel
    {
        public string Code { get; set; }
        public string Title { get; set; }

        public CodeModel(string Title, string Code)
        {
            this.Title = Title;
            this.Code = Code;
        }
    }
}

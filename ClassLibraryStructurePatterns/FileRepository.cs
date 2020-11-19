using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryStructurePatterns
{
    public class FileRepository : IDataRepository
    {
        public string obtainData()
        {
            return "file data repository.";
        }
    }
}

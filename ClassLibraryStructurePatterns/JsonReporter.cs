using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryStructurePatterns
{
    public class JsonReporter : IReporter
    {
        private IDataRepository dataRepository;

        public JsonReporter(IDataRepository dataRepository)
        {
            this.dataRepository = dataRepository;
        }

        public string createReport()
        {
            return "Json report obtain data from " + dataRepository.obtainData();
        }
    }
}

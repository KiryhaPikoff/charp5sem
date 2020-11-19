using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryStructurePatterns
{
    public class XmlReporter : IReporter
    {
        private IDataRepository dataRepository;

        public XmlReporter(IDataRepository dataRepository)
        {
            this.dataRepository = dataRepository;
        }

        public string createReport()
        {
            return "Xml report obtain data from " + dataRepository.obtainData();
        }
    }
}

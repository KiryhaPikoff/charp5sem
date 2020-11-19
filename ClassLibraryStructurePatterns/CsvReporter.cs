using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryStructurePatterns
{
    public class CsvReporter : IReporter
    {
        private IDataRepository dataRepository;

        public CsvReporter(IDataRepository dataRepository) {
            this.dataRepository = dataRepository;
        }

        public string createReport()
        {
            return "Csv report obtain data from " + dataRepository.obtainData();
        }
    }
}

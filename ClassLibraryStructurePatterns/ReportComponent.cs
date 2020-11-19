using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibraryStructurePatterns
{
    public partial class ReportComponent: Component
    {
        public ReportComponent()
        {
        }

        public string createReport(ReportType reportType, RepositoryType repositoryType) {
            IDataRepository repository;
            switch (repositoryType) {
                case RepositoryType.FILE:
                {
                    repository = new FileRepository();
                    break;
                }

                case RepositoryType.SITE:
                {
                    repository = new SiteParser();
                    break;
                }

                default:
                {
                    repository = new FileRepository();
                    break;
                }
            }

            IReporter reporter;
            switch (reportType)
            {
                case ReportType.CSV:
                {
                    reporter = new CsvReporter(repository);
                    break;
                }

                case ReportType.XML:
                {
                    reporter = new XmlReporter(repository);
                    break;
                }

                case ReportType.JSON:
                {
                    reporter = new JsonReporter(repository);
                    break;
                }

                default:
                {
                    reporter = new JsonReporter(repository);
                    break;
                }
            }

            return reporter.createReport();
        }
    }
}

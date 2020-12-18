
using EmployeeBusinessLogic.BindingModel;
using EmployeeBusinessLogic.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.IO;
using System.Linq;


namespace EmployeeBusinessLogic
{
    public class PluginManager
    {
        [ImportMany(typeof(IEmployeePlugin))]
        IEnumerable<IEmployeePlugin> Plugins { get; set; }

        public readonly Dictionary<string, Func<EmployeeBindingModel, EmployeeBindingModel>> plgs = new Dictionary<string, Func<EmployeeBindingModel, EmployeeBindingModel>>();
        public List<string> Headers { get; set; }
        public PluginManager()
        {
            AggregateCatalog catalog = new AggregateCatalog();
            var pa = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Plugins");
            catalog.Catalogs.Add(new DirectoryCatalog(pa));
            CompositionContainer container = new CompositionContainer(catalog);
            container.ComposeParts(this);
            Headers = new List<string>();
            if (Plugins.Count() != 0)
            {
                Plugins.ToList()
                    .ForEach(p =>
                        plgs.Add(p.Name, (employee) => p.Handle(employee)
                    )
                );
                Headers.AddRange(plgs.Keys.ToList());
            }
        }
    }
}

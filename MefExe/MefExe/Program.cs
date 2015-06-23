using Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition.Hosting;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Composition;

namespace MefExe
{
    class Program
    {
        static void Main(string[] args)
        {
            var catalog = new AggregateCatalog();

            string executionFile = Assembly.GetExecutingAssembly().Location;

            FileInfo fileInfo = new FileInfo(executionFile);
            catalog.Catalogs.Add(new DirectoryCatalog(fileInfo.Directory.FullName));

            CompositionContainer container = new CompositionContainer(catalog);


            Holder h = new Holder();

            container.ComposeParts(h);



        }
    }
}

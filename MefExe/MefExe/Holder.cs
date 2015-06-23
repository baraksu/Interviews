using Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MefExe
{
    public class Holder
    {
        [ImportMany(typeof(ICommand))]

        public IEnumerable<Lazy<ICommand>> Commands { get; set; }
        


    }
}

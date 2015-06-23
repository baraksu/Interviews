using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts;
using System.ComponentModel.Composition;

namespace Commands
{
    [Export(typeof(ICommand))]
    public class OutputCommand : ICommand

    {
        public Task Execute()
        {
            return Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.Out.WriteLine("O {0}", i);
                    System.Threading.Thread.Sleep(100);
                }
            });

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sitta.Core
{
    internal interface IFlow
    {
        public IStep CurrentStep { get; }
    }

    internal interface IStep
    {
        string Name { get; }
    }
}

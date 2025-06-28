using Sitta.Core.Descriptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sitta.Core
{
    public interface IParser
    {
        public IDescription Parse(string description);
        public IEnumerable<IDescription> Parse(IEnumerable<string> description);
    }

    internal class Parser : IParser
    {
        public IDescription Parse(string description)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IDescription> Parse(IEnumerable<string> description)
        {
            throw new NotImplementedException();
        }
    }
}

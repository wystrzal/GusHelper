using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GusHelper
{
    public sealed class GusHelperClient
    {
        private readonly string key;
        private readonly bool production;

        public GusHelperClient(string key, bool production = true)
        {
            this.key = key;
            this.production = production;
        }


    }
}

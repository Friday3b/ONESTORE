using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace testbinding
{
    public class Store
    {
        public string? Name { get; set; }

        internal object ToLower()
        {
            throw new NotImplementedException();
        }
    }
}

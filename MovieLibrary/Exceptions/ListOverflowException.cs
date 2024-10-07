using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibrary.Exceptioins
{
    public class ListOverflowException:Exception
    {

        public ListOverflowException(string message) : base(message) { }
    }

}


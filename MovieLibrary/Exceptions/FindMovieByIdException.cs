using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibrary.Exceptions
{
    public class FindMovieByIdException:Exception
    {
        public FindMovieByIdException(string Message):base(Message) { }
    }
}

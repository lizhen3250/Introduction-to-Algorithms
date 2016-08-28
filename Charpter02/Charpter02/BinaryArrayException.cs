using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charpter02
{
    public class BinaryArrayException : Exception
    {
        public BinaryArrayException() { }
        public BinaryArrayException(string message) : base(message) { }     
    }
}

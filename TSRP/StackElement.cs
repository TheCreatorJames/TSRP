using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSRP
{
    public abstract class StackElement : ICloneable
    {
        public abstract object Clone();
        public abstract bool Execute(string command, TSRPStack stack);
    }
  
}

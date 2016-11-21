using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSRP
{
    class StackFunction : StackString
    {
        public StackFunction(String s)
        {
            value = s;
        }

        public StackFunction(StackFunction s) : this(s.value)
        {

        }

        public StackFunction() : this("")
        {

        }

        public override object Clone()
        {
            return new StackFunction(this);
        }


        public override bool Execute(string command, TSRPStack stack)
        {
            if(command == "string")
            {
                stack.Pop();
                stack.Push(value);
                return true;
            }
            return base.Execute(command, stack);
        }

        public override string ToString()
        {
            return base.ToString() + "[Function]";
        }
    }
}

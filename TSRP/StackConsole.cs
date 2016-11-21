using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSRP
{
    class StackConsole : StackCustom
    {
        public override object Clone()
        {
            return new StackConsole();
        }

        public override bool Execute(string command, TSRPStack stack)
        {
            if(command == "WriteLine")
            {
                if(stack.Top is StackString)
                {
                    Console.WriteLine(((StackString)stack.Pop()).Value);
                }
                return true;
            } else
            if (command == "Write")
            {
                if (stack.Top is StackString)
                {
                    Console.Write(((StackString)stack.Pop()).Value);
                }
                return true;
            }
            else
            if (command == "Read")
            {
                var l = Console.ReadLine();
                stack.Push(l);
                return true;
            }
            else
            if (command == "ReadChar")
            {
                string str = Console.ReadKey().KeyChar + "";
                stack.Push(str);
                return true;
            }
            return false;
        }
    }
}

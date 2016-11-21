using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSRP
{
    public class StackString : StackElement
    {
        protected string value;


        public StackString() : this("")
        {

        }

        public StackString(string value)
        {
            this.value = value;
        }

        public StackString(StackString copy) : this(copy.value)
        {

        }

       


        public string Value
        {
            get
            {
                return value;
            }

            set
            {
                this.value = value;
            }
        }

        private readonly string[] types = new string[] { "long", "int", "uint", "ulong", "double", "float", "short", "byte", "sbyte" };
        public override bool Execute(string command, TSRPStack stack)
        {
            if (command == "function")
            {
                stack.Pop();
                stack.Push(new StackFunction(value));
                return true;
            }
            else
            if (types.Contains(command))
            {
                stack.Pop();
                StackNumber a = StackNumber.Convert(command, value);
                stack.Push(a);
                return true;
            }
            else if (command == "+")
            {
                if (stack.FromTop(1) is StackNumber)
                {
                    stack.Pop();
                    var a = (StackNumber)stack.Pop();
                    stack.Push(new StackString(a.ToString() + value));
                }
                else
                if (stack.FromTop(1) is StackString)
                {
                    stack.Pop();
                    var a = (StackString)stack.Pop();
                    stack.Push(new StackString(a.value + value));
                }
                else return false;
                return true;
            }
            else if (command == "array")
            {
                stack.Pop();
                stack.Push(new StackArray(this));
                return true;
            }
            else if (command == "chararray" || command == "carray")
            {
                stack.Pop();
                stack.Push(new StackArray(this, true));
                return true;
            }
            else if (command == "string")
            {
                return true;
            }
            else if (command == "==")
            {
                if (stack.FromTop(1) is StackString)
                {
                    stack.Pop();
                    var a = (StackString)stack.Pop();
                    stack.Push(a.value == value);
                    return true;
                }
            }
            else if (command == "!=")
            {
                if (stack.FromTop(1) is StackString)
                {
                    stack.Pop();
                    var a = (StackString)stack.Pop();
                    stack.Push(a.value != value);
                    return true;
                }

            }
            else if (command == "contains")
            {
                if (stack.FromTop(1) is StackString)
                {
                    stack.Pop();
                    var a = (StackString)stack.Pop();
                    stack.Push(a.value.Contains(value));
                    return true;
                }
            }
            else if (command == "split")
            {
                if (stack.FromTop(1) is StackString)
                {
                    stack.Pop();
                    var a = (StackString)stack.Pop();
                    var b = new TSRPStack();

                    var c = a.value.Split(new string[] { value }, StringSplitOptions.None);
                    foreach (string d in c)
                    {
                        b.Push(d);
                    }
                    stack.Push(new StackArray(b));

                    return true;
                }

            }
            else if (command == "trim")
            {
                stack.Pop();
                stack.Push(value.Trim().Replace("\n", "").Replace("\r","").Replace("\t", ""));
                return true;
            }
            else if (command == "len" || command == "length")
            {
                stack.Pop();
                stack.Push(value.Length);
                return true;
            }


            return false;
        }

        public override object Clone()
        {
            return new StackString(this);
        }

        public override string ToString()
        {
            return value.ToString();
        }
    }
}

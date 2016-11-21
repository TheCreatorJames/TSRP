using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSRP
{
    public class StackArray : StackCustom
    {
        private TSRPStack elements;


        public StackArray()
        {
            elements = new TSRPStack();
        }

        public StackArray(TSRPStack s)
        {
            elements = s;
        }

        public StackArray(StackArray copy) : this()
        {
            foreach (StackElement e in copy.elements.Elements)
            {
                elements.Push((StackElement)e.Clone());
            }
        }

        public StackArray(StackString ss, bool dig = false) : this(ss.Value, dig)
        {
        }

        public StackArray(String s, bool dig = false) : this()
        {
            if (dig)
                foreach (char n in s)
                {
                    elements.Push((ushort)n);
                }
            else
                foreach (char n in s)
                {
                    elements.Push("" + n);
                }
        }



        public void Push(StackElement el)
        {
            elements.Push(el);
        }

        public StackElement Pop()
        {
            return elements.Pop();
        }

        public int Count
        {
            get
            {
                return elements.Count;
            }
        }


        public StackElement[] Elements
        {
            get
            {
                return elements.Elements;
            }

            set
            {
                elements.Clear();
                elements.Elements = value;
            }
        }

        public override object Clone()
        {
            return new StackArray(this);
        }

        public override bool Execute(string command, TSRPStack stack)
        {
            if (command.EndsWith("*") && (stack.Top == this || command.EndsWith("**")))
            {
                int k = 1;
                if (command.EndsWith("**")) k = 2;
                bool j = Execute(command.Substring(0, command.Length - k), stack);
                
                int counter = 0;
               
                while (stack.Top != this)
                {
                    counter++;
                    elements.Push(stack.Pop());
                }

                stack.Pop();

                for(int i = 0; i < counter; i++)
                {
                    stack.Push(elements.Pop());
                }
            }
            else
            if (command == "size")
            {
                stack.Push(Count);
                return true;
            }
            else
            if (command == "at")
            {
                if (stack.Top is StackNumber)
                {
                    int n = ((StackNumber)stack.Pop()).ToInt();
                    if (n < Count)
                    {
                        stack.Push(((StackElement)elements.FromTop(Count - n - 1).Clone()));
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }

                return false;
            }
            else
            if (command == "push" || command == "array_push")
            {
                if (stack.Count != 0)
                    elements.Push(stack.Pop());
                return true;
            }
            else
            if (command == "array_pop")
            {
                if (elements.Count > 0)
                {
                    stack.Push(elements.Pop());
                    return true;
                }
                else return false;
            }
            else
            if (command == "set")
            {
                if (stack.Top is StackNumber)
                {
                    int n = ((StackNumber)stack.Pop()).ToInt();
                    StackElement el = stack.Pop();
                    var x = Elements;
                    if (n < Count)
                    {
                        x[n] = el;
                        elements.Elements = x;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
                return false;
            }
            else if (command == "chars2str")
            {
                var x = Elements;
                StringBuilder b = new StringBuilder();
                for (int i = 0; i < x.Length; i++)
                {
                    StackNumber y = null;
                    if (x[i] is StackNumber)
                    {
                        y = (StackNumber)x[i];
                    }
                    else continue;
                    b.Append((char)y.ToUnsignedShort());
                }
                stack.Push(b.ToString());
                return true;
            }
            else if (command == "concatstr")
            {
                var x = Elements;
                StringBuilder b = new StringBuilder();
                for (int i = 0; i < x.Length; i++)
                {
                    StackString y = null;
                    if (x[i] is StackString)
                    {
                        y = (StackString)x[i];
                    }
                    else continue;
                    b.Append(y.Value);
                }
                stack.Push(b.ToString());
                return true;
            }
            else if (command == "array_clear" || command == "empty")
            {
                elements.Clear();
                return true;
            }
            else if (command == "release")
            {
                stack.Pop();
                var els = elements.Elements;
                //Array.Reverse(els);
                foreach (StackElement el in els)
                {
                    stack.Push(el);
                }
                elements.Clear();

                return true;
            }
            else if (command == "clone")
            {
                stack.Push(new StackArray(this));
                return true;
            }
            else if (command == "reverse")
            {
                var x = elements.Elements;

                elements.Clear();
                for (var i = x.Length - 1; i >= 0; i--)
                    elements.Push(x[i]);

                return true;
            }


            return false;
        }

        public TSRPStack GetTSRPStack()
        {
            return elements;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TSRP
{
    public class StackBool : StackElement
    {
        private bool value;


        public StackBool() : this(false)
        {

        }

        public StackBool(bool value)
        {
            this.value = value;
        }

        
        public StackBool(StackBool copy) : this(copy.value)
        {
        }

        public bool Value
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

        public static bool Equals(StackBool a, StackBool b)
        {
            return a.value == b.value;
        }

		public static bool Xor(StackBool a, StackBool b)
        {
            return a.value ^ b.value;
        }

		public static bool Or(StackBool a, StackBool b)
        {
            return a.value || b.value;
        }

		public static bool And(StackBool a, StackBool b)
        {
            return a.value && b.value;
        }

        private bool Equals(TSRPStack stack, bool flip = false)
        {
            if (stack.Top is StackBool && stack.FromTop(1) is StackBool)
            {
                StackBool a = (StackBool)stack.Pop();
                StackBool b = (StackBool)stack.Pop();
                var c = Equals(a, b) ^ flip;
				stack.Push(new StackBool(c));
                return true;
            }
            
            return false;
        }

	    private bool Or(TSRPStack stack, bool flip = false)
        {
            if (stack.Top is StackBool && stack.FromTop(1) is StackBool)
            {
                StackBool a = (StackBool)stack.Pop();
                StackBool b = (StackBool)stack.Pop();
                var c = Or(a, b) ^ flip;
				stack.Push(new StackBool(c));
                return true;
            }
            
            return false;
        }


		private bool Xor(TSRPStack stack, bool flip = false)
        {
            if (stack.Top is StackBool && stack.FromTop(1) is StackBool)
            {
                StackBool a = (StackBool)stack.Pop();
                StackBool b = (StackBool)stack.Pop();
                var c = Xor(a, b) ^ flip;
				stack.Push(new StackBool(c));
                return true;
            }
            
            return false;
        }

		public override object Clone()
		{
			return new StackBool(this);
		}
		
	    private bool And(TSRPStack stack, bool flip = false)
        {
            if (stack.Top is StackBool && stack.FromTop(1) is StackBool)
            {
                StackBool a = (StackBool)stack.Pop();
                StackBool b = (StackBool)stack.Pop();
                var c = And(a, b) ^ flip;
				stack.Push(new StackBool(c));
                return true;
            }
            
            return false;
        }



        public override bool Execute(string command, TSRPStack stack)
        {
            if (command == "!" || command == "not")
            {
                stack.Pop();
				stack.Push(!value);
                return true;
            }
            else if (command == "string")
            {
                stack.Pop();
                stack.Push(value.ToString());
                return true; 
            }
            else if (command == "==")
            {
                return Equals(stack);
            }
            else if (command == "!=")
            {
                return Equals(stack, true);
            }
			else if (command == "&&" || command == "and")
			{
				return And(stack);
			}
			else if (command == "nand")
			{
				return And(stack, true);
			}
			else if (command == "or" || command == "||")
			{
				return Or(stack);
			}
			else if (command == "xor" || command == "^")
			{
				return Xor(stack);
			}
			else if (command == "nor")
			{
				return Or(stack, true);
			}
			else if (command == "int")
			{
				stack.Pop();
				byte a = 1;
				if(!value) a = 0;
				stack.Push((int)a);
				return true;
			}
			else if (command == "double")
			{
				stack.Pop();
				byte a = 1;
				if(!value) a = 0;
				stack.Push((double)a);
				return true;
			}
			else if (command == "float")
			{
				stack.Pop();
				byte a = 1;
				if(!value) a = 0;
				stack.Push((float)a);
				return true;
			}
			else if (command == "uint")
			{
				stack.Pop();
				byte a = 1;
				if(!value) a = 0;
				stack.Push((uint)a);
				return true;
			}
			else if (command == "long")
			{
				stack.Pop();
				byte a = 1;
				if(!value) a = 0;
				stack.Push((long)a);
				return true;
			}
			else if (command == "ulong")
			{
				stack.Pop();
				byte a = 1;
				if(!value) a = 0;
				stack.Push((ulong)a);
				return true;
			}
			else if (command == "short")
			{
				stack.Pop();
				byte a = 1;
				if(!value) a = 0;
				stack.Push((short)a);
				return true;
			}
			else if (command == "ushort")
			{
				stack.Pop();
				byte a = 1;
				if(!value) a = 0;
				stack.Push((ushort)a);
				return true;
			}
			else if (command == "byte")
			{
				stack.Pop();
				byte a = 1;
				if(!value) a = 0;
				stack.Push((byte)a);
				return true;
			}
			else if (command == "sbyte")
			{
				stack.Pop();
				byte a = 1;
				if(!value) a = 0;
				stack.Push((sbyte)a);
				return true;
			}
           

            return false;
        }

		public override String ToString()
		{
			return value.ToString();
		}
    }
}

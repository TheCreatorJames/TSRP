
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace TSRP
{

    public class TSRPStack
    {
        private Stack<StackElement> elements;
		private Stack<StackCustom> customs; 

        public TSRPStack()
        {
			customs = new Stack<StackCustom>();
            elements = new Stack<StackElement>();
        }

        public StackElement[] Elements
        {
            get
            {
				var result = elements.ToArray();
				Array.Reverse(result);

                return result;
            }

			set
			{
				elements.Clear();
				foreach(StackElement el in value)
				{
					Push(el);
				}
			}
            
        }


		public void Reverse()
		{
			
            //inefficient but necessary without more tricks
			elements = new Stack<StackElement>(elements.Reverse());
			customs = new Stack<StackCustom>(customs.Reverse());
		}

        public int Count
        {
            get
            {
                return elements.Count;
            }
        }


		public void Clear()
		{
			elements.Clear();
		}


	
		public void Push(int n)
        {
            Push(new StackInt(n));
        }

		
		public void Push(double n)
        {
            Push(new StackDouble(n));
        }

		
		public void Push(float n)
        {
            Push(new StackFloat(n));
        }

		
		public void Push(uint n)
        {
            Push(new StackUnsignedInt(n));
        }

		
		public void Push(long n)
        {
            Push(new StackLong(n));
        }

		
		public void Push(ulong n)
        {
            Push(new StackUnsignedLong(n));
        }

		
		public void Push(short n)
        {
            Push(new StackShort(n));
        }

		
		public void Push(ushort n)
        {
            Push(new StackUnsignedShort(n));
        }

		
		public void Push(byte n)
        {
            Push(new StackByte(n));
        }

		
		public void Push(sbyte n)
        {
            Push(new StackSignedByte(n));
        }

	
        public void Push(bool n)
        {
            Push(new StackBool(n));
        }

        public void Push(string n)
        {
	

            Push(new StackString(n));
        }

        public void Push(StackElement n)
        {
			if(n is StackCustom) customs.Push((StackCustom)n);
            elements.Push(n);
        }

        public StackElement FromTop(int n)
        {
			if(Count < n) return null;
        
            return elements.ElementAt(n);
        }

		public StackCustom TopCustom
		{
			get
			{
				if(customs.Count == 0) return null;
				return customs.Peek();
			}
		}

        public StackElement Top
        {
            get
            {
				if(Count == 0) return null;
                return elements.Peek();
            }
        }

        public StackElement Pop()
        {
			if(Top == TopCustom) customs.Pop();
            return elements.Pop();
        }

		public override String ToString()
		{
			string result = "";
			foreach(var s in elements)
			{
				result = s.ToString() + " " + result;
			}
			return result;

		}
    }
}

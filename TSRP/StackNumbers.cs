
using System;

namespace TSRP
{


// This code is automatically generated.
public abstract class StackNumber : StackElement
{
	protected static Random random = new Random();
		public abstract byte[] Bytes
		{
			get;
		}

	public int ToInt()
	{
		if(this is StackInt)
		{
			return (int)((StackInt)this).Value;
		}

		if(this is StackDouble)
		{
			return (int)((StackDouble)this).Value;
		}

		if(this is StackFloat)
		{
			return (int)((StackFloat)this).Value;
		}

		if(this is StackUnsignedInt)
		{
			return (int)((StackUnsignedInt)this).Value;
		}

		if(this is StackLong)
		{
			return (int)((StackLong)this).Value;
		}

		if(this is StackUnsignedLong)
		{
			return (int)((StackUnsignedLong)this).Value;
		}

		if(this is StackShort)
		{
			return (int)((StackShort)this).Value;
		}

		if(this is StackUnsignedShort)
		{
			return (int)((StackUnsignedShort)this).Value;
		}

		if(this is StackByte)
		{
			return (int)((StackByte)this).Value;
		}

		if(this is StackSignedByte)
		{
			return (int)((StackSignedByte)this).Value;
		}

	
		return 0;
	}
	public double ToDouble()
	{
		if(this is StackInt)
		{
			return (double)((StackInt)this).Value;
		}

		if(this is StackDouble)
		{
			return (double)((StackDouble)this).Value;
		}

		if(this is StackFloat)
		{
			return (double)((StackFloat)this).Value;
		}

		if(this is StackUnsignedInt)
		{
			return (double)((StackUnsignedInt)this).Value;
		}

		if(this is StackLong)
		{
			return (double)((StackLong)this).Value;
		}

		if(this is StackUnsignedLong)
		{
			return (double)((StackUnsignedLong)this).Value;
		}

		if(this is StackShort)
		{
			return (double)((StackShort)this).Value;
		}

		if(this is StackUnsignedShort)
		{
			return (double)((StackUnsignedShort)this).Value;
		}

		if(this is StackByte)
		{
			return (double)((StackByte)this).Value;
		}

		if(this is StackSignedByte)
		{
			return (double)((StackSignedByte)this).Value;
		}

	
		return 0;
	}
	public float ToFloat()
	{
		if(this is StackInt)
		{
			return (float)((StackInt)this).Value;
		}

		if(this is StackDouble)
		{
			return (float)((StackDouble)this).Value;
		}

		if(this is StackFloat)
		{
			return (float)((StackFloat)this).Value;
		}

		if(this is StackUnsignedInt)
		{
			return (float)((StackUnsignedInt)this).Value;
		}

		if(this is StackLong)
		{
			return (float)((StackLong)this).Value;
		}

		if(this is StackUnsignedLong)
		{
			return (float)((StackUnsignedLong)this).Value;
		}

		if(this is StackShort)
		{
			return (float)((StackShort)this).Value;
		}

		if(this is StackUnsignedShort)
		{
			return (float)((StackUnsignedShort)this).Value;
		}

		if(this is StackByte)
		{
			return (float)((StackByte)this).Value;
		}

		if(this is StackSignedByte)
		{
			return (float)((StackSignedByte)this).Value;
		}

	
		return 0;
	}
	public uint ToUnsignedInt()
	{
		if(this is StackInt)
		{
			return (uint)((StackInt)this).Value;
		}

		if(this is StackDouble)
		{
			return (uint)((StackDouble)this).Value;
		}

		if(this is StackFloat)
		{
			return (uint)((StackFloat)this).Value;
		}

		if(this is StackUnsignedInt)
		{
			return (uint)((StackUnsignedInt)this).Value;
		}

		if(this is StackLong)
		{
			return (uint)((StackLong)this).Value;
		}

		if(this is StackUnsignedLong)
		{
			return (uint)((StackUnsignedLong)this).Value;
		}

		if(this is StackShort)
		{
			return (uint)((StackShort)this).Value;
		}

		if(this is StackUnsignedShort)
		{
			return (uint)((StackUnsignedShort)this).Value;
		}

		if(this is StackByte)
		{
			return (uint)((StackByte)this).Value;
		}

		if(this is StackSignedByte)
		{
			return (uint)((StackSignedByte)this).Value;
		}

	
		return 0;
	}
	public long ToLong()
	{
		if(this is StackInt)
		{
			return (long)((StackInt)this).Value;
		}

		if(this is StackDouble)
		{
			return (long)((StackDouble)this).Value;
		}

		if(this is StackFloat)
		{
			return (long)((StackFloat)this).Value;
		}

		if(this is StackUnsignedInt)
		{
			return (long)((StackUnsignedInt)this).Value;
		}

		if(this is StackLong)
		{
			return (long)((StackLong)this).Value;
		}

		if(this is StackUnsignedLong)
		{
			return (long)((StackUnsignedLong)this).Value;
		}

		if(this is StackShort)
		{
			return (long)((StackShort)this).Value;
		}

		if(this is StackUnsignedShort)
		{
			return (long)((StackUnsignedShort)this).Value;
		}

		if(this is StackByte)
		{
			return (long)((StackByte)this).Value;
		}

		if(this is StackSignedByte)
		{
			return (long)((StackSignedByte)this).Value;
		}

	
		return 0;
	}
	public ulong ToUnsignedLong()
	{
		if(this is StackInt)
		{
			return (ulong)((StackInt)this).Value;
		}

		if(this is StackDouble)
		{
			return (ulong)((StackDouble)this).Value;
		}

		if(this is StackFloat)
		{
			return (ulong)((StackFloat)this).Value;
		}

		if(this is StackUnsignedInt)
		{
			return (ulong)((StackUnsignedInt)this).Value;
		}

		if(this is StackLong)
		{
			return (ulong)((StackLong)this).Value;
		}

		if(this is StackUnsignedLong)
		{
			return (ulong)((StackUnsignedLong)this).Value;
		}

		if(this is StackShort)
		{
			return (ulong)((StackShort)this).Value;
		}

		if(this is StackUnsignedShort)
		{
			return (ulong)((StackUnsignedShort)this).Value;
		}

		if(this is StackByte)
		{
			return (ulong)((StackByte)this).Value;
		}

		if(this is StackSignedByte)
		{
			return (ulong)((StackSignedByte)this).Value;
		}

	
		return 0;
	}
	public short ToShort()
	{
		if(this is StackInt)
		{
			return (short)((StackInt)this).Value;
		}

		if(this is StackDouble)
		{
			return (short)((StackDouble)this).Value;
		}

		if(this is StackFloat)
		{
			return (short)((StackFloat)this).Value;
		}

		if(this is StackUnsignedInt)
		{
			return (short)((StackUnsignedInt)this).Value;
		}

		if(this is StackLong)
		{
			return (short)((StackLong)this).Value;
		}

		if(this is StackUnsignedLong)
		{
			return (short)((StackUnsignedLong)this).Value;
		}

		if(this is StackShort)
		{
			return (short)((StackShort)this).Value;
		}

		if(this is StackUnsignedShort)
		{
			return (short)((StackUnsignedShort)this).Value;
		}

		if(this is StackByte)
		{
			return (short)((StackByte)this).Value;
		}

		if(this is StackSignedByte)
		{
			return (short)((StackSignedByte)this).Value;
		}

	
		return 0;
	}
	public ushort ToUnsignedShort()
	{
		if(this is StackInt)
		{
			return (ushort)((StackInt)this).Value;
		}

		if(this is StackDouble)
		{
			return (ushort)((StackDouble)this).Value;
		}

		if(this is StackFloat)
		{
			return (ushort)((StackFloat)this).Value;
		}

		if(this is StackUnsignedInt)
		{
			return (ushort)((StackUnsignedInt)this).Value;
		}

		if(this is StackLong)
		{
			return (ushort)((StackLong)this).Value;
		}

		if(this is StackUnsignedLong)
		{
			return (ushort)((StackUnsignedLong)this).Value;
		}

		if(this is StackShort)
		{
			return (ushort)((StackShort)this).Value;
		}

		if(this is StackUnsignedShort)
		{
			return (ushort)((StackUnsignedShort)this).Value;
		}

		if(this is StackByte)
		{
			return (ushort)((StackByte)this).Value;
		}

		if(this is StackSignedByte)
		{
			return (ushort)((StackSignedByte)this).Value;
		}

	
		return 0;
	}
	public byte ToByte()
	{
		if(this is StackInt)
		{
			return (byte)((StackInt)this).Value;
		}

		if(this is StackDouble)
		{
			return (byte)((StackDouble)this).Value;
		}

		if(this is StackFloat)
		{
			return (byte)((StackFloat)this).Value;
		}

		if(this is StackUnsignedInt)
		{
			return (byte)((StackUnsignedInt)this).Value;
		}

		if(this is StackLong)
		{
			return (byte)((StackLong)this).Value;
		}

		if(this is StackUnsignedLong)
		{
			return (byte)((StackUnsignedLong)this).Value;
		}

		if(this is StackShort)
		{
			return (byte)((StackShort)this).Value;
		}

		if(this is StackUnsignedShort)
		{
			return (byte)((StackUnsignedShort)this).Value;
		}

		if(this is StackByte)
		{
			return (byte)((StackByte)this).Value;
		}

		if(this is StackSignedByte)
		{
			return (byte)((StackSignedByte)this).Value;
		}

	
		return 0;
	}
	public sbyte ToSignedByte()
	{
		if(this is StackInt)
		{
			return (sbyte)((StackInt)this).Value;
		}

		if(this is StackDouble)
		{
			return (sbyte)((StackDouble)this).Value;
		}

		if(this is StackFloat)
		{
			return (sbyte)((StackFloat)this).Value;
		}

		if(this is StackUnsignedInt)
		{
			return (sbyte)((StackUnsignedInt)this).Value;
		}

		if(this is StackLong)
		{
			return (sbyte)((StackLong)this).Value;
		}

		if(this is StackUnsignedLong)
		{
			return (sbyte)((StackUnsignedLong)this).Value;
		}

		if(this is StackShort)
		{
			return (sbyte)((StackShort)this).Value;
		}

		if(this is StackUnsignedShort)
		{
			return (sbyte)((StackUnsignedShort)this).Value;
		}

		if(this is StackByte)
		{
			return (sbyte)((StackByte)this).Value;
		}

		if(this is StackSignedByte)
		{
			return (sbyte)((StackSignedByte)this).Value;
		}

	
		return 0;
	}
	
	public static StackNumber Convert(string command, string value)
	{
			if( command == "int")
			{
				int a = 0;
				var b = int.TryParse(value, out a);
				return new StackInt(a);
			}

			if( command == "double")
			{
				double a = 0;
				var b = double.TryParse(value, out a);
				return new StackDouble(a);
			}

			if( command == "float")
			{
				float a = 0;
				var b = float.TryParse(value, out a);
				return new StackFloat(a);
			}

			if( command == "uint")
			{
				uint a = 0;
				var b = uint.TryParse(value, out a);
				return new StackUnsignedInt(a);
			}

			if( command == "long")
			{
				long a = 0;
				var b = long.TryParse(value, out a);
				return new StackLong(a);
			}

			if( command == "ulong")
			{
				ulong a = 0;
				var b = ulong.TryParse(value, out a);
				return new StackUnsignedLong(a);
			}

			if( command == "short")
			{
				short a = 0;
				var b = short.TryParse(value, out a);
				return new StackShort(a);
			}

			if( command == "ushort")
			{
				ushort a = 0;
				var b = ushort.TryParse(value, out a);
				return new StackUnsignedShort(a);
			}

			if( command == "byte")
			{
				byte a = 0;
				var b = byte.TryParse(value, out a);
				return new StackByte(a);
			}

			if( command == "sbyte")
			{
				sbyte a = 0;
				var b = sbyte.TryParse(value, out a);
				return new StackSignedByte(a);
			}

		return null;
	}

	//Yes this is really hackish, but meh. It's a learning thing. 
	protected static StackNumber[] Convert(StackNumber a, StackNumber b)
	{

				
		if(a is StackInt)
		{
			if(b is StackInt)
			{
				
				return new StackNumber[] { a, new StackInt((int)((StackInt)b).Value) };

			}
			if(b is StackDouble)
			{

				return new StackNumber[] { new StackDouble((double)((StackInt)a).Value), b };

			}
			if(b is StackFloat)
			{

				return new StackNumber[] { new StackFloat((float)((StackInt)a).Value), b };

			}
			if(b is StackUnsignedInt)
			{
				
				return new StackNumber[] { a, new StackInt((int)((StackUnsignedInt)b).Value) };

			}
			if(b is StackLong)
			{

				return new StackNumber[] { new StackLong((long)((StackInt)a).Value), b };

			}
			if(b is StackUnsignedLong)
			{

				return new StackNumber[] { new StackUnsignedLong((ulong)((StackInt)a).Value), b };

			}
			if(b is StackShort)
			{
				
				return new StackNumber[] { a, new StackInt((int)((StackShort)b).Value) };

			}
			if(b is StackUnsignedShort)
			{
				
				return new StackNumber[] { a, new StackInt((int)((StackUnsignedShort)b).Value) };

			}
			if(b is StackByte)
			{
				
				return new StackNumber[] { a, new StackInt((int)((StackByte)b).Value) };

			}
			if(b is StackSignedByte)
			{
				
				return new StackNumber[] { a, new StackInt((int)((StackSignedByte)b).Value) };

			}
		}

		
		if(a is StackDouble)
		{
			if(b is StackInt)
			{
				
				return new StackNumber[] { a, new StackDouble((double)((StackInt)b).Value) };

			}
			if(b is StackDouble)
			{
				
				return new StackNumber[] { a, new StackDouble((double)((StackDouble)b).Value) };

			}
			if(b is StackFloat)
			{
				
				return new StackNumber[] { a, new StackDouble((double)((StackFloat)b).Value) };

			}
			if(b is StackUnsignedInt)
			{
				
				return new StackNumber[] { a, new StackDouble((double)((StackUnsignedInt)b).Value) };

			}
			if(b is StackLong)
			{
				
				return new StackNumber[] { a, new StackDouble((double)((StackLong)b).Value) };

			}
			if(b is StackUnsignedLong)
			{
				
				return new StackNumber[] { a, new StackDouble((double)((StackUnsignedLong)b).Value) };

			}
			if(b is StackShort)
			{
				
				return new StackNumber[] { a, new StackDouble((double)((StackShort)b).Value) };

			}
			if(b is StackUnsignedShort)
			{
				
				return new StackNumber[] { a, new StackDouble((double)((StackUnsignedShort)b).Value) };

			}
			if(b is StackByte)
			{
				
				return new StackNumber[] { a, new StackDouble((double)((StackByte)b).Value) };

			}
			if(b is StackSignedByte)
			{
				
				return new StackNumber[] { a, new StackDouble((double)((StackSignedByte)b).Value) };

			}
		}

		
		if(a is StackFloat)
		{
			if(b is StackInt)
			{
				
				return new StackNumber[] { a, new StackFloat((float)((StackInt)b).Value) };

			}
			if(b is StackDouble)
			{

				return new StackNumber[] { new StackDouble((double)((StackFloat)a).Value), b };

			}
			if(b is StackFloat)
			{
				
				return new StackNumber[] { a, new StackFloat((float)((StackFloat)b).Value) };

			}
			if(b is StackUnsignedInt)
			{
				
				return new StackNumber[] { a, new StackFloat((float)((StackUnsignedInt)b).Value) };

			}
			if(b is StackLong)
			{
				
				return new StackNumber[] { a, new StackFloat((float)((StackLong)b).Value) };

			}
			if(b is StackUnsignedLong)
			{
				
				return new StackNumber[] { a, new StackFloat((float)((StackUnsignedLong)b).Value) };

			}
			if(b is StackShort)
			{
				
				return new StackNumber[] { a, new StackFloat((float)((StackShort)b).Value) };

			}
			if(b is StackUnsignedShort)
			{
				
				return new StackNumber[] { a, new StackFloat((float)((StackUnsignedShort)b).Value) };

			}
			if(b is StackByte)
			{
				
				return new StackNumber[] { a, new StackFloat((float)((StackByte)b).Value) };

			}
			if(b is StackSignedByte)
			{
				
				return new StackNumber[] { a, new StackFloat((float)((StackSignedByte)b).Value) };

			}
		}

		
		if(a is StackUnsignedInt)
		{
			if(b is StackInt)
			{
				
				return new StackNumber[] { a, new StackUnsignedInt((uint)((StackInt)b).Value) };

			}
			if(b is StackDouble)
			{

				return new StackNumber[] { new StackDouble((double)((StackUnsignedInt)a).Value), b };

			}
			if(b is StackFloat)
			{

				return new StackNumber[] { new StackFloat((float)((StackUnsignedInt)a).Value), b };

			}
			if(b is StackUnsignedInt)
			{
				
				return new StackNumber[] { a, new StackUnsignedInt((uint)((StackUnsignedInt)b).Value) };

			}
			if(b is StackLong)
			{

				return new StackNumber[] { new StackLong((long)((StackUnsignedInt)a).Value), b };

			}
			if(b is StackUnsignedLong)
			{

				return new StackNumber[] { new StackUnsignedLong((ulong)((StackUnsignedInt)a).Value), b };

			}
			if(b is StackShort)
			{
				
				return new StackNumber[] { a, new StackUnsignedInt((uint)((StackShort)b).Value) };

			}
			if(b is StackUnsignedShort)
			{
				
				return new StackNumber[] { a, new StackUnsignedInt((uint)((StackUnsignedShort)b).Value) };

			}
			if(b is StackByte)
			{
				
				return new StackNumber[] { a, new StackUnsignedInt((uint)((StackByte)b).Value) };

			}
			if(b is StackSignedByte)
			{
				
				return new StackNumber[] { a, new StackUnsignedInt((uint)((StackSignedByte)b).Value) };

			}
		}

		
		if(a is StackLong)
		{
			if(b is StackInt)
			{
				
				return new StackNumber[] { a, new StackLong((long)((StackInt)b).Value) };

			}
			if(b is StackDouble)
			{

				return new StackNumber[] { new StackDouble((double)((StackLong)a).Value), b };

			}
			if(b is StackFloat)
			{

				return new StackNumber[] { new StackFloat((float)((StackLong)a).Value), b };

			}
			if(b is StackUnsignedInt)
			{
				
				return new StackNumber[] { a, new StackLong((long)((StackUnsignedInt)b).Value) };

			}
			if(b is StackLong)
			{
				
				return new StackNumber[] { a, new StackLong((long)((StackLong)b).Value) };

			}
			if(b is StackUnsignedLong)
			{
				
				return new StackNumber[] { a, new StackLong((long)((StackUnsignedLong)b).Value) };

			}
			if(b is StackShort)
			{
				
				return new StackNumber[] { a, new StackLong((long)((StackShort)b).Value) };

			}
			if(b is StackUnsignedShort)
			{
				
				return new StackNumber[] { a, new StackLong((long)((StackUnsignedShort)b).Value) };

			}
			if(b is StackByte)
			{
				
				return new StackNumber[] { a, new StackLong((long)((StackByte)b).Value) };

			}
			if(b is StackSignedByte)
			{
				
				return new StackNumber[] { a, new StackLong((long)((StackSignedByte)b).Value) };

			}
		}

		
		if(a is StackUnsignedLong)
		{
			if(b is StackInt)
			{
				
				return new StackNumber[] { a, new StackUnsignedLong((ulong)((StackInt)b).Value) };

			}
			if(b is StackDouble)
			{

				return new StackNumber[] { new StackDouble((double)((StackUnsignedLong)a).Value), b };

			}
			if(b is StackFloat)
			{

				return new StackNumber[] { new StackFloat((float)((StackUnsignedLong)a).Value), b };

			}
			if(b is StackUnsignedInt)
			{
				
				return new StackNumber[] { a, new StackUnsignedLong((ulong)((StackUnsignedInt)b).Value) };

			}
			if(b is StackLong)
			{
				
				return new StackNumber[] { a, new StackUnsignedLong((ulong)((StackLong)b).Value) };

			}
			if(b is StackUnsignedLong)
			{
				
				return new StackNumber[] { a, new StackUnsignedLong((ulong)((StackUnsignedLong)b).Value) };

			}
			if(b is StackShort)
			{
				
				return new StackNumber[] { a, new StackUnsignedLong((ulong)((StackShort)b).Value) };

			}
			if(b is StackUnsignedShort)
			{
				
				return new StackNumber[] { a, new StackUnsignedLong((ulong)((StackUnsignedShort)b).Value) };

			}
			if(b is StackByte)
			{
				
				return new StackNumber[] { a, new StackUnsignedLong((ulong)((StackByte)b).Value) };

			}
			if(b is StackSignedByte)
			{
				
				return new StackNumber[] { a, new StackUnsignedLong((ulong)((StackSignedByte)b).Value) };

			}
		}

		
		if(a is StackShort)
		{
			if(b is StackInt)
			{

				return new StackNumber[] { new StackInt((int)((StackShort)a).Value), b };

			}
			if(b is StackDouble)
			{

				return new StackNumber[] { new StackDouble((double)((StackShort)a).Value), b };

			}
			if(b is StackFloat)
			{

				return new StackNumber[] { new StackFloat((float)((StackShort)a).Value), b };

			}
			if(b is StackUnsignedInt)
			{

				return new StackNumber[] { new StackUnsignedInt((uint)((StackShort)a).Value), b };

			}
			if(b is StackLong)
			{

				return new StackNumber[] { new StackLong((long)((StackShort)a).Value), b };

			}
			if(b is StackUnsignedLong)
			{

				return new StackNumber[] { new StackUnsignedLong((ulong)((StackShort)a).Value), b };

			}
			if(b is StackShort)
			{
				
				return new StackNumber[] { a, new StackShort((short)((StackShort)b).Value) };

			}
			if(b is StackUnsignedShort)
			{
				
				return new StackNumber[] { a, new StackShort((short)((StackUnsignedShort)b).Value) };

			}
			if(b is StackByte)
			{
				
				return new StackNumber[] { a, new StackShort((short)((StackByte)b).Value) };

			}
			if(b is StackSignedByte)
			{
				
				return new StackNumber[] { a, new StackShort((short)((StackSignedByte)b).Value) };

			}
		}

		
		if(a is StackUnsignedShort)
		{
			if(b is StackInt)
			{

				return new StackNumber[] { new StackInt((int)((StackUnsignedShort)a).Value), b };

			}
			if(b is StackDouble)
			{

				return new StackNumber[] { new StackDouble((double)((StackUnsignedShort)a).Value), b };

			}
			if(b is StackFloat)
			{

				return new StackNumber[] { new StackFloat((float)((StackUnsignedShort)a).Value), b };

			}
			if(b is StackUnsignedInt)
			{

				return new StackNumber[] { new StackUnsignedInt((uint)((StackUnsignedShort)a).Value), b };

			}
			if(b is StackLong)
			{

				return new StackNumber[] { new StackLong((long)((StackUnsignedShort)a).Value), b };

			}
			if(b is StackUnsignedLong)
			{

				return new StackNumber[] { new StackUnsignedLong((ulong)((StackUnsignedShort)a).Value), b };

			}
			if(b is StackShort)
			{
				
				return new StackNumber[] { a, new StackUnsignedShort((ushort)((StackShort)b).Value) };

			}
			if(b is StackUnsignedShort)
			{
				
				return new StackNumber[] { a, new StackUnsignedShort((ushort)((StackUnsignedShort)b).Value) };

			}
			if(b is StackByte)
			{
				
				return new StackNumber[] { a, new StackUnsignedShort((ushort)((StackByte)b).Value) };

			}
			if(b is StackSignedByte)
			{
				
				return new StackNumber[] { a, new StackUnsignedShort((ushort)((StackSignedByte)b).Value) };

			}
		}

		
		if(a is StackByte)
		{
			if(b is StackInt)
			{

				return new StackNumber[] { new StackInt((int)((StackByte)a).Value), b };

			}
			if(b is StackDouble)
			{

				return new StackNumber[] { new StackDouble((double)((StackByte)a).Value), b };

			}
			if(b is StackFloat)
			{

				return new StackNumber[] { new StackFloat((float)((StackByte)a).Value), b };

			}
			if(b is StackUnsignedInt)
			{

				return new StackNumber[] { new StackUnsignedInt((uint)((StackByte)a).Value), b };

			}
			if(b is StackLong)
			{

				return new StackNumber[] { new StackLong((long)((StackByte)a).Value), b };

			}
			if(b is StackUnsignedLong)
			{

				return new StackNumber[] { new StackUnsignedLong((ulong)((StackByte)a).Value), b };

			}
			if(b is StackShort)
			{

				return new StackNumber[] { new StackShort((short)((StackByte)a).Value), b };

			}
			if(b is StackUnsignedShort)
			{

				return new StackNumber[] { new StackUnsignedShort((ushort)((StackByte)a).Value), b };

			}
			if(b is StackByte)
			{
				
				return new StackNumber[] { a, new StackByte((byte)((StackByte)b).Value) };

			}
			if(b is StackSignedByte)
			{
				
				return new StackNumber[] { a, new StackByte((byte)((StackSignedByte)b).Value) };

			}
		}

		
		if(a is StackSignedByte)
		{
			if(b is StackInt)
			{

				return new StackNumber[] { new StackInt((int)((StackSignedByte)a).Value), b };

			}
			if(b is StackDouble)
			{

				return new StackNumber[] { new StackDouble((double)((StackSignedByte)a).Value), b };

			}
			if(b is StackFloat)
			{

				return new StackNumber[] { new StackFloat((float)((StackSignedByte)a).Value), b };

			}
			if(b is StackUnsignedInt)
			{

				return new StackNumber[] { new StackUnsignedInt((uint)((StackSignedByte)a).Value), b };

			}
			if(b is StackLong)
			{

				return new StackNumber[] { new StackLong((long)((StackSignedByte)a).Value), b };

			}
			if(b is StackUnsignedLong)
			{

				return new StackNumber[] { new StackUnsignedLong((ulong)((StackSignedByte)a).Value), b };

			}
			if(b is StackShort)
			{

				return new StackNumber[] { new StackShort((short)((StackSignedByte)a).Value), b };

			}
			if(b is StackUnsignedShort)
			{

				return new StackNumber[] { new StackUnsignedShort((ushort)((StackSignedByte)a).Value), b };

			}
			if(b is StackByte)
			{
				
				return new StackNumber[] { a, new StackSignedByte((sbyte)((StackByte)b).Value) };

			}
			if(b is StackSignedByte)
			{
				
				return new StackNumber[] { a, new StackSignedByte((sbyte)((StackSignedByte)b).Value) };

			}
		}

		return null;
	} 
}

    public class StackInt : StackNumber
    {
        private int value;

		
        public int Value
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
        
        public StackInt() : this(0)
        {

        }

		public override byte[] Bytes
		{
			get
			{
				return BitConverter.GetBytes(value);
			}
		}

        public StackInt(int value)
        {
            this.value = value;
        }


		public StackInt(StackInt copy) : this(copy.value)
		{
		
		}

		public static StackInt Add(StackInt a, StackInt b, bool flip = false)
		{
			int c = a.value;
			if(flip)
			{
				c -= b.value;
			} 
			else
			{
				c += b.value;
			}
		

			return new StackInt(c);
		}
		
        public override object  Clone()
		{
			return new StackInt(this);
		}

		public static StackInt Multiply(StackInt a, StackInt b)
		{
			int c = (int)(a.value * b.value);
			return new StackInt(c);
		}

		

		public static StackInt Power(StackInt a, StackInt b)
		{
			int c = (int)(Math.Pow(a.value,b.value));
			return new StackInt(c);
		}


		public static bool Equals(StackInt a, StackInt b)
		{
			bool c = a.value == b.value;
			return c;
		}


		public static bool GT(StackInt a, StackInt b)
		{
			bool c = a.value > b.value;
			return c;
		}


		public static bool LT(StackInt a, StackInt b)
		{
			bool c = a.value < b.value;
			return c;
		}


		public static bool GTE(StackInt a, StackInt b)
		{
			bool c = a.value >= b.value;
			return c;
		}


		
		public static bool LTE(StackInt a, StackInt b)
		{
			bool c = a.value <= b.value;
			return c;
		}



					
		public static StackInt Ceil(StackInt a)
		{	
			return new StackInt(a);
			
		}
					
		public static StackInt Floor(StackInt a)
		{	
			return new StackInt(a);
			
		}
					
		public static StackInt Round(StackInt a)
		{	
			return new StackInt(a);
			
		}


		public static StackInt And(StackInt a, StackInt b)
		{
			int c = (int)(a.value & b.value);
			return new StackInt(c);
		}

		public static StackInt Or(StackInt a, StackInt b)
		{
			int c = (int)(a.value | b.value);
			return new StackInt(c);
		}

		public static StackInt Xor(StackInt a, StackInt b)
		{
			int c = (int)(a.value ^ b.value);
			return new StackInt(c);
		}

		public static StackInt LSL(StackInt a, StackInt b)
		{
			int c = (int)(a.value << (int)b.value);
			return new StackInt(c);
		}

		public static StackInt LSR(StackInt a, StackInt b)
		{
			int c = (int)(a.value >> (int)b.value);
			return new StackInt(c);
		}

		public static StackInt Not(StackInt a)
		{
			int c = (int)(~a.value);
			return new StackInt(c);
		}


		public static StackInt Divide(StackInt a, StackInt b)
		{
			int c = (int)(a.value / b.value);
			return new StackInt(c);
		}
		

		public static StackInt Modulo(StackInt a, StackInt b)
		{
			int c = (int)(a.value % b.value);
			return new StackInt(c);
		}

		public static StackInt Max(StackInt a, StackInt b)
		{			
			if(a.value > b.value)
			{
				return new StackInt(a);
			}

			return new StackInt(b);
		}
		
		public static StackInt Min(StackInt a, StackInt b)
		{			
			if(a.value < b.value)
			{
				return new StackInt(a);
			}

			return new StackInt(b);
		}

				
		public static StackInt Abs(StackInt a)
		{	
						return new StackInt((int)Math.Abs(a.value));

					}



		public static StackString Stringify(StackInt a)
		{	
			return new StackString(a.ToString());
		}



		//	if(stack.Top is StackInt && stack.FromTop(1) is StackInt)
		
		private static StackElement[] CheckNGo(string command, TSRPStack stack)
		{

			if(stack.Count < 2) return null; 

			if(stack.Top.GetType() == typeof(StackInt) && stack.FromTop(1).GetType() == typeof(StackInt))
			{
				StackInt b = (StackInt)stack.Pop();
				StackInt a = (StackInt)stack.Pop();
				StackInt[] c = new StackInt[] { a, b };
				return c;
			}

			// Also a hack but it works.
			if(command == "+" && stack.Top is StackNumber && stack.FromTop(1) is StackString)
			{
				StackInt a = (StackInt)stack.Pop();
				var b = new StackString((StackString)stack.Pop());
				b.Value += a.value; 
				stack.Push(b);
				return new StackElement[]{ new StackBool(true) };
			}

			if(stack.Top is StackNumber && stack.FromTop(1) is StackNumber)
			{
				StackNumber b = (StackNumber)stack.Pop();
				StackNumber a = (StackNumber)stack.Pop();
				StackElement[] c =  Convert(a,b); 
				stack.Push(c[0]); 
				stack.Push(c[1]);
				var res = stack.Top.Execute(command,stack);
				c = new StackElement[] { new StackBool(res) };	
				return c;
			}
			
			return null;
		}



        public override bool Execute(string command, TSRPStack stack)
        {
            if(command == "+")
			{
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				
				StackInt[] d = (StackInt[])c;
				
				stack.Push(Add(d[0], d[1]));
				return true;
			}
			else
			if(command == "-")
			{
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				
				StackInt[] d = (StackInt[])c;

				stack.Push(Add(d[0], d[1], true));
				return true;
			}
			else 
			if(command == "*")
			{
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				
				
				StackInt[] d = (StackInt[])c;

				stack.Push(Multiply(d[0], d[1]));
				return true;
			}
			else 
			if(command == "^")
			{
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				
				
				StackInt[] d = (StackInt[])c;

				stack.Push(Power(d[0], d[1]));
				return true;
			}
			else 
			if(command == "/")
			{
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				
				
				StackInt[] d = (StackInt[])c;

				stack.Push(Divide(d[0], d[1]));
				return true;

			}
			else 
			if(command == "%" || command=="mod")
			{
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				
				
				StackInt[] d = (StackInt[])c;

				stack.Push(Modulo(d[0], d[1]));
				return true;
			}
			else 
			if(command == "max")
			{
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				
				StackInt[] d = (StackInt[])c;

				stack.Push(Max(d[0], d[1]));
				return true;
			}
			else 
			if(command == "min")
			{
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				
				StackInt[] d = (StackInt[])c;

				stack.Push(Min(d[0], d[1]));
				return true;
			}
			else 
			if(command == "<")
			{
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				
				StackInt[] d = (StackInt[])c;


				stack.Push(LT(d[0], d[1]));
			}
			else 
			if(command == ">")
			{
			
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				StackInt[] d = (StackInt[])c;

				stack.Push(GT(d[0], d[1]));
			}
			else 
			if(command == "==")
			{
			
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				
				StackInt[] d = (StackInt[])c;
				
				stack.Push(Equals(d[0], d[1]));
			}
			else 
			if(command == "!=")
			{
			
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				
				StackInt[] d = (StackInt[])c;
				
				stack.Push(!Equals(d[0], d[1]));
			}
			else 
			if(command == ">=")
			{
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				StackInt[] d = (StackInt[])c;
				
				stack.Push(GTE(d[0], d[1]));
			}
			else 
			if(command == "<=")
			{
				
				var c = CheckNGo(command, stack);

				if(c == null) return false;
				if(c.Length == 1) return true; 
				StackInt[] d = (StackInt[])c;

				stack.Push(LTE(d[0], d[1]));
			}
			else if(command == "int") 
			{
				stack.Pop();
				stack.Push((int)value);

				return true;
			}
			else if(command == "double") 
			{
				stack.Pop();
				stack.Push((double)value);

				return true;
			}
			else if(command == "float") 
			{
				stack.Pop();
				stack.Push((float)value);

				return true;
			}
			else if(command == "uint") 
			{
				stack.Pop();
				stack.Push((uint)value);

				return true;
			}
			else if(command == "long") 
			{
				stack.Pop();
				stack.Push((long)value);

				return true;
			}
			else if(command == "ulong") 
			{
				stack.Pop();
				stack.Push((ulong)value);

				return true;
			}
			else if(command == "short") 
			{
				stack.Pop();
				stack.Push((short)value);

				return true;
			}
			else if(command == "ushort") 
			{
				stack.Pop();
				stack.Push((ushort)value);

				return true;
			}
			else if(command == "byte") 
			{
				stack.Pop();
				stack.Push((byte)value);

				return true;
			}
			else if(command == "sbyte") 
			{
				stack.Pop();
				stack.Push((sbyte)value);

				return true;
			}
						else if(command == "string")
			{
				stack.Pop();
				stack.Push(Stringify(this));
				return true;
			}
			else if (command == "abs" || command == "Abs")
			{
				stack.Pop();
				stack.Push(Abs(this));
				return true;
			}
			else if(command == "round")
			{
			
				stack.Pop();
				stack.Push(Round(this));
				return true;
			}
			else if(command == "floor")
			{
			
				stack.Pop();
				stack.Push(Floor(this));
				return true;
			}
			else if(command == "ceil")
			{
				stack.Pop();
				stack.Push(Ceil(this));
				return true;
			}
			else if (command == "rand")
			{
				stack.Pop();
				stack.Push(random.Next((int)value));
				return true;
			}
			else if (command == "char2str")
			{
				stack.Pop();
				stack.Push("" + (char)this.ToUnsignedShort());
				return true;
			}
			else if (command == "~")
			{
				
				if(stack.Top is StackInt)
				{ 
					StackInt d = (StackInt)stack.Pop();
					stack.Push(Not(d));
					return true;
				}
			}
			else if (command == ">>")
			{
			
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				StackInt[] d = (StackInt[])c;
				
				stack.Push(LSR(d[0], d[1]));
			}
			else if (command == "<<")
			{
			
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				StackInt[] d = (StackInt[])c;
				
				stack.Push(LSL(d[0], d[1]));
			}
			else if (command == "&" || command == "and")
			{
			
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				StackInt[] d = (StackInt[])c;
				
				stack.Push(And(d[0], d[1]));
			}
			else if (command == "|" || command == "or")
			{
			
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				StackInt[] d = (StackInt[])c;
				
				stack.Push(Or(d[0], d[1]));
			}
			else if (command == "xor")
			{
			
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				StackInt[] d = (StackInt[])c;
				
				stack.Push(Xor(d[0], d[1]));
			}



		



			return false;
        }



		public static explicit operator StackDouble(StackInt n)
        {
            return new StackDouble((double)n.value);
        }


		public static explicit operator StackFloat(StackInt n)
        {
            return new StackFloat((float)n.value);
        }


		public static explicit operator StackUnsignedInt(StackInt n)
        {
            return new StackUnsignedInt((uint)n.value);
        }


		public static explicit operator StackLong(StackInt n)
        {
            return new StackLong((long)n.value);
        }


		public static explicit operator StackUnsignedLong(StackInt n)
        {
            return new StackUnsignedLong((ulong)n.value);
        }


		public static explicit operator StackShort(StackInt n)
        {
            return new StackShort((short)n.value);
        }


		public static explicit operator StackUnsignedShort(StackInt n)
        {
            return new StackUnsignedShort((ushort)n.value);
        }


		public static explicit operator StackByte(StackInt n)
        {
            return new StackByte((byte)n.value);
        }


		public static explicit operator StackSignedByte(StackInt n)
        {
            return new StackSignedByte((sbyte)n.value);
        }

		
		public override string ToString()
		{
			return value.ToString();
		}
    }



    public class StackDouble : StackNumber
    {
        private double value;

		
        public double Value
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
        
        public StackDouble() : this(0)
        {

        }

		public override byte[] Bytes
		{
			get
			{
				return BitConverter.GetBytes(value);
			}
		}

        public StackDouble(double value)
        {
            this.value = value;
        }


		public StackDouble(StackDouble copy) : this(copy.value)
		{
		
		}

		public static StackDouble Add(StackDouble a, StackDouble b, bool flip = false)
		{
			double c = a.value;
			if(flip)
			{
				c -= b.value;
			} 
			else
			{
				c += b.value;
			}
		

			return new StackDouble(c);
		}
		
        public override object  Clone()
		{
			return new StackDouble(this);
		}

		public static StackDouble Multiply(StackDouble a, StackDouble b)
		{
			double c = (double)(a.value * b.value);
			return new StackDouble(c);
		}

		

		public static StackDouble Power(StackDouble a, StackDouble b)
		{
			double c = (double)(Math.Pow(a.value,b.value));
			return new StackDouble(c);
		}


		public static bool Equals(StackDouble a, StackDouble b)
		{
			bool c = a.value == b.value;
			return c;
		}


		public static bool GT(StackDouble a, StackDouble b)
		{
			bool c = a.value > b.value;
			return c;
		}


		public static bool LT(StackDouble a, StackDouble b)
		{
			bool c = a.value < b.value;
			return c;
		}


		public static bool GTE(StackDouble a, StackDouble b)
		{
			bool c = a.value >= b.value;
			return c;
		}


		
		public static bool LTE(StackDouble a, StackDouble b)
		{
			bool c = a.value <= b.value;
			return c;
		}



					
		public static StackDouble Ceil(StackDouble a)
		{	
			return new StackDouble((double)Math.Ceiling(a.value));

		}
					
		public static StackDouble Floor(StackDouble a)
		{	
			return new StackDouble((double)Math.Floor(a.value));

		}
					
		public static StackDouble Round(StackDouble a)
		{	
			return new StackDouble((double)Math.Round(a.value));

		}


		
	


		public static StackDouble Divide(StackDouble a, StackDouble b)
		{
			double c = (double)(a.value / b.value);
			return new StackDouble(c);
		}
		

		public static StackDouble Modulo(StackDouble a, StackDouble b)
		{
			double c = (double)(a.value % b.value);
			return new StackDouble(c);
		}

		public static StackDouble Max(StackDouble a, StackDouble b)
		{			
			if(a.value > b.value)
			{
				return new StackDouble(a);
			}

			return new StackDouble(b);
		}
		
		public static StackDouble Min(StackDouble a, StackDouble b)
		{			
			if(a.value < b.value)
			{
				return new StackDouble(a);
			}

			return new StackDouble(b);
		}

				
		public static StackDouble Abs(StackDouble a)
		{	
						return new StackDouble((double)Math.Abs(a.value));

					}



		public static StackString Stringify(StackDouble a)
		{	
			return new StackString(a.ToString());
		}



		//	if(stack.Top is StackDouble && stack.FromTop(1) is StackDouble)
		
		private static StackElement[] CheckNGo(string command, TSRPStack stack)
		{

			if(stack.Count < 2) return null; 

			if(stack.Top.GetType() == typeof(StackDouble) && stack.FromTop(1).GetType() == typeof(StackDouble))
			{
				StackDouble b = (StackDouble)stack.Pop();
				StackDouble a = (StackDouble)stack.Pop();
				StackDouble[] c = new StackDouble[] { a, b };
				return c;
			}

			// Also a hack but it works.
			if(command == "+" && stack.Top is StackNumber && stack.FromTop(1) is StackString)
			{
				StackDouble a = (StackDouble)stack.Pop();
				var b = new StackString((StackString)stack.Pop());
				b.Value += a.value; 
				stack.Push(b);
				return new StackElement[]{ new StackBool(true) };
			}

			if(stack.Top is StackNumber && stack.FromTop(1) is StackNumber)
			{
				StackNumber b = (StackNumber)stack.Pop();
				StackNumber a = (StackNumber)stack.Pop();
				StackElement[] c =  Convert(a,b); 
				stack.Push(c[0]); 
				stack.Push(c[1]);
				var res = stack.Top.Execute(command,stack);
				c = new StackElement[] { new StackBool(res) };	
				return c;
			}
			
			return null;
		}



        public override bool Execute(string command, TSRPStack stack)
        {
            if(command == "+")
			{
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				
				StackDouble[] d = (StackDouble[])c;
				
				stack.Push(Add(d[0], d[1]));
				return true;
			}
			else
			if(command == "-")
			{
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				
				StackDouble[] d = (StackDouble[])c;

				stack.Push(Add(d[0], d[1], true));
				return true;
			}
			else 
			if(command == "*")
			{
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				
				
				StackDouble[] d = (StackDouble[])c;

				stack.Push(Multiply(d[0], d[1]));
				return true;
			}
			else 
			if(command == "^")
			{
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				
				
				StackDouble[] d = (StackDouble[])c;

				stack.Push(Power(d[0], d[1]));
				return true;
			}
			else 
			if(command == "/")
			{
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				
				
				StackDouble[] d = (StackDouble[])c;

				stack.Push(Divide(d[0], d[1]));
				return true;

			}
			else 
			if(command == "%" || command=="mod")
			{
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				
				
				StackDouble[] d = (StackDouble[])c;

				stack.Push(Modulo(d[0], d[1]));
				return true;
			}
			else 
			if(command == "max")
			{
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				
				StackDouble[] d = (StackDouble[])c;

				stack.Push(Max(d[0], d[1]));
				return true;
			}
			else 
			if(command == "min")
			{
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				
				StackDouble[] d = (StackDouble[])c;

				stack.Push(Min(d[0], d[1]));
				return true;
			}
			else 
			if(command == "<")
			{
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				
				StackDouble[] d = (StackDouble[])c;


				stack.Push(LT(d[0], d[1]));
			}
			else 
			if(command == ">")
			{
			
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				StackDouble[] d = (StackDouble[])c;

				stack.Push(GT(d[0], d[1]));
			}
			else 
			if(command == "==")
			{
			
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				
				StackDouble[] d = (StackDouble[])c;
				
				stack.Push(Equals(d[0], d[1]));
			}
			else 
			if(command == "!=")
			{
			
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				
				StackDouble[] d = (StackDouble[])c;
				
				stack.Push(!Equals(d[0], d[1]));
			}
			else 
			if(command == ">=")
			{
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				StackDouble[] d = (StackDouble[])c;
				
				stack.Push(GTE(d[0], d[1]));
			}
			else 
			if(command == "<=")
			{
				
				var c = CheckNGo(command, stack);

				if(c == null) return false;
				if(c.Length == 1) return true; 
				StackDouble[] d = (StackDouble[])c;

				stack.Push(LTE(d[0], d[1]));
			}
			else if(command == "int") 
			{
				stack.Pop();
				stack.Push((int)value);

				return true;
			}
			else if(command == "double") 
			{
				stack.Pop();
				stack.Push((double)value);

				return true;
			}
			else if(command == "float") 
			{
				stack.Pop();
				stack.Push((float)value);

				return true;
			}
			else if(command == "uint") 
			{
				stack.Pop();
				stack.Push((uint)value);

				return true;
			}
			else if(command == "long") 
			{
				stack.Pop();
				stack.Push((long)value);

				return true;
			}
			else if(command == "ulong") 
			{
				stack.Pop();
				stack.Push((ulong)value);

				return true;
			}
			else if(command == "short") 
			{
				stack.Pop();
				stack.Push((short)value);

				return true;
			}
			else if(command == "ushort") 
			{
				stack.Pop();
				stack.Push((ushort)value);

				return true;
			}
			else if(command == "byte") 
			{
				stack.Pop();
				stack.Push((byte)value);

				return true;
			}
			else if(command == "sbyte") 
			{
				stack.Pop();
				stack.Push((sbyte)value);

				return true;
			}
						else if(command == "string")
			{
				stack.Pop();
				stack.Push(Stringify(this));
				return true;
			}
			else if (command == "abs" || command == "Abs")
			{
				stack.Pop();
				stack.Push(Abs(this));
				return true;
			}
			else if(command == "round")
			{
			
				stack.Pop();
				stack.Push(Round(this));
				return true;
			}
			else if(command == "floor")
			{
			
				stack.Pop();
				stack.Push(Floor(this));
				return true;
			}
			else if(command == "ceil")
			{
				stack.Pop();
				stack.Push(Ceil(this));
				return true;
			}
			else if (command == "rand")
			{
				stack.Pop();
				stack.Push(random.Next((int)value));
				return true;
			}
			else if (command == "char2str")
			{
				stack.Pop();
				stack.Push("" + (char)this.ToUnsignedShort());
				return true;
			}




		



			return false;
        }



		public static explicit operator StackInt(StackDouble n)
        {
            return new StackInt((int)n.value);
        }


		public static explicit operator StackFloat(StackDouble n)
        {
            return new StackFloat((float)n.value);
        }


		public static explicit operator StackUnsignedInt(StackDouble n)
        {
            return new StackUnsignedInt((uint)n.value);
        }


		public static explicit operator StackLong(StackDouble n)
        {
            return new StackLong((long)n.value);
        }


		public static explicit operator StackUnsignedLong(StackDouble n)
        {
            return new StackUnsignedLong((ulong)n.value);
        }


		public static explicit operator StackShort(StackDouble n)
        {
            return new StackShort((short)n.value);
        }


		public static explicit operator StackUnsignedShort(StackDouble n)
        {
            return new StackUnsignedShort((ushort)n.value);
        }


		public static explicit operator StackByte(StackDouble n)
        {
            return new StackByte((byte)n.value);
        }


		public static explicit operator StackSignedByte(StackDouble n)
        {
            return new StackSignedByte((sbyte)n.value);
        }

		
		public override string ToString()
		{
			return value.ToString();
		}
    }



    public class StackFloat : StackNumber
    {
        private float value;

		
        public float Value
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
        
        public StackFloat() : this(0)
        {

        }

		public override byte[] Bytes
		{
			get
			{
				return BitConverter.GetBytes(value);
			}
		}

        public StackFloat(float value)
        {
            this.value = value;
        }


		public StackFloat(StackFloat copy) : this(copy.value)
		{
		
		}

		public static StackFloat Add(StackFloat a, StackFloat b, bool flip = false)
		{
			float c = a.value;
			if(flip)
			{
				c -= b.value;
			} 
			else
			{
				c += b.value;
			}
		

			return new StackFloat(c);
		}
		
        public override object  Clone()
		{
			return new StackFloat(this);
		}

		public static StackFloat Multiply(StackFloat a, StackFloat b)
		{
			float c = (float)(a.value * b.value);
			return new StackFloat(c);
		}

		

		public static StackFloat Power(StackFloat a, StackFloat b)
		{
			float c = (float)(Math.Pow(a.value,b.value));
			return new StackFloat(c);
		}


		public static bool Equals(StackFloat a, StackFloat b)
		{
			bool c = a.value == b.value;
			return c;
		}


		public static bool GT(StackFloat a, StackFloat b)
		{
			bool c = a.value > b.value;
			return c;
		}


		public static bool LT(StackFloat a, StackFloat b)
		{
			bool c = a.value < b.value;
			return c;
		}


		public static bool GTE(StackFloat a, StackFloat b)
		{
			bool c = a.value >= b.value;
			return c;
		}


		
		public static bool LTE(StackFloat a, StackFloat b)
		{
			bool c = a.value <= b.value;
			return c;
		}



					
		public static StackFloat Ceil(StackFloat a)
		{	
			return new StackFloat((float)Math.Ceiling(a.value));

		}
					
		public static StackFloat Floor(StackFloat a)
		{	
			return new StackFloat((float)Math.Floor(a.value));

		}
					
		public static StackFloat Round(StackFloat a)
		{	
			return new StackFloat((float)Math.Round(a.value));

		}


		
	


		public static StackFloat Divide(StackFloat a, StackFloat b)
		{
			float c = (float)(a.value / b.value);
			return new StackFloat(c);
		}
		

		public static StackFloat Modulo(StackFloat a, StackFloat b)
		{
			float c = (float)(a.value % b.value);
			return new StackFloat(c);
		}

		public static StackFloat Max(StackFloat a, StackFloat b)
		{			
			if(a.value > b.value)
			{
				return new StackFloat(a);
			}

			return new StackFloat(b);
		}
		
		public static StackFloat Min(StackFloat a, StackFloat b)
		{			
			if(a.value < b.value)
			{
				return new StackFloat(a);
			}

			return new StackFloat(b);
		}

				
		public static StackFloat Abs(StackFloat a)
		{	
						return new StackFloat((float)Math.Abs(a.value));

					}



		public static StackString Stringify(StackFloat a)
		{	
			return new StackString(a.ToString());
		}



		//	if(stack.Top is StackFloat && stack.FromTop(1) is StackFloat)
		
		private static StackElement[] CheckNGo(string command, TSRPStack stack)
		{

			if(stack.Count < 2) return null; 

			if(stack.Top.GetType() == typeof(StackFloat) && stack.FromTop(1).GetType() == typeof(StackFloat))
			{
				StackFloat b = (StackFloat)stack.Pop();
				StackFloat a = (StackFloat)stack.Pop();
				StackFloat[] c = new StackFloat[] { a, b };
				return c;
			}

			// Also a hack but it works.
			if(command == "+" && stack.Top is StackNumber && stack.FromTop(1) is StackString)
			{
				StackFloat a = (StackFloat)stack.Pop();
				var b = new StackString((StackString)stack.Pop());
				b.Value += a.value; 
				stack.Push(b);
				return new StackElement[]{ new StackBool(true) };
			}

			if(stack.Top is StackNumber && stack.FromTop(1) is StackNumber)
			{
				StackNumber b = (StackNumber)stack.Pop();
				StackNumber a = (StackNumber)stack.Pop();
				StackElement[] c =  Convert(a,b); 
				stack.Push(c[0]); 
				stack.Push(c[1]);
				var res = stack.Top.Execute(command,stack);
				c = new StackElement[] { new StackBool(res) };	
				return c;
			}
			
			return null;
		}



        public override bool Execute(string command, TSRPStack stack)
        {
            if(command == "+")
			{
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				
				StackFloat[] d = (StackFloat[])c;
				
				stack.Push(Add(d[0], d[1]));
				return true;
			}
			else
			if(command == "-")
			{
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				
				StackFloat[] d = (StackFloat[])c;

				stack.Push(Add(d[0], d[1], true));
				return true;
			}
			else 
			if(command == "*")
			{
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				
				
				StackFloat[] d = (StackFloat[])c;

				stack.Push(Multiply(d[0], d[1]));
				return true;
			}
			else 
			if(command == "^")
			{
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				
				
				StackFloat[] d = (StackFloat[])c;

				stack.Push(Power(d[0], d[1]));
				return true;
			}
			else 
			if(command == "/")
			{
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				
				
				StackFloat[] d = (StackFloat[])c;

				stack.Push(Divide(d[0], d[1]));
				return true;

			}
			else 
			if(command == "%" || command=="mod")
			{
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				
				
				StackFloat[] d = (StackFloat[])c;

				stack.Push(Modulo(d[0], d[1]));
				return true;
			}
			else 
			if(command == "max")
			{
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				
				StackFloat[] d = (StackFloat[])c;

				stack.Push(Max(d[0], d[1]));
				return true;
			}
			else 
			if(command == "min")
			{
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				
				StackFloat[] d = (StackFloat[])c;

				stack.Push(Min(d[0], d[1]));
				return true;
			}
			else 
			if(command == "<")
			{
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				
				StackFloat[] d = (StackFloat[])c;


				stack.Push(LT(d[0], d[1]));
			}
			else 
			if(command == ">")
			{
			
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				StackFloat[] d = (StackFloat[])c;

				stack.Push(GT(d[0], d[1]));
			}
			else 
			if(command == "==")
			{
			
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				
				StackFloat[] d = (StackFloat[])c;
				
				stack.Push(Equals(d[0], d[1]));
			}
			else 
			if(command == "!=")
			{
			
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				
				StackFloat[] d = (StackFloat[])c;
				
				stack.Push(!Equals(d[0], d[1]));
			}
			else 
			if(command == ">=")
			{
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				StackFloat[] d = (StackFloat[])c;
				
				stack.Push(GTE(d[0], d[1]));
			}
			else 
			if(command == "<=")
			{
				
				var c = CheckNGo(command, stack);

				if(c == null) return false;
				if(c.Length == 1) return true; 
				StackFloat[] d = (StackFloat[])c;

				stack.Push(LTE(d[0], d[1]));
			}
			else if(command == "int") 
			{
				stack.Pop();
				stack.Push((int)value);

				return true;
			}
			else if(command == "double") 
			{
				stack.Pop();
				stack.Push((double)value);

				return true;
			}
			else if(command == "float") 
			{
				stack.Pop();
				stack.Push((float)value);

				return true;
			}
			else if(command == "uint") 
			{
				stack.Pop();
				stack.Push((uint)value);

				return true;
			}
			else if(command == "long") 
			{
				stack.Pop();
				stack.Push((long)value);

				return true;
			}
			else if(command == "ulong") 
			{
				stack.Pop();
				stack.Push((ulong)value);

				return true;
			}
			else if(command == "short") 
			{
				stack.Pop();
				stack.Push((short)value);

				return true;
			}
			else if(command == "ushort") 
			{
				stack.Pop();
				stack.Push((ushort)value);

				return true;
			}
			else if(command == "byte") 
			{
				stack.Pop();
				stack.Push((byte)value);

				return true;
			}
			else if(command == "sbyte") 
			{
				stack.Pop();
				stack.Push((sbyte)value);

				return true;
			}
						else if(command == "string")
			{
				stack.Pop();
				stack.Push(Stringify(this));
				return true;
			}
			else if (command == "abs" || command == "Abs")
			{
				stack.Pop();
				stack.Push(Abs(this));
				return true;
			}
			else if(command == "round")
			{
			
				stack.Pop();
				stack.Push(Round(this));
				return true;
			}
			else if(command == "floor")
			{
			
				stack.Pop();
				stack.Push(Floor(this));
				return true;
			}
			else if(command == "ceil")
			{
				stack.Pop();
				stack.Push(Ceil(this));
				return true;
			}
			else if (command == "rand")
			{
				stack.Pop();
				stack.Push(random.Next((int)value));
				return true;
			}
			else if (command == "char2str")
			{
				stack.Pop();
				stack.Push("" + (char)this.ToUnsignedShort());
				return true;
			}




		



			return false;
        }



		public static explicit operator StackInt(StackFloat n)
        {
            return new StackInt((int)n.value);
        }


		public static explicit operator StackDouble(StackFloat n)
        {
            return new StackDouble((double)n.value);
        }


		public static explicit operator StackUnsignedInt(StackFloat n)
        {
            return new StackUnsignedInt((uint)n.value);
        }


		public static explicit operator StackLong(StackFloat n)
        {
            return new StackLong((long)n.value);
        }


		public static explicit operator StackUnsignedLong(StackFloat n)
        {
            return new StackUnsignedLong((ulong)n.value);
        }


		public static explicit operator StackShort(StackFloat n)
        {
            return new StackShort((short)n.value);
        }


		public static explicit operator StackUnsignedShort(StackFloat n)
        {
            return new StackUnsignedShort((ushort)n.value);
        }


		public static explicit operator StackByte(StackFloat n)
        {
            return new StackByte((byte)n.value);
        }


		public static explicit operator StackSignedByte(StackFloat n)
        {
            return new StackSignedByte((sbyte)n.value);
        }

		
		public override string ToString()
		{
			return value.ToString();
		}
    }



    public class StackUnsignedInt : StackNumber
    {
        private uint value;

		
        public uint Value
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
        
        public StackUnsignedInt() : this(0)
        {

        }

		public override byte[] Bytes
		{
			get
			{
				return BitConverter.GetBytes(value);
			}
		}

        public StackUnsignedInt(uint value)
        {
            this.value = value;
        }


		public StackUnsignedInt(StackUnsignedInt copy) : this(copy.value)
		{
		
		}

		public static StackUnsignedInt Add(StackUnsignedInt a, StackUnsignedInt b, bool flip = false)
		{
			uint c = a.value;
			if(flip)
			{
				c -= b.value;
			} 
			else
			{
				c += b.value;
			}
		

			return new StackUnsignedInt(c);
		}
		
        public override object  Clone()
		{
			return new StackUnsignedInt(this);
		}

		public static StackUnsignedInt Multiply(StackUnsignedInt a, StackUnsignedInt b)
		{
			uint c = (uint)(a.value * b.value);
			return new StackUnsignedInt(c);
		}

		

		public static StackUnsignedInt Power(StackUnsignedInt a, StackUnsignedInt b)
		{
			uint c = (uint)(Math.Pow(a.value,b.value));
			return new StackUnsignedInt(c);
		}


		public static bool Equals(StackUnsignedInt a, StackUnsignedInt b)
		{
			bool c = a.value == b.value;
			return c;
		}


		public static bool GT(StackUnsignedInt a, StackUnsignedInt b)
		{
			bool c = a.value > b.value;
			return c;
		}


		public static bool LT(StackUnsignedInt a, StackUnsignedInt b)
		{
			bool c = a.value < b.value;
			return c;
		}


		public static bool GTE(StackUnsignedInt a, StackUnsignedInt b)
		{
			bool c = a.value >= b.value;
			return c;
		}


		
		public static bool LTE(StackUnsignedInt a, StackUnsignedInt b)
		{
			bool c = a.value <= b.value;
			return c;
		}



					
		public static StackUnsignedInt Ceil(StackUnsignedInt a)
		{	
			return new StackUnsignedInt(a);
			
		}
					
		public static StackUnsignedInt Floor(StackUnsignedInt a)
		{	
			return new StackUnsignedInt(a);
			
		}
					
		public static StackUnsignedInt Round(StackUnsignedInt a)
		{	
			return new StackUnsignedInt(a);
			
		}


		public static StackUnsignedInt And(StackUnsignedInt a, StackUnsignedInt b)
		{
			uint c = (uint)(a.value & b.value);
			return new StackUnsignedInt(c);
		}

		public static StackUnsignedInt Or(StackUnsignedInt a, StackUnsignedInt b)
		{
			uint c = (uint)(a.value | b.value);
			return new StackUnsignedInt(c);
		}

		public static StackUnsignedInt Xor(StackUnsignedInt a, StackUnsignedInt b)
		{
			uint c = (uint)(a.value ^ b.value);
			return new StackUnsignedInt(c);
		}

		public static StackUnsignedInt LSL(StackUnsignedInt a, StackUnsignedInt b)
		{
			uint c = (uint)(a.value << (int)b.value);
			return new StackUnsignedInt(c);
		}

		public static StackUnsignedInt LSR(StackUnsignedInt a, StackUnsignedInt b)
		{
			uint c = (uint)(a.value >> (int)b.value);
			return new StackUnsignedInt(c);
		}

		public static StackUnsignedInt Not(StackUnsignedInt a)
		{
			uint c = (uint)(~a.value);
			return new StackUnsignedInt(c);
		}


		public static StackUnsignedInt Divide(StackUnsignedInt a, StackUnsignedInt b)
		{
			uint c = (uint)(a.value / b.value);
			return new StackUnsignedInt(c);
		}
		

		public static StackUnsignedInt Modulo(StackUnsignedInt a, StackUnsignedInt b)
		{
			uint c = (uint)(a.value % b.value);
			return new StackUnsignedInt(c);
		}

		public static StackUnsignedInt Max(StackUnsignedInt a, StackUnsignedInt b)
		{			
			if(a.value > b.value)
			{
				return new StackUnsignedInt(a);
			}

			return new StackUnsignedInt(b);
		}
		
		public static StackUnsignedInt Min(StackUnsignedInt a, StackUnsignedInt b)
		{			
			if(a.value < b.value)
			{
				return new StackUnsignedInt(a);
			}

			return new StackUnsignedInt(b);
		}

				
		public static StackUnsignedInt Abs(StackUnsignedInt a)
		{	
						return new StackUnsignedInt(a);
			
					}



		public static StackString Stringify(StackUnsignedInt a)
		{	
			return new StackString(a.ToString());
		}



		//	if(stack.Top is StackUnsignedInt && stack.FromTop(1) is StackUnsignedInt)
		
		private static StackElement[] CheckNGo(string command, TSRPStack stack)
		{

			if(stack.Count < 2) return null; 

			if(stack.Top.GetType() == typeof(StackUnsignedInt) && stack.FromTop(1).GetType() == typeof(StackUnsignedInt))
			{
				StackUnsignedInt b = (StackUnsignedInt)stack.Pop();
				StackUnsignedInt a = (StackUnsignedInt)stack.Pop();
				StackUnsignedInt[] c = new StackUnsignedInt[] { a, b };
				return c;
			}

			// Also a hack but it works.
			if(command == "+" && stack.Top is StackNumber && stack.FromTop(1) is StackString)
			{
				StackUnsignedInt a = (StackUnsignedInt)stack.Pop();
				var b = new StackString((StackString)stack.Pop());
				b.Value += a.value; 
				stack.Push(b);
				return new StackElement[]{ new StackBool(true) };
			}

			if(stack.Top is StackNumber && stack.FromTop(1) is StackNumber)
			{
				StackNumber b = (StackNumber)stack.Pop();
				StackNumber a = (StackNumber)stack.Pop();
				StackElement[] c =  Convert(a,b); 
				stack.Push(c[0]); 
				stack.Push(c[1]);
				var res = stack.Top.Execute(command,stack);
				c = new StackElement[] { new StackBool(res) };	
				return c;
			}
			
			return null;
		}



        public override bool Execute(string command, TSRPStack stack)
        {
            if(command == "+")
			{
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				
				StackUnsignedInt[] d = (StackUnsignedInt[])c;
				
				stack.Push(Add(d[0], d[1]));
				return true;
			}
			else
			if(command == "-")
			{
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				
				StackUnsignedInt[] d = (StackUnsignedInt[])c;

				stack.Push(Add(d[0], d[1], true));
				return true;
			}
			else 
			if(command == "*")
			{
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				
				
				StackUnsignedInt[] d = (StackUnsignedInt[])c;

				stack.Push(Multiply(d[0], d[1]));
				return true;
			}
			else 
			if(command == "^")
			{
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				
				
				StackUnsignedInt[] d = (StackUnsignedInt[])c;

				stack.Push(Power(d[0], d[1]));
				return true;
			}
			else 
			if(command == "/")
			{
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				
				
				StackUnsignedInt[] d = (StackUnsignedInt[])c;

				stack.Push(Divide(d[0], d[1]));
				return true;

			}
			else 
			if(command == "%" || command=="mod")
			{
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				
				
				StackUnsignedInt[] d = (StackUnsignedInt[])c;

				stack.Push(Modulo(d[0], d[1]));
				return true;
			}
			else 
			if(command == "max")
			{
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				
				StackUnsignedInt[] d = (StackUnsignedInt[])c;

				stack.Push(Max(d[0], d[1]));
				return true;
			}
			else 
			if(command == "min")
			{
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				
				StackUnsignedInt[] d = (StackUnsignedInt[])c;

				stack.Push(Min(d[0], d[1]));
				return true;
			}
			else 
			if(command == "<")
			{
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				
				StackUnsignedInt[] d = (StackUnsignedInt[])c;


				stack.Push(LT(d[0], d[1]));
			}
			else 
			if(command == ">")
			{
			
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				StackUnsignedInt[] d = (StackUnsignedInt[])c;

				stack.Push(GT(d[0], d[1]));
			}
			else 
			if(command == "==")
			{
			
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				
				StackUnsignedInt[] d = (StackUnsignedInt[])c;
				
				stack.Push(Equals(d[0], d[1]));
			}
			else 
			if(command == "!=")
			{
			
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				
				StackUnsignedInt[] d = (StackUnsignedInt[])c;
				
				stack.Push(!Equals(d[0], d[1]));
			}
			else 
			if(command == ">=")
			{
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				StackUnsignedInt[] d = (StackUnsignedInt[])c;
				
				stack.Push(GTE(d[0], d[1]));
			}
			else 
			if(command == "<=")
			{
				
				var c = CheckNGo(command, stack);

				if(c == null) return false;
				if(c.Length == 1) return true; 
				StackUnsignedInt[] d = (StackUnsignedInt[])c;

				stack.Push(LTE(d[0], d[1]));
			}
			else if(command == "int") 
			{
				stack.Pop();
				stack.Push((int)value);

				return true;
			}
			else if(command == "double") 
			{
				stack.Pop();
				stack.Push((double)value);

				return true;
			}
			else if(command == "float") 
			{
				stack.Pop();
				stack.Push((float)value);

				return true;
			}
			else if(command == "uint") 
			{
				stack.Pop();
				stack.Push((uint)value);

				return true;
			}
			else if(command == "long") 
			{
				stack.Pop();
				stack.Push((long)value);

				return true;
			}
			else if(command == "ulong") 
			{
				stack.Pop();
				stack.Push((ulong)value);

				return true;
			}
			else if(command == "short") 
			{
				stack.Pop();
				stack.Push((short)value);

				return true;
			}
			else if(command == "ushort") 
			{
				stack.Pop();
				stack.Push((ushort)value);

				return true;
			}
			else if(command == "byte") 
			{
				stack.Pop();
				stack.Push((byte)value);

				return true;
			}
			else if(command == "sbyte") 
			{
				stack.Pop();
				stack.Push((sbyte)value);

				return true;
			}
						else if(command == "string")
			{
				stack.Pop();
				stack.Push(Stringify(this));
				return true;
			}
			else if (command == "abs" || command == "Abs")
			{
				stack.Pop();
				stack.Push(Abs(this));
				return true;
			}
			else if(command == "round")
			{
			
				stack.Pop();
				stack.Push(Round(this));
				return true;
			}
			else if(command == "floor")
			{
			
				stack.Pop();
				stack.Push(Floor(this));
				return true;
			}
			else if(command == "ceil")
			{
				stack.Pop();
				stack.Push(Ceil(this));
				return true;
			}
			else if (command == "rand")
			{
				stack.Pop();
				stack.Push(random.Next((int)value));
				return true;
			}
			else if (command == "char2str")
			{
				stack.Pop();
				stack.Push("" + (char)this.ToUnsignedShort());
				return true;
			}
			else if (command == "~")
			{
				
				if(stack.Top is StackUnsignedInt)
				{ 
					StackUnsignedInt d = (StackUnsignedInt)stack.Pop();
					stack.Push(Not(d));
					return true;
				}
			}
			else if (command == ">>")
			{
			
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				StackUnsignedInt[] d = (StackUnsignedInt[])c;
				
				stack.Push(LSR(d[0], d[1]));
			}
			else if (command == "<<")
			{
			
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				StackUnsignedInt[] d = (StackUnsignedInt[])c;
				
				stack.Push(LSL(d[0], d[1]));
			}
			else if (command == "&" || command == "and")
			{
			
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				StackUnsignedInt[] d = (StackUnsignedInt[])c;
				
				stack.Push(And(d[0], d[1]));
			}
			else if (command == "|" || command == "or")
			{
			
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				StackUnsignedInt[] d = (StackUnsignedInt[])c;
				
				stack.Push(Or(d[0], d[1]));
			}
			else if (command == "xor")
			{
			
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				StackUnsignedInt[] d = (StackUnsignedInt[])c;
				
				stack.Push(Xor(d[0], d[1]));
			}



		



			return false;
        }



		public static explicit operator StackInt(StackUnsignedInt n)
        {
            return new StackInt((int)n.value);
        }


		public static explicit operator StackDouble(StackUnsignedInt n)
        {
            return new StackDouble((double)n.value);
        }


		public static explicit operator StackFloat(StackUnsignedInt n)
        {
            return new StackFloat((float)n.value);
        }


		public static explicit operator StackLong(StackUnsignedInt n)
        {
            return new StackLong((long)n.value);
        }


		public static explicit operator StackUnsignedLong(StackUnsignedInt n)
        {
            return new StackUnsignedLong((ulong)n.value);
        }


		public static explicit operator StackShort(StackUnsignedInt n)
        {
            return new StackShort((short)n.value);
        }


		public static explicit operator StackUnsignedShort(StackUnsignedInt n)
        {
            return new StackUnsignedShort((ushort)n.value);
        }


		public static explicit operator StackByte(StackUnsignedInt n)
        {
            return new StackByte((byte)n.value);
        }


		public static explicit operator StackSignedByte(StackUnsignedInt n)
        {
            return new StackSignedByte((sbyte)n.value);
        }

		
		public override string ToString()
		{
			return value.ToString();
		}
    }



    public class StackLong : StackNumber
    {
        private long value;

		
        public long Value
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
        
        public StackLong() : this(0)
        {

        }

		public override byte[] Bytes
		{
			get
			{
				return BitConverter.GetBytes(value);
			}
		}

        public StackLong(long value)
        {
            this.value = value;
        }


		public StackLong(StackLong copy) : this(copy.value)
		{
		
		}

		public static StackLong Add(StackLong a, StackLong b, bool flip = false)
		{
			long c = a.value;
			if(flip)
			{
				c -= b.value;
			} 
			else
			{
				c += b.value;
			}
		

			return new StackLong(c);
		}
		
        public override object  Clone()
		{
			return new StackLong(this);
		}

		public static StackLong Multiply(StackLong a, StackLong b)
		{
			long c = (long)(a.value * b.value);
			return new StackLong(c);
		}

		

		public static StackLong Power(StackLong a, StackLong b)
		{
			long c = (long)(Math.Pow(a.value,b.value));
			return new StackLong(c);
		}


		public static bool Equals(StackLong a, StackLong b)
		{
			bool c = a.value == b.value;
			return c;
		}


		public static bool GT(StackLong a, StackLong b)
		{
			bool c = a.value > b.value;
			return c;
		}


		public static bool LT(StackLong a, StackLong b)
		{
			bool c = a.value < b.value;
			return c;
		}


		public static bool GTE(StackLong a, StackLong b)
		{
			bool c = a.value >= b.value;
			return c;
		}


		
		public static bool LTE(StackLong a, StackLong b)
		{
			bool c = a.value <= b.value;
			return c;
		}



					
		public static StackLong Ceil(StackLong a)
		{	
			return new StackLong(a);
			
		}
					
		public static StackLong Floor(StackLong a)
		{	
			return new StackLong(a);
			
		}
					
		public static StackLong Round(StackLong a)
		{	
			return new StackLong(a);
			
		}


		public static StackLong And(StackLong a, StackLong b)
		{
			long c = (long)(a.value & b.value);
			return new StackLong(c);
		}

		public static StackLong Or(StackLong a, StackLong b)
		{
			long c = (long)(a.value | b.value);
			return new StackLong(c);
		}

		public static StackLong Xor(StackLong a, StackLong b)
		{
			long c = (long)(a.value ^ b.value);
			return new StackLong(c);
		}

		public static StackLong LSL(StackLong a, StackLong b)
		{
			long c = (long)(a.value << (int)b.value);
			return new StackLong(c);
		}

		public static StackLong LSR(StackLong a, StackLong b)
		{
			long c = (long)(a.value >> (int)b.value);
			return new StackLong(c);
		}

		public static StackLong Not(StackLong a)
		{
			long c = (long)(~a.value);
			return new StackLong(c);
		}


		public static StackLong Divide(StackLong a, StackLong b)
		{
			long c = (long)(a.value / b.value);
			return new StackLong(c);
		}
		

		public static StackLong Modulo(StackLong a, StackLong b)
		{
			long c = (long)(a.value % b.value);
			return new StackLong(c);
		}

		public static StackLong Max(StackLong a, StackLong b)
		{			
			if(a.value > b.value)
			{
				return new StackLong(a);
			}

			return new StackLong(b);
		}
		
		public static StackLong Min(StackLong a, StackLong b)
		{			
			if(a.value < b.value)
			{
				return new StackLong(a);
			}

			return new StackLong(b);
		}

				
		public static StackLong Abs(StackLong a)
		{	
						return new StackLong((long)Math.Abs(a.value));

					}



		public static StackString Stringify(StackLong a)
		{	
			return new StackString(a.ToString());
		}



		//	if(stack.Top is StackLong && stack.FromTop(1) is StackLong)
		
		private static StackElement[] CheckNGo(string command, TSRPStack stack)
		{

			if(stack.Count < 2) return null; 

			if(stack.Top.GetType() == typeof(StackLong) && stack.FromTop(1).GetType() == typeof(StackLong))
			{
				StackLong b = (StackLong)stack.Pop();
				StackLong a = (StackLong)stack.Pop();
				StackLong[] c = new StackLong[] { a, b };
				return c;
			}

			// Also a hack but it works.
			if(command == "+" && stack.Top is StackNumber && stack.FromTop(1) is StackString)
			{
				StackLong a = (StackLong)stack.Pop();
				var b = new StackString((StackString)stack.Pop());
				b.Value += a.value; 
				stack.Push(b);
				return new StackElement[]{ new StackBool(true) };
			}

			if(stack.Top is StackNumber && stack.FromTop(1) is StackNumber)
			{
				StackNumber b = (StackNumber)stack.Pop();
				StackNumber a = (StackNumber)stack.Pop();
				StackElement[] c =  Convert(a,b); 
				stack.Push(c[0]); 
				stack.Push(c[1]);
				var res = stack.Top.Execute(command,stack);
				c = new StackElement[] { new StackBool(res) };	
				return c;
			}
			
			return null;
		}



        public override bool Execute(string command, TSRPStack stack)
        {
            if(command == "+")
			{
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				
				StackLong[] d = (StackLong[])c;
				
				stack.Push(Add(d[0], d[1]));
				return true;
			}
			else
			if(command == "-")
			{
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				
				StackLong[] d = (StackLong[])c;

				stack.Push(Add(d[0], d[1], true));
				return true;
			}
			else 
			if(command == "*")
			{
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				
				
				StackLong[] d = (StackLong[])c;

				stack.Push(Multiply(d[0], d[1]));
				return true;
			}
			else 
			if(command == "^")
			{
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				
				
				StackLong[] d = (StackLong[])c;

				stack.Push(Power(d[0], d[1]));
				return true;
			}
			else 
			if(command == "/")
			{
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				
				
				StackLong[] d = (StackLong[])c;

				stack.Push(Divide(d[0], d[1]));
				return true;

			}
			else 
			if(command == "%" || command=="mod")
			{
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				
				
				StackLong[] d = (StackLong[])c;

				stack.Push(Modulo(d[0], d[1]));
				return true;
			}
			else 
			if(command == "max")
			{
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				
				StackLong[] d = (StackLong[])c;

				stack.Push(Max(d[0], d[1]));
				return true;
			}
			else 
			if(command == "min")
			{
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				
				StackLong[] d = (StackLong[])c;

				stack.Push(Min(d[0], d[1]));
				return true;
			}
			else 
			if(command == "<")
			{
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				
				StackLong[] d = (StackLong[])c;


				stack.Push(LT(d[0], d[1]));
			}
			else 
			if(command == ">")
			{
			
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				StackLong[] d = (StackLong[])c;

				stack.Push(GT(d[0], d[1]));
			}
			else 
			if(command == "==")
			{
			
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				
				StackLong[] d = (StackLong[])c;
				
				stack.Push(Equals(d[0], d[1]));
			}
			else 
			if(command == "!=")
			{
			
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				
				StackLong[] d = (StackLong[])c;
				
				stack.Push(!Equals(d[0], d[1]));
			}
			else 
			if(command == ">=")
			{
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				StackLong[] d = (StackLong[])c;
				
				stack.Push(GTE(d[0], d[1]));
			}
			else 
			if(command == "<=")
			{
				
				var c = CheckNGo(command, stack);

				if(c == null) return false;
				if(c.Length == 1) return true; 
				StackLong[] d = (StackLong[])c;

				stack.Push(LTE(d[0], d[1]));
			}
			else if(command == "int") 
			{
				stack.Pop();
				stack.Push((int)value);

				return true;
			}
			else if(command == "double") 
			{
				stack.Pop();
				stack.Push((double)value);

				return true;
			}
			else if(command == "float") 
			{
				stack.Pop();
				stack.Push((float)value);

				return true;
			}
			else if(command == "uint") 
			{
				stack.Pop();
				stack.Push((uint)value);

				return true;
			}
			else if(command == "long") 
			{
				stack.Pop();
				stack.Push((long)value);

				return true;
			}
			else if(command == "ulong") 
			{
				stack.Pop();
				stack.Push((ulong)value);

				return true;
			}
			else if(command == "short") 
			{
				stack.Pop();
				stack.Push((short)value);

				return true;
			}
			else if(command == "ushort") 
			{
				stack.Pop();
				stack.Push((ushort)value);

				return true;
			}
			else if(command == "byte") 
			{
				stack.Pop();
				stack.Push((byte)value);

				return true;
			}
			else if(command == "sbyte") 
			{
				stack.Pop();
				stack.Push((sbyte)value);

				return true;
			}
						else if(command == "string")
			{
				stack.Pop();
				stack.Push(Stringify(this));
				return true;
			}
			else if (command == "abs" || command == "Abs")
			{
				stack.Pop();
				stack.Push(Abs(this));
				return true;
			}
			else if(command == "round")
			{
			
				stack.Pop();
				stack.Push(Round(this));
				return true;
			}
			else if(command == "floor")
			{
			
				stack.Pop();
				stack.Push(Floor(this));
				return true;
			}
			else if(command == "ceil")
			{
				stack.Pop();
				stack.Push(Ceil(this));
				return true;
			}
			else if (command == "rand")
			{
				stack.Pop();
				stack.Push(random.Next((int)value));
				return true;
			}
			else if (command == "char2str")
			{
				stack.Pop();
				stack.Push("" + (char)this.ToUnsignedShort());
				return true;
			}
			else if (command == "~")
			{
				
				if(stack.Top is StackLong)
				{ 
					StackLong d = (StackLong)stack.Pop();
					stack.Push(Not(d));
					return true;
				}
			}
			else if (command == ">>")
			{
			
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				StackLong[] d = (StackLong[])c;
				
				stack.Push(LSR(d[0], d[1]));
			}
			else if (command == "<<")
			{
			
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				StackLong[] d = (StackLong[])c;
				
				stack.Push(LSL(d[0], d[1]));
			}
			else if (command == "&" || command == "and")
			{
			
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				StackLong[] d = (StackLong[])c;
				
				stack.Push(And(d[0], d[1]));
			}
			else if (command == "|" || command == "or")
			{
			
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				StackLong[] d = (StackLong[])c;
				
				stack.Push(Or(d[0], d[1]));
			}
			else if (command == "xor")
			{
			
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				StackLong[] d = (StackLong[])c;
				
				stack.Push(Xor(d[0], d[1]));
			}



		



			return false;
        }



		public static explicit operator StackInt(StackLong n)
        {
            return new StackInt((int)n.value);
        }


		public static explicit operator StackDouble(StackLong n)
        {
            return new StackDouble((double)n.value);
        }


		public static explicit operator StackFloat(StackLong n)
        {
            return new StackFloat((float)n.value);
        }


		public static explicit operator StackUnsignedInt(StackLong n)
        {
            return new StackUnsignedInt((uint)n.value);
        }


		public static explicit operator StackUnsignedLong(StackLong n)
        {
            return new StackUnsignedLong((ulong)n.value);
        }


		public static explicit operator StackShort(StackLong n)
        {
            return new StackShort((short)n.value);
        }


		public static explicit operator StackUnsignedShort(StackLong n)
        {
            return new StackUnsignedShort((ushort)n.value);
        }


		public static explicit operator StackByte(StackLong n)
        {
            return new StackByte((byte)n.value);
        }


		public static explicit operator StackSignedByte(StackLong n)
        {
            return new StackSignedByte((sbyte)n.value);
        }

		
		public override string ToString()
		{
			return value.ToString();
		}
    }



    public class StackUnsignedLong : StackNumber
    {
        private ulong value;

		
        public ulong Value
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
        
        public StackUnsignedLong() : this(0)
        {

        }

		public override byte[] Bytes
		{
			get
			{
				return BitConverter.GetBytes(value);
			}
		}

        public StackUnsignedLong(ulong value)
        {
            this.value = value;
        }


		public StackUnsignedLong(StackUnsignedLong copy) : this(copy.value)
		{
		
		}

		public static StackUnsignedLong Add(StackUnsignedLong a, StackUnsignedLong b, bool flip = false)
		{
			ulong c = a.value;
			if(flip)
			{
				c -= b.value;
			} 
			else
			{
				c += b.value;
			}
		

			return new StackUnsignedLong(c);
		}
		
        public override object  Clone()
		{
			return new StackUnsignedLong(this);
		}

		public static StackUnsignedLong Multiply(StackUnsignedLong a, StackUnsignedLong b)
		{
			ulong c = (ulong)(a.value * b.value);
			return new StackUnsignedLong(c);
		}

		

		public static StackUnsignedLong Power(StackUnsignedLong a, StackUnsignedLong b)
		{
			ulong c = (ulong)(Math.Pow(a.value,b.value));
			return new StackUnsignedLong(c);
		}


		public static bool Equals(StackUnsignedLong a, StackUnsignedLong b)
		{
			bool c = a.value == b.value;
			return c;
		}


		public static bool GT(StackUnsignedLong a, StackUnsignedLong b)
		{
			bool c = a.value > b.value;
			return c;
		}


		public static bool LT(StackUnsignedLong a, StackUnsignedLong b)
		{
			bool c = a.value < b.value;
			return c;
		}


		public static bool GTE(StackUnsignedLong a, StackUnsignedLong b)
		{
			bool c = a.value >= b.value;
			return c;
		}


		
		public static bool LTE(StackUnsignedLong a, StackUnsignedLong b)
		{
			bool c = a.value <= b.value;
			return c;
		}



					
		public static StackUnsignedLong Ceil(StackUnsignedLong a)
		{	
			return new StackUnsignedLong(a);
			
		}
					
		public static StackUnsignedLong Floor(StackUnsignedLong a)
		{	
			return new StackUnsignedLong(a);
			
		}
					
		public static StackUnsignedLong Round(StackUnsignedLong a)
		{	
			return new StackUnsignedLong(a);
			
		}


		public static StackUnsignedLong And(StackUnsignedLong a, StackUnsignedLong b)
		{
			ulong c = (ulong)(a.value & b.value);
			return new StackUnsignedLong(c);
		}

		public static StackUnsignedLong Or(StackUnsignedLong a, StackUnsignedLong b)
		{
			ulong c = (ulong)(a.value | b.value);
			return new StackUnsignedLong(c);
		}

		public static StackUnsignedLong Xor(StackUnsignedLong a, StackUnsignedLong b)
		{
			ulong c = (ulong)(a.value ^ b.value);
			return new StackUnsignedLong(c);
		}

		public static StackUnsignedLong LSL(StackUnsignedLong a, StackUnsignedLong b)
		{
			ulong c = (ulong)(a.value << (int)b.value);
			return new StackUnsignedLong(c);
		}

		public static StackUnsignedLong LSR(StackUnsignedLong a, StackUnsignedLong b)
		{
			ulong c = (ulong)(a.value >> (int)b.value);
			return new StackUnsignedLong(c);
		}

		public static StackUnsignedLong Not(StackUnsignedLong a)
		{
			ulong c = (ulong)(~a.value);
			return new StackUnsignedLong(c);
		}


		public static StackUnsignedLong Divide(StackUnsignedLong a, StackUnsignedLong b)
		{
			ulong c = (ulong)(a.value / b.value);
			return new StackUnsignedLong(c);
		}
		

		public static StackUnsignedLong Modulo(StackUnsignedLong a, StackUnsignedLong b)
		{
			ulong c = (ulong)(a.value % b.value);
			return new StackUnsignedLong(c);
		}

		public static StackUnsignedLong Max(StackUnsignedLong a, StackUnsignedLong b)
		{			
			if(a.value > b.value)
			{
				return new StackUnsignedLong(a);
			}

			return new StackUnsignedLong(b);
		}
		
		public static StackUnsignedLong Min(StackUnsignedLong a, StackUnsignedLong b)
		{			
			if(a.value < b.value)
			{
				return new StackUnsignedLong(a);
			}

			return new StackUnsignedLong(b);
		}

				
		public static StackUnsignedLong Abs(StackUnsignedLong a)
		{	
						return new StackUnsignedLong(a);
			
					}



		public static StackString Stringify(StackUnsignedLong a)
		{	
			return new StackString(a.ToString());
		}



		//	if(stack.Top is StackUnsignedLong && stack.FromTop(1) is StackUnsignedLong)
		
		private static StackElement[] CheckNGo(string command, TSRPStack stack)
		{

			if(stack.Count < 2) return null; 

			if(stack.Top.GetType() == typeof(StackUnsignedLong) && stack.FromTop(1).GetType() == typeof(StackUnsignedLong))
			{
				StackUnsignedLong b = (StackUnsignedLong)stack.Pop();
				StackUnsignedLong a = (StackUnsignedLong)stack.Pop();
				StackUnsignedLong[] c = new StackUnsignedLong[] { a, b };
				return c;
			}

			// Also a hack but it works.
			if(command == "+" && stack.Top is StackNumber && stack.FromTop(1) is StackString)
			{
				StackUnsignedLong a = (StackUnsignedLong)stack.Pop();
				var b = new StackString((StackString)stack.Pop());
				b.Value += a.value; 
				stack.Push(b);
				return new StackElement[]{ new StackBool(true) };
			}

			if(stack.Top is StackNumber && stack.FromTop(1) is StackNumber)
			{
				StackNumber b = (StackNumber)stack.Pop();
				StackNumber a = (StackNumber)stack.Pop();
				StackElement[] c =  Convert(a,b); 
				stack.Push(c[0]); 
				stack.Push(c[1]);
				var res = stack.Top.Execute(command,stack);
				c = new StackElement[] { new StackBool(res) };	
				return c;
			}
			
			return null;
		}



        public override bool Execute(string command, TSRPStack stack)
        {
            if(command == "+")
			{
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				
				StackUnsignedLong[] d = (StackUnsignedLong[])c;
				
				stack.Push(Add(d[0], d[1]));
				return true;
			}
			else
			if(command == "-")
			{
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				
				StackUnsignedLong[] d = (StackUnsignedLong[])c;

				stack.Push(Add(d[0], d[1], true));
				return true;
			}
			else 
			if(command == "*")
			{
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				
				
				StackUnsignedLong[] d = (StackUnsignedLong[])c;

				stack.Push(Multiply(d[0], d[1]));
				return true;
			}
			else 
			if(command == "^")
			{
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				
				
				StackUnsignedLong[] d = (StackUnsignedLong[])c;

				stack.Push(Power(d[0], d[1]));
				return true;
			}
			else 
			if(command == "/")
			{
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				
				
				StackUnsignedLong[] d = (StackUnsignedLong[])c;

				stack.Push(Divide(d[0], d[1]));
				return true;

			}
			else 
			if(command == "%" || command=="mod")
			{
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				
				
				StackUnsignedLong[] d = (StackUnsignedLong[])c;

				stack.Push(Modulo(d[0], d[1]));
				return true;
			}
			else 
			if(command == "max")
			{
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				
				StackUnsignedLong[] d = (StackUnsignedLong[])c;

				stack.Push(Max(d[0], d[1]));
				return true;
			}
			else 
			if(command == "min")
			{
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				
				StackUnsignedLong[] d = (StackUnsignedLong[])c;

				stack.Push(Min(d[0], d[1]));
				return true;
			}
			else 
			if(command == "<")
			{
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				
				StackUnsignedLong[] d = (StackUnsignedLong[])c;


				stack.Push(LT(d[0], d[1]));
			}
			else 
			if(command == ">")
			{
			
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				StackUnsignedLong[] d = (StackUnsignedLong[])c;

				stack.Push(GT(d[0], d[1]));
			}
			else 
			if(command == "==")
			{
			
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				
				StackUnsignedLong[] d = (StackUnsignedLong[])c;
				
				stack.Push(Equals(d[0], d[1]));
			}
			else 
			if(command == "!=")
			{
			
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				
				StackUnsignedLong[] d = (StackUnsignedLong[])c;
				
				stack.Push(!Equals(d[0], d[1]));
			}
			else 
			if(command == ">=")
			{
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				StackUnsignedLong[] d = (StackUnsignedLong[])c;
				
				stack.Push(GTE(d[0], d[1]));
			}
			else 
			if(command == "<=")
			{
				
				var c = CheckNGo(command, stack);

				if(c == null) return false;
				if(c.Length == 1) return true; 
				StackUnsignedLong[] d = (StackUnsignedLong[])c;

				stack.Push(LTE(d[0], d[1]));
			}
			else if(command == "int") 
			{
				stack.Pop();
				stack.Push((int)value);

				return true;
			}
			else if(command == "double") 
			{
				stack.Pop();
				stack.Push((double)value);

				return true;
			}
			else if(command == "float") 
			{
				stack.Pop();
				stack.Push((float)value);

				return true;
			}
			else if(command == "uint") 
			{
				stack.Pop();
				stack.Push((uint)value);

				return true;
			}
			else if(command == "long") 
			{
				stack.Pop();
				stack.Push((long)value);

				return true;
			}
			else if(command == "ulong") 
			{
				stack.Pop();
				stack.Push((ulong)value);

				return true;
			}
			else if(command == "short") 
			{
				stack.Pop();
				stack.Push((short)value);

				return true;
			}
			else if(command == "ushort") 
			{
				stack.Pop();
				stack.Push((ushort)value);

				return true;
			}
			else if(command == "byte") 
			{
				stack.Pop();
				stack.Push((byte)value);

				return true;
			}
			else if(command == "sbyte") 
			{
				stack.Pop();
				stack.Push((sbyte)value);

				return true;
			}
						else if(command == "string")
			{
				stack.Pop();
				stack.Push(Stringify(this));
				return true;
			}
			else if (command == "abs" || command == "Abs")
			{
				stack.Pop();
				stack.Push(Abs(this));
				return true;
			}
			else if(command == "round")
			{
			
				stack.Pop();
				stack.Push(Round(this));
				return true;
			}
			else if(command == "floor")
			{
			
				stack.Pop();
				stack.Push(Floor(this));
				return true;
			}
			else if(command == "ceil")
			{
				stack.Pop();
				stack.Push(Ceil(this));
				return true;
			}
			else if (command == "rand")
			{
				stack.Pop();
				stack.Push(random.Next((int)value));
				return true;
			}
			else if (command == "char2str")
			{
				stack.Pop();
				stack.Push("" + (char)this.ToUnsignedShort());
				return true;
			}
			else if (command == "~")
			{
				
				if(stack.Top is StackUnsignedLong)
				{ 
					StackUnsignedLong d = (StackUnsignedLong)stack.Pop();
					stack.Push(Not(d));
					return true;
				}
			}
			else if (command == ">>")
			{
			
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				StackUnsignedLong[] d = (StackUnsignedLong[])c;
				
				stack.Push(LSR(d[0], d[1]));
			}
			else if (command == "<<")
			{
			
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				StackUnsignedLong[] d = (StackUnsignedLong[])c;
				
				stack.Push(LSL(d[0], d[1]));
			}
			else if (command == "&" || command == "and")
			{
			
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				StackUnsignedLong[] d = (StackUnsignedLong[])c;
				
				stack.Push(And(d[0], d[1]));
			}
			else if (command == "|" || command == "or")
			{
			
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				StackUnsignedLong[] d = (StackUnsignedLong[])c;
				
				stack.Push(Or(d[0], d[1]));
			}
			else if (command == "xor")
			{
			
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				StackUnsignedLong[] d = (StackUnsignedLong[])c;
				
				stack.Push(Xor(d[0], d[1]));
			}



		



			return false;
        }



		public static explicit operator StackInt(StackUnsignedLong n)
        {
            return new StackInt((int)n.value);
        }


		public static explicit operator StackDouble(StackUnsignedLong n)
        {
            return new StackDouble((double)n.value);
        }


		public static explicit operator StackFloat(StackUnsignedLong n)
        {
            return new StackFloat((float)n.value);
        }


		public static explicit operator StackUnsignedInt(StackUnsignedLong n)
        {
            return new StackUnsignedInt((uint)n.value);
        }


		public static explicit operator StackLong(StackUnsignedLong n)
        {
            return new StackLong((long)n.value);
        }


		public static explicit operator StackShort(StackUnsignedLong n)
        {
            return new StackShort((short)n.value);
        }


		public static explicit operator StackUnsignedShort(StackUnsignedLong n)
        {
            return new StackUnsignedShort((ushort)n.value);
        }


		public static explicit operator StackByte(StackUnsignedLong n)
        {
            return new StackByte((byte)n.value);
        }


		public static explicit operator StackSignedByte(StackUnsignedLong n)
        {
            return new StackSignedByte((sbyte)n.value);
        }

		
		public override string ToString()
		{
			return value.ToString();
		}
    }



    public class StackShort : StackNumber
    {
        private short value;

		
        public short Value
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
        
        public StackShort() : this(0)
        {

        }

		public override byte[] Bytes
		{
			get
			{
				return BitConverter.GetBytes(value);
			}
		}

        public StackShort(short value)
        {
            this.value = value;
        }


		public StackShort(StackShort copy) : this(copy.value)
		{
		
		}

		public static StackShort Add(StackShort a, StackShort b, bool flip = false)
		{
			short c = a.value;
			if(flip)
			{
				c -= b.value;
			} 
			else
			{
				c += b.value;
			}
		

			return new StackShort(c);
		}
		
        public override object  Clone()
		{
			return new StackShort(this);
		}

		public static StackShort Multiply(StackShort a, StackShort b)
		{
			short c = (short)(a.value * b.value);
			return new StackShort(c);
		}

		

		public static StackShort Power(StackShort a, StackShort b)
		{
			short c = (short)(Math.Pow(a.value,b.value));
			return new StackShort(c);
		}


		public static bool Equals(StackShort a, StackShort b)
		{
			bool c = a.value == b.value;
			return c;
		}


		public static bool GT(StackShort a, StackShort b)
		{
			bool c = a.value > b.value;
			return c;
		}


		public static bool LT(StackShort a, StackShort b)
		{
			bool c = a.value < b.value;
			return c;
		}


		public static bool GTE(StackShort a, StackShort b)
		{
			bool c = a.value >= b.value;
			return c;
		}


		
		public static bool LTE(StackShort a, StackShort b)
		{
			bool c = a.value <= b.value;
			return c;
		}



					
		public static StackShort Ceil(StackShort a)
		{	
			return new StackShort(a);
			
		}
					
		public static StackShort Floor(StackShort a)
		{	
			return new StackShort(a);
			
		}
					
		public static StackShort Round(StackShort a)
		{	
			return new StackShort(a);
			
		}


		public static StackShort And(StackShort a, StackShort b)
		{
			short c = (short)(a.value & b.value);
			return new StackShort(c);
		}

		public static StackShort Or(StackShort a, StackShort b)
		{
			short c = (short)(a.value | b.value);
			return new StackShort(c);
		}

		public static StackShort Xor(StackShort a, StackShort b)
		{
			short c = (short)(a.value ^ b.value);
			return new StackShort(c);
		}

		public static StackShort LSL(StackShort a, StackShort b)
		{
			short c = (short)(a.value << (int)b.value);
			return new StackShort(c);
		}

		public static StackShort LSR(StackShort a, StackShort b)
		{
			short c = (short)(a.value >> (int)b.value);
			return new StackShort(c);
		}

		public static StackShort Not(StackShort a)
		{
			short c = (short)(~a.value);
			return new StackShort(c);
		}


		public static StackShort Divide(StackShort a, StackShort b)
		{
			short c = (short)(a.value / b.value);
			return new StackShort(c);
		}
		

		public static StackShort Modulo(StackShort a, StackShort b)
		{
			short c = (short)(a.value % b.value);
			return new StackShort(c);
		}

		public static StackShort Max(StackShort a, StackShort b)
		{			
			if(a.value > b.value)
			{
				return new StackShort(a);
			}

			return new StackShort(b);
		}
		
		public static StackShort Min(StackShort a, StackShort b)
		{			
			if(a.value < b.value)
			{
				return new StackShort(a);
			}

			return new StackShort(b);
		}

				
		public static StackShort Abs(StackShort a)
		{	
						return new StackShort((short)Math.Abs(a.value));

					}



		public static StackString Stringify(StackShort a)
		{	
			return new StackString(a.ToString());
		}



		//	if(stack.Top is StackShort && stack.FromTop(1) is StackShort)
		
		private static StackElement[] CheckNGo(string command, TSRPStack stack)
		{

			if(stack.Count < 2) return null; 

			if(stack.Top.GetType() == typeof(StackShort) && stack.FromTop(1).GetType() == typeof(StackShort))
			{
				StackShort b = (StackShort)stack.Pop();
				StackShort a = (StackShort)stack.Pop();
				StackShort[] c = new StackShort[] { a, b };
				return c;
			}

			// Also a hack but it works.
			if(command == "+" && stack.Top is StackNumber && stack.FromTop(1) is StackString)
			{
				StackShort a = (StackShort)stack.Pop();
				var b = new StackString((StackString)stack.Pop());
				b.Value += a.value; 
				stack.Push(b);
				return new StackElement[]{ new StackBool(true) };
			}

			if(stack.Top is StackNumber && stack.FromTop(1) is StackNumber)
			{
				StackNumber b = (StackNumber)stack.Pop();
				StackNumber a = (StackNumber)stack.Pop();
				StackElement[] c =  Convert(a,b); 
				stack.Push(c[0]); 
				stack.Push(c[1]);
				var res = stack.Top.Execute(command,stack);
				c = new StackElement[] { new StackBool(res) };	
				return c;
			}
			
			return null;
		}



        public override bool Execute(string command, TSRPStack stack)
        {
            if(command == "+")
			{
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				
				StackShort[] d = (StackShort[])c;
				
				stack.Push(Add(d[0], d[1]));
				return true;
			}
			else
			if(command == "-")
			{
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				
				StackShort[] d = (StackShort[])c;

				stack.Push(Add(d[0], d[1], true));
				return true;
			}
			else 
			if(command == "*")
			{
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				
				
				StackShort[] d = (StackShort[])c;

				stack.Push(Multiply(d[0], d[1]));
				return true;
			}
			else 
			if(command == "^")
			{
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				
				
				StackShort[] d = (StackShort[])c;

				stack.Push(Power(d[0], d[1]));
				return true;
			}
			else 
			if(command == "/")
			{
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				
				
				StackShort[] d = (StackShort[])c;

				stack.Push(Divide(d[0], d[1]));
				return true;

			}
			else 
			if(command == "%" || command=="mod")
			{
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				
				
				StackShort[] d = (StackShort[])c;

				stack.Push(Modulo(d[0], d[1]));
				return true;
			}
			else 
			if(command == "max")
			{
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				
				StackShort[] d = (StackShort[])c;

				stack.Push(Max(d[0], d[1]));
				return true;
			}
			else 
			if(command == "min")
			{
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				
				StackShort[] d = (StackShort[])c;

				stack.Push(Min(d[0], d[1]));
				return true;
			}
			else 
			if(command == "<")
			{
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				
				StackShort[] d = (StackShort[])c;


				stack.Push(LT(d[0], d[1]));
			}
			else 
			if(command == ">")
			{
			
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				StackShort[] d = (StackShort[])c;

				stack.Push(GT(d[0], d[1]));
			}
			else 
			if(command == "==")
			{
			
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				
				StackShort[] d = (StackShort[])c;
				
				stack.Push(Equals(d[0], d[1]));
			}
			else 
			if(command == "!=")
			{
			
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				
				StackShort[] d = (StackShort[])c;
				
				stack.Push(!Equals(d[0], d[1]));
			}
			else 
			if(command == ">=")
			{
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				StackShort[] d = (StackShort[])c;
				
				stack.Push(GTE(d[0], d[1]));
			}
			else 
			if(command == "<=")
			{
				
				var c = CheckNGo(command, stack);

				if(c == null) return false;
				if(c.Length == 1) return true; 
				StackShort[] d = (StackShort[])c;

				stack.Push(LTE(d[0], d[1]));
			}
			else if(command == "int") 
			{
				stack.Pop();
				stack.Push((int)value);

				return true;
			}
			else if(command == "double") 
			{
				stack.Pop();
				stack.Push((double)value);

				return true;
			}
			else if(command == "float") 
			{
				stack.Pop();
				stack.Push((float)value);

				return true;
			}
			else if(command == "uint") 
			{
				stack.Pop();
				stack.Push((uint)value);

				return true;
			}
			else if(command == "long") 
			{
				stack.Pop();
				stack.Push((long)value);

				return true;
			}
			else if(command == "ulong") 
			{
				stack.Pop();
				stack.Push((ulong)value);

				return true;
			}
			else if(command == "short") 
			{
				stack.Pop();
				stack.Push((short)value);

				return true;
			}
			else if(command == "ushort") 
			{
				stack.Pop();
				stack.Push((ushort)value);

				return true;
			}
			else if(command == "byte") 
			{
				stack.Pop();
				stack.Push((byte)value);

				return true;
			}
			else if(command == "sbyte") 
			{
				stack.Pop();
				stack.Push((sbyte)value);

				return true;
			}
						else if(command == "string")
			{
				stack.Pop();
				stack.Push(Stringify(this));
				return true;
			}
			else if (command == "abs" || command == "Abs")
			{
				stack.Pop();
				stack.Push(Abs(this));
				return true;
			}
			else if(command == "round")
			{
			
				stack.Pop();
				stack.Push(Round(this));
				return true;
			}
			else if(command == "floor")
			{
			
				stack.Pop();
				stack.Push(Floor(this));
				return true;
			}
			else if(command == "ceil")
			{
				stack.Pop();
				stack.Push(Ceil(this));
				return true;
			}
			else if (command == "rand")
			{
				stack.Pop();
				stack.Push(random.Next((int)value));
				return true;
			}
			else if (command == "char2str")
			{
				stack.Pop();
				stack.Push("" + (char)this.ToUnsignedShort());
				return true;
			}
			else if (command == "~")
			{
				
				if(stack.Top is StackShort)
				{ 
					StackShort d = (StackShort)stack.Pop();
					stack.Push(Not(d));
					return true;
				}
			}
			else if (command == ">>")
			{
			
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				StackShort[] d = (StackShort[])c;
				
				stack.Push(LSR(d[0], d[1]));
			}
			else if (command == "<<")
			{
			
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				StackShort[] d = (StackShort[])c;
				
				stack.Push(LSL(d[0], d[1]));
			}
			else if (command == "&" || command == "and")
			{
			
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				StackShort[] d = (StackShort[])c;
				
				stack.Push(And(d[0], d[1]));
			}
			else if (command == "|" || command == "or")
			{
			
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				StackShort[] d = (StackShort[])c;
				
				stack.Push(Or(d[0], d[1]));
			}
			else if (command == "xor")
			{
			
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				StackShort[] d = (StackShort[])c;
				
				stack.Push(Xor(d[0], d[1]));
			}



		



			return false;
        }



		public static explicit operator StackInt(StackShort n)
        {
            return new StackInt((int)n.value);
        }


		public static explicit operator StackDouble(StackShort n)
        {
            return new StackDouble((double)n.value);
        }


		public static explicit operator StackFloat(StackShort n)
        {
            return new StackFloat((float)n.value);
        }


		public static explicit operator StackUnsignedInt(StackShort n)
        {
            return new StackUnsignedInt((uint)n.value);
        }


		public static explicit operator StackLong(StackShort n)
        {
            return new StackLong((long)n.value);
        }


		public static explicit operator StackUnsignedLong(StackShort n)
        {
            return new StackUnsignedLong((ulong)n.value);
        }


		public static explicit operator StackUnsignedShort(StackShort n)
        {
            return new StackUnsignedShort((ushort)n.value);
        }


		public static explicit operator StackByte(StackShort n)
        {
            return new StackByte((byte)n.value);
        }


		public static explicit operator StackSignedByte(StackShort n)
        {
            return new StackSignedByte((sbyte)n.value);
        }

		
		public override string ToString()
		{
			return value.ToString();
		}
    }



    public class StackUnsignedShort : StackNumber
    {
        private ushort value;

		
        public ushort Value
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
        
        public StackUnsignedShort() : this(0)
        {

        }

		public override byte[] Bytes
		{
			get
			{
				return BitConverter.GetBytes(value);
			}
		}

        public StackUnsignedShort(ushort value)
        {
            this.value = value;
        }


		public StackUnsignedShort(StackUnsignedShort copy) : this(copy.value)
		{
		
		}

		public static StackUnsignedShort Add(StackUnsignedShort a, StackUnsignedShort b, bool flip = false)
		{
			ushort c = a.value;
			if(flip)
			{
				c -= b.value;
			} 
			else
			{
				c += b.value;
			}
		

			return new StackUnsignedShort(c);
		}
		
        public override object  Clone()
		{
			return new StackUnsignedShort(this);
		}

		public static StackUnsignedShort Multiply(StackUnsignedShort a, StackUnsignedShort b)
		{
			ushort c = (ushort)(a.value * b.value);
			return new StackUnsignedShort(c);
		}

		

		public static StackUnsignedShort Power(StackUnsignedShort a, StackUnsignedShort b)
		{
			ushort c = (ushort)(Math.Pow(a.value,b.value));
			return new StackUnsignedShort(c);
		}


		public static bool Equals(StackUnsignedShort a, StackUnsignedShort b)
		{
			bool c = a.value == b.value;
			return c;
		}


		public static bool GT(StackUnsignedShort a, StackUnsignedShort b)
		{
			bool c = a.value > b.value;
			return c;
		}


		public static bool LT(StackUnsignedShort a, StackUnsignedShort b)
		{
			bool c = a.value < b.value;
			return c;
		}


		public static bool GTE(StackUnsignedShort a, StackUnsignedShort b)
		{
			bool c = a.value >= b.value;
			return c;
		}


		
		public static bool LTE(StackUnsignedShort a, StackUnsignedShort b)
		{
			bool c = a.value <= b.value;
			return c;
		}



					
		public static StackUnsignedShort Ceil(StackUnsignedShort a)
		{	
			return new StackUnsignedShort(a);
			
		}
					
		public static StackUnsignedShort Floor(StackUnsignedShort a)
		{	
			return new StackUnsignedShort(a);
			
		}
					
		public static StackUnsignedShort Round(StackUnsignedShort a)
		{	
			return new StackUnsignedShort(a);
			
		}


		public static StackUnsignedShort And(StackUnsignedShort a, StackUnsignedShort b)
		{
			ushort c = (ushort)(a.value & b.value);
			return new StackUnsignedShort(c);
		}

		public static StackUnsignedShort Or(StackUnsignedShort a, StackUnsignedShort b)
		{
			ushort c = (ushort)(a.value | b.value);
			return new StackUnsignedShort(c);
		}

		public static StackUnsignedShort Xor(StackUnsignedShort a, StackUnsignedShort b)
		{
			ushort c = (ushort)(a.value ^ b.value);
			return new StackUnsignedShort(c);
		}

		public static StackUnsignedShort LSL(StackUnsignedShort a, StackUnsignedShort b)
		{
			ushort c = (ushort)(a.value << (int)b.value);
			return new StackUnsignedShort(c);
		}

		public static StackUnsignedShort LSR(StackUnsignedShort a, StackUnsignedShort b)
		{
			ushort c = (ushort)(a.value >> (int)b.value);
			return new StackUnsignedShort(c);
		}

		public static StackUnsignedShort Not(StackUnsignedShort a)
		{
			ushort c = (ushort)(~a.value);
			return new StackUnsignedShort(c);
		}


		public static StackUnsignedShort Divide(StackUnsignedShort a, StackUnsignedShort b)
		{
			ushort c = (ushort)(a.value / b.value);
			return new StackUnsignedShort(c);
		}
		

		public static StackUnsignedShort Modulo(StackUnsignedShort a, StackUnsignedShort b)
		{
			ushort c = (ushort)(a.value % b.value);
			return new StackUnsignedShort(c);
		}

		public static StackUnsignedShort Max(StackUnsignedShort a, StackUnsignedShort b)
		{			
			if(a.value > b.value)
			{
				return new StackUnsignedShort(a);
			}

			return new StackUnsignedShort(b);
		}
		
		public static StackUnsignedShort Min(StackUnsignedShort a, StackUnsignedShort b)
		{			
			if(a.value < b.value)
			{
				return new StackUnsignedShort(a);
			}

			return new StackUnsignedShort(b);
		}

				
		public static StackUnsignedShort Abs(StackUnsignedShort a)
		{	
						return new StackUnsignedShort(a);
			
					}



		public static StackString Stringify(StackUnsignedShort a)
		{	
			return new StackString(a.ToString());
		}



		//	if(stack.Top is StackUnsignedShort && stack.FromTop(1) is StackUnsignedShort)
		
		private static StackElement[] CheckNGo(string command, TSRPStack stack)
		{

			if(stack.Count < 2) return null; 

			if(stack.Top.GetType() == typeof(StackUnsignedShort) && stack.FromTop(1).GetType() == typeof(StackUnsignedShort))
			{
				StackUnsignedShort b = (StackUnsignedShort)stack.Pop();
				StackUnsignedShort a = (StackUnsignedShort)stack.Pop();
				StackUnsignedShort[] c = new StackUnsignedShort[] { a, b };
				return c;
			}

			// Also a hack but it works.
			if(command == "+" && stack.Top is StackNumber && stack.FromTop(1) is StackString)
			{
				StackUnsignedShort a = (StackUnsignedShort)stack.Pop();
				var b = new StackString((StackString)stack.Pop());
				b.Value += a.value; 
				stack.Push(b);
				return new StackElement[]{ new StackBool(true) };
			}

			if(stack.Top is StackNumber && stack.FromTop(1) is StackNumber)
			{
				StackNumber b = (StackNumber)stack.Pop();
				StackNumber a = (StackNumber)stack.Pop();
				StackElement[] c =  Convert(a,b); 
				stack.Push(c[0]); 
				stack.Push(c[1]);
				var res = stack.Top.Execute(command,stack);
				c = new StackElement[] { new StackBool(res) };	
				return c;
			}
			
			return null;
		}



        public override bool Execute(string command, TSRPStack stack)
        {
            if(command == "+")
			{
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				
				StackUnsignedShort[] d = (StackUnsignedShort[])c;
				
				stack.Push(Add(d[0], d[1]));
				return true;
			}
			else
			if(command == "-")
			{
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				
				StackUnsignedShort[] d = (StackUnsignedShort[])c;

				stack.Push(Add(d[0], d[1], true));
				return true;
			}
			else 
			if(command == "*")
			{
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				
				
				StackUnsignedShort[] d = (StackUnsignedShort[])c;

				stack.Push(Multiply(d[0], d[1]));
				return true;
			}
			else 
			if(command == "^")
			{
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				
				
				StackUnsignedShort[] d = (StackUnsignedShort[])c;

				stack.Push(Power(d[0], d[1]));
				return true;
			}
			else 
			if(command == "/")
			{
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				
				
				StackUnsignedShort[] d = (StackUnsignedShort[])c;

				stack.Push(Divide(d[0], d[1]));
				return true;

			}
			else 
			if(command == "%" || command=="mod")
			{
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				
				
				StackUnsignedShort[] d = (StackUnsignedShort[])c;

				stack.Push(Modulo(d[0], d[1]));
				return true;
			}
			else 
			if(command == "max")
			{
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				
				StackUnsignedShort[] d = (StackUnsignedShort[])c;

				stack.Push(Max(d[0], d[1]));
				return true;
			}
			else 
			if(command == "min")
			{
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				
				StackUnsignedShort[] d = (StackUnsignedShort[])c;

				stack.Push(Min(d[0], d[1]));
				return true;
			}
			else 
			if(command == "<")
			{
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				
				StackUnsignedShort[] d = (StackUnsignedShort[])c;


				stack.Push(LT(d[0], d[1]));
			}
			else 
			if(command == ">")
			{
			
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				StackUnsignedShort[] d = (StackUnsignedShort[])c;

				stack.Push(GT(d[0], d[1]));
			}
			else 
			if(command == "==")
			{
			
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				
				StackUnsignedShort[] d = (StackUnsignedShort[])c;
				
				stack.Push(Equals(d[0], d[1]));
			}
			else 
			if(command == "!=")
			{
			
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				
				StackUnsignedShort[] d = (StackUnsignedShort[])c;
				
				stack.Push(!Equals(d[0], d[1]));
			}
			else 
			if(command == ">=")
			{
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				StackUnsignedShort[] d = (StackUnsignedShort[])c;
				
				stack.Push(GTE(d[0], d[1]));
			}
			else 
			if(command == "<=")
			{
				
				var c = CheckNGo(command, stack);

				if(c == null) return false;
				if(c.Length == 1) return true; 
				StackUnsignedShort[] d = (StackUnsignedShort[])c;

				stack.Push(LTE(d[0], d[1]));
			}
			else if(command == "int") 
			{
				stack.Pop();
				stack.Push((int)value);

				return true;
			}
			else if(command == "double") 
			{
				stack.Pop();
				stack.Push((double)value);

				return true;
			}
			else if(command == "float") 
			{
				stack.Pop();
				stack.Push((float)value);

				return true;
			}
			else if(command == "uint") 
			{
				stack.Pop();
				stack.Push((uint)value);

				return true;
			}
			else if(command == "long") 
			{
				stack.Pop();
				stack.Push((long)value);

				return true;
			}
			else if(command == "ulong") 
			{
				stack.Pop();
				stack.Push((ulong)value);

				return true;
			}
			else if(command == "short") 
			{
				stack.Pop();
				stack.Push((short)value);

				return true;
			}
			else if(command == "ushort") 
			{
				stack.Pop();
				stack.Push((ushort)value);

				return true;
			}
			else if(command == "byte") 
			{
				stack.Pop();
				stack.Push((byte)value);

				return true;
			}
			else if(command == "sbyte") 
			{
				stack.Pop();
				stack.Push((sbyte)value);

				return true;
			}
						else if(command == "string")
			{
				stack.Pop();
				stack.Push(Stringify(this));
				return true;
			}
			else if (command == "abs" || command == "Abs")
			{
				stack.Pop();
				stack.Push(Abs(this));
				return true;
			}
			else if(command == "round")
			{
			
				stack.Pop();
				stack.Push(Round(this));
				return true;
			}
			else if(command == "floor")
			{
			
				stack.Pop();
				stack.Push(Floor(this));
				return true;
			}
			else if(command == "ceil")
			{
				stack.Pop();
				stack.Push(Ceil(this));
				return true;
			}
			else if (command == "rand")
			{
				stack.Pop();
				stack.Push(random.Next((int)value));
				return true;
			}
			else if (command == "char2str")
			{
				stack.Pop();
				stack.Push("" + (char)this.ToUnsignedShort());
				return true;
			}
			else if (command == "~")
			{
				
				if(stack.Top is StackUnsignedShort)
				{ 
					StackUnsignedShort d = (StackUnsignedShort)stack.Pop();
					stack.Push(Not(d));
					return true;
				}
			}
			else if (command == ">>")
			{
			
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				StackUnsignedShort[] d = (StackUnsignedShort[])c;
				
				stack.Push(LSR(d[0], d[1]));
			}
			else if (command == "<<")
			{
			
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				StackUnsignedShort[] d = (StackUnsignedShort[])c;
				
				stack.Push(LSL(d[0], d[1]));
			}
			else if (command == "&" || command == "and")
			{
			
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				StackUnsignedShort[] d = (StackUnsignedShort[])c;
				
				stack.Push(And(d[0], d[1]));
			}
			else if (command == "|" || command == "or")
			{
			
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				StackUnsignedShort[] d = (StackUnsignedShort[])c;
				
				stack.Push(Or(d[0], d[1]));
			}
			else if (command == "xor")
			{
			
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				StackUnsignedShort[] d = (StackUnsignedShort[])c;
				
				stack.Push(Xor(d[0], d[1]));
			}



		



			return false;
        }



		public static explicit operator StackInt(StackUnsignedShort n)
        {
            return new StackInt((int)n.value);
        }


		public static explicit operator StackDouble(StackUnsignedShort n)
        {
            return new StackDouble((double)n.value);
        }


		public static explicit operator StackFloat(StackUnsignedShort n)
        {
            return new StackFloat((float)n.value);
        }


		public static explicit operator StackUnsignedInt(StackUnsignedShort n)
        {
            return new StackUnsignedInt((uint)n.value);
        }


		public static explicit operator StackLong(StackUnsignedShort n)
        {
            return new StackLong((long)n.value);
        }


		public static explicit operator StackUnsignedLong(StackUnsignedShort n)
        {
            return new StackUnsignedLong((ulong)n.value);
        }


		public static explicit operator StackShort(StackUnsignedShort n)
        {
            return new StackShort((short)n.value);
        }


		public static explicit operator StackByte(StackUnsignedShort n)
        {
            return new StackByte((byte)n.value);
        }


		public static explicit operator StackSignedByte(StackUnsignedShort n)
        {
            return new StackSignedByte((sbyte)n.value);
        }

		
		public override string ToString()
		{
			return value.ToString();
		}
    }



    public class StackByte : StackNumber
    {
        private byte value;

		
        public byte Value
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
        
        public StackByte() : this(0)
        {

        }

		public override byte[] Bytes
		{
			get
			{
				return BitConverter.GetBytes(value);
			}
		}

        public StackByte(byte value)
        {
            this.value = value;
        }


		public StackByte(StackByte copy) : this(copy.value)
		{
		
		}

		public static StackByte Add(StackByte a, StackByte b, bool flip = false)
		{
			byte c = a.value;
			if(flip)
			{
				c -= b.value;
			} 
			else
			{
				c += b.value;
			}
		

			return new StackByte(c);
		}
		
        public override object  Clone()
		{
			return new StackByte(this);
		}

		public static StackByte Multiply(StackByte a, StackByte b)
		{
			byte c = (byte)(a.value * b.value);
			return new StackByte(c);
		}

		

		public static StackByte Power(StackByte a, StackByte b)
		{
			byte c = (byte)(Math.Pow(a.value,b.value));
			return new StackByte(c);
		}


		public static bool Equals(StackByte a, StackByte b)
		{
			bool c = a.value == b.value;
			return c;
		}


		public static bool GT(StackByte a, StackByte b)
		{
			bool c = a.value > b.value;
			return c;
		}


		public static bool LT(StackByte a, StackByte b)
		{
			bool c = a.value < b.value;
			return c;
		}


		public static bool GTE(StackByte a, StackByte b)
		{
			bool c = a.value >= b.value;
			return c;
		}


		
		public static bool LTE(StackByte a, StackByte b)
		{
			bool c = a.value <= b.value;
			return c;
		}



					
		public static StackByte Ceil(StackByte a)
		{	
			return new StackByte(a);
			
		}
					
		public static StackByte Floor(StackByte a)
		{	
			return new StackByte(a);
			
		}
					
		public static StackByte Round(StackByte a)
		{	
			return new StackByte(a);
			
		}


		public static StackByte And(StackByte a, StackByte b)
		{
			byte c = (byte)(a.value & b.value);
			return new StackByte(c);
		}

		public static StackByte Or(StackByte a, StackByte b)
		{
			byte c = (byte)(a.value | b.value);
			return new StackByte(c);
		}

		public static StackByte Xor(StackByte a, StackByte b)
		{
			byte c = (byte)(a.value ^ b.value);
			return new StackByte(c);
		}

		public static StackByte LSL(StackByte a, StackByte b)
		{
			byte c = (byte)(a.value << (int)b.value);
			return new StackByte(c);
		}

		public static StackByte LSR(StackByte a, StackByte b)
		{
			byte c = (byte)(a.value >> (int)b.value);
			return new StackByte(c);
		}

		public static StackByte Not(StackByte a)
		{
			byte c = (byte)(~a.value);
			return new StackByte(c);
		}


		public static StackByte Divide(StackByte a, StackByte b)
		{
			byte c = (byte)(a.value / b.value);
			return new StackByte(c);
		}
		

		public static StackByte Modulo(StackByte a, StackByte b)
		{
			byte c = (byte)(a.value % b.value);
			return new StackByte(c);
		}

		public static StackByte Max(StackByte a, StackByte b)
		{			
			if(a.value > b.value)
			{
				return new StackByte(a);
			}

			return new StackByte(b);
		}
		
		public static StackByte Min(StackByte a, StackByte b)
		{			
			if(a.value < b.value)
			{
				return new StackByte(a);
			}

			return new StackByte(b);
		}

				
		public static StackByte Abs(StackByte a)
		{	
						return new StackByte((byte)Math.Abs(a.value));

					}



		public static StackString Stringify(StackByte a)
		{	
			return new StackString(a.ToString());
		}



		//	if(stack.Top is StackByte && stack.FromTop(1) is StackByte)
		
		private static StackElement[] CheckNGo(string command, TSRPStack stack)
		{

			if(stack.Count < 2) return null; 

			if(stack.Top.GetType() == typeof(StackByte) && stack.FromTop(1).GetType() == typeof(StackByte))
			{
				StackByte b = (StackByte)stack.Pop();
				StackByte a = (StackByte)stack.Pop();
				StackByte[] c = new StackByte[] { a, b };
				return c;
			}

			// Also a hack but it works.
			if(command == "+" && stack.Top is StackNumber && stack.FromTop(1) is StackString)
			{
				StackByte a = (StackByte)stack.Pop();
				var b = new StackString((StackString)stack.Pop());
				b.Value += a.value; 
				stack.Push(b);
				return new StackElement[]{ new StackBool(true) };
			}

			if(stack.Top is StackNumber && stack.FromTop(1) is StackNumber)
			{
				StackNumber b = (StackNumber)stack.Pop();
				StackNumber a = (StackNumber)stack.Pop();
				StackElement[] c =  Convert(a,b); 
				stack.Push(c[0]); 
				stack.Push(c[1]);
				var res = stack.Top.Execute(command,stack);
				c = new StackElement[] { new StackBool(res) };	
				return c;
			}
			
			return null;
		}



        public override bool Execute(string command, TSRPStack stack)
        {
            if(command == "+")
			{
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				
				StackByte[] d = (StackByte[])c;
				
				stack.Push(Add(d[0], d[1]));
				return true;
			}
			else
			if(command == "-")
			{
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				
				StackByte[] d = (StackByte[])c;

				stack.Push(Add(d[0], d[1], true));
				return true;
			}
			else 
			if(command == "*")
			{
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				
				
				StackByte[] d = (StackByte[])c;

				stack.Push(Multiply(d[0], d[1]));
				return true;
			}
			else 
			if(command == "^")
			{
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				
				
				StackByte[] d = (StackByte[])c;

				stack.Push(Power(d[0], d[1]));
				return true;
			}
			else 
			if(command == "/")
			{
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				
				
				StackByte[] d = (StackByte[])c;

				stack.Push(Divide(d[0], d[1]));
				return true;

			}
			else 
			if(command == "%" || command=="mod")
			{
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				
				
				StackByte[] d = (StackByte[])c;

				stack.Push(Modulo(d[0], d[1]));
				return true;
			}
			else 
			if(command == "max")
			{
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				
				StackByte[] d = (StackByte[])c;

				stack.Push(Max(d[0], d[1]));
				return true;
			}
			else 
			if(command == "min")
			{
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				
				StackByte[] d = (StackByte[])c;

				stack.Push(Min(d[0], d[1]));
				return true;
			}
			else 
			if(command == "<")
			{
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				
				StackByte[] d = (StackByte[])c;


				stack.Push(LT(d[0], d[1]));
			}
			else 
			if(command == ">")
			{
			
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				StackByte[] d = (StackByte[])c;

				stack.Push(GT(d[0], d[1]));
			}
			else 
			if(command == "==")
			{
			
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				
				StackByte[] d = (StackByte[])c;
				
				stack.Push(Equals(d[0], d[1]));
			}
			else 
			if(command == "!=")
			{
			
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				
				StackByte[] d = (StackByte[])c;
				
				stack.Push(!Equals(d[0], d[1]));
			}
			else 
			if(command == ">=")
			{
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				StackByte[] d = (StackByte[])c;
				
				stack.Push(GTE(d[0], d[1]));
			}
			else 
			if(command == "<=")
			{
				
				var c = CheckNGo(command, stack);

				if(c == null) return false;
				if(c.Length == 1) return true; 
				StackByte[] d = (StackByte[])c;

				stack.Push(LTE(d[0], d[1]));
			}
			else if(command == "int") 
			{
				stack.Pop();
				stack.Push((int)value);

				return true;
			}
			else if(command == "double") 
			{
				stack.Pop();
				stack.Push((double)value);

				return true;
			}
			else if(command == "float") 
			{
				stack.Pop();
				stack.Push((float)value);

				return true;
			}
			else if(command == "uint") 
			{
				stack.Pop();
				stack.Push((uint)value);

				return true;
			}
			else if(command == "long") 
			{
				stack.Pop();
				stack.Push((long)value);

				return true;
			}
			else if(command == "ulong") 
			{
				stack.Pop();
				stack.Push((ulong)value);

				return true;
			}
			else if(command == "short") 
			{
				stack.Pop();
				stack.Push((short)value);

				return true;
			}
			else if(command == "ushort") 
			{
				stack.Pop();
				stack.Push((ushort)value);

				return true;
			}
			else if(command == "byte") 
			{
				stack.Pop();
				stack.Push((byte)value);

				return true;
			}
			else if(command == "sbyte") 
			{
				stack.Pop();
				stack.Push((sbyte)value);

				return true;
			}
						else if(command == "string")
			{
				stack.Pop();
				stack.Push(Stringify(this));
				return true;
			}
			else if (command == "abs" || command == "Abs")
			{
				stack.Pop();
				stack.Push(Abs(this));
				return true;
			}
			else if(command == "round")
			{
			
				stack.Pop();
				stack.Push(Round(this));
				return true;
			}
			else if(command == "floor")
			{
			
				stack.Pop();
				stack.Push(Floor(this));
				return true;
			}
			else if(command == "ceil")
			{
				stack.Pop();
				stack.Push(Ceil(this));
				return true;
			}
			else if (command == "rand")
			{
				stack.Pop();
				stack.Push(random.Next((int)value));
				return true;
			}
			else if (command == "char2str")
			{
				stack.Pop();
				stack.Push("" + (char)this.ToUnsignedShort());
				return true;
			}
			else if (command == "~")
			{
				
				if(stack.Top is StackByte)
				{ 
					StackByte d = (StackByte)stack.Pop();
					stack.Push(Not(d));
					return true;
				}
			}
			else if (command == ">>")
			{
			
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				StackByte[] d = (StackByte[])c;
				
				stack.Push(LSR(d[0], d[1]));
			}
			else if (command == "<<")
			{
			
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				StackByte[] d = (StackByte[])c;
				
				stack.Push(LSL(d[0], d[1]));
			}
			else if (command == "&" || command == "and")
			{
			
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				StackByte[] d = (StackByte[])c;
				
				stack.Push(And(d[0], d[1]));
			}
			else if (command == "|" || command == "or")
			{
			
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				StackByte[] d = (StackByte[])c;
				
				stack.Push(Or(d[0], d[1]));
			}
			else if (command == "xor")
			{
			
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				StackByte[] d = (StackByte[])c;
				
				stack.Push(Xor(d[0], d[1]));
			}



		



			return false;
        }



		public static explicit operator StackInt(StackByte n)
        {
            return new StackInt((int)n.value);
        }


		public static explicit operator StackDouble(StackByte n)
        {
            return new StackDouble((double)n.value);
        }


		public static explicit operator StackFloat(StackByte n)
        {
            return new StackFloat((float)n.value);
        }


		public static explicit operator StackUnsignedInt(StackByte n)
        {
            return new StackUnsignedInt((uint)n.value);
        }


		public static explicit operator StackLong(StackByte n)
        {
            return new StackLong((long)n.value);
        }


		public static explicit operator StackUnsignedLong(StackByte n)
        {
            return new StackUnsignedLong((ulong)n.value);
        }


		public static explicit operator StackShort(StackByte n)
        {
            return new StackShort((short)n.value);
        }


		public static explicit operator StackUnsignedShort(StackByte n)
        {
            return new StackUnsignedShort((ushort)n.value);
        }


		public static explicit operator StackSignedByte(StackByte n)
        {
            return new StackSignedByte((sbyte)n.value);
        }

		
		public override string ToString()
		{
			return value.ToString();
		}
    }



    public class StackSignedByte : StackNumber
    {
        private sbyte value;

		
        public sbyte Value
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
        
        public StackSignedByte() : this(0)
        {

        }

		public override byte[] Bytes
		{
			get
			{
				return BitConverter.GetBytes(value);
			}
		}

        public StackSignedByte(sbyte value)
        {
            this.value = value;
        }


		public StackSignedByte(StackSignedByte copy) : this(copy.value)
		{
		
		}

		public static StackSignedByte Add(StackSignedByte a, StackSignedByte b, bool flip = false)
		{
			sbyte c = a.value;
			if(flip)
			{
				c -= b.value;
			} 
			else
			{
				c += b.value;
			}
		

			return new StackSignedByte(c);
		}
		
        public override object  Clone()
		{
			return new StackSignedByte(this);
		}

		public static StackSignedByte Multiply(StackSignedByte a, StackSignedByte b)
		{
			sbyte c = (sbyte)(a.value * b.value);
			return new StackSignedByte(c);
		}

		

		public static StackSignedByte Power(StackSignedByte a, StackSignedByte b)
		{
			sbyte c = (sbyte)(Math.Pow(a.value,b.value));
			return new StackSignedByte(c);
		}


		public static bool Equals(StackSignedByte a, StackSignedByte b)
		{
			bool c = a.value == b.value;
			return c;
		}


		public static bool GT(StackSignedByte a, StackSignedByte b)
		{
			bool c = a.value > b.value;
			return c;
		}


		public static bool LT(StackSignedByte a, StackSignedByte b)
		{
			bool c = a.value < b.value;
			return c;
		}


		public static bool GTE(StackSignedByte a, StackSignedByte b)
		{
			bool c = a.value >= b.value;
			return c;
		}


		
		public static bool LTE(StackSignedByte a, StackSignedByte b)
		{
			bool c = a.value <= b.value;
			return c;
		}



					
		public static StackSignedByte Ceil(StackSignedByte a)
		{	
			return new StackSignedByte(a);
			
		}
					
		public static StackSignedByte Floor(StackSignedByte a)
		{	
			return new StackSignedByte(a);
			
		}
					
		public static StackSignedByte Round(StackSignedByte a)
		{	
			return new StackSignedByte(a);
			
		}


		public static StackSignedByte And(StackSignedByte a, StackSignedByte b)
		{
			sbyte c = (sbyte)(a.value & b.value);
			return new StackSignedByte(c);
		}

		public static StackSignedByte Or(StackSignedByte a, StackSignedByte b)
		{
			sbyte c = (sbyte)(a.value | b.value);
			return new StackSignedByte(c);
		}

		public static StackSignedByte Xor(StackSignedByte a, StackSignedByte b)
		{
			sbyte c = (sbyte)(a.value ^ b.value);
			return new StackSignedByte(c);
		}

		public static StackSignedByte LSL(StackSignedByte a, StackSignedByte b)
		{
			sbyte c = (sbyte)(a.value << (int)b.value);
			return new StackSignedByte(c);
		}

		public static StackSignedByte LSR(StackSignedByte a, StackSignedByte b)
		{
			sbyte c = (sbyte)(a.value >> (int)b.value);
			return new StackSignedByte(c);
		}

		public static StackSignedByte Not(StackSignedByte a)
		{
			sbyte c = (sbyte)(~a.value);
			return new StackSignedByte(c);
		}


		public static StackSignedByte Divide(StackSignedByte a, StackSignedByte b)
		{
			sbyte c = (sbyte)(a.value / b.value);
			return new StackSignedByte(c);
		}
		

		public static StackSignedByte Modulo(StackSignedByte a, StackSignedByte b)
		{
			sbyte c = (sbyte)(a.value % b.value);
			return new StackSignedByte(c);
		}

		public static StackSignedByte Max(StackSignedByte a, StackSignedByte b)
		{			
			if(a.value > b.value)
			{
				return new StackSignedByte(a);
			}

			return new StackSignedByte(b);
		}
		
		public static StackSignedByte Min(StackSignedByte a, StackSignedByte b)
		{			
			if(a.value < b.value)
			{
				return new StackSignedByte(a);
			}

			return new StackSignedByte(b);
		}

				
		public static StackSignedByte Abs(StackSignedByte a)
		{	
						return new StackSignedByte((sbyte)Math.Abs(a.value));

					}



		public static StackString Stringify(StackSignedByte a)
		{	
			return new StackString(a.ToString());
		}



		//	if(stack.Top is StackSignedByte && stack.FromTop(1) is StackSignedByte)
		
		private static StackElement[] CheckNGo(string command, TSRPStack stack)
		{

			if(stack.Count < 2) return null; 

			if(stack.Top.GetType() == typeof(StackSignedByte) && stack.FromTop(1).GetType() == typeof(StackSignedByte))
			{
				StackSignedByte b = (StackSignedByte)stack.Pop();
				StackSignedByte a = (StackSignedByte)stack.Pop();
				StackSignedByte[] c = new StackSignedByte[] { a, b };
				return c;
			}

			// Also a hack but it works.
			if(command == "+" && stack.Top is StackNumber && stack.FromTop(1) is StackString)
			{
				StackSignedByte a = (StackSignedByte)stack.Pop();
				var b = new StackString((StackString)stack.Pop());
				b.Value += a.value; 
				stack.Push(b);
				return new StackElement[]{ new StackBool(true) };
			}

			if(stack.Top is StackNumber && stack.FromTop(1) is StackNumber)
			{
				StackNumber b = (StackNumber)stack.Pop();
				StackNumber a = (StackNumber)stack.Pop();
				StackElement[] c =  Convert(a,b); 
				stack.Push(c[0]); 
				stack.Push(c[1]);
				var res = stack.Top.Execute(command,stack);
				c = new StackElement[] { new StackBool(res) };	
				return c;
			}
			
			return null;
		}



        public override bool Execute(string command, TSRPStack stack)
        {
            if(command == "+")
			{
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				
				StackSignedByte[] d = (StackSignedByte[])c;
				
				stack.Push(Add(d[0], d[1]));
				return true;
			}
			else
			if(command == "-")
			{
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				
				StackSignedByte[] d = (StackSignedByte[])c;

				stack.Push(Add(d[0], d[1], true));
				return true;
			}
			else 
			if(command == "*")
			{
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				
				
				StackSignedByte[] d = (StackSignedByte[])c;

				stack.Push(Multiply(d[0], d[1]));
				return true;
			}
			else 
			if(command == "^")
			{
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				
				
				StackSignedByte[] d = (StackSignedByte[])c;

				stack.Push(Power(d[0], d[1]));
				return true;
			}
			else 
			if(command == "/")
			{
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				
				
				StackSignedByte[] d = (StackSignedByte[])c;

				stack.Push(Divide(d[0], d[1]));
				return true;

			}
			else 
			if(command == "%" || command=="mod")
			{
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				
				
				StackSignedByte[] d = (StackSignedByte[])c;

				stack.Push(Modulo(d[0], d[1]));
				return true;
			}
			else 
			if(command == "max")
			{
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				
				StackSignedByte[] d = (StackSignedByte[])c;

				stack.Push(Max(d[0], d[1]));
				return true;
			}
			else 
			if(command == "min")
			{
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				
				StackSignedByte[] d = (StackSignedByte[])c;

				stack.Push(Min(d[0], d[1]));
				return true;
			}
			else 
			if(command == "<")
			{
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				
				StackSignedByte[] d = (StackSignedByte[])c;


				stack.Push(LT(d[0], d[1]));
			}
			else 
			if(command == ">")
			{
			
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				StackSignedByte[] d = (StackSignedByte[])c;

				stack.Push(GT(d[0], d[1]));
			}
			else 
			if(command == "==")
			{
			
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				
				StackSignedByte[] d = (StackSignedByte[])c;
				
				stack.Push(Equals(d[0], d[1]));
			}
			else 
			if(command == "!=")
			{
			
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				
				StackSignedByte[] d = (StackSignedByte[])c;
				
				stack.Push(!Equals(d[0], d[1]));
			}
			else 
			if(command == ">=")
			{
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				StackSignedByte[] d = (StackSignedByte[])c;
				
				stack.Push(GTE(d[0], d[1]));
			}
			else 
			if(command == "<=")
			{
				
				var c = CheckNGo(command, stack);

				if(c == null) return false;
				if(c.Length == 1) return true; 
				StackSignedByte[] d = (StackSignedByte[])c;

				stack.Push(LTE(d[0], d[1]));
			}
			else if(command == "int") 
			{
				stack.Pop();
				stack.Push((int)value);

				return true;
			}
			else if(command == "double") 
			{
				stack.Pop();
				stack.Push((double)value);

				return true;
			}
			else if(command == "float") 
			{
				stack.Pop();
				stack.Push((float)value);

				return true;
			}
			else if(command == "uint") 
			{
				stack.Pop();
				stack.Push((uint)value);

				return true;
			}
			else if(command == "long") 
			{
				stack.Pop();
				stack.Push((long)value);

				return true;
			}
			else if(command == "ulong") 
			{
				stack.Pop();
				stack.Push((ulong)value);

				return true;
			}
			else if(command == "short") 
			{
				stack.Pop();
				stack.Push((short)value);

				return true;
			}
			else if(command == "ushort") 
			{
				stack.Pop();
				stack.Push((ushort)value);

				return true;
			}
			else if(command == "byte") 
			{
				stack.Pop();
				stack.Push((byte)value);

				return true;
			}
			else if(command == "sbyte") 
			{
				stack.Pop();
				stack.Push((sbyte)value);

				return true;
			}
						else if(command == "string")
			{
				stack.Pop();
				stack.Push(Stringify(this));
				return true;
			}
			else if (command == "abs" || command == "Abs")
			{
				stack.Pop();
				stack.Push(Abs(this));
				return true;
			}
			else if(command == "round")
			{
			
				stack.Pop();
				stack.Push(Round(this));
				return true;
			}
			else if(command == "floor")
			{
			
				stack.Pop();
				stack.Push(Floor(this));
				return true;
			}
			else if(command == "ceil")
			{
				stack.Pop();
				stack.Push(Ceil(this));
				return true;
			}
			else if (command == "rand")
			{
				stack.Pop();
				stack.Push(random.Next((int)value));
				return true;
			}
			else if (command == "char2str")
			{
				stack.Pop();
				stack.Push("" + (char)this.ToUnsignedShort());
				return true;
			}
			else if (command == "~")
			{
				
				if(stack.Top is StackSignedByte)
				{ 
					StackSignedByte d = (StackSignedByte)stack.Pop();
					stack.Push(Not(d));
					return true;
				}
			}
			else if (command == ">>")
			{
			
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				StackSignedByte[] d = (StackSignedByte[])c;
				
				stack.Push(LSR(d[0], d[1]));
			}
			else if (command == "<<")
			{
			
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				StackSignedByte[] d = (StackSignedByte[])c;
				
				stack.Push(LSL(d[0], d[1]));
			}
			else if (command == "&" || command == "and")
			{
			
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				StackSignedByte[] d = (StackSignedByte[])c;
				
				stack.Push(And(d[0], d[1]));
			}
			else if (command == "|" || command == "or")
			{
			
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				StackSignedByte[] d = (StackSignedByte[])c;
				
				stack.Push(Or(d[0], d[1]));
			}
			else if (command == "xor")
			{
			
				var c = CheckNGo(command, stack);
				if(c == null) return false;
				if(c.Length == 1) return true; 
				StackSignedByte[] d = (StackSignedByte[])c;
				
				stack.Push(Xor(d[0], d[1]));
			}



		



			return false;
        }



		public static explicit operator StackInt(StackSignedByte n)
        {
            return new StackInt((int)n.value);
        }


		public static explicit operator StackDouble(StackSignedByte n)
        {
            return new StackDouble((double)n.value);
        }


		public static explicit operator StackFloat(StackSignedByte n)
        {
            return new StackFloat((float)n.value);
        }


		public static explicit operator StackUnsignedInt(StackSignedByte n)
        {
            return new StackUnsignedInt((uint)n.value);
        }


		public static explicit operator StackLong(StackSignedByte n)
        {
            return new StackLong((long)n.value);
        }


		public static explicit operator StackUnsignedLong(StackSignedByte n)
        {
            return new StackUnsignedLong((ulong)n.value);
        }


		public static explicit operator StackShort(StackSignedByte n)
        {
            return new StackShort((short)n.value);
        }


		public static explicit operator StackUnsignedShort(StackSignedByte n)
        {
            return new StackUnsignedShort((ushort)n.value);
        }


		public static explicit operator StackByte(StackSignedByte n)
        {
            return new StackByte((byte)n.value);
        }

		
		public override string ToString()
		{
			return value.ToString();
		}
    }



}
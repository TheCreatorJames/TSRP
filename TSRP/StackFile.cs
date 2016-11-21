using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace TSRP
{
    class StackFile : StackCustom, IDisposable
    {
        private FileStream file;
        private StreamReader reader;
        private StreamWriter writer;
        private bool closed;
        public StackFile(string file)
        {
            this.file = File.Open(file, FileMode.OpenOrCreate);
            var utf8WithoutBom = new System.Text.UTF8Encoding(false);
            this.reader = new StreamReader(this.file, utf8WithoutBom, false, 2048, true);
            this.writer = new StreamWriter(this.file, utf8WithoutBom, 2048, true);  
        }

        public override object Clone()
        {
            return this;
        }

        public void Dispose()
        {
            reader.Close();
            writer.Close();
            file.Close();
            
        }

        public override bool Execute(string command, TSRPStack stack)
        {
            if (closed) return false;
            if (command == "CheckLine")
            {
                stack.Push(reader.Peek() >= 0);
                return true;
            }
            else
            if (command == "Check")
            {
                stack.Push(file.Position < file.Length);
                return true;
            }
            else
            if(command == "Close")
            {
                Dispose();
                closed = true;
                return true;
            }
            else
            if (command == "Write")
            {
                if (stack.Top is StackString)
                {
                    StackString s = (StackString)stack.Pop();
                    writer.Write(s.Value);
                    return true;
                }
            }
            else
            if (command == "ReadByte")
            {
                stack.Push((byte)file.ReadByte());
                return true;
            }
            else
            if (command == "Read")
            {
                stack.Push("" + (char)reader.Read());
                return true;
            }
            else
            if (command == "WriteLine")
            {
                StackString s = (StackString)stack.Pop();
                writer.WriteLine(s.Value);
                return true;
            }
            else
            if (command == "ReadLine")
            {
                stack.Push(reader.ReadLine());
                return true;
            }
            else
            if (command == "ReadToEnd")
            {
                stack.Push(reader.ReadToEnd());
                return true;
            }
            else
            if (command == "WriteByte")
            {
                if (stack.Top is StackNumber)
                {
                    StackNumber s = (StackNumber)stack.Pop();
                    file.WriteByte(s.ToByte());
                    return true;
                }
            }
            else
            if (command == "ReadBytes")
            {
                if (stack.Top is StackNumber)
                {
                    int x = ((StackNumber)stack.Pop()).ToInt();
                    byte[] buf = new byte[x];
                    file.Read(buf, 0, x);
                    TSRPStack s = new TSRPStack();
                    foreach (byte b in buf)
                    {
                        s.Push(b);
                    }
                    stack.Push(new StackArray(s));
                    return true;
                }
            }
            else 
            if (command == "WriteBytes")
            {
                if (stack.Top is StackArray)
                {
                    StackElement[] els = ((StackArray)stack.Pop()).Elements;
                    foreach(StackNumber n in els)
                    {
                        file.WriteByte(n.ToByte());
                    }
                    return true;
                }
            }
            else
            if (command == "ReadWord")
            {
                StringBuilder b = new StringBuilder();
                while (reader.Peek() >= 0 && ((char)reader.Peek() != ' ') && ((char)reader.Peek() != '\n') && ((char)reader.Peek() != '\t') && ((char)reader.Peek() != '\r'))
                {
                    b.Append((char)reader.Read());
                }

                
                if(reader.Peek() >= 0)
                b.Append((char)reader.Read());
                
                stack.Push(b.ToString());
                return true;
            }
            return false;
        }
    }
}

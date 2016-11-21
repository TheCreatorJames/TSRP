using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSRP
{
    class Program
    {
        static void Main(string[] args)
        {
            String str = "";
         
            if(args.Length >= 1)
            {
                str = File.ReadAllText(args[0]);
            }
            else
            {
                StringBuilder b = new StringBuilder();
                int j = 0;
                while ((j = Console.Read()) != -1)
                {
                    b.Append((char)j);
                }

                str = b.ToString();
            }

            TSRPStack stack = new TSRPStack();
            
            Parser p = new Parser();
            p.AddVariable("Console", new StackConsole());
            p.AddVariable("System", new StackSystem());
            p.Parse(str);
            
        }
    }
}

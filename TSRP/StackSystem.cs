using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSRP
{
    class StackSystem : StackCustom
    {
        public StackSystem()
        {

        }


        public override object Clone()
        {
            return new StackSystem();
        }

        public override bool Execute(string command, TSRPStack stack)
        {
            if (command == "open_file")
            {
                if (stack.Top is StackString)
                {
                    StackString s = (StackString)stack.Pop();

                    stack.Push(new StackFile(s.Value));
                }

            }
            else if (command == "call_windows")
            {
                if (stack.Top is StackString)
                {
                    StackString s = (StackString)stack.Pop();

                    System.Diagnostics.Process process = new System.Diagnostics.Process();
                    System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                    startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                    startInfo.FileName = "cmd.exe";
                    startInfo.Arguments = "/C " + s.Value;
                    process.StartInfo = startInfo;
                    process.Start();
                    return true;
                }
            }
            else if (command == "call_program")
            {
                if (stack.Top is StackString && stack.FromTop(1) is StackString)
                {
                    StackString args = (StackString)stack.Pop();
                    StackString program_name = (StackString)stack.Pop();


                    System.Diagnostics.Process process = new System.Diagnostics.Process();
                    System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                    startInfo.FileName = program_name.Value;
                    startInfo.Arguments = args.Value;
                    process.StartInfo = startInfo;
                    process.Start();
                    return true;
                }
            }

            return false;
        }
    }
}

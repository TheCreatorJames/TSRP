using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace TSRP
{
    public class Parser
    {
        private Stack<TSRPStack> stacks;
        
        private Dictionary<String, StackElement> variables;
        private List<StackCustom> imports;

        public TSRPStack Stack
        {
            get
            {
                return stacks.Peek();
            }
            /*
            set
            {
                stack = value;
            }*/
        }


        public static String PreprocessString(string x)
        {
            x = x.Replace("%", "[_%%_]");
            x = x.Replace("\\\"", "%q");
            x = x.Replace("_", "%d");
            Regex r = new Regex("\"[0-9A-Za-z %_+\\/\\$\\@\\#\\%\\^\\&\\*\\(\\)\\!\\.\\-\\<\\>\\?\\,\\{\\}\\=\\:\\~\\`\\[\\]\\=]+\"");
            Regex z = new Regex("\\}[ \\t\\n\\r]+pop");
            var n = r.Matches(x);
            int c = 0;
           
            foreach(var a in n)
            {
                x = x.Substring(0, x.IndexOf(a.ToString())) + "!__@" + c++ + x.Substring(x.IndexOf(a.ToString()) + a.ToString().Length);
                    
                    //x.Replace(a.ToString(), "!__@" + c++);
            }


            var match = z.Match(x);
            while(match.Success)
            {
                bool quit = false;
                int i = match.Index;
                int bCount = 1;
                for(var j = i-1; j >= 0; j--)
                {
                    if (x[j] == '}')
                    {
                        bCount++;
                    }

                    if(x[j] == '{')
                    {
                        bCount--;
                    }

                    if (bCount == 0)
                    {
                        x = x.Replace(x.Substring(j, i + match.Value.Length -j), "");
                        break;
                    }

                    if (j == 0) quit = true;
                }

                if (quit) break;
                match = z.Match(x);
            }

           
            
            x = x.Replace("%d", "_");
            x = x.Replace("%q", "\\\"");
            x = x.Replace("[_%%_]", "%");

            c = 0;
            foreach (var a in n)
            {
                String n2 = a.ToString();
                n2 = n2.Replace(" ", "_");

                String y = "!__@" + c;
                if(x.IndexOf(y) != -1)
                x = x.Substring(0, x.IndexOf(y)) + n2 + x.Substring(x.IndexOf(y) + y.ToString().Length);
                c++;
            }

            //Console.WriteLine(x);


            //Do some partial trimming. 
            for (var i = 0; i < 10; i++)
            {
                x = x.Replace("\n", " ");
                x = x.Replace("\t", " ");
                x = x.Replace("\r", " ");
                x = x.Replace("  ", " ");
            }
            return x;
        }


        public void AddVariable(string s, StackElement el)
        {
            variables[s] = (StackElement)el.Clone();
        }


        public static String ParseInlineString(string x)
        {
            x = x.Replace("%q", "\"");
            x = x.Replace("_", " ");
            x = x.Replace("%d", "_");
            x = x.Replace("[_%%_]", "%");
            x = x.Substring(1, x.Length - 2);
            return x;
        }



        public Parser()
        {
            this.stacks = new Stack<TSRPStack>();
            //this.stack = new TSRPStack();
 
            stacks.Push(new TSRPStack());
            this.variables = new Dictionary<string, StackElement>();
            imports = new List<StackCustom>();
            Parse(" { =eif_temp pop =eif_tempb pop $eif_temp if $eif_tempb $eif_temp ! if } =eif pop ");
        }


        public void Parse(string p, bool pre = false, Dictionary<string, StackElement> local_variables = null, List<String> held_variables = null)
        {
            int brace_count = 0;
            string function_making = "";
            Dictionary<string, StackElement> changes = null;

            List<string> local_held_variables = null;

            bool hold = false;

            if (held_variables != null && local_variables != null)
            {
                changes = new Dictionary<string, StackElement>();
            }

            if(!pre)
            {
                p = PreprocessString(p);
            }

            var arr = p.Split(' ');

            
            foreach (var s1 in arr)
            {
                if (s1.Length == 0) continue;
                var s = s1;
                if (s == "[%d%%%d]") s = "%";

                int a;
                double b;


                if (s == "{")
                {
                    if (brace_count > 0)
                    {
                        function_making += " { ";
                    }

                    brace_count++;
                }
                else
                if (s == "}")
                {
                    brace_count--;

                    if (brace_count == 0)
                    {
                        Stack.Push(new StackFunction(function_making));
                        function_making = "";
                    }
                    else
                    {
                        function_making += " } ";
                    }
                }
                else
                if (brace_count > 0)
                {
                    function_making += s + " ";
                }
                else
                if (s == "[]")
                {
                    Stack.Push(new StackArray());
                }
                else
                if (s == "enter" || s == "Enter")
                {
                    if (Stack.Top is StackArray)
                    {
                        stacks.Push(((StackArray)Stack.Top).GetTSRPStack());
                    }
                }
                else 
                if (s == "hold")
                {
                    hold = true;
                }
                else 
                if (s == "set_hold" && Stack.Top is StackBool)
                {
                    StackBool v = (StackBool)Stack.Top;
                    hold = v.Value;
                }
                else
                if (s == "leave" || s == "Leave" || s == "exit" || s == "Exit")
                {
                    if (stacks.Count > 1)
                        stacks.Pop();
                }
                else
                if (s == "[")
                {
                    stacks.Push(new TSRPStack());
                }
                else
                if (s == "]")
                {
                    if (stacks.Count > 1)
                    {
                        TSRPStack stack = Stack;
                        stacks.Pop();
                        Stack.Push(new StackArray(stack));
                    } //else error
                }
                else
                if (s == "clear")
                {
                    Stack.Clear();
                }
                else
                if (s == "import")
                {
                    if (Stack.Top is StackCustom)
                    {
                        var el = (StackCustom)Stack.Pop();
                        imports.Add(el);
                    }
                }
                else
                if (s.ToLower().StartsWith("repeat"))
                {
                    var k = s.Split(':');
                    

                    if (Stack.Top is StackNumber && Stack.FromTop(1) is StackFunction)
                    {
                        int times = ((StackNumber)Stack.Pop()).ToInt();
                        StackFunction func = (StackFunction)Stack.Pop();
                        for (int i = 0; i < times; i++)
                        {
                            if (k.Length != 1)
                            {
                                if (local_variables == null) local_variables = new Dictionary<string, StackElement>();
                                local_variables[k[1]] = new StackInt(i);
                            }

                            Parse(func.Value, true, local_variables, held_variables);
                        }
                    }

                }
                else
                if (s == "if")
                {
                    if (Stack.Top is StackBool && Stack.FromTop(1) is StackFunction)
                    {
                        bool v = ((StackBool)Stack.Pop()).Value;
                        StackFunction func = (StackFunction)Stack.Pop();
                        if (v)
                        {
                            Parse(func.Value, true, local_variables, held_variables);
                        }
                    }
                }
                else
                if (s == "while")
                {
                    if (Stack.Top is StackFunction && Stack.FromTop(1) is StackFunction)
                    {
                        StackFunction statement = (StackFunction)Stack.Pop();
                        StackFunction func = (StackFunction)Stack.Pop();
                        Parse(statement.Value, true, local_variables, held_variables);

                        while (Stack.Top is StackBool && ((StackBool)Stack.Pop()).Value)
                        {
                            Parse(func.Value, true, local_variables, held_variables);
                            Parse(statement.Value, true, local_variables, held_variables);
                        }
                    }

                }
                else
                if (s == "exec" || s == "execute" || s == "run")
                {
                    if (Stack.Top is StackFunction)
                    {
                        Parse(((StackFunction)Stack.Pop()).Value, true, local_variables, held_variables);
                    }
                }
                else
                if (s == "@size")
                {
                    Stack.Push(Stack.Count);
                }
                else
                if (s == "dup")
                {
                    if (Stack.Top is StackArray) Stack.Push(Stack.Top);
                    Stack.Push((StackElement)Stack.Top.Clone());
                }
                else
                if (s == "pop" || s == "del")
                {
                    Stack.Pop();
                }
                else
                if (s == "swap")
                {
                    var t = Stack.Pop();
                    var t2 = Stack.Pop();
                    Stack.Push(t);
                    Stack.Push(t2);
                }
                else
                if (s.Length > 2 && s.StartsWith(":>"))
                {
                    var k = s.Substring(2);
                    if (variables.ContainsKey(k) && variables[k] is StackArray)
                    {
                        var j = (StackArray)variables[k];

                        if (Stack.Count > 0)
                        j.Push(Stack.Pop());
                    }
                }
                else
                if (s.Length > 2 && s.StartsWith(":<"))
                {

                    var k = s.Substring(2);
                    if (variables.ContainsKey(k) && variables[k] is StackArray)
                    {
                        var j = (StackArray)variables[k];
                        if (j.Count > 0) Stack.Push(j.Pop());
                    }
                }
                else
                if (s.Length > 2 && s.StartsWith("::"))
                {

                    var k = s.Substring(2);
                    if (variables.ContainsKey(k) && variables[k] is StackArray)
                    {
                        var j = (StackArray)variables[k];
                        Stack.Push(j.Count);
                    }
                }
                else
                if (s.Length > 1 && s.StartsWith("$"))
                {


                    if (variables.ContainsKey(s.Substring(1)))
                    {
                        if (variables[s.Substring(1)] is StackArray)
                            Stack.Push(variables[s.Substring(1)]); // Don't clone the stack array.
                        else
                            Stack.Push((StackElement)variables[s.Substring(1)].Clone());
                    }
                }
                else
                if (s.Length > 1 && s.StartsWith("=") && s[1] != '=')
                {
                    
                        if (Stack.Top is StackArray)
                            variables[s.Substring(1)] = Stack.Top; // Don't Clone the Stack Array.
                        else
                            variables[s.Substring(1)] = (StackElement)Stack.Top.Clone();

                    
                }
                else
                if (s.Length > 2 && s.StartsWith("_=")) //Local Variables
                {
                    if (local_variables == null)
                    {
                        local_variables = new Dictionary<string, StackElement>();
                    }

                    if (hold)
                    {
                        if(held_variables == null)
                        {
                            held_variables = new List<string>();
                            local_held_variables = new List<string>();
                        }
                        local_held_variables.Add(s.Substring(2));
                        held_variables.Add(s.Substring(2));
                    }

                    if(changes != null)
                    {
                        if(held_variables.Contains(s.Substring(2)) && !changes.ContainsKey(s.Substring(2)))
                        {
                            changes[s.Substring(2)] = local_variables[s.Substring(2)]; // Makes sure any changes don't affect the caller.
                        }
                    }

                   


                    if (Stack.Top is StackArray)
                        local_variables[s.Substring(2)] = Stack.Top; // Don't Clone the Stack Array.
                    else
                        local_variables[s.Substring(2)] = (StackElement)Stack.Top.Clone();

                }
                else
                if (s.Length > 2 && s.StartsWith("_$")) //Local Variables
                {
                    if (local_variables == null)
                    {
                        local_variables = new Dictionary<string, StackElement>();
                    }

                    if (local_variables.ContainsKey(s.Substring(2)))
                    {
                        if (local_variables[s.Substring(2)] is StackArray)
                            Stack.Push(local_variables[s.Substring(2)]); // Don't clone the stack array.
                        else
                            Stack.Push((StackElement)local_variables[s.Substring(2)].Clone());
                    }

                }
                else
                if (s == "False" || s == "false")
                {
                    Stack.Push(false);
                }
                else
                if (s == "True" || s == "true")
                {
                    Stack.Push(true);
                }
                else
                if (s.StartsWith("\"") && s.EndsWith("\""))
                {
                    Stack.Push(ParseInlineString(s));
                }
                else
                if (s.Contains('.') && double.TryParse(s, out b))
                {
                    Stack.Push(b);
                }
                else
                if (int.TryParse(s, out a))
                {
                    Stack.Push(a);
                }
                else
                {
                    if (Stack.Top != null && Stack.Top.Execute(s, Stack))
                    {

                    }
                    else
                    {
                        if (variables.ContainsKey(s) && variables[s] is StackFunction)
                        {
                            Parse(((StackFunction)variables[s]).Value, true, local_variables, held_variables);
                        }
                        else
                        {
                            if (Stack.TopCustom != null && Stack.TopCustom.Execute(s, Stack))
                            {

                            }
                            else
                            {
                                bool got_one = false;
                                foreach (var im in imports)
                                {
                                    if (im.Execute(s, Stack))
                                    {
                                        got_one = true;
                                        break;
                                    }
                                }

                                if (!got_one)
                                {
                                    //Failure.
                                }


                            }
                        }
                    }

                }
            }

            if(hold)
            {
                foreach(string s in local_held_variables)
                {
                    held_variables.Remove(s);
                }
            }

            //Reversing any changes to local variables.
            if (changes != null)
            {
                var keys = changes.Keys;
                foreach (String s in keys)
                {
                    local_variables[s] = changes[s];
                }
            }

        }









    }


}

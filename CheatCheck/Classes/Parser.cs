using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheatCheck.Classes
{
    public class Parser
    {
        public static void parser()
        {
            Console.Clear();
            Console.Write("ULTIMATE JMP CALCULATOR SUPER PRO MAX ULTRA\n" + "Enter bytes: ");
            string bytes = Console.ReadLine();
            bytes = bytes.Replace(" ", string.Empty);
            char[] parsed = bytes.ToArray();
            string result = "";

            for (int i = 0; i < parsed.Length; i++) // As byte array
            {
                if (i % 2 == 1)
                {
                    if(i != parsed.Length-1)
                    {
                        result += ("0x" + bytes[i - 1] + bytes[i] + ", ");
                    }
                    else
                    {
                        result += ("0x" + bytes[i - 1] + bytes[i]);
                    }                    
                }              
            }
            Console.WriteLine(result);
            result = "";
            for (int i = 0; i < parsed.Length; i++) //As string array
            {
                if (i % 2 == 1)
                {
                    if (i != parsed.Length - 1)
                    {
                        result += ("\"" + "0x" + bytes[i - 1] + bytes[i] + "\"" + ", ");
                    }
                    else
                    {
                        result += ("\"" + "0x" + bytes[i - 1] + bytes[i] + "\"");
                    }
                }
            }
            Console.WriteLine(result);
            result = "";
            for (int i = 0; i < parsed.Length; i++) //As char array
            {
                if (i % 2 == 1)
                {
                    if (i != parsed.Length - 1)
                    {
                        result += ("\'" + "0x" + bytes[i - 1] + bytes[i] + "\'" + ", ");
                    }
                    else
                    {
                        result += ("\'" + "0x" + bytes[i - 1] + bytes[i] + "\'");
                    }
                }
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
        
    }
}

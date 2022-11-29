using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheatCheck.Classes
{
    public class JMPCalc
    {
        static string ToHex(long value)
        {
            return String.Format("{0:X}", value);
        }
        public static void calc()
        {
            Console.Clear();
            Console.Write("ULTIMATE JMP CALCULATOR SUPER PRO MAX ULTRA\n" + "Enter start address: ");
            long StartAddress = Convert.ToInt64(Console.ReadLine(), 16);
            Console.Write("Enter destination: ");
            long JMPAddress = Convert.ToInt64(Console.ReadLine(), 16);
            long difference = (0 - (StartAddress - JMPAddress)) - 5;
            char[] bytes = (ToHex(difference)).ToArray();
            List<string> names = new List<string>();
            for (int i = 0; i < bytes.Length; i++)
            {

                if (i % 2 == 1)
                {
                    names.Add("0x" + bytes[i - 1] + bytes[i]);

                }
            }           
            names.Reverse();
            if (names.Count < 4)
            {
                names.Add("0x00");
            }
            for (int i = 0; i < names.Count; i++)
            {
                if (i != names.Count - 1)
                {
                    Console.Write(names[i] + ", ");
                }
                else
                {
                    Console.Write(names[i]);
                }
                
            }
            Console.WriteLine();
            for (int i = 0; i < names.Count; i++)
            {
                if (i != names.Count - 1)
                {
                    Console.Write("\"" + names[i] + "\"" + ", ");
                }
                else
                {
                    Console.Write("\"" + names[i] + "\"");
                }
                
            }
            Console.WriteLine();
            for (int i = 0; i < names.Count; i++)
            {
                if (i != names.Count - 1)
                {
                    Console.Write("\'" + names[i] + "\'" + ", ");
                }
                else
                {
                    Console.Write("\'" + names[i] + "\'");
                }

            }
            Console.ReadLine();
        }
    }
}

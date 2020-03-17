using System;
using System.IO;
using System.Text;
using static System.Console;
namespace StringReaderWriterApp
{
    class Program
    {
        static void Main()
        {
            WriteLine("***** Fun with StringWriter / StringReader *****\n");

            // Create a StringWriter and emit character data to memory.
            using (StringWriter strWriter = new StringWriter())
            {
                strWriter.WriteLine("Don't forget Mother's Day this year...");
                WriteLine($"Contents of StringWriter:\n{strWriter}");

                // Get the internal StringBuilder.
                StringBuilder sb = strWriter.GetStringBuilder();
                sb.Insert(0, "Hey!! ");
                WriteLine($"-> {sb.ToString()}");
                sb.Remove(0, "Hey!! ".Length);
                WriteLine($"-> {sb.ToString()}");
            }

            using (StringWriter strWriter = new StringWriter())
            {
                strWriter.WriteLine("Don't forget Mother's Day this year...");
                WriteLine($"Contents of StringWriter:\n{strWriter}");

                // Read data from the StringWriter.
                using (StringReader strReader = new StringReader(strWriter.ToString()))
                {
                    string input = null;
                    while ((input = strReader.ReadLine()) != null)
                    {
                        WriteLine(input);
                    }
                }
            }

            ReadLine();
        }
    }
}
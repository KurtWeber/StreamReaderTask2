using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StreamReaderTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of StreamReader to read from a file
            StreamReader reader = new StreamReader("..\\..\\..\\Shakespeare.txt");

            // Count to determine number of lines
            int lineNumber = 0;
            
            // Read first line from the text file
            string line = reader.ReadLine();

            // Read the other lines from the text file
            while (line != null)
            {
                // Increment by 1 (linenumber = linenumber + 1)
                lineNumber++;
                // Write line to console
                Console.WriteLine(line);
                // Read next line
                line = reader.ReadLine();
            }
            // Close the resource after you've finished using it
            reader.Close();
        }
    }
}


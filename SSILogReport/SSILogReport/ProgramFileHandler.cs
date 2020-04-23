using System;
using System.Collections.Generic;
using System.IO;

namespace SSILogReport
{
    /// <summary>
    /// Static class to be called for file handling functions
    /// </summary>
    internal static class ProgramFileHandler
    {
        /// <summary>
        /// Returns a List containing the lines of a log file
        /// </summary>
        /// <param name="path"></param>
        /// <returns>List<string></returns>
        public static List<string> ReadFile(string path)
        {
            List<string> list = new List<string>();
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        list.Add(line);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("File reading error: ");
                Console.WriteLine(e.Message);
            }

            return list;
        }

        /// <summary>
        /// Writes a string array into a file in a given path
        /// </summary>
        /// <param name="writePath"></param>
        /// <param name="writeLines"></param>
        public static void WriteFile(string writePath, string[] writeLines)
        {
            File.WriteAllLines(writePath, writeLines);
        }
    }
}
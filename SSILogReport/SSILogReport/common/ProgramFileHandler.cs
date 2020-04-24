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

        public static void WriteFile(string writePath, string[] writeLines)
        {
            File.WriteAllLines(writePath, writeLines);
        }
    }
}
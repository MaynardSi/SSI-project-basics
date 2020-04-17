using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSILogReport
{
    static class ProgramFileHandler
    {
        /// <summary>
        /// Returns a List containing the lines of a log file
        /// </summary>
        /// <param name="path"></param>
        /// <returns>List<string></returns>
        public static List<string> ReadFile(string path)
        {
            var list = new List<string>();
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

    }
}

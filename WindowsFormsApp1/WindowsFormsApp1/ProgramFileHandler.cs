using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    static class ProgramFileHandler
    {
        public static void ReadFile(string path)
        {
            //File openedFile = File.OpenText(path);
        }

        static void main(string[] args)
        {
            DirectoryInfo root = new DirectoryInfo(".");
            Console.WriteLine(root);
        }

    }
}

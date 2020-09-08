using System;
using System.IO;

namespace PII_Game_Of_Life
{
    public class FileReader
    {

        /// <summary>
        /// Lee un archivo y devuelve una lista con cada una de sus líneas
        /// </summary>
        public static string[] ReadFile(string path)
        {
            string content = File.ReadAllText(path);
            string[] contentLines = content.Split('\n');
            return contentLines;
        }
    }
}

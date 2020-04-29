using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace FileLib
{
    public class FileLinesArr : IEnumerable
    {
        string[] lines;

        public FileLinesArr(string path)
        {
            lines = File.ReadAllLines(path);
        }

        public IEnumerator GetEnumerator()
        {
            return new FileEnumenatorArr(lines);
        }
    }
}

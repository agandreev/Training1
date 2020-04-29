using System.Collections;
using System.IO;

namespace FileLib
{
    public class FileLines : IEnumerable
    {
        StreamReader sr;

        public FileLines(string path)
        {
            sr = new StreamReader(new FileStream(path, FileMode.Open));
        }

        public IEnumerator GetEnumerator()
        {
            return new FileEnumerator(sr);
        }
    }
}

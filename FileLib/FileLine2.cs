using System.Collections;
using System.IO;

namespace FileLib
{
    public class FileLine2 
    {
        StreamReader sr;

        public FileLine2(string path)
        {
            sr = new StreamReader(new FileStream(path, FileMode.Open));
        }

        public IEnumerator GetEnumerator()
        {
            while (!sr.EndOfStream)
            {
                yield return sr.ReadLine();
            }
            sr.Close();
        }
    }
}

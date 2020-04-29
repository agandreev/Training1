using System.Collections;
using System.IO;

namespace FileLib
{
    public class FileEnumerator : IEnumerator
    {
        StreamReader sr;
        string line;

        public FileEnumerator(StreamReader sr)
        {
            this.sr = sr;
        }

        public object Current => line;

        public bool MoveNext()
        {
            while (!sr.EndOfStream)
            {
                line = sr.ReadLine();
                return true;
            }
            Reset();
            return false;
        }

        public void Reset()
        {
            sr.Close();
        }
    }
}

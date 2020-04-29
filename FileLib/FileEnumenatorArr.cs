using System.Collections;

namespace FileLib
{
    public class FileEnumenatorArr : IEnumerator
    {
        private string[] lines;
        private int position = -1;

        public FileEnumenatorArr(string[] lines)
        {
            this.lines = lines;
        }

        public object Current => lines[position];

        public bool MoveNext()
        {
            if (++position <= lines.Length - 1)
            {
                return true;
            }
            Reset();
            return false;
        }

        public void Reset()
        {
            position = -1;
        }
    }
}
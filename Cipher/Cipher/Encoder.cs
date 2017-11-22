using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cipher
{
    public class Encoder
    {
        private string file;
        private string key;
        private int keyLength;
        private List<string> blocks = new List<string>();
        private List<int> originalFileASCIIVals = new List<int>();

        public void ReadFileContents(string path)
        {
            file = System.IO.File.ReadAllText(path);

        }

        public void SetKey(string key)
        {
            this.key = key;
            SetKeyLength();
            AddBlankCharacters();
        }

        public string GetKey()
        {
            return this.key;
        }

        private void SetKeyLength()
        {
            keyLength = key.Length;
        }

        private void AddBlankCharacters()
        {
            int modulo = file.Length % keyLength;

            if (modulo != 0)
            {
                int remaining = keyLength - modulo;
                for (int i = 0; i < remaining; i++)
                {
                    file += (char)26;
                }
            }
        }

        public void DivideIntoBlocks()
        {
            for (int i = 0; i < file.Length; i += keyLength)
            {
                string tmp = "";
                for (int j = i; j < i + keyLength; j++)
                {
                    tmp = tmp + file[j];
                }
                blocks.Add(tmp);
            }
        }

        public List<string> GetBlocks()
        {
            return blocks;
        }

        public void Permutate()
        {
            List<int> permutationArray = new List<int>();
            List<int> indexOrder = new List<int>();
            for (int i = 0; i < keyLength; i++)
            {
                permutationArray.Add(key[i]);
            }
            var sorted = permutationArray.Select((x, i) => new KeyValuePair<int, int>(x, i))
            .OrderBy(x => x.Key)
            .ToList();
            indexOrder = sorted.Select(x => x.Value).ToList();
            foreach (int i in indexOrder)
            {
                Console.WriteLine(i + 1);
            }

        }

    }
}

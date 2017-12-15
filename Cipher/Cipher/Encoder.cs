using System;
using System.Collections.Generic;
using System.IO;
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
        private List<string> permutatedBlocks = new List<string>();
        private List<List<int>> permutatedASCIIblocks = new List<List<int>>();
        private List<List<int>> permutatedReplacedASCIIIblocks;
        private string output;

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

        public void setASCIIblocks()
        {
            foreach(string s in permutatedBlocks)
            {
                List<int> temp = new List<int>();
                foreach(char c in s)
                {
                    temp.Add(c);
                }
                permutatedASCIIblocks.Add(temp);
            }

            foreach(List<int> l in permutatedASCIIblocks)
            {
                foreach(int i in l)
                {
                    Console.Write((char)i+ " ");
                }
                Console.WriteLine();
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
                Console.WriteLine((int)key[i]);
            }
            var sorted = permutationArray.Select((x, i) => new KeyValuePair<int, int>(x, i))
            .OrderBy(x => x.Key)
            .ToList();
            indexOrder = sorted.Select(x => x.Value).ToList();
            indexOrder.Reverse();
           

            foreach(string s in blocks)
            {
                string temp = "";
                for(int i = 0;i<indexOrder.Count;i++)
                {
                    temp += s[indexOrder[i]];
                }
                permutatedBlocks.Add(temp);
            }

            

        }

        public void Replace()
        {
            permutatedReplacedASCIIIblocks = new List<List<int>>();
            foreach(List<int> lint in permutatedASCIIblocks)
            {
                List<int> temp = new List<int>();
                for(int i=0;i<lint.Count;i++)
                {
                    int keyCode = key[i];
                    int blockCode = lint[i];
                   // int shift = Math.Abs(blockCode - keyCode);
                    int newVal = blockCode + keyCode;
                    if(newVal>255)
                    {
                        newVal = newVal - 255;
                    }
                    temp.Add(newVal);
                }
                permutatedReplacedASCIIIblocks.Add(temp);
            }

            foreach(List<int> i in permutatedReplacedASCIIIblocks)
            {
                foreach(int j in i)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }

        public void ConverToString()
        {
            output = "";
            foreach(List<int> lint in permutatedReplacedASCIIIblocks)
            {
                foreach(int i in lint)
                {
                    char temp = (char)i;
                    output += temp;
                }
            }

        }

        public void WriteOutputToFile(string path)
        {
            File.WriteAllText(path, output);
        }

        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public void Encode(string filePath, string fileOutput, string key)
        {
            ReadFileContents(filePath);
            SetKey(key);
            DivideIntoBlocks();
            Permutate();
            setASCIIblocks();
            Replace();
            ConverToString();
            WriteOutputToFile(fileOutput);
        }

    }
}

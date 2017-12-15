using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cipher
{
    
    class Decoder
    {
        private string file;
        private string key;
        private int keyLength;
        private List<string> blocks = new List<string>();
        private List<List<int>> replacedBlocks;
        private List<List<int>> depermutadedBlocks;
        private string output;
        public void ReadFileContents(string path)
        {
            file = File.ReadAllText(path);
        }

        public void SetKey(string key)
        {
            this.key = key;
            SetKeyLength();

        }

        public string GetKey()
        {
            return key;
        }

        public void SetKeyLength()
        {
            keyLength = key.Length;
        }

        public void DivideIntoBlocks()
        {
            for(int i =0; i<file.Length;i+=keyLength)
            {
                string tmp = "";
                for(int j=i;j<i+keyLength;j++)
                {
                    tmp = tmp + file[j];
                }
                blocks.Add(tmp);
            }
        }

        public void Replace()
        {
            replacedBlocks = new List<List<int>>();
            foreach(string block in blocks)
            {
                List<int> temp = new List<int>();
                for(int i=0;i<block.Length;i++)
                {
                    int keyCode = key[i];
                    int blockCode = block[i];
                    /* int shift = Math.Abs(blockCode - keyCode);
                     int newVal = blockCode - shift;*/
                    int newVal = blockCode - keyCode;
                    temp.Add(newVal);
                }
                replacedBlocks.Add(temp);
            }

            foreach(List<int> blocks in replacedBlocks)
            {
                foreach(int i in blocks)
                {
                    Console.Write((char)i);
                }
                Console.WriteLine();
            }

        }

        public void Depermutate()
        {
            depermutadedBlocks = new List<List<int>>();
            List<int> permArray = new List<int>();
            List<int> indexOrder;
            for (int i = 0; i < keyLength; i++)
            {
                permArray.Add(key[i]);
                Console.WriteLine((int)key[i]);
            }
            var sorted = permArray.Select((x, i) => new KeyValuePair<int, int>(x, i))
            .OrderBy(x => x.Key)
            .ToList();
            indexOrder = sorted.Select(x => x.Value).ToList();
            indexOrder.Reverse();
            Console.WriteLine("depermutate");

            foreach(int i in indexOrder)
            {
                Console.Write(i + " ");
            }

            foreach(List<int> s in replacedBlocks)
            {
                int[] temp = new int[keyLength];
                int idx = 0;
                foreach(int i in indexOrder)
                {
                    temp[i] = s[idx];
                    idx++;
                }
                depermutadedBlocks.Add(temp.ToList());
                
            }
        }

        public void ToString()
        {
            string temp = "";
            foreach(List<int> block in depermutadedBlocks)
            {
                foreach(int i in block)
                {
                    temp += (char)i;
                }
            }
            string c = "";
             c += (char)26;
            Console.WriteLine(c);
            temp = temp.Replace(c, string.Empty);

            Console.WriteLine(temp);
            output = temp;
        }

        public void WriteOutputToFile(string path)
        {
            File.WriteAllText(path, output);
        }

        public void Decode(string filePath, string fileOutput,string key)
        {
            ReadFileContents(filePath);
            SetKey(key);
            DivideIntoBlocks();
            Replace();
            Depermutate();
            ToString();
            WriteOutputToFile(fileOutput);

        }
    }
}

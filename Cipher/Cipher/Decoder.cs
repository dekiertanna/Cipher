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
            permArray.Add(1);
            permArray.Add(5);
            permArray.Add(3);
            permArray.Add(2);
            permArray.Add(0);
            permArray.Add(4);

            foreach(List<int> block in replacedBlocks)
            {
                List<int> temp = new List<int>();
                foreach(int i in permArray)
                {
                    temp.Add(block[i]);
                }
                depermutadedBlocks.Add(temp);
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

            Console.WriteLine(temp);
        }
    }
}

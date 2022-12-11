using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ce205_hw3_nasifcan_yavuz
{
    public class OpenAddressing
    {
        /// <summary>
        /// Open Addressing
        /// </summary>
        public class hashnode
        {
            public int key;
            public string data;

            public hashnode(int key, string data)
            {
                this.key = key;
                this.data = data;
            }
        }

        public hashnode[] table;
        /// <summary>
        /// Open Addressing
        /// </summary>
        /// <param name="size"></param>
        public OpenAddressing(int size)
        {
            table = new hashnode[size];
        }
        /// <summary>
        /// Open Addressing Linear Probing insertion
        /// </summary>
        /// <param name="key"></param>
        /// <param name="data"></param>
        public void OpenAddressingLinearProbingInsert(int key, string data, int n)
        {
            int index = key % n;
            while (table[index] != null)
            {
                index = (index + 1) % n;
            }
            table[index] = new hashnode(key, data);
        }

        /// <summary>
        /// Open Addressing Quadratic Probing Insertion
        /// </summary>
        /// <param name="key"></param>
        /// <param name="data"></param>
        public void OpenAddressingQuadraticProbingInsert(int key, string data, int n)
        {
            int index = key % n;
            int i = 1;
            while (table[index] != null)
            {
                index = (index + i * i) % n;
                i++;
            }
            table[index] = new hashnode(key, data);
        }

        /// <summary>
        /// Open Addressing Double Hashing Insertion
        /// </summary>
        /// <param name="key"></param>
        /// <param name="data"></param>
        public void OpenAddressingDoubleProbingInsert(int key, string data, int n)
        {
            int index = key % n;
            int i = 1;
            while (table[index] != null)
            {
                index = (index + i * (key % (table.Length - 1))) % n;
                i++;
            }
            table[index] = new hashnode(key, data);
        }
    }
}

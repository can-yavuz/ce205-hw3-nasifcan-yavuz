using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ce205_hw3_nasifcan_yavuz
{
    public class HashingChaining
    {
        /// <summary>
        /// @param size is the size of the hash table
        /// 
        /// </summary>
        public class hashnode
        {
            public int key;
            public string data;
            public hashnode next;
            public hashnode(int key, string data)
            {
                this.key = key;
                this.data = data;
                this.next = null;
            }
        }
        /// <summary>
        /// @param size is the size of the hash table
        /// </summary>
        public LinkedList<hashnode>[] table;

        public HashingChaining(int size)
        {
            table = new LinkedList<hashnode>[size];
        }

        /// <summary>
        /// Adding a new node to the hash table
        /// </summary>
        /// <param name="key"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public int HashingChainingInsert(int key, string data)
        {
            int index = key % table.Length;
            if (table[index] == null)
            {
                table[index] = new LinkedList<hashnode>();
                table[index].AddFirst(new hashnode(key, data));
                return 0;
            }
            else
            {
                foreach (hashnode node in table[index])
                {
                    if (node.key == key)
                    {
                        return -1;
                    }
                }
                table[index].AddFirst(new hashnode(key, data));
                return 0;
            }
        }

    }
}

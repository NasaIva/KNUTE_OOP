using System;
using System.Collections.Generic;
using System.Linq;
namespace Laba6._1
{
    class MyDictionary<TKey, TValue>
    {
        TKey[] Klist = new TKey[0];
        TValue[] Vlist = new TValue[0];

        public void Add(TKey key, TValue value)
        {
            TKey[] newKList = new TKey[GetLengthK() + 1];
            TValue[] newVList = new TValue[GetLengthV() + 1];

            Klist.CopyTo(newKList, 0);
            Vlist.CopyTo(newVList, 0);

            newKList[GetLengthK()] = key;
            newVList[GetLengthV()] = value;

            Klist = newKList;
            Vlist = newVList;

        }

        public TKey GetValueK(int index)
        {
            return Klist[index];
        }

        public TValue GetValueV(int index)
        {
            return Vlist[index];
        }

        public int GetLengthK()
        {
            return Klist.Length;
        }
        public int GetLengthV()
        {
            return Vlist.Length;
        }

        public void PrintList()
        {
            for (int i = 0; i < GetLengthK(); i++)
            {
                Console.WriteLine((i+1) + ". " + Klist[i] + " : " + Vlist[i]);
            }
        }
    }
}

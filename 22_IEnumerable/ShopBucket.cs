using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _22_IEnumerable
{
    class ShopBucket :IEnumerable
    {
        Item[] items = new Item[0];
        public void AddItem(Item item)
        {
            Array.Resize(ref items, items.Length + 1);
            items[items.Length - 1] = item;
        }

        /*public IEnumerator GetEnumerator()
        {
            return items.GetEnumerator();
        }*/
        public IEnumerator GetEnumerator() // неіменований ітератор
        {
            /*for (int i = 0; i < items.Length; i++)
            {
                yield return items[i];
            }*/
            foreach (Item item in items)
            {
                yield return item; // 
            }
        }
        public IEnumerable<Item> GetReverse()
        {
            for (int i = items.Length - 1; i >= 0; i--)
            {
                yield return items[i];
            }
        }
        public IEnumerable<Item> GetCheaperItem(int maxPrice)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i].Price <= maxPrice)
                    yield return items[i];
            }
        }
        public override string ToString()
        {
            return $"{String.Join<Item>("\n",items)}";
        }
    }
}

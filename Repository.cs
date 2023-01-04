using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace generic_list
{
    internal class Repository<T> : IEnumerable<T>
    {
        private List<T> Items = new List<T>();


        public int Count => Items.Count;
        public int GetCount()
        {
            return Count;
        }

        public void Cerate(T item)
        {
            Items.Add(item);
        }
        public T Read(int index)
        {
            if (index < 0 || index >= Items.Count)
                throw new IndexOutOfRangeException("neplatný index");
            return Items[index];
        }
        public T Update(int index, T item)
        {
            if (index < 0 || index >= Items.Count)
                throw new IndexOutOfRangeException("neplatný index");
            return Items[index] = item;
        }
        public void Delete(int index)
        {
            if (index < 0 || index >= Items.Count)
                throw new IndexOutOfRangeException("neplatný index");
            Items.RemoveAt(index);
        }
        public void Clear() { Items.Clear(); }

        public T[] AsArray()
        {
            return Items.ToArray();
        }
        public IEnumerator<T> GetEnumerator()
        {
            return new RepositoryEnumerator<T>(Items);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }
}

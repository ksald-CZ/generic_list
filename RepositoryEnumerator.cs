using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generic_list
{
    internal class RepositoryEnumerator<T> : IEnumerator<T>
    {
        private int currentIndex = -1; // začínáme na idexu -1 prtože je to pak jednodušší inkermentovat

        public RepositoryEnumerator(List<T> items) { Items = items; }

        public T Current => Items[currentIndex];

        public List<T> Items { get; }

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            // nic nema delat
        }

        public bool MoveNext()
        {
            currentIndex++; // přičte 1 k aktuálnímu indexu
            return currentIndex < Items.Count;
        }
        public void Reset()
        {
            currentIndex = -1; //vrací na začatek indexu
        }
    }
}

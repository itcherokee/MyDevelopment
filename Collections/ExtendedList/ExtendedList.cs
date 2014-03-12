using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtendedList
{
    public class ExtendedList<T> : IExtendedList<T>
    {
        private const int InitialCapacity = 10;
        private int count;
        private int capacity;
        private T[] list;

        public ExtendedList(int initialCapacity = InitialCapacity)
        {
            this.Initialize(initialCapacity);
        }

        public ExtendedList(IEnumerable<T> initialContent)
        {
            if (initialContent != null)
            {
                var content = initialContent as ICollection<T> ?? initialContent.ToArray();
                this.Initialize(content.Count);
                content.CopyTo(this.list, 0);
                this.count = content.Count;
            }
            else
            {
                throw new ArgumentNullException(ErrorMessages.ErrorNullValue, "initialContent");
            }
        }

        private void Initialize(int initialCapacity)
        {
            if (initialCapacity >= 0 && initialCapacity <= int.MaxValue)
            {
                try
                {
                    this.list = new T[initialCapacity + (initialCapacity / 3)];
                    this.capacity = initialCapacity;
                    this.count = 0;
                }
                catch (OutOfMemoryException e)
                {
                    throw new ArgumentException(ErrorMessages.ErrorCapacity, e);
                }
            }
            else
            {
                throw new ArgumentException(ErrorMessages.ErrorCapacity, "initialCapacity");
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public void Add(T item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            this.Initialize(this.capacity);
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        public int Count
        {
            get { return this.count; }
        }

        public bool IsReadOnly { get; private set; }

        public int IndexOf(T item)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, T item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        public T this[int index]
        {
            get
            {
                if (index >= 0 && index < this.Count)
                {
                    return this.list[index];
                }

                throw new ArgumentOutOfRangeException(ErrorMessages.ErrorOutOfRangeIndex, "index");
            }
            set
            {
                if (index >= 0 && index < this.Count)
                {
                    this.list[index] = value;
                }

                throw new ArgumentOutOfRangeException(ErrorMessages.ErrorOutOfRangeIndex, "index");
            }
        }

        public int Capacity
        {
            get { return this.capacity; }
        }

        public bool IsEmpty
        {
            get { return this.Count <= 0; }
        }

        public int FreePositionsLeft
        {
            get { return this.Capacity - this.Count; }
        }

        public bool RemoveAll(T element)
        {
            throw new NotImplementedException();
        }

        public bool Compact()
        {
            throw new NotImplementedException();
        }

        public T[] ToArray()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> ToList()
        {
            throw new NotImplementedException();
        }
    }
}
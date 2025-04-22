using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Reflection;
using System.Xml.Linq;

namespace Test6_ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<string> list = new CustomList<string>();

            list.Add("Pesho");
            list.Add("Gosho");
            list.Add("Tosho");

            Console.WriteLine(list.Length);
            Console.WriteLine(list.Capacity);


            try
            {
                Console.WriteLine(list.Get(-2));
            }

            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }

            list.Set(2, "Geri");

            Console.WriteLine(list.Get(2));


            try
            {
                list.RemoveAt(-1);
            }
            catch (IndexOutOfRangeException ex)

            {
                Console.WriteLine(ex.Message);
            }



            foreach (var item in list)

            {

                Console.WriteLine(item);

            }
        }
    }

    class CustomList<T> : IEnumerable<T>
    {
        private const int InitialCapacity = 2;
        private T[] items;

        public int Length { get; set; }
        public int Capacity { get; set; }

        public CustomList()
        {
            this.items = new T[InitialCapacity];
            this.Capacity = InitialCapacity;
        }

        public T this[int index]
        {
            get
            {
                CheckIndexOutsideBounds(index);
                return this.items[index];
            }
            set
            {
                CheckIndexOutsideBounds(index);
                this[index] = value;
            }
        }

        public void Add(T element) //премахва се else клаузата, *=
        {
            if (this.Length == this.Capacity)
            {
                this.Capacity *= 2;
                T[] temp = new T[this.Capacity];
                for (int i = 0; i < items.Length; i++)
                {
                    temp[i] = items[i];
                }
                items = temp;
            }
                items[this.Length] = element;
                this.Length++;
        }

        public T Get(int index)
        {
            CheckIndexOutsideBounds(index);
            return this.items[index];
        }

        public void Set(int index, T element)
        {
            CheckIndexOutsideBounds(index);
            this.items[index] = element;
        }

        public void RemoveAt(int index)
        {
            CheckIndexOutsideBounds(index);
            for (int i = index; i > items.Length - 1; i++)
            {
                items[i] = items[i + 1];
            }
            this.Length--;
        }

        private void CheckIndexOutsideBounds(int index)
        {
            if (index < 0 || index >= this.Length)
            {
                new IndexOutOfRangeException();
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in items)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}

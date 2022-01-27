using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_LABA_6_1
{
    class Storage<T>
    {
        const int dop = 10; //дополнительная длина массива

        private T[] arr;
        private int size;
        private int capacity;
        public Storage()
        {
            arr = null;
        }
        public Storage(int _size)
        {
            //конструктор с заданной длиной массива
            arr = new T[_size + dop];
            size = _size;
            capacity = _size + dop;
        }
        ~Storage() { }
        public void reserve(int _size)
        {
            //задать размер
            arr = new T[_size + dop];
            size = 0;
            capacity = _size + dop;
        }
        public void push_back(T elem)
        {
            if (arr == null)
            {
                arr = new T[3];
                arr[0] = elem;
                size = 1;
                capacity = 3;
            }
            else if (arr != null)
            {
                if (size == capacity)
                {
                    T[] newarr = new T[size + dop];
                    for (int i = 0; i < size; i++)
                        newarr[i] = arr[i];
                    newarr[size] = elem;
                    arr = newarr;
                    capacity = size + dop;
                    size++;
                }
                else
                {
                    arr[size] = elem;
                    size++;
                }
            }//вставка в конец
        }
        public void pop_back()
        { //удалить из конца  
            if (arr != null && size > 0)
            {
                if (size < capacity / 3 && size > 20)
                {
                    size--;
                    T[] newarr = new T[size + dop];
                    for (int i = 0; i < size; i++)
                        newarr[i] = arr[i];
                    arr = newarr;
                    capacity = size + dop;
                }
                else size--;
            }
            else if (arr == null || size <= 0)
                Console.WriteLine("Массив пустой");
        }//удалить последний элемент
        public void insert(T elem, int index)
        {
            if (arr == null)
            {
                arr = new T[3];
                arr[0] = elem;
                size = 1;
                capacity = 3;
            }
            else if (size == 0)
            {
                arr[0] = elem;
                size++;
            }
            else
            {
                if (index > size)
                    index = size;
                if (index < 0)
                {
                    index = 0;

                }
                if (size == capacity)
                {
                    size++;
                    T[] newarr = new T[size + dop];
                    for (int i = 0, k = 0; i < size; i++, k++)
                    {
                        if (i == index)
                        {
                            newarr[k] = elem;
                            k++;
                        }
                        else newarr[k] = arr[i];
                    }
                    arr = newarr;
                    capacity = size + dop;
                }
                else
                {
                    for (int i = size - 1; i >= index; i--)
                        arr[i + 1] = arr[i];
                    arr[index] = elem;
                    size++;
                }
            }
        }
        //вставка по индексу
        public void push_front(T elem)
        {
            //insert(elem, 0);
            if (arr == null)
            {
                arr = new T[3];
                arr[0] = elem;
                size = 1;
                capacity = 3;
            }
            else
            {
                if (size == capacity)
                {
                    size++;
                    T[] newarr = new T[size + dop];
                    newarr[0] = elem;
                    for (int i = 0; i < size - 1; i++)
                        newarr[i + 1] = arr[i];
                    arr = newarr;
                    capacity = size + dop;
                }
                else
                {
                    for (int i = size - 1; i >= 0; i--)
                        arr[i + 1] = arr[i];
                    size++;
                    arr[0] = elem;
                }
            }
        }//вставка в начало
        public void pop_front()
        {   //удаляет первый элемент
            if (arr != null && size > 0)
            {
                if (size < (capacity / 4) && size > 50)
                {
                    size--;
                    T[] newarr = new T[size + dop];
                    for (int i = 1; i < size + 1; i++)
                        newarr[i - 1] = arr[i];
                    arr = newarr;
                    capacity = size + dop;
                }
                else
                {
                    for (int i = 1; i < size; i++)
                        arr[i - 1] = arr[i];
                    size--;
                }
            }
            else Console.WriteLine("Массив пустой");
        }                       //удалить первый элемент
        public void pop(int index)
        { //удалить по индексу 
            if (arr != null && size > 0)
            {
                if (size < (capacity / 4) && size > 50)
                {
                    size--;
                    T[] newarr = new T[size + dop];
                    for (int i = 0, k = 0; i < size + 1; i++)
                        if (i != index)
                        {
                            newarr[k] = arr[i];
                            k++;
                        }
                    arr = newarr;
                    capacity = size + dop;
                }
                else
                {
                    for (int i = index + 1; i < size; i++)
                        arr[i - 1] = arr[i];
                    size--;
                }
            }
            else Console.WriteLine("Массив пустой");
        }                    //удалить по индексу
        public T this[int i]
        {
            get
            {
                if (i < size && i >= 0 && arr != null)
                    return arr[i];
                else throw new IndexOutOfRangeException();
            }
            set
            {
                if (i < size && i >= 0 && arr != null)
                    arr[i] = value;
                else throw new IndexOutOfRangeException();
            }
        }
        public T getanddelete(int index)
        {
            if (arr != null && size > 0)
            {
                if (size < (capacity / 4) && size > 50)
                {
                    size--;
                    T[] newarr = new T[size + dop];
                    for (int i = 0, k = 0; i < size + 1; i++)
                        if (i != index)
                        {
                            newarr[k] = arr[i];
                            k++;
                        }
                    T r_elem = arr[index];
                    arr = newarr;
                    capacity = size + dop;
                    return r_elem;
                }
                else
                {
                    T r_elem = arr[index];
                    for (int i = index + 1; i < size; i++)
                        arr[i - 1] = arr[i];
                    size--;
                    return r_elem;
                }
            }
            else throw new IndexOutOfRangeException();
        }
        public T get(int index)
        { //достать элемент 
            if (arr != null && size > 0)
            {
                T r_elem = arr[index];
                return r_elem;
            }
            else throw new Exception("Массив пустой");
        }                       //достать
        public void clear()
        { //очистка

            arr = null;
            size = 0;
            capacity = 0;
        }                           //очистка
        public int Size()
        { //вернуть размер
            return size;
        }                             //вернуть размер
        public int Capacity()
        {  //вернуть размер расширенного массива
            return capacity;
        }                         //вернуть размер расширенного массива
        public bool empty()
        {  //проверить пустой ли 
            if (arr == null || size == 0)
                return true;
            else return false;
        }                           //проверка, пустой ли массив
        public void resize(int n)
        { //изменить размер 
            if (arr == null)
                reserve(n);
            else if (n > size && n <= capacity)
                size = n;
            else if (n > capacity)
            {
                T[] newarr = new T[n + dop];
                for (int i = 0; i < size; i++)
                    newarr[i] = arr[i];

                arr = newarr;
                size = n;
                capacity = size + dop;
            }
            else if (n < (capacity / 3) && n > 20)
            {
                size = n;
                T[] newarr = new T[size + dop];
                for (int i = 0; i < size; i++)
                    newarr[i] = arr[i];

                arr = newarr;
                capacity = size + dop;
            }
            else if (n < size)
                size = n;
        }                     //задать новый размер массива
        public int Find(T elem)
        { //найти по индексу
            if (arr != null && size != 0)
                for (int i = 0; i < size; i++)
                {
                    if (arr[i].Equals(elem))
                        return i;
                }
            return -1;
        }
    }
}

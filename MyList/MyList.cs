using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyList
{
    internal class MyList<T> : ICollection<T>
    {
        private ListNode<T> head;
        private ListNode<T> tail;
        private int count = 0;

        public MyList()
        {
            count = 0;
        }

        public MyList(T val)
        {
            head = tail = new ListNode<T>(val, null);
            count = 1;
        }

        public MyList(IEnumerable<T> collection)
        {
            foreach(var item in collection)
            {
                Add(item);
            }
        }

        public int Count => count;

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(T item)
        {
            if(count == 0)
            {
                head = tail = new ListNode<T>(item, null);
            }
            else
            {
                ListNode<T> node = new ListNode<T>(item, null);
                tail.next = node;
                tail = tail.next;
            }
            ++count;
        }

        public void Clear()
        {
            while(head != null)
            {
                var tmp = head;
                head = head.next;
                tmp.next = null;
            }
            tail = null;
            count = 0;

        }

        public T? this[int index]
        {
            get
            {
                var tmp = head;
                int curIndex = 0;

                while(tmp != null)
                {
                    if(curIndex == index)
                    {
                        return tmp.val;
                    }
                    ++curIndex;
                    tmp = tmp.next;
                }

                return default(T?);
            }
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new MyListIterator<T>(head);
        }

        public bool Remove(T item)
        {
            if(head.val.Equals(item) == true)
            {
                var tmp = head;
                head = head.next;
                tmp.next = null;
                --count;
                return true;
            }

            if(tail.val.Equals(item) == true)
            {
                for (tail = head; tail.next.next != null; tail = tail.next) ;
                tail.next = null;
                --count;
                return true;
            }

            var prev = head;
            var cur = head.next;

            while(cur != null)
            {
                if(cur.val.Equals(item) == true)
                {
                    prev.next = cur.next;
                    cur = null;
                    --count;
                    return true;
                }

                cur = cur.next;
                prev = prev.next;
            }

            return false;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new MyListIterator<T>(head);
        }
    }
}

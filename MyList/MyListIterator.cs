using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyList
{
    internal class MyListIterator<T> : IEnumerator<T>
    {
        private ListNode<T>? head;
        private ListNode<T>? curElement;
        private T? curItem;

        public MyListIterator(ListNode<T> head)
        {
            this.head = head;
            curElement = head;
            curItem = default(T);
        }
        public T Current => curItem;

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            
        }

        public bool MoveNext()
        {
            if(curElement == null)
            {
                return false;
            }

            curItem = curElement.val;
            curElement = curElement.next;

            return true;
        }

        public void Reset()
        {
            curElement = head;
        }
    }
}

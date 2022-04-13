using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyList
{
    internal class ListNode<T>
    {
        public T? val;
        public ListNode<T>? next;

        public ListNode(T? val, ListNode<T>? next)
        {
            this.val = val;
            this.next = next;
        }
    }
}

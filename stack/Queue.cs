using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack
{
    public class Queue<E>
    {
        public Queue<E> Next { get; set; }

        public E Value { get; set; }

    }

    class QStack<E>
    {
        int count = 0;
        private Queue<E> first;
        private Queue<E> last;

        public void Enqueue(E value)
        {
            var newItem = new Queue<E>
            {
                Value = value,
            };
            if (first == null)
            {
                first = newItem;
                last = newItem;
                count++;
            }
            else
            {
                last.Next = newItem;
                last = newItem;
                count++;
            }
        }

        public E Dequeue()
        {
            if (first == null)
            {
                return default(E);
            }
            E value = first.Value;
            first = first.Next;
            count--;
            return value;
        }

        public E Peek()
        {

            if (first == null)
            {
                return default(E);
            }
            return first.Value;
        }

        public void Clear()
        {
            first = null;
            count--;
        }

    }
}


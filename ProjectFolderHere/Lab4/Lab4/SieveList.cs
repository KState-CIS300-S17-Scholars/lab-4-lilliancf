using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class SieveList : IEnumerable<int>
    {
        private Node _head;
        private Node _tail;

        public void BuildList(int bound)
        {
            _head = new Node(2);
            Node temp = _head;
            for (int i = 3; i <= bound; i++)
            {
                temp.Next = new Node(i);
                _tail = temp.Next;
                temp = temp.Next;
            }
        }

        public void FindPrimes()
        {
            int bound = _tail.Data;
            Node cur = _head;
            Node temp = cur;
            while (cur != null)
            {
                while (temp.Next != null)
                {
                    if ((temp.Next.Data % cur.Data) == 0)
                    {
                        temp.Next = temp.Next.Next;
                    }
                    temp = temp.Next;
                    if (temp == null) break;
                }
                cur = cur.Next;
                temp = cur;
            }
        }

        public IEnumerator<int> GetEnumerator()
        {
            return new SieveEnumerator(_head);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new SieveEnumerator(_head);
        }

        private class SieveEnumerator : IEnumerator<int>
        {
            private Node _cur;

            public SieveEnumerator(Node head)
            {
                Node dummy = new Node(0);
                dummy.Next = head;
                _cur = dummy;
            }
            
            public int Current
            {
                get
                {
                    return _cur.Data;
                }
            }

            object IEnumerator.Current
            {
                get
                {
                    return _cur.Data;
                }
            }

            public void Dispose()
            {
            }

            public bool MoveNext()
            {
                if (_cur == null) return false;
                else
                {
                    _cur = _cur.Next;
                    if (_cur == null) return false;
                    else return true;
                }
            }

            public void Reset()
            {
                throw new NotImplementedException();
            }
        }


        private class Node
        {
            private int _data;
            private Node _next;

            public Node(int d)
            {
                _data = d;
                _next = null;
            }

            public int Data {
                get {
                    return _data;
                }
                set
                {
                    _data = value;
                }
            }

            public Node Next
            {
                get
                {
                    return _next;
                }
                set
                {
                    _next = value;
                }
            }
        }
    }
}

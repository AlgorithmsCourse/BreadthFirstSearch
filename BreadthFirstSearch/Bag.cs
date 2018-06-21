using System.Collections;
using System.Collections.Generic;

namespace Graph
{   //finds a shortest path from source; moves 1 step in all directions before progressing further therefore only the first time a V's is accessed in anydirection is recorded on Edgeto array


    public class Bag : IEnumerable, IEnumerator
    {
        private Node _first; //first node in list marking entry pt of traversal; set to null upon init
        private int _size = 0;
          private class Node
        {
            internal int Cargo;
            internal Node Next;
        }
        public void Add(int item)
        {
            Node OldFirst = _first; //saves ref to current first node so that new node will point to it; this will be 'null' for first node created
            _first = new Node();
            _first.Cargo = item;
            _first.Next = OldFirst;
        }
        private Node _current;
        public IEnumerator GetEnumerator()
        {
            return this;
        }

        public bool MoveNext()
        {
            throw new System.NotImplementedException();
        }
        public void Reset()
        {
            throw new System.NotImplementedException();
        }

        public bool IsEmpty => _size == 0;

        public object Current => _current =_first;
    }
    }


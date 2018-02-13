using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListStack
{
    class Node
    {
        public int info;
        public Node next;

        public Node(int i)
        {
            info = i;
            next = null;
        }

    }
}

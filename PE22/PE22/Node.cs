using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE22
{
    class Node
    {
        // attributes
        private int data;
        Node lNode = null;
        Node rNode = null;

        // constructor
        public Node(int num)
        {
            data = num;
        }

        // properties
        public int Data
        {
            get { return data; }
        }

        public Node LNode
        {
            get { return lNode; }
            set { lNode = value; }
        }

        public Node RNode
        {
            get { return rNode; }
            set { rNode = value; }
        }
    }
}

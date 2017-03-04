using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE22
{
    class Tree
    {
        // attribute
        Node root = null;

        // insert methods
        public void Insert(int data) // public insert to be called by main
        {
            // if root node has not been created
            if(root == null)
            {
                root = new Node(data);
            }
            else
            {
                Insert(data, root);
            }
        }

        private void Insert(int data, Node node) // private insert that only gets called when root node has been filled
        {
            // creates tree left if less than node value
            if(data < node.Data)
            {
                // create node to the left if space is avalable
                if(node.LNode == null)
                {
                    node.LNode = new Node(data);
                }
                // space is occupado
                else
                {
                    Insert(data, node.LNode);
                }
            }

            // try to create node to the right
            else if(data >= node.Data)
            {
                // attempt to add node to the right
                if(node.RNode == null)
                {
                    node.RNode = new Node(data);
                }
                // Right node is occupied
                else
                {
                    Insert(data, node.RNode);
                }
            }
        }

        // print methods
        public void Print() // public print that can be called by the main
        {
            // check if root node exists
            if(root != null) // root node does exist
            {
                Console.WriteLine(root.Data);
                Print(root, 0);
            }
            else // root does not exist
            {
                Console.WriteLine("ERROR: TREE NOT CREATED");
            }
        }

        private void Print(Node node, int level)
        {
            if (node != null)
            {
                // print statement
                for(int x = 0; x < level; x++)
                {
                    Console.Write("|");
                }
                Console.WriteLine(node.Data);

                Print(node.LNode, level + 1);
                Print(node.RNode, level + 1);
            }
        }
    }
}

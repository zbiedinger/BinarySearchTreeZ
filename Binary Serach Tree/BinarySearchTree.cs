using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Serach_Tree
{
    class BinarySearchTree : IEnumerable
    {
        //Member Variables
        public Node RootNode;

        //constructor
        public BinarySearchTree()
        {

        }

        //Adds the passed in int to the tree as A node
        public void Add(int numToAdd)
        {
            Node nodeToAdd = new Node(numToAdd);
            Add(nodeToAdd);
        }

        //Adds the passed in node to the tree
        public void Add(Node nodeToAdd)
        {
            if (RootNode == null)
            {
                RootNode = nodeToAdd;
            }
            else
            {
                Node nextNode = RootNode;
                while (true)
                {
                    if (nodeToAdd.data <= nextNode.data)//Is new node in left tree
                    {
                        if (nextNode.LeftChildNode == null)
                        {
                            nextNode.LeftChildNode = new Node(nodeToAdd.data);
                            break;
                        }
                        else
                        {
                            nextNode = nextNode.LeftChildNode;
                        }
                    }
                    else//Is new node in right tree
                    {
                        if (nextNode.RightChildNode == null)
                        {
                            nextNode.RightChildNode = new Node(nodeToAdd.data);
                            break;
                        }
                        else
                        {
                            nextNode = nextNode.RightChildNode;
                        }
                    }
                }
            }
        }


        //Searches through the binary tree for the passed value
        //returns a null node if the tree is empty or the value can't be found
        public Node Search(int numToFInd)
        {
            Node nextNode = RootNode;
            while (nextNode != null)
            {
                if (numToFInd == nextNode.data)
                {
                    return nextNode;
                }
                else if (numToFInd < nextNode.data)
                {
                    nextNode = nextNode.LeftChildNode;
                }
                else
                {
                    nextNode = nextNode.RightChildNode;
                }
            }
            return null;
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}

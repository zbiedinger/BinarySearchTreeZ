using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Serach_Tree
{
    class BinarySearchTree
    {
        //Member Variables
        public Node RootNode;
        public Node LastNode;


        //constructor
        public BinarySearchTree()
        {

        }


        //Member Methods
        public Node sort(Node nodeTosort)
        {
            Node addedNode = new Node(1);
            return addedNode;
        }

        //Adds a new node with the input data
        public void Add(Node nodeToAdd)
        {
            if (RootNode == null)
            {
                RootNode = nodeToAdd;
                LastNode = nodeToAdd;
            }
            else
            {
                Node node = RootNode;
                while (true)
                {
                    if (nodeToAdd.data <= node.data)//goes left
                    {
                        if(node.LeftChildNode == null)
                        {
                            RootNode.LeftChildNode = nodeToAdd;
                            break;
                        }
                        else
                        {
                            node = node.LeftChildNode;
                        }
                    }
                    else//goes right
                    {
                        if (node.RightChildNode == null)
                        {
                            RootNode.RightChildNode = nodeToAdd;
                            break;
                        }
                        else
                        {
                            node = node.RightChildNode;
                        }
                    }
                }
            }
        }

        //Searchs throught the binary tree for the passed value
        public Node Search()
        {
            Node searchedNode = new Node(1);

            return searchedNode;
        }
    }
}

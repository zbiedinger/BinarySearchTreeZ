﻿using System;
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
            }
            else
            {
                Node nextNode = RootNode;
                while (true)
                {
                    if (nodeToAdd.data <= nextNode.data)//goes left
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
                    else//goes right
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

        //Searchs throught the binary tree for the passed value
        public Node Search()
        {
            Node searchedNode = new Node(1);

            return searchedNode;
        }
    }
}

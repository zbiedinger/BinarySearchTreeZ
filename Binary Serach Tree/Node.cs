using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Serach_Tree
{
    class Node
    {
        public int data;
        public Node LeftChildNode;
        public Node RightChildNode;

        public Node(int data)
        {
            this.data = data;
            RightChildNode = null;
            LeftChildNode = null;
        }
    }
}

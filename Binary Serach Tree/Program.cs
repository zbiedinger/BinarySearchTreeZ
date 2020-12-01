using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Serach_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree tree = new BinarySearchTree();

            Node node10 = new Node(10);
            Node node20 = new Node(20);
            Node node30 = new Node(30);
            Node node40 = new Node(40);
            Node node50 = new Node(50);
            Node node60 = new Node(60);
            Node node70 = new Node(70);

            Node node15 = new Node(15);
            Node node25 = new Node(25);
            Node node35 = new Node(35);
            Node node45 = new Node(45);
            Node node55 = new Node(55);
            Node node65 = new Node(65);
            Node node75 = new Node(75);


            tree.Add(node40);
            tree.Add(node50);
            tree.Add(node15);
            tree.Add(node25);
            tree.Add(node25);
            tree.Add(node20);
            tree.Add(node10);
            tree.Add(node30);
            tree.Add(node75);
            tree.Add(node75);
            tree.Add(node10);
            tree.Add(node60);
            tree.Add(node35);
            tree.Add(node70);

        }
    }
}

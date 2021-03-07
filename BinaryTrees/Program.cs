using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTrees
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree tree = new BinarySearchTree();

            Node nodeA = new Node(7);
            Node nodeB = new Node(9);

            tree.InsertNode(nodeA);
        }
    }
}

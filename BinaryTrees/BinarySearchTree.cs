using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTrees
{
    public class BinarySearchTree
    {
        private Node _rootNode;
        public Node RootNode { get; }

        public BinarySearchTree()
        {
            _rootNode = null;
        }

        public void InsertNode(Node node)
        {
            if (_rootNode == null)
            {
                _rootNode = node;
            }
            else
            {

            }
        }
    }

    public class Node
    {
        private int _data;
        public int Data
        {
            get { return _data; }
        }

        private Node _left;
        public Node Left { get; }

        private Node _right;
        public Node Right { get; }

        public Node(int data)
        {
            _data = data;
        }
    }

    public static class NodeWriter
    {
        public static void PrintPreOrder(Node node)
        {
            Console.WriteLine(node.Data);

            if (node.Left != null)
                PrintPreOrder(node.Left);

            if (node.Right != null)
                PrintPreOrder(node.Right);
        }

        public static void PrintInOrder(Node node)
        {
            if (node.Left != null)
                PrintPreOrder(node.Left);

            Console.WriteLine(node.Data);

            if (node.Right != null)
                PrintPreOrder(node.Right);
        }

        public static void PrintPostOrder(Node node)
        {
            if (node.Left != null)
                PrintPreOrder(node.Left);

            if (node.Right != null)
                PrintPreOrder(node.Right);

            Console.WriteLine(node.Data);
        }
    }
}

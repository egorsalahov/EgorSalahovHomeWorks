using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.Concurrents
{
    internal class ConcurrentTree
    {
        class Node
        {
            public int data { get; set; }
            public Node Left { get; set; }
            public Node Right { get; set; }

            public Node(int value)
            {
                data = value;
                Left = null;
                Right = null;
            }
        }

        Node root;
        object locker = new object();

        public void Add(int value)
        {
            lock (locker) 
            {
                if (root == null)
                {
                    root = new Node(value); 
                }
                else
                {
                    Insert(root, value);  
                }
            }
        }

        private void Insert(Node node, int value)
        {
            if (value < node.data)
            {
                if (node.Left == null)
                {
                    node.Left = new Node(value);
                }
                else
                {
                    Insert(node.Left, value);
                }
            }
            else
            {
                if (node.Right == null)
                {
                    node.Right = new Node(value);
                }
                else
                {
                    Insert(node.Right, value);
                }            }
        }

        public void ParallelBFS(Action<int> node)
        {
            if (root == null) return;

            ConcurrentQueue<Node> nodesInProcess = new ConcurrentQueue<Node>();
            nodesInProcess.Enqueue(root);

            while (nodesInProcess.TryDequeue(out var currentNode))
            {
                node(currentNode.data);

                if (currentNode.Left != null)
                {
                    nodesInProcess.Enqueue(currentNode.Left);
                }

                if (currentNode.Right != null)
                {
                    nodesInProcess.Enqueue(currentNode.Right);
                }
            }
        }
    }
}

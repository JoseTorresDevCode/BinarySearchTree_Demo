using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreeDemo
{
    class Node
    {
        public int Data;
        public Node RightNode;
        public Node LeftNode;
        public Node Parent; 

        public Node(int data)
        {
            Data = data;
        }
    }
}

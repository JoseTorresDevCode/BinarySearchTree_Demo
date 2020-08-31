using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreeDemo
{
    class BinarySearchTree
    {
        public Node RootNode;
        //public Node nodeToAdd;

        public void Add(int item)
        {
            Node tempNode;
            Node nodeToAdd = new Node(item);
            if (RootNode == null)
            {
                RootNode = new Node(item);
            }
            else if (RootNode != null)
            {
                Node currentNode = RootNode;
                
                while (nodeToAdd.Parent == null) 
                {
                    tempNode = currentNode;
                    if (nodeToAdd.Data <= currentNode.Data)
                    {
                        currentNode = currentNode.LeftNode;
                        if (currentNode == null)
                        {
                            tempNode.LeftNode = nodeToAdd;
                            nodeToAdd.Parent = tempNode;
                        }

                    }
                    else
                    {
                        currentNode = currentNode.RightNode;
                        if (currentNode == null)
                        {
                            tempNode.RightNode = nodeToAdd;
                            nodeToAdd.Parent = tempNode;
                        }
                    }
                    
                }
            }
            
        }

        public void Search(Node nodeToAdd)
        {
            this.nodeToAdd = nodeToAdd;
            Node currentNode = RootNode;
            bool isEqual = false;
            if(RootNode.Data.Equals(nodeToAdd))
            {
                isEqual = true;
            }
            while (nodeToAdd < currentNode.Data)
            {
                currentNode = currentNode.LeftNode ;
                if()
            }
        }
    }
}

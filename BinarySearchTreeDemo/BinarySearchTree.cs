using System;
using System.Collections.Generic;
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
        

        public void Add(Node nodeToAdd)
        {
            Node tempNode;
            if (RootNode == null)
            {
                RootNode = nodeToAdd;
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
    }
}

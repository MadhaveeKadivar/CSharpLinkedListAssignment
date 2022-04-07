using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDataStructureAssignments
{
    internal class Node<T>
    {
        public T data; // data variable
        public Node<T> next; // declaring a next node
        public Node(T data) // Creating a constructor having node data as parameter
        {
            this.data = data;
        }
    }
}

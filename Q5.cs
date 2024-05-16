using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Army
{
    public class Node
    {
        private int value; //Q5a
        private Node next; //Q5b

        // for Q6
        public Node(int value)
        {
            this.value = value;
            this.next = null;
        }
        public Node(int value, Node next)
        {
            this.value = value;
            this.next = next;
        }
        public int GetValue()
        {
            return this.value;
        }
        public void SetValue(int value)
        {
            this.value = value;
        }
        public Node GetNext()
        {
            return this.next;
        }
        public void SetNext(Node next)
        {
            this.next = next;
        }
    }
    class Q5
    {
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Army
{
    public class LinkedList : IEnumerable<int>
    {
        private Node node; //Q6a


        public LinkedList(Node node)
        {
            this.node = node;
        }
        public Node GetNode()
        {
            return this.node;
        }


        public void Append(int value) //Q6b 
        {
            // רשמתם להוסיף איבר לסוף הרשימה המקושרת ושזה אמור להיות עם סיבוכיות של 1
            // אני למדתי שהסוף זה האחד שמצביע על כלום ומכיוון שבשאלה 5 לא רשמתם להוסיף מצביע על האיבר האחרון אז אין אפשרות לעשות בסיבוכיות של 1
            // ומכיוון שלא רשמתם בשאלה 6ג לעשות בסיבוכיות של 1 אז אני התייחסתי אליהם הפוך(הסוף זה מה שמצביע על כולם ההתחלה זה מה שמצביע על כלום) 
            Node new_node = new Node(value, this.node);
            this.node = new_node;
        }

        public void Prepend(int value) //Q6c
        {   
            Node check = this.node;
            if (check == null)
            {
                this.node = new Node(value);
            }
            else
            {
                while (check.GetNext() != null)
                {
                    check = check.GetNext();
                }
                Node new_node = new Node(value);
                check.SetNext(new_node);
            }
        }

        public int Pop() //Q6d
        {
            int value = this.node.GetValue();
            this.node = this.node.GetNext();
            return value;
        }

        public int Unqueue() //Q6e
        {
            Node check = this.node;
            Node check_next = check.GetNext();
            int value;
            if (check_next == null)
            {
                value = check.GetValue();
                this.node = null;
            }
            else
            {
                while (check_next.GetNext() != null)
                {
                    check = check.GetNext();
                    check_next = check_next.GetNext();
                }
                value = check_next.GetValue();
                check.SetNext(null);
            }
            return value;
        }

        // Q6f
        public IEnumerator<int> GetEnumerator()
        {
            Node check = node;
            while (check != null)
            {
                yield return check.GetValue();
                check = check.GetNext();
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public bool IsCircular() //Q6g
        {
            Node check = this.node;
            while(check.GetNext() != null)
            {
                if (check.GetNext() == this.node)
                {
                    return true;
                }
                check = check.GetNext();
            }
            return false;
        }

        //Q6h
        public void Sort()
        {
            if (this.node == null)
            {
                return;
            }
            bool swap_check = true;
            Node check = this.node;
            while (swap_check)
            {
                check = this.node;
                swap_check = false;
                while (check.GetNext() != null)
                {
                    if (check.GetValue() > check.GetNext().GetValue())
                    {
                        swap(check, check.GetNext());
                        swap_check = true;
                    }
                    check = check.GetNext();
                }
            }
            // for Q6i and Q6j
            max_node = check;
            min_node = this.node;
        }
        private void swap(Node first, Node second)
        {
            int tmp = first.GetValue();
            first.SetValue(second.GetValue());
            second.SetValue(tmp);
        }

        // בשביל שפונקציות אלו יהיו סיבוכיות של 1 אז יצרתי פויינטר לאיבר המקסימלי והמינימלי שממומשים בsort
        // Q6i
        private static Node max_node;
        public Node GetMaxNode()
        {
            return max_node;
        }

        // Q6j
        private static Node min_node;
        public Node GetMinNode()
        {
            return min_node;
        }
    }
    class Q6
    {
    }
}

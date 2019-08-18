namespace HW1
{
    public class BigInteger
    {

        Node head1, head2;

        public class Node
        {
            public int data;
            public Node next;

            public Node(int d)
            {
                data = d;
                next = null;
            }
        }

        Node addTwoLists(Node first, Node second)
        {

            Node res = null;
            Node prev = null;
            Node temp = null;
            int carry = 0, sum;

            while (first != null || second != null)
            {

                sum = carry + (first != null ? first.data : 0)
                            + (second != null ? second.data : 0);

                // update carry for next calulation 
                carry = (sum >= 10) ? 1 : 0;

                // update sum if it is greater than 10 
                sum = sum % 10;

                // Create a new node with sum as data 
                temp = new Node(sum);

                // if this is the first node then set it as head of 
                // the resultant list 
                if (res == null)
                {
                    res = temp;
                }

                // If this is not the first 
                // node then connect it to the rest. 
                else
                {
                    prev.next = temp;
                }

                // Set prev for next insertion 
                prev = temp;

                // Move first and second pointers to next nodes 
                if (first != null)
                {
                    first = first.next;
                }

                if (second != null)
                {
                    second = second.next;
                }
            }

            if (carry > 0)
            {
                temp.next = new Node(carry);
            }

            // return head of the resultant list 
            return res;
        }

    }
}
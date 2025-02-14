namespace DoublyLinkedList
{
    class DoublyLinkedList
    {
        private Node? head;
        private Node? tail;
        private int length;

        public DoublyLinkedList()
        {
            head = null;
            tail = null;
            length = 0;
        }

        public DoublyLinkedList(int data)
        {
            Node newNode = new Node(data);
            head = newNode;
            tail = newNode;
            length = 1;
        }

        public void Append(int data)
        {
            Node newNode = new Node(data);
            if (length == 0) 
            {
                tail = newNode;
                head = newNode;
            }
            else
            {
                tail.Next = newNode;
                newNode.Prev = tail;
                tail = newNode;
            }
            length++;
        }

        public void PrintList()
        {
            Node currentNode = head;

            while (currentNode != null)
            {
                Console.Write("List: " + currentNode.Data + " ");
                currentNode = currentNode.Next;
            }
        }

        public int GetLength()
        {
            return length;
        }

        public int GetHead()
        {
            return head.Data;
        }

        public int GetTail()
        {
            return tail.Data;
        }
    }
}

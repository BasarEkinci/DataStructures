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
            Console.Write("\nList: ");
            while (currentNode != null)
            {
                Console.Write(currentNode.Data + " ");
                currentNode = currentNode.Next;
            }
        }

        public int GetLength()
        {
            return length;
        }

        public void GetHead()
        {
            if (head == null)
            {
                return;
            }
            Console.Write("Head: " + head.Data + "\n");
        }

        public void GetTail()
        {
            if (tail == null)
            {
                return;
            }
            Console.Write("Tail: " + tail.Data + "\n");
        }

        public Node DeleteLast()
        {
            if (head == null) return null;
            Node nodeToDelete = tail;

            if(length == 1)
            {
                head = null;
                tail = null;
            }
            else
            {
                tail = nodeToDelete.Prev;
                tail.Next = null;
                nodeToDelete.Prev = null;
            }
            return nodeToDelete;
        }
    }
}

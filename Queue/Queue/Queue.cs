namespace Queue
{
    class Queue
    {
        private Node? head;
        private Node? tail;

        private int size;

        public Queue()
        {
            head = null;
            tail = null;
        }

        public Queue(int data)
        {
            Node node = new Node(data);
            head = node;
            tail = node;
            size = 1;
        }
        public int GetSize()
        {
            return size;
        }
        public Node Enqueue(int data)
        {
            Node newNode = new Node(data);
            if(size == 0)
            {
                tail = newNode;
                head = newNode;
            }
            else
            {
                tail!.Next = newNode;
                tail = newNode;
            }
            size++;
            return newNode;
        }

        public Node Dequeue()
        {
            if (size == 0) return null;
            Node removedNode = head!;
            if(size == 1)
            {
                tail = null;
                head = null;
            }
            else
            {
                head = head!.Next;
                removedNode.Next = null;
            }
            size--;
            return removedNode;
        }

        public void PrintAll()
        {
            if (size == 0) { return; }

            Node temp = head!;
            Console.Write("Queue: ");
            while (temp != null)
            {
                Console.Write(temp.Data + " ");
                temp = temp.Next;
            }
            Console.WriteLine();
        }

        public int Peek()
        {
            if (size == 0) return -1;
            return head!.Data;
        }

        public bool IsEmpty()
        {
            return size == 0;
        }
    }
}

namespace LinkedListProject
{
    class LinkedList
    {
        private Node? head;
        private Node? tail;
        private int length;

        public LinkedList()
        {
            head = null;
            tail = null;
            length = 0;
        }

        public LinkedList(int data)
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
                head = newNode;
                tail = newNode;
            }
            else
            {
                tail!.Next = newNode;
                tail = newNode;
            }
            length++;
        }

        public void PrintList()
        {
            Node? temp = head;
            Console.Write("List: ");
            while (temp != null)
            {
                Console.Write($"{temp.data} ");
                temp = temp.Next;
            }
            Console.WriteLine();
        }
    }
}

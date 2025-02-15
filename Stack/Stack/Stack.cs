namespace Stack
{
    class Stack
    {
        private Node? top;

        private int count;

        public Stack()
        {
            top = null;
            count = 0;
        }

        public Stack(int data)
        {
            Node newNode = new Node(data);
            top = newNode;
            count = 1;
        }

        public void Push(int data)
        {
            Node newNode = new Node(data);
            newNode.Next = top;
            top = newNode;
            count++;
        }

        public void PrintTop()
        {
            if (top != null)
            {
                Console.WriteLine("Top Value of Stack: " + top.Data);
            }
            else
            {
                Console.WriteLine("No 'Top' value!");
            }
        }

        public int GetCount() { return count; }

        public void PrintAll()
        {
            Node temp = top;
            while (temp != null)
            {
                Console.Write(temp.Data + " ");
                temp = temp.Next;
            }
            Console.WriteLine();
        }

        public Node? Pop()
        {
            if (count == 0)
            {
                return null;
            }
            count--;
            Node? temp = top;
            top = temp.Next;
            temp.Next = null;
            return temp;
        }
        
        public bool IsEmpty() => count == 0;
    }
}

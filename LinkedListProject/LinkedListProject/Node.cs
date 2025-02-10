namespace LinkedListProject
{
    class Node
    {
        public int data { get; set; }
        public Node? Next { get; set; }
        public Node(int data)
        {
            this.data = data;
            Next = null;
        }
    }
}

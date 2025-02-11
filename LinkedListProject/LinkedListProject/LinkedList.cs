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

        public int GetLength()
        {
            return length;
        }

        public void GetTail()
        {
            if (tail == null)
            {
                Console.WriteLine("List is empty");
            }
            else
            {
                Console.WriteLine("Tail: " + tail.data);
            }
        }

        public void GetHead()
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
            }
            else
            {
                Console.WriteLine("Head: " + head.data);
            }
        }

        public Node DeleteLastNode()
        {
            Node? temp = tail;
            if (length == 0)
                return null;

            else if (length == 1)
            {
                head = null;
                tail = null;
                length = 0;
            }
            else
            {
                Node current = head;
                while (current!.Next != tail)
                {
                    current = current.Next;
                }
                temp = tail;
                tail = current;
                tail.Next = null;
                length--;
            }
            return temp;
        }

        public Node DeleteFirstNode()
        {
            if (length == 0)
                return null;

            Node temp = head;
            head = head.Next;
            temp.Next = null;

            if(length == 1)
                tail = null;

            length--;
            return temp;
        }


        public void AddNodeToFirst(int data)
        {
            Node newNode = new Node(data);
            if(length == 0)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                newNode.Next = head;
                head = newNode;
            }
            length++;
        }

        /// <summary>
        /// Get the node at specified index
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        /// <exception cref="IndexOutOfRangeException"></exception>
        /// <exception cref="Exception"></exception>
        public Node GetNodeAt(int index)
        {
            if (length == 0)
                return null;

            if(index > length)
            {
                throw new IndexOutOfRangeException();
            }
            if(index < 0)
            {
                throw new Exception("IndexCannotBeNegative");
            }
            Node targetNode = head;

            for(int i = 0; i < index; i++)
            {
                targetNode = targetNode.Next;
            }
            return targetNode;
        }


        /// <summary>
        /// Change the data of the specified index
        /// </summary>
        /// <param name="index">Data at index</param>
        /// <param name="newData"> New data</param>
        public void SetNode(int index, int newData)
        {
            Node node = GetNodeAt(index);
            node.data = newData;
        }


        /// <summary>
        /// Insert the new Node at Specified Index
        /// </summary>
        /// <param name="index"> index to add new Node</param>
        /// <param name="data"> Data of the Node will be added</param>
        /// <returns></returns>
        public bool InsertNode(int index,int data)
        {
            if(index > length || index < 0)
            {
                return false;
            }

            if(index == 0)
            {
                AddNodeToFirst(data);
                return true;
            }
            else if(index == length - 1)
            {
                Append(data);
                return true;
            }
            else
            {
                int previousIndex = index - 1;
                Node newNode = new Node(data);
                Node previousNode = GetNodeAt(previousIndex);
                newNode.Next = previousNode.Next;
                previousNode.Next = newNode;
                length++;
                return true;
            }
        }

        public Node DeleteNode(int index)
        {
            if(index < 0)
            {
                throw new Exception("IndexCannotBeNegative");
            }
            else if(index >= length)
            {
                throw new IndexOutOfRangeException();
            }
            if (index == 0)
                return DeleteFirstNode();

            if (index == length - 1)
                return DeleteLastNode();

            Node nodeToDelete = GetNodeAt(index);
            Node previousNode = GetNodeAt(index - 1);

            previousNode.Next = nodeToDelete.Next;
            nodeToDelete.Next = null;
            length--;
            return nodeToDelete;
        }
    }
}

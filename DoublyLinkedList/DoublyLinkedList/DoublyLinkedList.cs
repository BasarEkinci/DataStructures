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
            Console.Write("List: ");
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
            if (length == 0) return null;
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
            length--;
            return nodeToDelete;
        }

        public Node DeleteFirst()
        {
            if (length == 0) return null;

            Node nodeToDelete = head;
            if (length == 1)
            {
                head = null;
                tail = null;
            }
            else
            {
                head = head.Next;
                head.Prev = null;
                nodeToDelete.Next = null;
            }
            length--;
            return nodeToDelete;
        }

        public void AddFirst(int data)
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
                head.Prev = newNode;
                head = newNode;
            }
            length++;
        }

        public Node GetNodeAt(int index)
        {
            if (length == 0) return null;
            if (index < 0 || index >= length) return null;

            if (length == 1)
            {
                return head;
            }
            else
            {
                Node temp;
                int tempIndex;
                int n = length / 2;
                if (n >= index)
                {
                    tempIndex = length - 1;
                    temp = tail;

                    while (tempIndex != index)
                    {
                        tempIndex--;
                        temp = temp.Prev;
                    }
                }
                else
                {
                    tempIndex = 0;
                    temp = head;
                    while (tempIndex != index)
                    {
                        tempIndex++;
                        temp = temp.Next;
                    }
                }
                return temp;
            }
        }

        public void SetNode(int index, int newData)
        {
            Node currentNode = GetNodeAt(index);
            if (currentNode == null) return;
            currentNode.Data = newData;
        }

        public bool InsertNodeAt(int index, int newData)
        {
            if (index < 0 || index > length) return false;

            if(index == length)
            {
                Append(newData);
            }
            else if(index == 0)
            {
                AddFirst(newData);
            }
            else
            {
                Node newNode = new Node(newData);
                Node prevNode = GetNodeAt(index - 1);
                Node nextNode = GetNodeAt(index);

                newNode.Next = nextNode;
                newNode.Prev = prevNode;

                prevNode.Next = newNode;
                nextNode.Prev = newNode;
                length++;
            }
            return true;
        }

        public Node DeleteNodeAt(int index)
        {
            if(index >= 0 && index < length)
            {
                
                if (index == 0)
                {
                    return DeleteFirst();
                }
                else if (index == length - 1)
                {
                    return DeleteLast();
                }
                else
                {
                    Node nodeToDelete = GetNodeAt(index);

                    nodeToDelete.Next.Prev = nodeToDelete.Prev;
                    nodeToDelete.Prev.Next = nodeToDelete.Next;

                    nodeToDelete.Next = null;
                    nodeToDelete.Prev = null;
                    length--;
                    return nodeToDelete;
                }
            }
            else
            {
                return null;
            }
        }
    }
}

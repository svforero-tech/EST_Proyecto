using EST_Proyecto.Forms.Interfaces;


namespace EST_Proyecto
{
    class BinaryTree<T> : ITree<T> where T : IComparable<T>
    {
        public NodeTree<T> Root;

        public BinaryTree()
        {
            Root = null;
        }
        

        public void PreOrder(NodeTree<int> node)
        {
            if (node == null) return;

            Console.WriteLine(node.Value);
            PreOrder(node.Left);
            PreOrder(node.Right);
            throw new NotImplementedException();
        }

        public void InOrder(NodeTree<int> node)
        {
            if (node == null) return;

     
            InOrder(node.Left);
            Console.WriteLine(node.Value);
            InOrder(node.Right);
        }

        public void PostOrder(NodeTree<int> node)
        {
            if (node == null) return;

            PostOrder(node.Left);
            PostOrder(node.Right);
            Console.WriteLine(node.Value);
        }

        public void Insert(T data)
        {
            NodeTree<T> newNode = new NodeTree<T>(data);

            if (Root == null)
            {
                Root = newNode;
                return;
            }

            NodeTree<T> current = Root;

            while (true)
            {
                if (data.CompareTo(current.Value) < 0)
                {
                    if (current.Left == null)
                    {
                        current.Left = newNode;
                        return;
                    }

                    current = current.Left;
                }
                else
                {
                    if (current.Right == null)
                    {
                        current.Right = newNode;
                        return;
                    }

                    current = current.Right;
                }
            }
        }

        public T Remove(T data)
        {
            Root = RemoveNode(Root, data);
            return data;
        }

        private NodeTree<T> RemoveNode(NodeTree<T> node, T data)
        {
            if (node == null)
                return null;

            int compare = data.CompareTo(node.Value);

            if (compare < 0)
            {
                node.Left = RemoveNode(node.Left, data);
            }
            else if (compare > 0)
            {
                node.Right = RemoveNode(node.Right, data);
            }
            else
            {
                // Caso 1: sin hijos
                if (node.Left == null && node.Right == null)
                    return null;

                // Caso 2: un hijo
                if (node.Left == null)
                    return node.Right;

                if (node.Right == null)
                    return node.Left;

                // Caso 3: dos hijos
                NodeTree<T> successor = GetMinNode(node.Right);

                node.Value = successor.Value;

                node.Right = RemoveNode(node.Right, successor.Value);
            }

            return node;
        }

        private NodeTree<T> GetMinNode(NodeTree<T> node)
        {
            while (node.Left != null)
            {
                node = node.Left;
            }

            return node;
        }
        

        public bool Contains(T data)
        {
            NodeTree<T> current = Root;

            while (current != null)
            {
                int compare = data.CompareTo(current.Value);

                if (compare == 0)
                    return true;

                if (compare < 0)
                    current = current.Left;
                else
                    current = current.Right;
            }

            return false;
        }

        public T Min()
        {
            if (Root == null)
                throw new Exception("El árbol está vacío");

            NodeTree<T> current = Root;

            while (current.Left != null)
            {
                current = current.Left;
            }

            return current.Value;
        }

        public T Max()
        {
            if (Root == null)
                throw new Exception("El árbol está vacío");

            NodeTree<T> current = Root;

            while (current.Right != null)
            {
                current = current.Right;
            }

            return current.Value;
        }

        public int Count()
        {
            return CountNodes(Root);
        }

        private int CountNodes(NodeTree<T> node)
        {
            if (node == null)
                return 0;

            return 1 + CountNodes(node.Left) + CountNodes(node.Right);
        }

        public int Height()
        {
            return Height(Root);
        }

        private int Height(NodeTree<T> node)
        {
            if (node == null)
                return -1;

            int leftHeight = Height(node.Left);
            int rightHeight = Height(node.Right);

            return 1 + Math.Max(leftHeight, rightHeight);
        }

        public bool IsEmpty()
        {
            return Root == null;
        }

        public void Clear()
        {
            Root = null;
        }


        public void InOrder()
        {
            InOrder(Root);
        }

        public void PostOrder()
        {
            PostOrder(Root);
        }

        public void LevelOrder()
        {
            if (Root == null) return;

            Queue<NodeTree<T>> queue = new Queue<NodeTree<T>>();
            queue.Enqueue(Root);

            while (queue.Count > 0)
            {
                NodeTree<T> current = queue.Dequeue();

                Console.WriteLine(current.Value);

                if (current.Left != null)
                    queue.Enqueue(current.Left);

                if (current.Right != null)
                    queue.Enqueue(current.Right);
            }
        }

        public NodeTree<T>? GetRoot()
        {
            return Root;
        }

        public void PreOrder()
        {
            PreOrder(Root);
        }
    }
}


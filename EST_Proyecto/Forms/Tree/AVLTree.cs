using EST_Proyecto.Forms.Interfaces;

namespace EST_Proyecto.Forms.Tree
{
    class AVLTree : BinaryTree<int>
    {
        // ALTURA

        private int GetHeight(NodeTree<int> node)
        {
            if (node == null)
                return 0;

            return 1 + Math.Max(GetHeight(node.Left), GetHeight(node.Right));
        }

        // FACTOR DE BALANCE 

        private int GetBalance(NodeTree<int> node)
        {
            if (node == null)
                return 0;

            return GetHeight(node.Left) - GetHeight(node.Right);
        }

        //ROTACIONES

        private NodeTree<int> RotateRight(NodeTree<int> y)
        {
            NodeTree<int> x = y.Left;
            NodeTree<int> T2 = x.Right;

            x.Right = y;
            y.Left = T2;

            return x;
        }

        private NodeTree<int> RotateLeft(NodeTree<int> x)
        {
            NodeTree<int> y = x.Right;
            NodeTree<int> T2 = y.Left;

            y.Left = x;
            x.Right = T2;

            return y;
        }

        //INSERT AVL

        public new void Insert(int data)
        {
            Root = InsertAVL(Root, data);
        }

        private NodeTree<int> InsertAVL(NodeTree<int> node, int data)
        {
            // Inserción normal BST
            if (node == null)
                return new NodeTree<int>(data);

            if (data < node.Value)
                node.Left = InsertAVL(node.Left, data);

            else if (data > node.Value)
                node.Right = InsertAVL(node.Right, data);

            else
                return node;

            // Balance
            int balance = GetBalance(node);

            // Caso Left Left
            if (balance > 1 && data < node.Left.Value)
                return RotateRight(node);

            // Caso Right Right
            if (balance < -1 && data > node.Right.Value)
                return RotateLeft(node);

            // Caso Left Right
            if (balance > 1 && data > node.Left.Value)
            {
                node.Left = RotateLeft(node.Left);
                return RotateRight(node);
            }

            // Caso Right Left
            if (balance < -1 && data < node.Right.Value)
            {
                node.Right = RotateRight(node.Right);
                return RotateLeft(node);
            }

            return node;
        }

        //  REMOVE AVL

        public new int Remove(int data)
        {
            Root = RemoveAVL(Root, data);
            return data;
        }

        private NodeTree<int> RemoveAVL(NodeTree<int> node, int data)
        {
            if (node == null)
                return node;

            // BST REMOVE
            if (data < node.Value)
                node.Left = RemoveAVL(node.Left, data);

            else if (data > node.Value)
                node.Right = RemoveAVL(node.Right, data);

            else
            {
                // 1 hijo o ninguno
                if (node.Left == null || node.Right == null)
                {
                    NodeTree<int> temp;

                    if (node.Left != null)
                        temp = node.Left;
                    else
                        temp = node.Right;

                    if (temp == null)
                        return null;

                    node = temp;
                }
                else
                {
                    // 2 hijos
                    NodeTree<int> temp = GetMinNode(node.Right);

                    node.Value = temp.Value;

                    node.Right = RemoveAVL(node.Right, temp.Value);
                }
            }

            // Balancear
            int balance = GetBalance(node);

            // Left Left
            if (balance > 1 && GetBalance(node.Left) >= 0)
                return RotateRight(node);

            // Left Right
            if (balance > 1 && GetBalance(node.Left) < 0)
            {
                node.Left = RotateLeft(node.Left);
                return RotateRight(node);
            }

            // Right Right
            if (balance < -1 && GetBalance(node.Right) <= 0)
                return RotateLeft(node);

            // Right Left
            if (balance < -1 && GetBalance(node.Right) > 0)
            {
                node.Right = RotateRight(node.Right);
                return RotateLeft(node);
            }

            return node;
        }

        //MIN NODE

        private NodeTree<int> GetMinNode(NodeTree<int> node)
        {
            while (node.Left != null)
            {
                node = node.Left;
            }

            return node;
        }
    }

}

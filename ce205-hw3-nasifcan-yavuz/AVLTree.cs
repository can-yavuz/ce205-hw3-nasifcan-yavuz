using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ce205_hw3_nasifcan_yavuz
{
    public class AVLTree
    {
        /// <summary>
        /// The code is a class that represents an AVL tree.
        ///The Node class has three fields: ID, height, and data.
        ///The left and right field are both of type Node.
        ///The constructor for the node takes in two parameters: the ID number of the node and its data string.
        //The code creates a class that has two properties, ID and height.
        /// </summary>
        public class Node
        {
            public int ID, height;
            public string data;

            public Node left, right;

            public Node(int ID, string data)
            {
                this.ID = ID;
                this.data = data;
                this.height = 1;
            }
        }
        public Node root;
        /// <summary>
        /// The code is a function that returns the height of a node.
        //The function is called Height and it takes in Node as an input parameter.
        // If the input parameter is null, then 0 will be returned.
        //Otherwise, the height of the node will be returned.
        //The code begins by checking if the input parameter is null (if N == null).
        /// </summary>
        /// <param name="N"></param>
        /// <returns></returns>
        public int Height(Node N)
        {
            if (N == null)
                return 0;
            return N.height;
        }

        public int Max(int a, int b)
        {
            return (a > b) ? a : b;
        }
        /// <summary>
        /// The code is a function that rotates the node on its right side by one step.
        ///The code starts with the line "Node x = y."
        ///This is because this function will be called from inside of another function, and it needs to know what node it's working with.
        /// </summary>
        /// <param name="y"></param>
        /// <returns></returns>
        public Node RightRotate(Node y)
        {
            Node x = y.left;
            Node T2 = x.right;

            x.right = y;
            y.left = T2;

            y.height = Max(Height(y.left), Height(y.right)) + 1;
            x.height = Max(Height(x.left), Height(x.right)) + 1;

            return x;
        }
        /// <summary>
        /// The code is a function that takes in a Node x and returns the node y.
        /// The code starts by taking the right child of x, which is y, and making it left child of x.
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public Node LeftRotate(Node x)
        {
            Node y = x.right;
            Node T2 = y.left;

            y.left = x;
            x.right = T2;

            x.height = Max(Height(x.left), Height(x.right)) + 1;
            y.height = Max(Height(y.left), Height(y.right)) + 1;

            return y;
        }
        /// <summary>
        ///  The code is a function that returns the balance of an account.
        /// The function starts by checking if the passed in node is null, which would mean it's not an account and should return 0.
        /// </summary>
        /// <param name="N"></param>
        /// <returns></returns>
        public int GetBalance(Node N)
        {
            if (N == null)
                return 0;
            return Height(N.left) - Height(N.right);
        }
        /// <summary>
        /// The code is a function that inserts a node into the tree.
        /// The code starts by checking if the node is null, which means it has not been inserted yet.
        /// If the node is null, then it will create a new Node with an ID of 1 and data of "data".
        /// </summary>
        /// <param name="node"></param>
        /// <param name="ID"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public Node Insert(Node node, int ID, string data)
        {
            if (node == null)
                return (new Node(ID, data));

            if (ID < node.ID)
                node.left = Insert(node.left, ID, data);
            else if (ID > node.ID)
                node.right = Insert(node.right, ID, data);
            else
                return node;

            node.height = 1 + Max(Height(node.left), Height(node.right));

            int balance = GetBalance(node);

            if (balance > 1 && ID < node.left.ID)
                return RightRotate(node);

            if (balance < -1 && ID > node.right.ID)
                return LeftRotate(node);

            if (balance > 1 && ID > node.left.ID)
            {
                node.left = LeftRotate(node.left);
                return RightRotate(node);
            }

            if (balance < -1 && ID < node.right.ID)
            {
                node.right = RightRotate(node.right);
                return LeftRotate(node);
            }

            return node;
        }
        public Node Delete(Node root, int ID)
        {
            if (root == null)
                return root;

            if (ID < root.ID)
                root.left = Delete(root.left, ID);
            else if (ID > root.ID)
                root.right = Delete(root.right, ID);
            else
            {
                if ((root.left == null) || (root.right == null))
                {
                    Node temp = null;
                    if (temp == root.left)
                        temp = root.right;
                    else
                        temp = root.left;

                    if (temp == null)
                    {
                        temp = root;
                        root = null;
                    }
                    else
                        root = temp;
                }
                else
                {
                    Node temp = minValueNode(root.right);

                    root.ID = temp.ID;
                    root.right = Delete(root.right, temp.ID);
                }
            }

            if (root == null)
                return root;

            root.height = Max(Height(root.left), Height(root.right)) + 1;

            int balance = GetBalance(root);

            if (balance > 1 && GetBalance(root.left) >= 0)
                return RightRotate(root);

            if (balance > 1 && GetBalance(root.left) < 0)
            {
                root.left = LeftRotate(root.left);
                return RightRotate(root);
            }

            if (balance < -1 && GetBalance(root.right) <= 0)
                return LeftRotate(root);

            if (balance < -1 && GetBalance(root.right) > 0)
            {
                root.right = RightRotate(root.right);
                return LeftRotate(root);
            }

            return root;
        }
        /// <summary>
        /// The code is trying to find the minimum value in a list of numbers.
        /// The code starts by setting current to be node, which is the first number in the list.
        /// Then it goes through each number on the left side of current and sets that as new current until there are no more left sides.
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public Node minValueNode(Node node)
        {
            Node current = node;

            while (current.left != null)
                current = current.left;

            return current;
        }
        /// <summary>
        /// The code starts by checking if the node is null.
        /// If it is not, then a loop starts that prints out the ID of the node and then calls PreOrder on its left and right children.
        /// </summary>
        /// <param name="node"></param>
        public void PreOrder(Node node)
        {
            if (node != null)
            {
                Console.Write(node.ID + " ");
                PreOrder(node.left);
                PreOrder(node.right);
            }
        }
        /// <summary>
        /// Required node finding is done in the AVL tree.
        /// </summary>
        /// <param name="root"></param>
        /// <param name="ID"></param>
        /// <returns></returns>
        public Node Search(Node root, int ID)
        {
            if (root == null || root.ID == ID)
                return root;

            if (root.ID < ID)
                return Search(root.right, ID);

            return Search(root.left, ID);
        }
        /// <summary>
        /// AVL tree deletion is done
        /// </summary>
        /// <param name="root"></param>
        /// <param name="ID"></param>
        /// <returns></returns>
        public int delete(int ID)
        {
            if (Search(root, ID) == null)
                return 0;
            else
            {
                root = Delete(root, ID);
                return 1;
            }
        }
        public int search(int ID)
        {
            if (Search(root, ID) == null)
                return 0;
            else
                return 1;
        }
        public int insert(int ID, string data)
        {
            root = Insert(root, ID, data);
            return 0;
        }
    }
}

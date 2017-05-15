namespace DataStructures.BinaryTrees
{
    using System;

    /// <summary>
    /// Represents a binary tree structure
    /// </summary>
    /// <typeparam name="T">the type of the values in the
    /// tree</typeparam>
    public class BinaryTree<T>
    {
        // The root of the tree
        private BinaryTreeNode<T> root;
        /// <summary>
        /// Constructs the tree
        /// </summary>
        /// <param name="value">the value of the root node</param>
        /// <param name="leftChild">the left child of the root node</param>
        /// <param name="rightChild">the right child of the
        /// root node</param>
        public BinaryTree(T value, BinaryTree<T> leftChild,
        BinaryTree<T> rightChild)
        {
            if (value == null)
            {
                throw new ArgumentNullException("Cannot insert null value!");
            }
            BinaryTreeNode<T> leftChildNode =
            leftChild != null ? leftChild.root : null;
            BinaryTreeNode<T> rightChildNode =
            rightChild != null ? rightChild.root : null;
            this.root = new BinaryTreeNode<T>(
            value, leftChildNode, rightChildNode);
        }
        /// <summary>
        /// Constructs the tree
        /// </summary>
        /// <param name="value">the value of the root node</param>
        public BinaryTree(T value)
        : this(value, null, null)
        {
        }
        /// <summary>
        /// The root of the tree.
        /// </summary>
        public BinaryTreeNode<T> Root
        {
            get
            {
                return this.root;
            }
        }
        /// <summary>
        /// Traverses binary tree in pre-order manner
        /// </summary>
        /// <param name="root">the binary tree to be traversed</param>
        private void PrintInorder(BinaryTreeNode<T> root)
        {
            if (root == null)
            {
                return;
            }
            // 1. Visit the left child
            PrintInorder(root.LeftChild);
            // 2. Visit the root of this subtree
            Console.Write(root.Value + " ");
            // 3. Visit the right child
            PrintInorder(root.RightChild);
        }
        /// <summary>
        /// Traverses and prints the binary
        /// tree in pre-order manner
        /// </summary>
        public void PrintInorder()
        {
            PrintInorder(this.root);
            Console.WriteLine();
        }
    }
}
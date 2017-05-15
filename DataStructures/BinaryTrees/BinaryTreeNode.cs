using System;

namespace DataStructures.BinaryTrees
{
    /// <summary>
    /// Represents a binary tree node
    /// </summary>
    /// <typeparam name="T">the type of the values in nodes</typeparam>
    public class BinaryTreeNode<T>
    {
        // Contains the value of the node
        private T value;
        // Shows whether the current node has parent
        private bool hasParent;
        // Contains the left child of the node
        private BinaryTreeNode<T> leftChild;
        // Contains the right child of the node
        private BinaryTreeNode<T> rightChild;
        /// <summary>
        /// Constructs a binary tree node
        /// </summary>
        /// <param name="value">the value of the node</param>
        /// <param name="leftChild">the left child of the node</param>
        /// <param name="rightChild">the right child of the
        /// node</param>
        public BinaryTreeNode(T value, BinaryTreeNode<T> leftChild,
        BinaryTreeNode<T> rightChild)
        {
            if (value == null)
            {
                throw new ArgumentNullException("Cannot insert null value!");
            }
            this.value = value;
            this.LeftChild = leftChild;
            this.RightChild = rightChild;
        }
        /// <summary>
        /// Constructs a binary tree node with no children
        /// </summary>
        /// <param name="value">the value of the node</param>
        public BinaryTreeNode(T value) : this(value, null, null)
        {
        }
        /// <summary>
        /// The value of the node
        /// </summary>
        public T Value
        {
            get
            {
                return this.value;
            }
            set
            {
                this.value = value;
            }
        }
        /// <summary>
        /// The left child of the node
        /// </summary>
        public BinaryTreeNode<T> LeftChild
        {
            get
            {
                return this.leftChild;
            }
            set
            {
                if (value == null)
                {
                    return;
                }
                if (value.hasParent)
                {
                    throw new ArgumentException(
                    "The node already has a parent!");
                }
                value.hasParent = true;
                this.leftChild = value;
            }
        }
        /// <summary>
        /// The right child of the node
        /// </summary>
        public BinaryTreeNode<T> RightChild
        {
            get
            {
                return this.rightChild;
            }
            set
            {
                if (value == null)
                {
                    return;
                }
                if (value.hasParent)
                {
                    throw new ArgumentException(
                    "The node already has a parent!");
                }
                value.hasParent = true;
                this.rightChild = value;
            }
        }
    }
}
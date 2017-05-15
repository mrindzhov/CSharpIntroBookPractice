namespace DataStructures.BinaryTrees
{
    /// <summary>
    /// Shows how the BinaryTree class can be used
    /// </summary>
    public class BinaryTreeExample
    {
        public static void Run()
        {
            // Create the binary tree from the sample
            BinaryTree<int> binaryTree =
                new BinaryTree<int>(14,
                    new BinaryTree<int>(19,
                        new BinaryTree<int>(23),
                        new BinaryTree<int>(6,
                            new BinaryTree<int>(10),
                            new BinaryTree<int>(21))),
                    new BinaryTree<int>(15,
                        new BinaryTree<int>(3),
                        null)
            );
            // Traverse and print the tree in in-order manner
            binaryTree.PrintInorder();
            // Console output:
            // 23 19 10 6 21 14 3 15
        }
    }
}

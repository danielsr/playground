using System;
using Util;

namespace Problems
{
    // https://leetcode.com/problems/construct-string-from-binary-tree/
    public class StringFromBinaryTree
    {
        public static String TreeToString(TreeNode node) // PreOrder
        {
            if (node == null)
                return "";
            
            if (node.Left == null && node.Right == null)
                return node.Value.ToString();
            
            if (node.Right == null)
                return node.Value.ToString() + "(" + TreeToString(node.Left) + ")";
            
            return node.Value.ToString() + "(" + TreeToString(node.Left) + ")(" + TreeToString(node.Right) + ")";
        }

        public static void Test()
        {
            TreeNode node = new TreeNode(1);
            node.Left = new TreeNode(2);
            node.Left.Right = new TreeNode(4);
            node.Right = new TreeNode(3);

            Console.WriteLine(TreeToString(node));
        }
        
    }
}
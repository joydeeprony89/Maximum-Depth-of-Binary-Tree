using System;

namespace Maximum_Depth_of_Binary_Tree
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
    }

    public class TreeNode
    {
      public int value;
      public TreeNode left;
      public TreeNode right;
      public TreeNode(int val)
      {
        value = val;
        left = right = null;
      }
    }

    public int MaxDepth(TreeNode root)
    {
      return MaxDepthHelper(root, 0);
    }

    private int MaxDepthHelper(TreeNode root, int max)
    {
      if (root == null) return max;
      max++;
      int maxLeft = MaxDepthHelper(root.left, max);
      int maxRight = MaxDepthHelper(root.right, max);
      return Math.Max(maxLeft, maxRight);
    }
  }
}

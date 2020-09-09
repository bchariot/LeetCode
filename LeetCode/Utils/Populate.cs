namespace LeetCode.Utils
{
    public class Populate
    {
        public static TreeNode TreeNode(int?[] nums)
        {
            return TreeNode(nums, new TreeNode(nums[0].Value), 0);
        }

        static TreeNode TreeNode(int?[] nums, TreeNode root, int i)
        {
            if (i < nums.Length && nums[i].HasValue)
            {
                TreeNode temp = new TreeNode(nums[i].Value);
                root = temp;
                root.left = TreeNode(nums, root.left, 2 * i + 1);
                root.right = TreeNode(nums, root.right, 2 * i + 2);
            }
            return root;
        }

        public static ListNode ListNode(int[] nums)
        {
            return ListNode(nums, new ListNode(nums[0]), 0);
        }

        static ListNode ListNode(int[] nums, ListNode root, int i)
        {
            if (i < nums.Length)
            {
                ListNode temp = new ListNode(nums[i]);
                root = temp;
                root.next = ListNode(nums, root.next, i + 1);
            }
            return root;
        }

        public static char[][] CharCharArray(char[,] array)
        {
            int rows = array.GetLength(0);
            int columns = array.Length / array.GetLength(0);
            char[][] charArray = new char[rows][];
            for (int i = 0; i < rows; i++)
            {
                charArray[i] = new char[columns];
                for (int j = 0; j < columns; j++)
                {
                    charArray[i][j] = array[i, j];
                }
            }

            return charArray;
        }

        public static int[][] IntIntArray(int[,] array)
        {
            int rows = array.GetLength(0);
            int columns = array.Length / array.GetLength(0);
            int[][] intArray = new int[rows][];
            for (int i = 0; i < rows; i++)
            {
                intArray[i] = new int[columns];
                for (int j = 0; j < columns; j++)
                {
                    intArray[i][j] = array[i, j];
                }
            }

            return intArray;
        }

        public static RandomNode RdmNode(int?[,] array)
        {
            RandomNode root = GetNextNode(array, new RandomNode(array[0, 0].Value), 0);
            HashMap<int, RandomNode> map = new HashMap<int, RandomNode>();
            RandomNode node = root;
            while (node != null)
            {
                map.Put(node.val, node);
                node = node.next;
            }
            return GetRandomNode(root, array, map, 0);
        }

        static RandomNode GetNextNode(int?[,] array, RandomNode root, int i)
        {
            if (i < array.Length / 2)
            {
                RandomNode temp = new RandomNode(array[i, 0].Value);
                root = temp;
                root.next = GetNextNode(array, root.next, i + 1);
            }
            return root;
        }

        static RandomNode GetRandomNode(RandomNode root, int?[,] array, HashMap<int, RandomNode> map, int i)
        {
            if (i < array.Length / 2)
            {
                RandomNode node = array[i, 1].HasValue && array[array[i, 1].Value, 0].HasValue && map.ContainsKey(array[array[i, 1].Value, 0].Value) ? map.Get(array[array[i, 1].Value, 0].Value) : null;
                root.random = node;
                root.next = GetRandomNode(root.next, array, map, i + 1);
            }

            return root;
        }
    }
}

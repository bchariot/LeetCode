using LeetCode.Algorithms;
using System;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program started");
            RunDynamicProgramming();
            RunHastSets();
            RunListNodes();
            RunMisc();
            RunQueues();
            RunRecursion();
            RunStacks();
            RunStrings();
            RunTreeNodes();
            Console.WriteLine("Program completed");
            Console.Read();
        }

        static void RunDynamicProgramming()
        {
            ClimbingStairs.RunCode();
            CoinChange.RunCode();
            MinimumPathSum.RunCode();
            UniquePaths.RunCode();
        }

        static void RunHastSets()
        {
            MissingNumber.RunCode();
            MostCommonWord.RunCode();
            RemoveVowels.RunCode();
            ReverseVowels.RunCode();
            SingleNumber.RunCode();
        }

        static void RunListNodes()
        {
            IntersectionTwoLinkedLists.RunCode();
            ReverseLinkedList.RunCode();
        }

        static void RunMisc()
        {
            GroupedAnagrams.RunCode();
            MinimumDominoRotations.RunCode();
            PowerOfTwo.RunCode();
            QuickSelect.RunCode();
            RemoveElement.RunCode();
            SortArrayByParity.RunCode();
            WordSearch.RunCode();
        }

        static void RunQueues()
        {
            KClosestPoints.RunCode();
            LastStoneWeight.RunCode();
            MinimumCostConnectSticks.RunCode();
            ReorganizeString.RunCode();
        }

        static void RunRecursion()
        {
            CombinationSum.RunCode();
            FloodFill.RunCode();
            LetterPhone.RunCode();
            MaxAreaOfIsland.RunCode();
            SubSets.RunCode();
        }

        static void RunStacks()
        {
            AsteroidCollision.RunCode();
            FrogJump.RunCode();
        }

        static void RunStrings()
        {
            FirstUniqueCharacter.RunCode();
            JewelsStones.RunCode();
            LongestCommonPrefix.RunCode();
            PartitionLabels.RunCode();
            StringCompression.RunCode();
        }

        static void RunTreeNodes()
        {
            BinaryTreePath.RunCode();
            BinaryTreeRightSideView.RunCode();
            LowestCommonAncestor.RunCode();
            PathSum.RunCode();
            RangeSumOfBST.RunCode();
            SubtreeOfAnotherTree.RunCode();
            SymmetricTree.RunCode();
            ValidateBinarySearchTree.RunCode();
        }
    }
}

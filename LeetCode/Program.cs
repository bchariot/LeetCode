using LeetCode.Algorithms;
using System;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program started");
            /*RunDFS();
            RunDynamicProgramming();
            RunHashMaps();
            RunHashSets();
            RunListNodes();
            RunMisc();
            RunQueues();
            RunRecursion();
            RunStacks();
            RunStrings();
            RunTreeNodes();*/
            Console.WriteLine("Program completed");
            Console.Read();
        }

        static void RunDFS()
        {
            NumberOfIslands.RunCode();
        }

        static void RunDynamicProgramming()
        {
            ClimbingStairs.RunCode();
            CoinChange.RunCode();
            HouseRobber.RunCode();
            MinimumPathSum.RunCode();
            UniquePaths.RunCode();
            WordBreak.RunCode();
        }

        static void RunHashMaps()
        {
            CopyListWithRandomPointer.RunCode();
            FindFirstAndLastPositionOfElementInSortedArray.RunCode();
            FirstUniqueCharacter.RunCode();
            GroupedAnagrams.RunCode();
            StringCompression.RunCode();
        }

        static void RunHashSets()
        {
            ContainsDuplicate.RunCode();
            FindAllNumbersDisappearedInArray.RunCode();
            JewelsStones.RunCode();
            MissingNumber.RunCode();
            MostCommonWord.RunCode();
            RemoveVowels.RunCode();
            ReverseVowels.RunCode();
            SingleNumber.RunCode();
        }

        static void RunListNodes()
        {
            IntersectionTwoLinkedLists.RunCode();
            MergeKSortedLists.RunCode();
            ReverseLinkedList.RunCode();
        }

        static void RunMisc()
        {
            FizzBuzz.RunCode();
            MinimumDominoRotations.RunCode();
            MoveZeroes.RunCode();
            PlusOne.RunCode();
            PowerOfTwo.RunCode();
            QuickSelect.RunCode();
            RemoveElement.RunCode();
            ReverseInteger.RunCode();
            RobotReturnToOrigin.RunCode();
            RotateImage.RunCode();
            SearchRotatedSortedArray.RunCode();
            SortArrayByParity.RunCode();
            TwoSum.RunCode();
            ValidAnagram.RunCode();
            ValidPalindrome.RunCode();
            WordSearch.RunCode();
        }

        static void RunQueues()
        {
            BestTimeToBuyStock.RunCode();
            BinaryTreeLevelOrderTraversal.RunCode();
            KClosestPoints.RunCode();
            KLargestElementInArray.RunCode();
            LastStoneWeight.RunCode();
            MinimumCostConnectSticks.RunCode();
            ReorganizeString.RunCode();
        }

        static void RunRecursion()
        {
            CloneGraph.RunCode();
            CombinationSum.RunCode();
            FlattenBSTToDLL.RunCode();
            FloodFill.RunCode();
            GenerateParentheses.RunCode();
            LetterPhone.RunCode();
            MaxAreaOfIsland.RunCode();
            PermutationSequence.RunCode();
            SubSets.RunCode();
        }

        static void RunStacks()
        {
            AsteroidCollision.RunCode();
            BackspaceStringCompare.RunCode();
            FlattenBinaryTreeToLinkedList.RunCode();
            FrogJump.RunCode();
            ValidParentheses.RunCode();
        }

        static void RunStrings()
        {
            LongestCommonPrefix.RunCode();
            PartitionLabels.RunCode();
            ReverseString.RunCode();
            ReverseWordsInString.RunCode();
            RotateArray.RunCode();
        }

        static void RunTreeNodes()
        {
            BinaryTreeMaximumPathSum.RunCode();
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

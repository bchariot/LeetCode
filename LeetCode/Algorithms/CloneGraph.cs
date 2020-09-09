using LeetCode.Utils;
using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms
{
    public class CloneGraph
    {
        // LeetCode #133. CloneGraph
        public static void RunCode()
        {
            GraphNode node = new GraphNode();
            Console.WriteLine($"    CloneGraph {Clone(node)}");
        }

        static GraphNode Clone(GraphNode node)
        {
            // Time Complexity: Linear O(n) Space: Linear O(n)
            Dictionary<int, GraphNode> map = new Dictionary<int, GraphNode>();
            return RecursiveCall(node, map);
        }

        static GraphNode RecursiveCall(GraphNode node, Dictionary<int, GraphNode> map)
        {
            if (map.ContainsKey(node.val))
            {
                return map[node.val];
            }

            GraphNode copy = new GraphNode(node.val);
            map.Add(node.val, copy);
            foreach (GraphNode nd in node.neighbors)
            {
                copy.neighbors.Add(RecursiveCall(nd, map));
            }

            return copy;
        }
    }
}

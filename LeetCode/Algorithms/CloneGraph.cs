using LeetCode.Utils;
using System;

namespace LeetCode.Algorithms
{
    public class CloneGraph
    {
        /* LeetCode #133. Clone Graph
         * Given a reference of a node in a connected undirected graph.
         * Return a deep copy (clone) of the graph.
         * Each node in the graph contains a val (int) and a list (List[Node]) of its neighbors.*/
        public static void RunCode()
        {
            GraphNode node = new GraphNode();
            Console.WriteLine($"    CloneGraph {Clone(node)}");
        }

        static GraphNode Clone(GraphNode node)
        {
            // Time Complexity: Linear O(n) Space: Linear O(n)
            HashMap<int, GraphNode> map = new HashMap<int, GraphNode>();
            return RecursiveCall(node, map);
        }

        static GraphNode RecursiveCall(GraphNode node, HashMap<int, GraphNode> map)
        {
            if (map.ContainsKey(node.val))
            {
                return map.Get(node.val);
            }

            GraphNode copy = new GraphNode(node.val);
            map.Put(node.val, copy);
            foreach (GraphNode nd in node.neighbors)
            {
                copy.neighbors.Add(RecursiveCall(nd, map));
            }

            return copy;
        }
    }
}

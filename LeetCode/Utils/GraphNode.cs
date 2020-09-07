using System.Collections.Generic;

namespace LeetCode.Utils
{
    public class GraphNode
    {
        public int val;
        public List<GraphNode> neighbors;

        public GraphNode()
        {
            val = 0;
            neighbors = new List<GraphNode>();
        }

        public GraphNode(int x)
        {
            val = x;
            neighbors = new List<GraphNode>();
        }

        public GraphNode(int x, List<GraphNode> xbors)
        {
            val = x;
            neighbors = xbors;
        }
    }
}

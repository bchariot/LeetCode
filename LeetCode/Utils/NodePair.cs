using System.Collections.Generic;

namespace LeetCode.Utils
{
    public class NodePair
    {
        public Node U { get; set; }
        public Node V { get; set; }

        public NodePair(Node u, Node v)
        {
            U = u;
            V = v;
        }

        public List<NodePair> List()
        {
            List<NodePair> list = new List<NodePair>();
            list.Add(this);
            return list;
        }
    }
}

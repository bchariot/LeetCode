using LeetCode.Utils;
using System;

namespace LeetCode.Algorithms
{
    public class FindUnionLCA
    {
        // LeetCode #236. Lowest Common Ancestor of a Binary Tree Using Find-Union
        public static void RunCode() {
            int?[] nums = new int?[] { 6, 2, 8, 0, 4, 7, 9, null, null, 3, 5 };
            Node root = Populate.Node(nums);
            Node p = new Node(0);
            Node q = new Node(4);
            Console.WriteLine($"    LowestCommonAncestor for {p.val},{q.val}: {GetLCA(root, p, q).val}");
        }

        static Node GetLCA(Node root, Node p, Node q) {
            NodePair pair = new NodePair(p, q);
            LCA(root, pair);
            return root;
        }

        static void LCA(Node u, NodePair pair) {
            MakeSet(u);
            Find(u).ancestor = u;
            foreach (Node vNode in u.Children()) {
                LCA(vNode, pair);
                Union(u, vNode);
                Find(u).ancestor = u;
            }
            u.colour = Node.black;
            Node v;
            foreach (NodePair uv in pair.List()) {
                u = uv.U;
                v = uv.V;
                if (v.colour == Node.black && u != null && v != null && Find(u) == Find(v)) {
                    Console.WriteLine($"Tarjan's Lowest Common Ancestor of {u.val} and {v.val}: {Find(v).ancestor.val}");
                }
            }
        }

        static void MakeSet(Node x) {
            x.parent = x;
            x.rank = 0;
        }

        static void Union(Node x, Node y) {
            Link(Find(x), Find(y));
        }

        static void Link(Node x, Node y) {
            if (x.rank > y.rank) {
                y.parent = x;
            } else {
                x.parent = y;
                if (x.rank == y.rank) {
                    y.rank += 1;
                }
            }
        }

        static Node Find(Node x) {
            if (x != x.parent) {
                x.parent = Find(x.parent);
            }

            return x.parent;
        }
    }
}

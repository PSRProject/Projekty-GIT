using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graph
{
    class Edge
    {
        Node startNode;
        Node endNode;
        int length;

        public Node StartNode { get; set; }
        public Node EndNode { get; set; }
        public int Length { get; set; }
    }
}

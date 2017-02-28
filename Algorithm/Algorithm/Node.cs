using Algorithm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4AI
{
    public class Node
    {
        public string Name { get; set; }
        public List<Node> Adjacent { get; set; }
        public bool isVisited { get; set; }
        public int TotalCost { get; set; }
        public List<Neighbour> NeighbourPath{get;set;}
    }
}

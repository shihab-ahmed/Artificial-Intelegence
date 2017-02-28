using Algorithm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4AI
{
    public class Graph
    {
        List<Node> GraphMap = new List<Node>();

        Node n = new Node();
        Node n1 = new Node();
        Node n2 = new Node();
        Node n3 = new Node();
        Node n4 = new Node();
        Node n5 = new Node();

        public Graph()
        {
            CreateGraph();
        }
       
        private void CreateGraph()
        {
          


            n.Name = "S";       
            n1.Name = "A";
            n2.Name = "B";
            n3.Name = "C";
            n4.Name = "D";
            n5.Name = "G";

            n.Adjacent = new List<Node> { n1,n5 };
            n1.Adjacent = new List<Node> {n2,n3};    
            n2.Adjacent = new List<Node> {n4};           
            n3.Adjacent = new List<Node> { n4,n5 };          
            n4.Adjacent = new List<Node> {n5 };
            n5.Adjacent = new List<Node> {  };

            GraphMap.Add(n);
            GraphMap.Add(n1);
            GraphMap.Add(n2);
            GraphMap.Add(n3);
            GraphMap.Add(n4);
            GraphMap.Add(n5);


        }

        public void addPathCost()
        {

            n.NeighbourPath  = new List<Neighbour> { new Neighbour { neighbour=n1, cost=1}, new Neighbour { neighbour = n5, cost = 12 } };
            n1.NeighbourPath = new List<Neighbour> { new Neighbour { neighbour = n2, cost = 3 }, new Neighbour { neighbour = n3, cost = 1 } };
            n2.NeighbourPath = new List<Neighbour> { new Neighbour { neighbour = n4, cost = 3 }};
            n3.NeighbourPath = new List<Neighbour> { new Neighbour { neighbour = n4, cost = 1 }, new Neighbour { neighbour = n5, cost = 2 } };
            n4.NeighbourPath = new List<Neighbour> { new Neighbour { neighbour = n5, cost = 3 } };
            n5.NeighbourPath = new List<Neighbour> { new Neighbour ()}; ;
        }

        public List<Node> getGraph()
        {
            return GraphMap;
        }
       
    }
}

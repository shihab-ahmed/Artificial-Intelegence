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
        Node n6 = new Node();
        Node n7 = new Node();
        Node n8 = new Node();
        Node n9 = new Node();
       
        

        public Graph()
        {
            CreateGraph();
        }
       
        private void CreateGraph()
        {
          


            n.Name =  "A";       
            n1.Name = "B";
            n2.Name = "C";
            n3.Name = "D";
            n4.Name = "E";
            n5.Name = "F";
            n6.Name = "G";
            n7.Name = "H";
            n8.Name = "I";
            n9.Name = "J";

            n.color = 0;
            n1.color = 0;
            n2.color = 0;
            n3.color = 0;
            n4.color = 0;
            n5.color = 0;
            n6.color = 0;
            n7.color = 0;
            n8.color = 0;
            n9.color = 0;
            

            n.Adjacent = new List<Node> { n1,n2,n3 };
            n1.Adjacent = new List<Node> {n,n4,n8};    
            n2.Adjacent = new List<Node> {n,n6,n7};           
            n3.Adjacent = new List<Node> { n,n5,n9 };          
            n4.Adjacent = new List<Node> {n1,n5,n7 };
            n5.Adjacent = new List<Node> {n3,n4,n6  };
            n6.Adjacent = new List<Node> {n8,n2,n5 };
            n7.Adjacent = new List<Node> {n9,n2,n4 };
            n8.Adjacent = new List<Node> {n1,n6,n9 };
            n9.Adjacent = new List<Node> {n8,n7,n3 };

            n.hurestic = 4;
            n1.hurestic = 3;
            n2.hurestic = 4;
            n3.hurestic = 2;
            n4.hurestic = 1;
            n5.hurestic = 0;

            GraphMap.Add(n);
            GraphMap.Add(n1);
            GraphMap.Add(n2);
            GraphMap.Add(n3);
            GraphMap.Add(n4);
            GraphMap.Add(n5);
            GraphMap.Add(n6);
            GraphMap.Add(n7);
            GraphMap.Add(n8);
            GraphMap.Add(n9);


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

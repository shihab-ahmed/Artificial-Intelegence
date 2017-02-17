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

        public Graph()
        {
            CreateGraph();
        }
       
        private void CreateGraph()
        {
            Node n = new Node();
            Node n1 = new Node();
            Node n2 = new Node();
            Node n3 = new Node();
            Node n4 = new Node();
            Node n5 = new Node();


            n.Name = "A";       
            n1.Name = "B";
            n2.Name = "C";
            n3.Name = "D";
            n4.Name = "E";
            n5.Name = "F";

            n.Adjacent = new List<Node> { n2,n3 };
            n1.Adjacent = new List<Node> {n2};    
            n2.Adjacent = new List<Node> { n,n1,n4};           
            n3.Adjacent = new List<Node> { n,n5 };          
            n4.Adjacent = new List<Node> {n2,n5 };           
            n5.Adjacent = new List<Node> { n3,n5 };

            GraphMap.Add(n);
            GraphMap.Add(n1);
            GraphMap.Add(n2);
            GraphMap.Add(n3);
            GraphMap.Add(n4);
            GraphMap.Add(n5);


        }
        public List<Node> getGraph()
        {
            return GraphMap;
        }
       
    }
}

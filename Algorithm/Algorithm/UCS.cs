using Lab4AI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    class UCS
    {
        Graph graph = new Graph();
        List<Node> graphList = new List<Node>();
        List<Node> exploredList = new List<Node>();
        List<Node> PriorityQueue = new List<Node>();

        public UCS()
        {
            graph.addPathCost();
            graphList = graph.getGraph();
            PriorityQueue.Add(graphList.First());
            doUCS();
            
        }
        public void doUCS()
        {
            Node n = getPriorityNode();
            



            
        }
        private Node getPriorityNode()
        {
            Node Temp = new Node();
            for (int i = 0; i < PriorityQueue.Count; i++)
            {
                if(PriorityQueue[i].TotalCost<=Temp.TotalCost)
                {
                    Temp= PriorityQueue[i];
                }
           
            }
            exploredList.Add(Temp);
           
            foreach (var item in Temp.Adjacent)
            {
                bool isInList = false;
                for (int i = 0; i < PriorityQueue.Count; i++)
                {
                    if(item==PriorityQueue[i])
                    {
                        isInList = true;
                    }

                }
                //for (int i = 0; i < exploredList.Count; i++)
                //{
                //    if (item == exploredList[i])
                //    {
                //        isInList = true;
                //    }
                //}
                if (!isInList)
                {
                    PriorityQueue.Add(item);
                    foreach (var neighbour in Temp.NeighbourPath)
                    {
                        if(neighbour.neighbour==item)
                        {
                            item.TotalCost = Temp.TotalCost + neighbour.cost;
                        }
                    }
                }
                PriorityQueue.Remove(Temp);
            }
           
            return Temp;
           
        }
    }
}

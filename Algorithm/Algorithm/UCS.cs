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
            getPriorityNode();
            if (PriorityQueue.Count != 0)
            {
                doUCS();
            }
            else
            {
                showPath();
            }

            
        }

        private void showPath()
        {
            foreach (var node in exploredList)
            {
                Console.WriteLine(node.Name+" cost is :"+node.TotalCost);
            }
        }
        private Node getPriorityNode()
        {
            Node Temp = PriorityQueue[0];
            for (int i = 0; i < PriorityQueue.Count; i++)
            {
                if(PriorityQueue[i].TotalCost<Temp.TotalCost)
                {
                    Temp= PriorityQueue[i];
                }
           
            }
            
       
           
            foreach (var item in Temp.Adjacent)
            {
                bool isInList = false;
                for (int i = 0; i < PriorityQueue.Count; i++)
                {
                    if(item==PriorityQueue[i])
                    {
                        isInList = true;
                        foreach (var neighbour in Temp.NeighbourPath)
                        {
                            if (neighbour.neighbour == item)
                            {
                                if (item.TotalCost >= Temp.TotalCost + neighbour.cost)
                                {
                                    item.TotalCost = Temp.TotalCost + neighbour.cost;
                                }
                            }
                        }
                    }
                   

                }
                for (int i = 0; i < exploredList.Count; i++)
               {
                   if (item == exploredList[i])
                    {
                       isInList = true;
                    }
                }
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
               
              
            }
            PriorityQueue.Remove(Temp);
            exploredList.Add(Temp);
            return Temp;
           
        }
    }
}

using Lab4AI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    class GraphColoring
    {
        Graph graph = new Graph();
        List<int> Color = new List<int>{1, 2, 3};
        List<Node> graphList = new List<Node>();
        public GraphColoring()
        {
             graphList = graph.getGraph();
             doGraphColoring(graphList, Color.Count);
        }
        public bool doGraphColoring(List<Node> graphList, int numberOfColor)
        {
            if (GraphColoringUntil(graphList, numberOfColor, 0) == false)
            {
                Console.WriteLine("Solution doesnt exist");
                return false;
            }
            printColor();
            return true;
        }

        private void printColor()
        {
            foreach (var item in graphList)
            {
                if (item.color.Equals(1)) Console.WriteLine("Red");
                if (item.color.Equals(2)) Console.WriteLine("Blue");
                if (item.color.Equals(3)) Console.WriteLine("Green");
               
            }
        }

        private bool GraphColoringUntil(List<Node> graphList, int numberOfColor, int numberOfNode)
        {
            if (numberOfNode == graphList.Count)
            {
                return true;
            }
            foreach (int ColorNo in Color)
            {
                if (IsSafe(numberOfNode, graphList, ColorNo))
                {
                    graphList.ElementAt<Node>(numberOfNode).color = ColorNo;
                    if (GraphColoringUntil(graphList, numberOfColor, numberOfNode + 1) == true)
                    {
                        return true;
                    }
                    graphList.ElementAt<Node>(numberOfNode).color = 0;
                }
            }
            return false;
        }

        private bool IsSafe(int numberOfNode, List<Node> graphList, int ColorNo)
        {
            foreach (var adjacent in graphList.ElementAt<Node>(numberOfNode).Adjacent )
            {
                if (adjacent.color.Equals(ColorNo))
                {
                    return false;
                }
            }
            return true;
        }
    }
}

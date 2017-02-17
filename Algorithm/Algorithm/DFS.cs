using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4AI
{
    public class DFS
    {
        Graph graph = new Graph();
        List<Node> graphList = new List<Node>();
        public DFS()
        {
            graphList = graph.getGraph();          
            doDFS(graphList.First());
        }
        private void doDFS(Node node)
        {
            if (!graphList.ElementAt<Node>(graphList.IndexOf(node)).isVisited)
            {
                graphList.ElementAt<Node>(graphList.IndexOf(node)).isVisited = true;
                Console.WriteLine(graphList.ElementAt<Node>(graphList.IndexOf(node)).Name + "\t");
                foreach (var item in graphList.ElementAt<Node>(graphList.IndexOf(node)).Adjacent)
                {
                    if (!item.isVisited)
                    {
                        doDFS(item);
                    }
                }
            }
        }

    }
}

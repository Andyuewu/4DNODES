using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    public class Matrix_Graph
    {
        private int Size;
        private double[,] Matrix;

        public Matrix_Graph(int size)
        {
            Size = size;
            Matrix = new double[Size, Size];
        }
        public void Print_Matrix()
        {
            Console.Write("    ");
            for (int k = 0; k < Matrix.Length / Size; k++)
            {
                Console.Write(k.ToString() + " | ");
            }
            Console.WriteLine();
            for (int i = 0; i < Matrix.Length / Size; i++)
            {
                Console.Write(i);
                for (int j = 0; j < Matrix.Length / Size; j++)
                {
                    Console.Write(" + " + Matrix[i, j]);
                }
                Console.WriteLine(" |");
            }
        }
        public double[,] Get_Matrix()
        {
            return Matrix;
        }
        public string Matrix_String()
        {
            string str = "    ";
            for (int k = 0; k < Matrix.Length / Size; k++)
            {
                str += k.ToString() + " | ";
            }
            str += "\n";
            for (int i = 0; i < Matrix.Length / Size; i++)
            {
                str += i.ToString();
                for (int j = 0; j < Matrix.Length / Size; j++)
                {
                    str += " + " + Matrix[i, j].ToString();
                }
                str += " |\n";
            }
            return str;
        }
        public void AddEdge(int node1, int node2, double weight)
        {
            Matrix[node1, node2] = weight;
            Matrix[node2, node1] = weight;
        }
        public void Add_Directional_Edge(int from, int too, double weight)
        {
            Matrix[from, too] = weight;
        }
        public List<int> Directly_Accessible_Nodes(int start)
        {
            List<int> nodes = new List<int>();
            for (int i = 0; i < Matrix.Length / Size; i++)
            {
                if (Matrix[start, i] > 0)
                {
                    nodes.Add(i);
                }
            }
            return nodes;
        }
        public double Weight_OF_Path(List<int> nodes)
        {
            double Weight = 0;
            for (int i = 1; i < nodes.Count; i++)
            {
                if (Matrix[nodes[i - 1], nodes[i]] != 0)
                {
                    Weight += Matrix[nodes[i - 1], nodes[i]];
                }
                else
                {
                    return 0;
                }
            }
            return Weight;
        }
        public List<int> depthFirst(int startnode)
        {
            List<int> visited = new List<int>();
            Stack<int> toVisit = new Stack<int>();
            visited.Add(startnode);
            toVisit.Push(startnode);
            int goVisit = startnode;
            while (toVisit != null)
            {
                for (int i = 0; i < Matrix.Length / Size; i++)
                {
                    if (Matrix[goVisit, i] != 0)
                    {
                        visited.Add(i);
                        toVisit.Push(i);
                    }
                    else
                    {
                        goVisit = toVisit.Pop();
                    }

                }
            }
            return visited;
        }
        private const double infinity = double.MaxValue;
        private int LowestCostUnvisitedNode(List<bool> visited, List<double> cost) //Modify the signature to pass in the two arrays holding the visited markers, and the costs
        {
            // Set a 'lowest cost so far' variable to infinity (use the constant again!)
            double lowestCostSoFar = infinity;
            // Set a 'lowest cost node' number to zero  (could actually be anything)
            int LowestCostNode = 0;
            // Loop through all the nodes in the graph
            for (int i = 0; i < Matrix.Length; i++)
            {
                if (visited[i] = false & cost[i] < lowestCostSoFar)
                {
                    LowestCostNode = i;
                    lowestCostSoFar = cost[i];
                }
            }
            // - If the node is not yet visited AND the cost to get to that unvisited node is less than the lowest cost so far
            //   - Set the 'lowest cost node' to the current node in the loop
            //   - Set the 'lowest cost so far' to the cost for that node
            return LowestCostNode;
        }
        //Calculates total cost of specified route of nodes visited, by adding values of the edges.
        //Assume the route provided is valid (i.e. an edge exists between each pair of nodes).
        //So if it is not a valid route an error may occur.
        public double TotalCostOfRoute(List<int> nodesFollowed)
        {
            double cost = 0;
            for (int i = 0; i < nodesFollowed.Count - 1; i++)
            {
                for (int v = 0; v < nodesFollowed.Count; v++)
                {
                    cost = cost + Matrix[i, v];
                }
            }
            return cost;
        }
        public List<int> Neighbours(int fromNode)
        {
            var list = new List<int>();
            for (int i = 0; i < Matrix.Length; i++)
            {
                if (Matrix[fromNode, i] != 0)
                {
                    list.Add(i);
                }
            }
            return list;
        }
        public bool allvisited(List<bool> visited)
        {
            foreach (var item in visited)
            {
                if (item == false)
                {
                    return false;
                }
            }
            return true;
        }
    }

}

using System.IO;

namespace Graph
{   //finds a shortest path from source; moves 1 step in all directions before progressing further therefore only the first time a V's is accessed in anydirection is recorded on Edgeto array
    class Program
    {
        static void Main(string[] args)
        {
            //set up the graph using the data from input file
            string filepath = @"C:\Users\beth.hart\source\repos\Algorithms\algs4-data\tinyCG.txt";
            string[] input = File.ReadAllLines(filepath);
            Graph g = new Graph(input);


            //call to Breadth First paths alg which sets up additional structures to process paths from source to V;
            //and provides access to the properties of the the graph
            int source = 0;
            var bfs = new BreadthFirstPath(g, source);

            //takes a vertex on the graph and returns the path back to source
            var path = bfs.PathTo(5);
            foreach(var v in bfs.PathTo(4))
            {
                System.Console.Write(v + " ");
            }

            
        }
    }
}

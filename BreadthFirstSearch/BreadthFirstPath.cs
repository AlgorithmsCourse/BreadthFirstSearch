using System.Collections.Generic;

namespace Graph
{   //finds a shortest path from source; moves 1 step in all directions before progressing further therefore only the first time a V's is accessed in anydirection is recorded on Edgeto array
    class BreadthFirstPath
    {
        bool[] _marked;  //keeps track of vistied v's
        int[] _edgeTo;   //traces a path from each v back to source
        int _source; //tracks the source
        

        //ctor init all data structures and fields, call search method (bfs())
        public BreadthFirstPath(Graph g, int source)
        {
            _edgeTo = new int[g.V];
            _source = source;
            _marked = new bool[g.V];
            bfs(g, source);
        }

        //process the graph and add values to data stuructures
        private void bfs(Graph g, int source)
        {
            Queue<int> queue = new Queue<int>();
            //start by marking source and loading to queue
            _marked[source] = true;
            queue.Enqueue(source);

            //deque next member, then iterate through adj list and if not marked -- mark, record source in edge to, add to queue
            while (queue.Count > 0)
            {
                var s = queue.Dequeue();
                foreach(var v in g.adj[s])
                {
                    if (!_marked[v])
                    {
                        _marked[v] = true;
                        _edgeTo[v] = s;
                        queue.Enqueue(v);
                    }
                }
            }
        }

        //QUERY THE COMPLETED STRUCTURE FROM CLIENT
        public bool HasPath(int v)
        {
            return _marked[v];
        }
        public IEnumerable<int> PathTo(int v)
        {

            if (HasPath(v))
            {
                var path = new Stack<int>();
                path.Push(v);
                for (int i = v; i != _source; i = _edgeTo[i])
                {
                    path.Push(_edgeTo[i]);
                }
                return path;
            } else return null;
        }
        
    }
}

using System;
using System.Collections.Generic;

namespace Graph
{
    // takes input and creates a repr of a graph consisting of and array of each vertex pointing to a linked list of all connecting Verticies.
    public class Graph
    {
        public int E { get; set; }
        public int V { get; }
        public LinkedList<int>[] adj;
        
        
        //ctor takes number of verticies and inits LL array and sets V field.
        public Graph(int v)
        {
            V = v;
            adj = new LinkedList<int>[v];
            for (var i = 0; i < v; i++)
            {
                adj[i] = new LinkedList<int>();
            }
        }

        //ctor takes input and parses it to extract Num of V's to call Graph(), and Edges to call Add Edge.
        //this ctor is specific to the fomat of the input provided, a string array where [0] is nume of V's, [1] is num of E's, and remaining lines are pairs of V's repr an E.
        public Graph(string[] input) : this(Convert.ToInt32(input[0]))
        {
            
            for (int i = 2; i < input.Length; i++)
            {
                string[] tempA = (input[i].Split());
                int v = Convert.ToInt32(tempA[1]);
                int w = Convert.ToInt32(tempA[0]);
                AddEdge(v, w);
            }

        }
        public void AddEdge(int v, int w)
        {
            adj[v].AddLast(w);
            adj[w].AddLast(v);
            E++;
        }
    }
}

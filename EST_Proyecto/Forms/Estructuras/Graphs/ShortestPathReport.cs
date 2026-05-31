using System;
using System.Collections.Generic;
using System.Text;

namespace EST_Proyecto.Forms.Estructuras.Graphs
{
    public class RelaxationStep
    {
        public int From;
        public int To;
        public double CandidateDistance;
        public bool Updated;

        public RelaxationStep(int from,int to, double candidateDistance,     bool updated)
        {
            From = from;
            To = to;
            CandidateDistance = candidateDistance;
            Updated = updated;
        }
    }

    public class TraceSnapshot
    {
        public int ExtractedVertex;

        public double[] Distances;

        public int[] Previous;

        public LinkedListaQueue<RelaxationStep> Relaxations;

        public TraceSnapshot(
            int extractedVertex,
            double[] distances,
            int[] previous)
        {
            ExtractedVertex = extractedVertex;

            Distances = distances;
            Previous = previous;

            Relaxations = new LinkedListaQueue<RelaxationStep>();
        }
    }

    public class ShortestPathReport
    {
        public double[] Distances;

        public int[] Previous;

        public LinkedListaQueue<TraceSnapshot> Trace;

        public ShortestPathReport(
            double[] distances,
            int[] previous)
        {
            Distances = distances;
            Previous = previous;

            Trace = new LinkedListaQueue<TraceSnapshot>();
        }
    }
}

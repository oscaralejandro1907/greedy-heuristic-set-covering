namespace SetCovering
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Data data = new Data();
            GreedyHeuristic heuristic = new GreedyHeuristic(data);
            heuristic.Solve();
            heuristic.Print();
        }
    }
}

//https://www.youtube.com/watch?v=Hw_IAYqtrLI
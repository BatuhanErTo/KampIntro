using System;

namespace MultipleImplementation // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IWorker> workers = new List<IWorker>() { new Robot(), new Worker(), new Manager()};
            List<IEat> workers2 = new List<IEat>() { new Worker() };
        }
    }
}
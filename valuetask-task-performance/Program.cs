using BenchmarkDotNet.Running;
using System;

namespace valuetask_task_performance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<MemoryBenchmark>();
        }
    }
}

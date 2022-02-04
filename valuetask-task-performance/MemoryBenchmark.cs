using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace valuetask_task_performance
{
    [MemoryDiagnoser]
    public class MemoryBenchmark
    {
        GitHubServices gitHubServices = new GitHubServices();
        [Benchmark]
        public async Task RunTaskWithOutCache()
        {

            string name = "trumboosahil";
            for (int i = 0; i < 1000; i++)
            {
                var repos = await gitHubServices.GetRepositriesAsyncBy_Task_WithOutCache(name);
            }

        }
        [Benchmark]
        public async Task RunValueTaskWithOutCache()
        {

            string name = "trumboosahil";
            for (int i = 0; i < 1000; i++)
            {
                var repos = await gitHubServices.GetRepositriesAsyncBy_ValueTask_WithOutCache(name);
            }

        }
        [Benchmark]
        public async Task RuntaskWithCache()
        {

            string name = "trumboosahil";
            for (int i = 0; i < 1000; i++)
            {
                var repos = await gitHubServices.GetRepositriesAsyncBy_Task(name);
            }

        }
        [Benchmark]
        public async Task RunValuetaskWithCache()
        {

            string name = "trumboosahil";
            for (int i = 0; i < 1000; i++)
            {
                var repos = await gitHubServices.GetRepositriesAsyncBy_ValueTask(name);
            }

        }
    }
}

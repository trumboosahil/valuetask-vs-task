using Microsoft.Extensions.Caching.Memory;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace valuetask_task_performance
{

    public class GitHubServices
    {
        readonly HttpClient httpClient = new HttpClient();
        IMemoryCache memoryCache = new MemoryCache(new MemoryCacheOptions());
        public GitHubServices()
        {
            httpClient.DefaultRequestHeaders.UserAgent.ParseAdd("Valuetask");
        }
        public async Task<string> GetRepositriesAsyncBy_Task_WithOutCache(string username)
        {

            var resultjson = await httpClient.GetStringAsync($"http://localhost:7071/api/Function1?name={username}");

            return resultjson;
        }
        public async ValueTask<string> GetRepositriesAsyncBy_ValueTask_WithOutCache(string username)
        {

            var resultjson = await httpClient.GetStringAsync($"http://localhost:7071/api/Function1?name={username}");

            return resultjson;
        }
        public async Task<string> GetRepositriesAsyncBy_Task(string username)
        {
            var gitrepositry = memoryCache.Get<string>(username);
            if (gitrepositry != null)
            {
                return gitrepositry;
            }

            var resultjson = await httpClient.GetStringAsync($"http://localhost:7071/api/Function1?name={username}");
            
            memoryCache.Set(username, resultjson, TimeSpan.FromHours(4));

            return resultjson;
        }

        public async ValueTask<string> GetRepositriesAsyncBy_ValueTask(string username)
        {
            var gitrepositry = memoryCache.Get<string>(username);
            if (gitrepositry != null)
            {
                return gitrepositry;
            }

            var resultjson = await httpClient.GetStringAsync($"http://localhost:7071/api/Function1?name={username}");

            memoryCache.Set(username, resultjson, TimeSpan.FromHours(4));

            return resultjson;
        }
    }
}

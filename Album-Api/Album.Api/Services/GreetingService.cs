using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Album.Api.Services
{
    public class GreetingService
    {
        public string GetGreeting(string? name = "World")
        {
            Program.Log($"GetGreeting method, parameter name = {name}");
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrEmpty(name))
            {
                return $"Hello World";
            }
            Program.Log($"Return GetGreeting method : Hello {name}");
            return $"Hello {name} from {Dns.GetHostName()} v2";
        }

    }
}
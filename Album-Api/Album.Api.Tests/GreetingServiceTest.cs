using Album.Api.Services;
using System;
using System.Net;
using Xunit;

namespace Album.Api.Tests
{
    public class GreetingServiceTest
    {
        [Fact]
        public void GreetingServiceNameTest()
        {
            //ARRANGE
            var GreetService = new GreetingService();
            string name = "Salar";
            //ACT
            var nameTest = GreetService.GetGreeting(name); //Check for Name
            //ASSERT
            Assert.Equal($"Hello Salar from {Dns.GetHostName()} v2", nameTest);
        }

        [Fact]
        public void GreetingServiceNullTest()
        {
            //ARRANGE
            var GreetService = new GreetingService();
            //ACT
            var nullTest = GreetService.GetGreeting(null); //Check for Null
            //ASSERT
            Assert.Equal($"Hello World", nullTest);
        }

        [Fact]
        public void GreetingServiceEmptyTest()
        {
            //ARRANGE
            var GreetService = new GreetingService();
            //ACT
            var emptyTest = GreetService.GetGreeting("");  //Check for empty
            //ASSERT
            Assert.Equal($"Hello World", emptyTest);
        }

        [Fact]
        public void GreetingServiceWhitespaceTest()
        {
            //ARRANGE
            var GreetService = new GreetingService();
            //ACT
            var whitespaceTest = GreetService.GetGreeting("  "); //Check for whitespace
            //ASSERT
            Assert.Equal($"Hello World", whitespaceTest);
        }
    }
}
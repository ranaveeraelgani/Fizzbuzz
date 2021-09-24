using System;
using Xunit;
using FizzBuzz;
using FizzBuzz.Pages;
using System.Collections.Generic;

namespace FizzBuzzTesting
{
    public class FizzbuzzUnitTest
    {
        [Fact]
        public void Test1()
        {            
            var ff = new FizzbuzzModel();
            ff.fbvalues = "1,3,a,15,5";
            ff.OnPost();
            var actualval = ff.result_list;
            var expectedval = new List<string> { "Divided 1 by 3", "Divided 1 by 5", "Fizz", "Invalid Item", "FizzBuzz","Buzz" };
            Assert.Equal(expectedval,actualval);
        }
    }
}

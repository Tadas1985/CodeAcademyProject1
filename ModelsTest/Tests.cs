using System;
using Xunit;
using Models;

namespace ModelsTest
{
    public class Tests
    {
        [Fact]
        public void CheckIfMethod_ToString_GeneratesString()
        {
            Candies candy = new Candies("test",1,2,3,4);
             
            
            Assert.Equal("test", candy.ToString(candy.Name));
        }
    }
}

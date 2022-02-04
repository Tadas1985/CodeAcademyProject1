using System;
using Xunit;
using Models;
using System.Collections.Generic;

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
        
        [Fact]
        public void TestIfMethod_WelcomeToStore_ValidatesCorrectInput()
        {
            StoreSimulation simulation = new StoreSimulation();
            int value1 = 1;
            simulation.WelcomeToStore();
            Assert.Equal(value1, simulation.WelcomeToStore());
        }
        
        [Fact]
        public void Test_ValdidatorOfUserInput_ValidatesCorrectValues()
        {
            int value1 = 1;
            StoreSimulation simulation = new StoreSimulation();
             var result =simulation.ValdidatorOfUserInput();
            Assert.Equal(value1, result);
        }
        
    }
    
}

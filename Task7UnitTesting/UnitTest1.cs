
namespace Task7UnitTesting.Tests
{
    public class CalcsTests
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(2, Calcs.Div(43, 21));
        }
        [Fact]
        public void Test2()
        {
            Assert.Equal(-1, Calcs.Div(87, -56));
        }
        [Fact]
        public void Test3()
        {
            Assert.Equal(-4, Calcs.Div(-9, 2));
        }
        [Fact]
        public void Test4()
        {
            Assert.Equal(86, Calcs.Div(-4321, -50));
        }
        [Fact]
        public void Test5()
        {
            Assert.Equal(0, Calcs.Div(0, 1234567890));
        }
        [Fact]
        public void Test6()
        {
            Assert.Equal(0, Calcs.Div(0, -1098765432));
        }
        [Fact]
        public void Test7()
        {
            Assert.Equal(22605091, Calcs.Div(2147483647, 95));
        }
        [Fact]
        public void Test8()
        {
            Assert.Equal(-238609294, Calcs.Div(-2147483648, 9));
        }
        [Fact]
        public void Test9()
        {
            Assert.Equal(0, Calcs.Div(99, 2147483647));
        }
        [Fact]
        public void Test10()
        {
            Assert.Equal(0, Calcs.Div(-87, -2147483648));
        }
        [Fact]
        public void Test11()
        {
            Assert.Equal(-1, Calcs.Div(-2147483648, 2147483647));
        }
        [Fact]
        public void Test12()
        {
            Assert.Equal(1, Calcs.Div(2147483647, 2147483647));
        }
        [Fact]
        public void Test13()
        {
            Assert.Equal(1, Calcs.Div(-2147483648, -2147483648));
        }
        [Fact]
        public void Test14()
        {
            Assert.Equal(0, Calcs.Div(2147483647, -2147483648));
        }
    }
}
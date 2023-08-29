
using Xunit;

namespace XUnitDemo1
{
    public class UnitTest2
    {
        [Theory]
        [InlineData(3)]
        [InlineData(100)]
        [InlineData(6)]
        public void PassingTHeory(int value)
        {

            Assert.True(MayorA5(value));

        }

        [Theory]
        [InlineData(3)]
        public void PassingTHeory2(int value)
        {

            Assert.True(MayorA5(value));

        }


        public bool MayorA5(int value)
        {
            if(value > 5)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}

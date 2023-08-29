namespace XUnitDemo1
{

    //[TestCaseOrderer("TestOrderExamples.TestCaseOrdering.PriorityOrderer", "TestOrderExamples")]

    public class UnitTest1
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        [Fact]
        public void Passingtest()
        {
            Assert.Equal(4, Add(2,2));
        }

        [Fact]
        public void FailingTest()
        {

            Assert.Equal(5, Add(2, 2));

        }
    }
}
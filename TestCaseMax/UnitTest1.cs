using Generics_Program;

namespace TestCaseMax
{
    public class Tests
    {
        FindMaxGenric<int> genericMthodForInt = new FindMaxGenric<int>();


        [Test]
        public void GivenMaxFirstNum_WhenAnalysed_ShouldReturnFirstMax_Int()
        {
            int result = genericMthodForInt.GenricValue(20, 10, 17);
            Assert.AreEqual(20, result);
            //Assert.Pass();
        }
        [Test]
        public void GivenMaxFirstNum_WhenAnalysed_ShouldReturnSecondMax_Int()
        {
            int result = genericMthodForInt.GenricValue(26, 30, 17);
            Assert.AreEqual(30, result);
            //Assert.Pass();

        }
        [Test]
        public void GivenMaxFirstNum_WhenAnalysed_ShoulReturnThirdMax_Int()
        {
            int result = genericMthodForInt.GenricValue(20, 10, 17);
            Assert.AreEqual(20, result);
            //Assert.Pass();
        }
    }
}
using Generics_Program;

namespace TestCaseMax
{
    public class Tests
    {
        FindMaxGenric<int> genericMthodForInt = new FindMaxGenric<int>();
        FindMaxGenric<string> genericMthodForString = new FindMaxGenric<string>();
        FindMaxGenric<double> genericMthodForFloat = new FindMaxGenric<double>();



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
        public void GivenMaxFirstNum_WhenAnalysed_ShouldReturnFirstMax_string()
        {
            string result = genericMthodForString.GenricValue("Mumbai", "Pune", "Rajasthan");
            Assert.AreEqual("Pune", result);
            //Assert.Pass();
        }
        [Test]
        public void GivenMaxFirstNum_WhenAnalysed_ShouldReturnSecondMax_string()
        {
            string result = genericMthodForString.GenricValue("Mumbai", "Pune", "Rajasthan");
            Assert.AreEqual("Mumbai", result);
            //Assert.Pass();
        }
        [Test]
        public void GivenMaxFirstNum_WhenAnalysed_ShouldReturnthridMax_string()
        {
            string result = genericMthodForString.GenricValue("Mumbai", "Pune", "Rajasthan");
            Assert.AreEqual("Rajasthan", result);
            //Assert.Pass();
        }
        [Test]
        public void GivenMaxFirstNum_WhenAnalysed_ShouldReturnfirstMax_double()
        {
            double result = genericMthodForFloat.GenricValue(1.2, 3.4, 9.9);
            Assert.AreEqual(9.9, result);
            //Assert.Pass();
        }
        [Test]
        public void GivenMaxFirstNum_WhenAnalysed_ShouldReturnSecondMax_double()
        {
            double result = genericMthodForFloat.GenricValue(1.2, 3.4, 9.9);
            Assert.AreEqual(3.4, result);
            //Assert.Pass();
        }
    }
}
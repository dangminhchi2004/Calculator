using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace CalculatorTester
{
    [TestClass]
    public class UnitTest1
    {
        private Caculation c,d;
        public TestContext TestContext { get; set; }
        [TestInitialize]//thiet lap DL dung chung cho testcase
        public void SetUp()
        {
            c = new Caculation(20, 4);
            d = new Caculation(19, 6);
        }
        [TestMethod]//1 testcase
        public void TestAdd1Operator()
        {
            int expected, actual;
            expected = 24;
            actual = c.Exectute("+");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]//1 testcase
        public void TestAdd2Operator()
        {
            int expected, actual;
            expected = 23;
            actual = d.Exectute("+");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]//1 testcase
        public void TestSub1Operator()
        {
            int expected, actual;
            expected = 16;
            actual = c.Exectute("-");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]//1 testcase
        public void TestSub2Operator()
        {
            int expected, actual;
            expected = 15;
            actual = d.Exectute("-");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]//1 testcase
        public void TestMul1Operator()
        {
            int expected, actual;
            expected = 80;
            actual = c.Exectute("*");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]//1 testcase
        public void TestMul2Operator()
        {
            int expected, actual;
            expected = 100;
            actual = d.Exectute("*");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]//1 testcase
        public void TestDiv1Operator()
        {
            int expected, actual;
            expected = 5;
            actual = c.Exectute("/");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]//1 testcase
        public void TestDiv2Operator()
        {
            int expected, actual;
            expected = 6;
            actual = d.Exectute("/");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]//1 testcase\
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestDivByZero()
        {
            c = new Caculation(10, 0);           
            c.Exectute("/");
        }
        //[Timeout()] thiet lap timeout khi thuc hien testcase
        //[Ignore] tam thoi bo qua testcase

        //Liên kết với project
        [TestMethod]//1 testcase\
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @".\Data\TestData.csv", "TestData#csv",
            DataAccessMethod.Sequential)]
        public void TestWithDataSource()
        {
            int a, b, expected, actual;
            string operation;
            a = int.Parse(TestContext.DataRow[0].ToString());
            b = int.Parse(TestContext.DataRow[1].ToString());
            operation = (TestContext.DataRow[2].ToString());
            operation = operation.Remove(0, 1);
            expected = int.Parse(TestContext.DataRow[3].ToString());
            c= new Caculation(a,b);
            actual = c.Exectute(operation);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]//1 testcase\
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @".\Data\PowerTestData.csv", "PowerTestData#csv",
            DataAccessMethod.Sequential)]
        public void TestPower()
        {
            int n;
            double actual;
            double x, expected;
            n = int.Parse(TestContext.DataRow[1].ToString());
            x = double.Parse(TestContext.DataRow[0].ToString());
            expected = double.Parse(TestContext.DataRow[2].ToString());
            actual = Caculation.Power(x, n);
            Assert.AreEqual(expected, actual);
        }
    }
}

using NUnit.Framework;
using ClassLibrary1;

namespace NUnitTestProject1
{
    class UnitTest2
    {
        [Test]

        public void checkEqualMinus1()
        {
            var myfxncresult = functionlb2.function(-1);
            var sysfxresult = functionlb2.functionSys(-1);

            Assert.AreEqual(myfxncresult, sysfxresult, 0.1);
        }

        [Test]
        public void checkEqualMinus2()
        {
            var myfxncresult = functionlb2.function(-2);
            var sysfxresult = functionlb2.functionSys(-2);

            Assert.AreEqual(myfxncresult, sysfxresult, 0.1);
        }

        [Test]
        public void checkEqualMinus10()
        {
            var myfxncresult = functionlb2.function(-10);
            var sysfxresult = functionlb2.functionSys(-10);

            Assert.AreEqual(myfxncresult, sysfxresult, 0.1);
        }

        [Test]
        public void checkEqualPlus1()
        {
            var myfxncresult = functionlb2.function(1);
            var sysfxresult = functionlb2.functionSys(1);

            Assert.AreEqual(myfxncresult, sysfxresult, 0.1);
        }

        [Test]
        public void checkEqualPlus2()
        {
            var myfxncresult = functionlb2.function(2);
            var sysfxresult = functionlb2.functionSys(2);

            Assert.AreEqual(myfxncresult, sysfxresult, 0.1);
        }

        [Test]
        public void checkEqualPlus10()
        {
            var myfxncresult = functionlb2.function(10);
            var sysfxresult = functionlb2.functionSys(10);

            Assert.AreEqual(myfxncresult, sysfxresult, 0.1);
        }

        [Test]
        public void checkEqualPlus5()
        {
            var myfxncresult = functionlb2.function(5);
            var sysfxresult = functionlb2.functionSys(5);

            Assert.AreEqual(myfxncresult, sysfxresult, 0.1);
        }

        [Test]
        public void checkEqualMinus5()
        {
            var myfxncresult = functionlb2.function(-5);
            var sysfxresult = functionlb2.functionSys(-5);

            Assert.AreEqual(myfxncresult, sysfxresult, 0.1);
        }

        public void TestMinus1()
        {
            var actual = functionlb2.function(-1);
            var expected = 0.8827012;

            Assert.AreEqual(expected, actual, 0.1);
        }

        [Test]
        public void TestMinus2()
        {
            var actual = functionlb2.function(-2);
            var expected = 1.66458;

            Assert.AreEqual(expected, actual, 0.1);
        }

        [Test]
        public void TestMinus10()
        {
            var actual = functionlb2.function(-10);
            var expected = 3.55099;

            Assert.AreEqual(expected, actual, 0.1);
        }

        [Test]
        public void TestPlus1()
        {
            var actual = functionlb2.function(1);
            var expected = double.NaN;

            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void TestPlus2()
        {
            var actual = functionlb2.function(2);
            var expected = -0.18634;

            Assert.AreEqual(expected, actual, 0.1);
        }

        [Test]
        public void TestPlus5()
        {
            var actual = functionlb2.function(5);
            var expected = -2.50424;

            Assert.AreEqual(expected, actual, 0.1);
        }

        [Test]
        public void TestPlus10()
        {
            var actual = functionlb2.function(10);
            var expected = -5.48324;

            Assert.AreEqual(expected, actual, 0.1);
        }
    }
}

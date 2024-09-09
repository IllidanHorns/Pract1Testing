using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Pract1Testing.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Result_check_0()
        {
            //arrange
            string a = "";

            //act
            CheckText check = new CheckText();
            check.checkNumber(a);
            check.checkMore10Letters(a);
            check.checkCapital(a);
            check.checkLowercase(a);
            check.checkSpecial(a);

            //assert
            Assert.AreEqual(0, check.scoreCounter);
        }

        [TestMethod]
        public void Result_check_1()
        {
            //arrange
            string a = "123";

            //act
            CheckText check = new CheckText();
            check.checkNumber(a);
            check.checkMore10Letters(a);
            check.checkCapital(a);
            check.checkLowercase(a);
            check.checkSpecial(a);

            //assert
            Assert.AreEqual(1, check.scoreCounter);
        }

        [TestMethod]
        public void Result_check_2()
        {
            //arrange
            string a = "123ASD";

            //act
            CheckText check = new CheckText();
            check.checkNumber(a);
            check.checkMore10Letters(a);
            check.checkCapital(a);
            check.checkLowercase(a);
            check.checkSpecial(a);

            //assert
            Assert.AreEqual(2, check.scoreCounter);
        }

        [TestMethod]
        public void Result_check_3()
        {
            //arrange
            string a = "123ASDasd";

            //act
            CheckText check = new CheckText();
            check.checkNumber(a);
            check.checkMore10Letters(a);
            check.checkCapital(a);
            check.checkLowercase(a);
            check.checkSpecial(a);

            //assert
            Assert.AreEqual(3, check.scoreCounter);
        }

        [TestMethod]
        public void Result_check_4()
        {
            //arrange
            string a = "123ASDas!";

            //act
            CheckText check = new CheckText();
            check.checkNumber(a);
            check.checkMore10Letters(a);
            check.checkCapital(a);
            check.checkLowercase(a);
            check.checkSpecial(a);

            //assert
            Assert.AreEqual(4, check.scoreCounter);
        }

        [TestMethod]
        public void Result_check_5()
        {
            //arrange
            string a = "3as!@Sd4%";

            //act
            CheckText check = new CheckText();
            check.checkNumber(a);
            check.checkMore10Letters(a);
            check.checkCapital(a);
            check.checkLowercase(a);
            check.checkSpecial(a);

            //assert
            Assert.AreEqual(5, check.scoreCounter);
        }
    }
}

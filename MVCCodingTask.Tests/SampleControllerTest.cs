using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MVCCodingTask;
using MVCCodingTask.Controllers;

namespace MVCCodingTask.Tests
{
    [TestClass]
    public class SampleControllerTest
    {
        [TestMethod]
        public void getNaturalNumberTest()
        {
            SampleController controller = new SampleController();

            Assert.AreEqual(controller.getNaturalNumber(5), "0,1,2,3,4,5");
        }

        [TestMethod]
        public void getEvenOddNumberTest()
        {
            SampleController controller = new SampleController();

            Assert.AreEqual(controller.getEvenOddNumber(5, true), "2,4");
            //Assert.AreEqual(controller.getEvenOddNumber(5, false), "1,3,5");
        }

        [TestMethod]
        public void getAlphaNumberTest()
        {
            SampleController controller = new SampleController();

            Assert.AreEqual(controller.getAlphaNumber(5), "0,1,2,C,4,E");
        }

        [TestMethod]
        public void getFibonacciTest()
        {
            SampleController controller = new SampleController();

            Assert.AreEqual(controller.getFibonacci(5), "0,1,1,2,3,5");
        }
    }
}

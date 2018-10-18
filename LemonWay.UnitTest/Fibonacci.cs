using LemonWay.UnitTest.ServiceReferenceUnitTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonWay.UnitTest
{
    [TestClass]
    public class Fibonacci
    {
        //service
        public static LemonWayWebServiceSoapClient service = new LemonWayWebServiceSoapClient();

        [TestMethod]
        public void Fibonacci1() //Test 1/4
        {
            int returnedValue = service.Fibonacci(101);
            Assert.AreEqual(-1, returnedValue);
        }

        [TestMethod]
        public void Fibonacci2() //Test 2/4
        {
            int returnedValue = service.Fibonacci(5);
            Assert.AreEqual(5, returnedValue);
        }

        [TestMethod]
        public void Fibonacci3() //Test 3/4
        {
            int returnedValue = service.Fibonacci(6);
            Assert.AreEqual(8, returnedValue);
        }

        [TestMethod]
        public void Fibonacci4() //Test 4/4
        {
            int returnedValue = service.Fibonacci(10);
            Assert.AreNotEqual(8, returnedValue);
        }
    }
}

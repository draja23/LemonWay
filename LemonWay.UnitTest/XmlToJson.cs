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
    public class XmlToJson
    {
        //Service
        public static LemonWayWebServiceSoapClient service = new LemonWayWebServiceSoapClient();

        [TestMethod]
        public void XmlToJson1() //Test 1/2
        {
            String xmlString = "<foo>bar</footer>";
            var returnedString = service.XmlToJson(xmlString);
            Assert.AreEqual("Bad Xml format", returnedString);
        }

        [TestMethod]
        public void XmlToJson2() //Test 1/2
        {
            String xmlString = "<foo>bar</foo>";
            var returnedString = service.XmlToJson(xmlString);
            Assert.AreEqual("{\"foo\":\"bar\"}", returnedString);
        }
    }
}

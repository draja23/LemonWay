using LemonWay.ConsumeWS.ConsoleApp.ServiceReferenceConsoleApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonWay.ConsumeWS.ConsoleApp
{
    class Program
    {
        //Logger
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        //Service reference
        public static LemonWayWebServiceSoapClient service = new LemonWayWebServiceSoapClient();
        static void Main(string[] args)
        {
            log.Info("ConsoleApp : Calling FibonacciClient Method - START");
            //method FibonacciClient           
            FibonacciClientAsync(6); //Call async method
            FibonacciClient(6); //Call Non async method
            log.Info("ConsoleApp : Calling FibonacciClient Method - END");
            log.Info("ConsoleApp : Calling XmlToJsonClient Method - START");
            //Method XmlToJsonClient
            String xmlString = "<TRANS><HPAY><ID>103</ID><STATUS>3</STATUS><EXTRA><IS3DS>0</IS3DS><AUTH>031183</AUTH></EXTRA><INT_MSG/><MLABEL>501767XXXXXX6700</MLABEL><MTOKEN>project01</MTOKEN></HPAY></TRANS>";
            XmlToJsonClientAsync(xmlString); //async
            XmlToJsonClient(xmlString);
            log.Info("ConsoleApp : Calling XmlToJsonClient Method - END");
            Console.Read();
        }

        /// <summary>
        ///  Method calls a Web service (calling a method XmlToJson)
        /// The XmlToJson service takes input a string xml and returns the json form of the xml string, 
        /// It will return "Bad Xml format" if the input string is not a well-formed xml
        /// </summary>
        /// <param name="xString">XML en string</param>       
        /// <returns> string au format JSON</returns>
        static void XmlToJsonClient(string xString)
        {
            var returnedString = service.XmlToJson(xString); //CALLING A SERVICE WEB
            Console.WriteLine(returnedString);
        }

        /// <summary>
        /// Method calls a Web service (calling a method Fibonacci)
        /// The Fibonacci service takes input an integer N, and return the Nth value in the Fibonacci sequence
        /// </summary>
        /// <param name="val">nombre entier</param>       
        /// <returns>Résultat de Fibonacci en entier</returns>
        static void FibonacciClient(int val)
        {
            int returnedValue = service.Fibonacci(val); //CALLING A SERVICE WEB
            Console.WriteLine(returnedValue);
        }


        /// <summary>
        /// ASYNC Method calls a Web service (calling a method XmlToJson)
        /// The XmlToJson service takes input a string xml and returns the json form of the xml string, 
        /// It will return "Bad Xml format" if the input string is not a well-formed xml
        /// </summary>
        /// <param name="xString">XML en string</param>       
        /// <returns> string au format JSON</returns>
        async static void XmlToJsonClientAsync(string xString)
        {
            var returnedString = await service.XmlToJsonAsync(xString); //CALLING A SERVICE WEB
            Console.WriteLine(returnedString.Body.XmlToJsonResult);
        }

        /// <summary>
        /// ASYNC Method calls a Web service (calling a method Fibonacci)
        /// The Fibonacci service takes input an integer N, and return the Nth value in the Fibonacci sequence
        /// </summary>
        /// <param name="val">nombre entier</param>       
        /// <returns>Résultat de Fibonacci en entier</returns>
        async static void FibonacciClientAsync(int val)
        {
            int returnedValue = await service.FibonacciAsync(val); //CALLING A SERVICE WEB
            Console.WriteLine(returnedValue);
        }

    }
}

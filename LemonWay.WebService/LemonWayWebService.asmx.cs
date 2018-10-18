using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Xml;

namespace LemonWay.WebService
{
    /// <summary>
    /// Description résumée de LemonWayWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Pour autoriser l'appel de ce service Web depuis un script à l'aide d'ASP.NET AJAX, supprimez les marques de commentaire de la ligne suivante. 
    // [System.Web.Script.Services.ScriptService]
    public class LemonWayWebService : System.Web.Services.WebService
    {
        //Logger
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        /// <summary>
        /// The Fibonacci service takes input an integer N, and return the Nth value in the Fibonacci sequence
        /// </summary>
        /// <param name="n">nombre entier</param>       
        /// <returns>Résultat de Fibonacci en entier</returns>
        [WebMethod]
        public int Fibonacci(int n)
        {
            try
            {
                if (n < 1 || n > 100)
                    return -1;

                int a = 0;
                int b = 1;
                // In N steps compute Fibonacci sequence iteratively.
                for (int i = 0; i < n; i++)
                {
                    int temp = a;
                    a = b;
                    b = temp + b;
                }
                return a;
            }
            catch (Exception ex)
            {
                //log exception
                log.Fatal("WebMethod Fibonacci : " + ex.Message.ToString());
                return 0;
            }           
        }

        /// <summary>
        /// The XmlToJson service takes input a string xml and returns the json form of the xml string, 
        /// It will return "Bad Xml format" if the input string is not a well-formed xml
        /// </summary>
        /// <param name="xmlString">XML en string</param>       
        /// <returns> string au format JSON</returns>
        [WebMethod]
        public string XmlToJson(string xmlString)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(xmlString);
                return JsonConvert.SerializeXmlNode(doc); //Newtonsoft.Json library..
            }
            catch (Exception ex)
            {
                //log exception
                log.Fatal("WebMethod XmlToJson : " + ex.Message.ToString());
                return "Bad Xml format";
            }
        }
    }
}


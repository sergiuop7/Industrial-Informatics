using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Services;

namespace WebApplication1
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod(Description = "This method displays a message")]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public int Add(int a, int b)
        {
            return a + b;
        }

        [WebMethod]
        public float CelsiusToFahrenheit(float x)
        {
            return (float)(x * 9 / 5 + 32);
        }

        [WebMethod]
        public float FahrenheitToCelsius(float y)
        {
            return (float)((y - 32) * 5 / 9);
        }

        [WebMethod]
        public float ConvertLeiToEuro(float leiAmount)
        {
            double exchangeRate = 4.95;
            return (float)(leiAmount / exchangeRate);
        }

        [WebMethod]
        public float ConvertEuroToLei(float euroAmount)
        {
            double exchangeRate = 4.95;
            return (float)(euroAmount * exchangeRate);
        }

        [WebMethod]
        public List<string> AfisareLista()
        {
            List<string> myList = new List<string>();
            myList.Add("one");
            myList.Add("two");
            myList.Add("three");
            myList.Add("four");
            myList.Add("five");

            return myList;
        }

        [WebMethod]
        public string GetDateTime()
        {
            DateTime now = DateTime.Now;
            string dateTimeString = $"Data si ora curenta: {now}";
            return dateTimeString;
        }

    }
}


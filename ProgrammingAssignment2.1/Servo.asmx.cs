using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.IO;
namespace ProgrammingAssignment2._1
{
    /// <summary>
    /// Summary description for Servo
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Servo : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        [WebMethod]
        public string FindFile(string fileName)
        {

            try
            {
                string path = "D:\\CSharpProjects\\CoffeeAddicts\\TestFiles\\";
                string fullPath = path + fileName;
                return File.ReadAllText(fullPath);
            }
            catch (IOException e)
            {

                return e.Message;
            }

           
           

        }
    }
}

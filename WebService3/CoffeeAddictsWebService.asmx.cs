using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace WebService3
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
        private DataAccessLayer dataAccessLayer = new DataAccessLayer();
        private Utils utils = new Utils();  

        [WebMethod]
        public string HelloWorld()
        {
            
            return "Hello World";
        }

        [WebMethod]
        public DataSet GetTable(string tableName)
        {
            DataTable table = dataAccessLayer.GetTable(tableName);
            DataSet ds = new DataSet();
            ds.Tables.Add(table);

            return ds;
        }

        [WebMethod]
        public DataSet GetTableNames()
        {
            try
            {
                return dataAccessLayer.GetTableNames();
            }
            catch (Exception)
            {
                Debug.WriteLine("Failed in GetTableNames()");

                return null;
                
            }
        }

        [WebMethod]
        public List<object[]> GetTableValuesAsList(string tableName)
        {
            try
            {

                DataTable table = dataAccessLayer.GetTable(tableName);
                return utils.ConvertDataTableToList(table);
                //DataTable table = dataAccessLayer.GetTable(tableName);
                //List<object[]> list = new List<object[]>();
                //foreach (DataRow row in table.Rows)
                //{
                //    var array = row.ItemArray;
                //    list.Add(array);
                //}
                //return list;
            }
            catch (SqlException e)
            {
                return null;
            }catch (Exception e)
            { return null; }

        }

        [WebMethod]
        public List<object[]> GetColumnNamesAsList(string tableName)
        {
            try
            {
                DataTable table = dataAccessLayer.GetColumnNames(tableName);
                return utils.ConvertDataTableToList(table);
                //List<object[]> list = new List<object[]>();
                //foreach (DataRow row in table.Rows)
                //{
                //    var array = row.ItemArray;
                //    list.Add(array);
                //}
                //return list;
            }
            catch (SqlException e)
            {
                return null;
            }
            catch (Exception e)
            { return null; }

        }



        [WebMethod]
        public void CreateEmployee(CRONUS_Sverige_AB_Employee employee)
        {
            dataAccessLayer.CreateEmployee(employee);
        }

        [WebMethod]
        public List<CRONUS_Sverige_AB_Employee> GetEmployees()
        {
            return dataAccessLayer.GetEmployees();
        }
        [WebMethod]
        public List<CRONUS_Sverige_AB_Employee_Absence> GetEmployeeAbsence(string primaryKey)
        {
            return dataAccessLayer.GetEmployeeAbsence(primaryKey);
        }

        [WebMethod]
        public List<CRONUS_Sverige_AB_Employee_Relative> GetEmployeeRelatives(string primaryKey)
        {
            return dataAccessLayer.GetEmployeeRelatives(primaryKey);    
        }

        [WebMethod]
        public List<CRONUS_Sverige_AB_Employee_Qualification> GetEmployeeQualifications(string primaryKey)
        {
            return dataAccessLayer.GetEmployeeQualifications(primaryKey);
        }
        [WebMethod]
        public void DeleteEmployee(string pk)
        {
            dataAccessLayer.DeleteEmployee(pk);
        }

        [WebMethod]
        public void UpdateEmployee(CRONUS_Sverige_AB_Employee employee)
        {
               
            dataAccessLayer.UpdateEmployee(employee);
        }

        [WebMethod]
        public DataSet GetCronusData(string methodName)
        { 
            return dataAccessLayer.GetCronusData(methodName);
        }


    }
}

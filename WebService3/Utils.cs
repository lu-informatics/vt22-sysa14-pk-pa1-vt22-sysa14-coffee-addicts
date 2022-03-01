using System;
using System.Collections.Generic;
using System.Data;

namespace WebService3
{
    public class Utils
    {

        public List<object[]> ConvertDataSetToList(DataSet dataSet)
        {
            try
            {
                DataTable table = dataSet.Tables[0];
                List<object[]> list = new List<object[]>();
                foreach (DataRow row in table.Rows)
                {
                    var array = row.ItemArray;
                    list.Add(array);
                }
                return list;
            }
            catch (Exception e)
            { return new List<object[]>(); }

        }
        public List<object[]> ConvertDataTableToList(DataTable dataTable)
        {
            try
            {
                List<object[]> list = new List<object[]>();
                foreach (DataRow row in dataTable.Rows)
                {
                    var array = row.ItemArray;
                    list.Add(array);
                }
                return list;
            }
            catch (Exception e)
            { return new List<object[]>(); }

        }
        public string SelectCronusQuery(string methodName)
        {
            string query = "";
            switch (methodName)
            {
                case "All keys":
                    query = "SELECT * FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS WHERE CONSTRAINT_TYPE LIKE '%KEY'";
                    return query;
                case "All indexes":
                    query = "SELECT * FROM sys.indexes";
                    return query;
                case "All table_constraints":
                    query = "SELECT * FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS";
                    return query;

                case "All tables #1":
                    query = "SELECT * FROM INFORMATION_SCHEMA.TABLES";
                    return query;

                case "All tables #2":
                    query = "SELECT * FROM sys.tables";
                    return query;

                case "All employee columns #1":
                    query = "SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME LIKE 'CRONUS Sverige AB$Employee'";
                    return query;

                case "All employee columns #2":
                    query = "SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('dbo.CRONUS Sverige AB$Employee')";
                    return query;

                case "Absentee": //Are spaces needed in query?
                    query = "SELECT e.[First Name] " +
                            "FROM [CRONUS Sverige AB$Employee] e " +
                            "WHERE e.[No_] IN " +
                            "( SELECT subquery.[Employee No_] " +
                            "FROM " +
                            "( SELECT TOP 1 [Employee No_], SUM([Quantity (Base)]) AS 'Absence Hours' " +
                            "FROM [CRONUS Sverige AB$Employee Absence] " +
                            "GROUP BY [Employee No_] " +
                            "ORDER BY 'Absence Hours' DESC " +
                            ") subquery) ";
                    return query;

                case "Sickness":
                    query = "SELECT [First Name], [Last Name], [Job Title],[Phone No_], [City] FROM [CRONUS Sverige AB$Employee] " +
                            "WHERE No_ IN " +
                                "( SELECT [Employee No_] FROM [CRONUS Sverige AB$Employee Absence] " +
                                "WHERE [Cause of Absence Code] LIKE 'SJUK' AND [From Date] BETWEEN " +
                                "CONVERT(datetime, '2004-01-01') AND CONVERT(datetime, '2004-12-31') " +
                                "GROUP BY [Employee No_] " +
                                ") ";
                    return query;

                case "Employees and relatives":
                    query = "SELECT e.[First Name] as 'Employee First Name', e.[Last Name] as 'Employee Last Name', er.[Relative Code] as 'Relative Relation', er.[First Name] as 'Relative First Name', er.[Last Name] as 'Relative Last Name' " +
                            "FROM [CRONUS Sverige AB$Employee] e " +
                            "JOIN [CRONUS Sverige AB$Employee Relative] er " +
                            "ON er.[Employee No_] = e.No_ ";
                    return query;

                case "All Employee Tables Metadata":
                    query = "SELECT TABLE_NAME, COLUMN_NAME, IS_NULLABLE, DATA_TYPE, CHARACTER_MAXIMUM_LENGTH " +
                            "FROM INFORMATION_SCHEMA.COLUMNS " +
                            "WHERE TABLE_NAME LIKE 'CRONUS Sverige AB$Employee%' ";
                    return query;

                default: return null;
            }

        }
        public CRONUS_Sverige_AB_Employee FillDefaultValues(CRONUS_Sverige_AB_Employee employee)
        {
            Random random = new Random();
            employee.Address = "DEFAULT";
            employee.Address_2 = "DEFAULT";
            employee.Alt__Address_Code = "DEFAULT";
            employee.Alt__Address_End_Date = DateTime.Now.AddDays(50);
            employee.Alt__Address_Start_Date = DateTime.Now;
            employee.Birth_Date = DateTime.Now;
            employee.Cause_of_Inactivity_Code = "DEFAULT";
            employee.Company_E_Mail = "DEFAULT";
            employee.Country_Region_Code = "DEFAULT";
            employee.County = "DEFAULT";
            employee.Employment_Date = DateTime.Now;
            employee.Emplymt__Contract_Code = "DEFAULT";
            employee.Extension = "DEFAULT";
            employee.E_Mail = "DEFAULT";
            employee.Fax_No_ = "DEFAULT";
            employee.Global_Dimension_1_Code = "DEFAULT";
            employee.Global_Dimension_2_Code = "DEFAULT";
            employee.Grounds_for_Term__Code = "DEFAULT";
            employee.Inactive_Date = DateTime.Now;
            employee.Initials = "DEFAULT";
            employee.Last_Date_Modified = DateTime.Now;
            employee.Manager_No_ = "DEFAULT";
            employee.Middle_Name = "DEFAULT";
            employee.Mobile_Phone_No_ = "DEFAULT";
            employee.No_ = random.Next(9999).ToString();
            employee.No__Series = "DEFAULT";
            employee.Pager = "DEFAULT";
            employee.Picture = null;
            employee.Post_Code = "DEFAULT";
            employee.Resource_No_ = "DEFAULT";
            employee.Salespers__Purch__Code = "DEFAULT";
            employee.Search_Name = "DEFAULT";
            employee.Sex = 0;
            employee.Social_Security_No_ = "DEFAULT";
            employee.Statistics_Group_Code = "DEFAULT";
            employee.Status = 0;
            employee.Termination_Date = DateTime.Now;
            //employee.timestamp = ;
            employee.Title = "DEFAULT";
            employee.Union_Code = "DEFAULT";
            employee.Union_Membership_No_ = "DEFAULT";
            return employee;
        }

    }
}
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using FunWithDapper.Config;
using FunWithDapper.Models;

namespace FunWithDapper
{
    public class Program
    {
        private static void Main(string[] args)
        {
            //ReturnAllQuery();
            //RunParameterizedQuery();
            ExecuteStoredProcedure();
            RetrieveOutputParameter();

            Console.ReadLine();
        }

        public static void ReturnAllQuery()
        {
            using (SqlConnection cn = new SqlConnection(Settings.ConnectionString))
            {
                var employees = cn.Query<Employee>("SELECT * FROM Employees").ToList();

                ReturnEmployees(employees);
            }
        }

        public static void RunParameterizedQuery()
        {
            using (SqlConnection cn = new SqlConnection(Settings.ConnectionString))
            {
                var p = new DynamicParameters();
                p.Add("EmployeeID", 5);
                var employees = cn.Query<Employee>("SELECT * FROM Employees WHERE EmployeeId > @EmployeeId",
                    //new {EmployeeId = 5}).ToList();
                    p).ToList();

                ReturnEmployees(employees);
            }
        }

        public static void ExecuteStoredProcedure()
        {
            using (SqlConnection cn = new SqlConnection(Settings.ConnectionString))
            {
                var employees = cn.Query<Employee>("EmployeeGetAll", commandType: CommandType.StoredProcedure).ToList();

                ReturnEmployees(employees);
            }
        }

        private static void ReturnEmployees(List<Employee> employees)
        {
            foreach (var employee in employees)
            {
                Console.WriteLine("{0}, {1} - {2}", employee.LastName, employee.FirstName, employee.Title);
            }
        }

        public static void RetrieveOutputParameter()
        {
            using (SqlConnection cn = new SqlConnection(Settings.ConnectionString))
            {
                var p = new DynamicParameters();
                p.Add("RegionDescription", "New Region");
                p.Add("RegionId", dbType: DbType.Int32, direction: ParameterDirection.Output);

                cn.Execute("RegionInsert", p, commandType: CommandType.StoredProcedure);

                int regionID = p.Get<int>("RegionId");
                Console.WriteLine("Id = {0}", regionID);
            }
        }
    }
}

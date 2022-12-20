using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    internal class CashierEmployee
    {
        private int employeeId;
        private string employeeName;
        private string employeeSurname;
        private string employeePassword;
        private string employeeuserName;

        public int EmployeeId { get => employeeId; set => employeeId = value; }
        public string EmployeeName { get => employeeName; set => employeeName = value; }
        public string EmployeeSurname { get => employeeSurname; set => employeeSurname = value; }
        public string EmployeePassword { get => employeePassword; set => employeePassword = value; }
        public string EmployeeuserName { get => employeeuserName; set => employeeuserName = value; }


        public bool cashierEntryContoreller(string employeePassword , int employeeId)
        {

            bool result = false;

            SqlConnection con = new SqlConnection();







            return result;

        }


    }
}

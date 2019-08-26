namespace Day3_4
{
    public class AllMessage
    {
        public string strEmpDL = "select CONCAT(FirstName, ' ', LastName) as Name from Employees";
        public string strEmp = "select EmployeeID, CONCAT(FirstName, ' ', LastName) as Name, Address, Salary from employees";
        public string strDL = "select EmployeeID, CONCAT(FirstName, ' ', LastName) as Name, Address, Salary from employees where CONCAT(FirstName, ' ', LastName)= '";
    }
}
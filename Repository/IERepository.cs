using EmployeeDAL;

namespace EmpApi.Repository
{
    public interface IERepository
    {
        public List<Department> ShowAllDepartments();
        public List<Employee> ShowAllEmployees();
        public List<Employee> ShowEmployeeByDept(int deptId);
        public bool AddEmployee(Employee e);
        public bool AddDepartment(Department e);
        public bool UpdateDepartmentName(int deptId, string name);
    }
}

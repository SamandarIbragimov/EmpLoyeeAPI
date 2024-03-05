using EmployeeDAL;
using Microsoft.EntityFrameworkCore;

namespace EmpApi.Repository
{
    public class ERepository : IERepository
    {
        EMSContext context = new EMSContext();
        public bool AddDepartment(Department d)
        {
            try
            {
                context.DepartmentDB.Add(d);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool AddEmployee(Employee e)
        {
            try
            {
                context.EmployeeDB.Add(e);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Department> ShowAllDepartments()
        {
            List<Department> list;
            try
            {
                list = context.DepartmentDB.Include(e => e.Employees).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            return list;
        }

        public List<Employee> ShowAllEmployees()
        {
            List<Employee> list;
            try
            {
                list = context.EmployeeDB.Include(e => e.Dept).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            return list;
        }

        public List<Employee> ShowEmployeeByDept(int deptId)
        {
            List<Employee> list;
            try
            {
                list = context.EmployeeDB.Where(x=>x.Dept.DeptId == deptId).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            return list;
        }

        public bool UpdateDepartmentName(int deptId, string name)
        {
            bool flag = false;
            try
            {
                context.DepartmentDB.Where(x => x.DeptId == deptId).First().DepartmentName = name;
                context.SaveChanges();
                flag = true;
            }
            catch (Exception)
            {
                throw;
            }
            return flag;
        }
    }
}


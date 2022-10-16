using DAL_EMS;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_EMS
{
    public class EMP_Helper
    {
        EmpMethods methods = null;
        public EMP_Helper()
        {
            methods = new EmpMethods();
        }
        public List<EmpProfile> Employeelist()
        {
            return methods.GetEmpProfiles();
        }
        public bool AddEmployee(EmpProfile emp)
        {
            return methods.AddEmployee(emp);
        }

        public bool UpdateEmployee(int id, EmpProfile emp)
        {
            return methods.UpdateEmployee(id, emp);
        }
        public bool DeleteEmp(int id)
        {
            return methods.Removeemployee(id);
        }
        public EmpProfile LocateEmp(int id)
        {
            return methods.FindEmployee(id);
        }

    }

    public class Dept_Helper
    {
        DeptMethods methods = null;
        public Dept_Helper()
        {
            methods = new DeptMethods();
        }
        public List<DeptMaster> ShowDeptList()
        {
            return methods.GetDeptMasters();
        }
        public bool AddDept(DeptMaster dept)
        {
            return methods.AddDepts(dept);
        }
        public bool UpdateDept(int id, DeptMaster dept)
        {
            return methods.UpdateDept(id, dept);
        }
        public bool DeleteDept(int id)
        {
            return methods.RemoveDept(id);
        }
        public DeptMaster FindDept(int id)
        {
            return methods.FindDept(id);
        }
    }
}

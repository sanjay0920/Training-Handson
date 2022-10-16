using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EMS_FULL_STACK_PROJECT.Models
{
    public class DeptModel
    {

        public int DeptCode { get; set; }
        public string DeptName { get; set; }


    }
    public class EmpModel
    {

        public int EmpCode { get; set; }
        public string EmpName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public int DeptCode { get; set; }



    }
}
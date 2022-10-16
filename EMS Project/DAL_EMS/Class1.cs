using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_EMS
{
    public class DeptMaster
    {
        [Key, Required]
        public int DeptCode { get; set; }
        public string DeptName { get; set; }
        public virtual ICollection<EmpProfile> EmpDetails { get; set; }
    }

    public class EmpProfile
    {
        [Key, Required]
        public int EmpCode { get; set; }
        [MinLength(3, ErrorMessage = "Name should have more than three character")]
        [MaxLength(30, ErrorMessage = "Maximum length of Name is 30 characters")]
        public string EmpName { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public int DeptCode { get; set; }

        [ForeignKey("DeptCode")]
        public virtual DeptMaster Deptdetails { get; set; }

    }

    public class MyContext : DbContext
    {
        public MyContext() : base("MyContext")
        {
            Database.SetInitializer(new SeedMethod());
        }
        public virtual DbSet<DeptMaster> DeptMasters { get; set; }
        public virtual DbSet<EmpProfile> EmpProfiles { get; set; }

    }

    public class SeedMethod : DropCreateDatabaseIfModelChanges<MyContext>
    {
        protected override void Seed(MyContext context)
        {
            List<DeptMaster> deptlist = new List<DeptMaster>();
            deptlist.Add(new DeptMaster { DeptCode = 1, DeptName = "HR" });
            deptlist.Add(new DeptMaster { DeptCode = 2, DeptName = "Administration" });
            deptlist.Add(new DeptMaster { DeptCode = 3, DeptName = "Accounts" });
            deptlist.Add(new DeptMaster { DeptCode = 4, DeptName = "Sales" });
            context.DeptMasters.AddRange(deptlist);

            List<EmpProfile> emplist = new List<EmpProfile>();
            emplist.Add(new EmpProfile()
            {
                EmpCode = 100,
                DateOfBirth = new DateTime(2000, 10, 11),
                EmpName = "Scott",
                Email = "scott@gmail.com",
                DeptCode = 1

            }
            );
            emplist.Add(new EmpProfile()
            {
                EmpCode = 101,
                DateOfBirth = new DateTime(2001, 02, 10),
                EmpName = "Alex",
                Email = "Alex@gmail.com",
                DeptCode = 2

            }
            );
            emplist.Add(new EmpProfile()
            {
                EmpCode = 103,
                DateOfBirth = new DateTime(2001, 11, 19),
                EmpName = "Sheriff",
                Email = "Sheriff@gmail.com",
                DeptCode = 3

            }
            );
            emplist.Add(new EmpProfile()
            {
                EmpCode = 104,
                DateOfBirth = new DateTime(2002, 11, 16),
                EmpName = "Vikram",
                Email = "Vikramsinghchauhan@gmail.com",
                DeptCode = 4
            });

            context.EmpProfiles.AddRange(emplist);
            context.SaveChanges();
            base.Seed(context);
        }

    }


}

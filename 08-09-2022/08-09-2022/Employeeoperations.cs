using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _08_09_2022
{
    public delegate void handler(Employee emp);
    public delegate void display();

    class employeeoperation : EventArgs

    {
        public static event handler add;
        public static event handler delete;
        public static event handler update;
        public static List<Employee> employees = new List<Employee>();

        static void Main(string[] args)
        {
            Employee emp = new Employee();
            add += new handler(insert);
            delete += new handler(remove);
            update += new handler(edit);

            while (true)
            {
                Console.WriteLine("select the operation: \n1. Add \n2. Update \n3. Delete \no. exit");
                int a = Convert.ToInt32(Console.ReadLine());
                if (a == 0)
                    break;
                else
                    switch (a)
                    {
                        case 1:
                            add(emp);
                            break;
                        case 2:
                            Console.WriteLine("enter employee id you want to update");
                            Employee emp1 = new Employee();
                            emp1.empid = Convert.ToInt32(Console.ReadLine());
                            update(emp1);
                            break;
                        case 3:
                            Console.WriteLine("enter employee id you want to update");
                            Employee emp2 = new Employee();
                            emp2.empid = Convert.ToInt32(Console.ReadLine());
                            delete(emp2);
                            break;
                        default:
                            Console.WriteLine("invslid option");
                            break;
                    }
            }
            display del = new display(display);
            del();
            Console.ReadLine();
        }
        static void display()
        {
            foreach (var item in employees)
            {
                Console.WriteLine(item.empname);
                Console.WriteLine(item.deptno);
            }

        }
        static void insert(Employee emp)
        {
            Employee employee = new Employee();
            Console.WriteLine("enter employeeid");
            employee.empid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter employee name");
            employee.empname = Console.ReadLine();
            Console.WriteLine("enter manager name");
            employee.manager = Console.ReadLine();
            Console.WriteLine("enter salary");
            employee.salary = Convert.ToInt32(Console.ReadLine());
            employees.Add(employee);
            Console.WriteLine("enter dept number");
            employee.deptno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter dept name");
            employee.deptname = Console.ReadLine();
            Console.WriteLine("enter location");
            employee.location = Console.ReadLine();
            employees.Add(employee);
            Console.WriteLine("employee added.");
        }
        static void remove(Employee emp)
        {
            Employee employee = employees.Find(y => y.empid == emp.empid);
            employees.Remove(employee);
            Console.WriteLine("employee removed.");
        }

        static void edit(Employee emp)
        {
            Employee employee = employees.Find(y => y.empid == emp.empid);
            Console.WriteLine("enter new details of employee ");
            Console.WriteLine("enter employeeid");
            employee.empid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter employee name");
            employee.empname = Console.ReadLine();
            Console.WriteLine("enter manager name");
            employee.manager = Console.ReadLine();
            Console.WriteLine("enter salary");
            employee.salary = Convert.ToInt32(Console.ReadLine());
            employees.Add(employee);
            Console.WriteLine("enter dept number");
            employee.deptno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter dept name");
            employee.deptname = Console.ReadLine();
            Console.WriteLine("enter location");
            employee.location = Console.ReadLine();
            employees.Add(employee);
            Console.WriteLine("employee updated.");
        }

        public void Displaybymgr(List<Employee> m)
        {
            Console.WriteLine("Enter the name of the manager whom name of employees you want to see ");
            string s = Console.ReadLine();
            var ti = m.Where(mi => mi.manager == s).ToList();
            if (ti.Count > 0)
            {
                foreach (var item in ti)
                    Console.WriteLine(item.empname);
            }
            else
            {
                Console.WriteLine("No employees is working under him");
            }
        }
        public void Display(List<Employee> m)
        {
            foreach (var item in m)
            {
                Console.WriteLine($"{item.empid} {item.empname} {item.deptno} {item.salary} {item.manager}\n");
            }


        }
    }
}

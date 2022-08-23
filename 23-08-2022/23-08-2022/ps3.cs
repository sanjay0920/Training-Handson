using System;

struct employee
{
    public int empno;
    public string empname;
    public int salary;
    public int deptno;
};

    public class ps3
    {
        public static void Main(string[] args)
        {
        employee emp1;
        employee emp2;

        emp1.empno = 01;
        emp1.empname = "sanjay";
        emp1.salary = 30000;
        emp1.deptno = 20;

        emp2.empno = 02;
        emp2.empname = "ajay";
        emp2.salary = 50000;
        emp2.deptno = 30;
        //printing emp1 details
        Console.WriteLine(emp1.empno);
        Console.WriteLine(emp1.empname);
        Console.WriteLine(emp1.salary);
        Console.WriteLine(emp1.deptno);
        Console.WriteLine("___________________________________");
        //printing emp2 details
        Console.WriteLine(emp2.empno);
        Console.WriteLine(emp2.empname);
        Console.WriteLine(emp2.salary);
        Console.WriteLine(emp2.deptno);



        Console.ReadKey();

    }
    }

using System;
using System.Collections.Generic;
using System.Text;

namespace OOPCSharpAssignment2
{
    class Employee
    {
        int EmpNo;
        string EmpName;
        double Salary, HRA, TA, DA, PF, TDS, NetSalary, GrossSalary;

        public Employee(int EmpNo, string EmpName, double Salary)
        {
            this.EmpNo = EmpNo;
            this.EmpName = EmpName;
            this.Salary = Salary;

        }
        public void CalHra()
        {
            if (Salary < 5000)
            {
                HRA = 0.1 * Salary;
            }
            else if (Salary < 10000)
            {
                HRA = 0.15 * Salary;
            }
            else if (Salary < 15000)
            {
                HRA = 0.20 * Salary;
            }
            else if (Salary < 20000)
            {
                HRA = 0.25 * Salary;
            }
            else
            {
                HRA = 0.30 * Salary;
            }
            Console.WriteLine(HRA);
        }
        public void CalTa()
        {
            if (Salary < 5000)
            {
                TA = 0.05 * Salary;
            }
            else if (Salary < 10000)
            {
                TA = 0.10 * Salary;
            }
            else if (Salary < 15000)
            {
                TA = 0.15 * Salary;
            }
            else if (Salary < 20000)
            {
                TA = 0.20 * Salary;
            }
            else
            {
                TA = 0.25 * Salary;
            }
            Console.WriteLine(TA);
        }
        public void CalDa()
        {
            if (Salary < 5000)
            {
                DA = 0.15 * Salary;
            }
            else if (Salary < 10000)
            {
                DA = 0.20 * Salary;
            }
            else if (Salary < 15000)
            {
                DA = 0.25 * Salary;
            }
            else if (Salary < 20000)
            {
                DA = 0.20 * Salary;
            }
            else
            {
                DA = 0.35 * Salary;
            }
            Console.WriteLine(DA);
        }
        public void GrossSal()
        {
            GrossSalary = Salary + HRA + TA + DA;
            Console.WriteLine("GrossSalary:" + GrossSalary);
        }
        public void pf()
        {
            PF = 0.1*GrossSalary;
            Console.WriteLine("PF:" + PF);
        }
        public void Tds()
        {
            TDS = 0.18*GrossSalary;
            Console.WriteLine("TDS:" + TDS);
        }
        public void NetSal()
        {
            NetSalary = GrossSalary-(PF+TDS) ;
            Console.WriteLine("NetSalary:" + NetSalary);
        }
        public void Display()
        {
            Console.WriteLine(EmpNo);
            Console.WriteLine(EmpName);
            Console.WriteLine(Salary);
            

         
        }

    }

    class Program
    {
        public static void Main(string[] args)
        {
            Employee emp = new Employee(5, "minu", 9000);
            emp.Display();
            emp.CalHra();
            emp.CalDa();
            emp.CalTa();
            emp.GrossSal();
            emp.pf();
            emp.Tds();
            emp.NetSal();


        }
    }
}

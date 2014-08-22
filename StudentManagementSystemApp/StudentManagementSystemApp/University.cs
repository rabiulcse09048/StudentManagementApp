using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystemApp
{
    public class University
    {
        private List<Department> departmentList=new List<Department>();
        Department aDepartment=new Department();
        string studentName = "";

        public bool AddDepartment(Department aDepartment)
        {
            departmentList.Add(aDepartment);
            return true;
        }

        public List<Department> GetAllDepartment()
        {
            return departmentList;
        }

        public bool checkRegNo(Department aDeparment,Student aStudent)
        {
            bool check = false;
              foreach(Department department in departmentList)
              {
                  check = department.CheckRegNo(aStudent);
                  if (check)
                      return true;
              }
              return check;

        }

        public bool AddStudent(Department aDepartment, Student aStudent)
        {
            bool check=false;
            foreach (Department department in departmentList)
            {
                if (department.Code == aDepartment.Code)
                {
                   check=aDepartment.AddStudent(aStudent);
                }
            }
            return check;
        }

        //public bool AddStudent(Department aDepartment,Student aStudent)
        //{
        //    bool check=false;
        //    foreach (Department department in departmentList)
        //    {
        //        if (department.Code == aDepartment.Code)
        //        {
        //            check = department.AddStudent(aStudent);

        //            return check;

        //        }
        //    }
        //    return check;
        //}

        public string ShowStudent(Department aDepartment)
        {
           
            foreach (Department department in departmentList)
            {
                if (department.Code == aDepartment.Code)
                {
                  aDepartment.studentList= department.GetAllStudent();
                  studentName = "Department : " + department.Name+"\n";
                    studentName += "Student Name\tReg No\n";
                    foreach(Student student in aDepartment.studentList)
                    {
                        studentName +=student.Name+ " " + student.RegNo+  "\n";
                    }
                  
                }
            }
            return studentName;
        }
    }

}

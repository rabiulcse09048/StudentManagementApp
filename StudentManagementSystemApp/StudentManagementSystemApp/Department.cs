using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystemApp
{
    public class Department
    {
        private string code;
        private string name;
        public List<Student> studentList=new List<Student>();

        public string  Code { get; set; }
        public string Name { get; set; }

        //public bool AddStudent(Student aStudent)
        //{
        //  if(DoesThisStudent(aStudent))
        //  {
        //      return true;
        //  }
        //  else
        //  {
        //      studentList.Add(aStudent);
        //      return false;
        //  }
        //}


        public bool AddStudent(Student aStudent)
        {
            studentList.Add(aStudent);
            return true;
        }

        public bool CheckRegNo(Student aStudent)
        {
            if (DoesThisStudent(aStudent))
            {
                return true;
            }
            else
            {
               return  false;
            }
        }

        private bool DoesThisStudent(Student aStudent)
        {
            foreach (Student student in studentList)
            {
                if (aStudent.RegNo == student.RegNo)
                    return true;
            }
            return false;
        }


        public List<Student> GetAllStudent()
        {
            return studentList;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DataAccess;

namespace BusinessLogic
{
    class StudentBUS
    {
        private StudentInfoDAO objStudent = new StudentInfoDAO();
        public List<StudentInfo> getStudentList()
        {
            return objStudent.getStudentInfo();
        }
        public List<StudentInfo> getStudentByID(string ID)
        {
            return objStudent.getStudentByID(ID);
        }
        public List<StudentInfo> getStudentByName(string Name)
        {
            return objStudent.getStudentByName(Name);
        }

        public List<StudentInfo> getStudentByPhone(string Phone)
        {
            return objStudent.getStudentByPhone(Phone);
        }
        public bool addStudentInfo(StudentInfo aStudent)
        {
            if (objStudent.addStudentInfo(aStudent))
                return true;
            return false;
        }
        public bool removeStudentInfo(string StudentId)
        {
            if (objStudent.RemoveStudentInfo(StudentId))
                return true;
            return false;
        }
        public bool updateStudentInfo(StudentInfo aStudent)
        {
            if (objStudent.UpdateStudentInfo(aStudent))
                return true;
            return false;
        }
    }
}

using System;


namespace DTO
{
    public class StudentInfo
    {
        public string StudentID { get; set; }
        public string FullName { get; set; }
        public DateTime BDay { get; set; }
        public string Address { get; set; }
        public char Gender { get; set; }
        public string Email { get; set; } 
        public string Phone { get; set; }

        public StudentInfo() { }
        public StudentInfo(string studentId, string fullName, DateTime bDay, string address,
            char gender, string email, string phone)
        {
            StudentID = studentId;
            FullName = fullName;
            BDay = bDay;
            Address = address;
            Gender = gender;
            Email = email;
            Phone = phone;
        }
    }
}

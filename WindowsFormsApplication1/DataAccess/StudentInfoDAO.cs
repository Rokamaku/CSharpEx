using System;
using System.Collections.Generic;
using DTO;
using System.Data.OleDb;
using System.Data;

namespace DataAccess
{
    public class StudentInfoDAO : DBConnection
    {
        public StudentInfoDAO() : base() { }

        public List<StudentInfo> getStudentInfo()
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                List<StudentInfo> listStudent = new List<StudentInfo>();
                OleDbCommand query = new OleDbCommand("select * from StudentInfo", conn);
                OleDbDataReader dr = query.ExecuteReader();
                while (dr.Read())
                {
                    StudentInfo aStudent = getStudentInfo(dr);
                    listStudent.Add(aStudent);
                }
                conn.Close();
                return listStudent;
            }
            catch (Exception)
            {
                conn.Close();
            }
            return null;
        }

        public List<StudentInfo> getStudentByID(string ID)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                List<StudentInfo> listStudent = new List<StudentInfo>();
                OleDbCommand query =
                    new OleDbCommand("select * from StudentInfo where StudentID =?", conn);
                query.Parameters.AddWithValue("@ID", ID);
                OleDbDataReader dr = query.ExecuteReader();
                while (dr.Read())
                {
                    StudentInfo aStudent = getStudentInfo(dr);
                    listStudent.Add(aStudent);
                }
                conn.Close();
                return listStudent;
            }
            catch (Exception)
            {
                conn.Close();
            }
            return null;
        }

        public List<StudentInfo> getStudentByName(string Name)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                List<StudentInfo> listStudent = new List<StudentInfo>();
                OleDbCommand query =
                    new OleDbCommand("select * from StudentInfo where FullName = ?", conn);
                query.Parameters.Add("@name", OleDbType.BSTR).Value = Name;
                OleDbDataReader dr = query.ExecuteReader();
                while (dr.Read())
                {
                    StudentInfo aStudent = getStudentInfo(dr);
                    listStudent.Add(aStudent);
                }
                conn.Close();
                return listStudent;
            }
            catch (Exception)
            {
                conn.Close();
            }
            return null;
        }

        public List<StudentInfo> getStudentByPhone(string Phone)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                List<StudentInfo> listStudent = new List<StudentInfo>();
                OleDbCommand query =
                    new OleDbCommand("select * from StudentInfo where Phone = ?", conn);
                query.Parameters.Add("@name", OleDbType.VarChar).Value = Phone;
                OleDbDataReader dr = query.ExecuteReader();
                while (dr.Read())
                {
                    StudentInfo aStudent = getStudentInfo(dr);
                    listStudent.Add(aStudent);
                }
                conn.Close();
                return listStudent;
            }
            catch (Exception)
            {
                conn.Close();
            }
            return null;
        }

        public bool addStudentInfo(StudentInfo aStudent)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                OleDbCommand query = new OleDbCommand(@"insert into StudentInfo values (
                    ?, ?, ?, ?, ?, ?, ?)", conn);
                query.Parameters.AddWithValue("@id", aStudent.StudentID);
                query.Parameters.AddWithValue("@fullname", aStudent.FullName);
                query.Parameters.Add("bday", OleDbType.Date).Value = aStudent.BDay;
                query.Parameters.AddWithValue("@address", aStudent.Address);
                query.Parameters.AddWithValue("@gender", aStudent.Gender);
                query.Parameters.AddWithValue("@email", aStudent.Email);
                query.Parameters.AddWithValue("@phone", aStudent.Phone);
                query.ExecuteNonQuery();
                return true;
            }
            catch (InvalidOperationException)
            {
                return false;
            }
        }

        private StudentInfo getStudentInfo(OleDbDataReader dr)
        {
            StudentInfo aStudent = new StudentInfo();
            aStudent.StudentID = dr.GetString(dr.GetOrdinal("StudentID"));
            aStudent.FullName = dr.GetString(dr.GetOrdinal("FullName"));
            aStudent.Gender = dr.GetString(dr.GetOrdinal("Gender"))[0];
            aStudent.BDay = dr.GetDateTime(dr.GetOrdinal("BDay"));
            aStudent.Address = dr.GetString(dr.GetOrdinal("Address"));
            aStudent.Email = dr.GetString(dr.GetOrdinal("Email"));
            aStudent.Phone = dr.GetString(dr.GetOrdinal("Phone"));
            return aStudent;
        }

        public bool RemoveStudentInfo(string StudentID)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                OleDbCommand query = new
                    OleDbCommand(@"Delete from StudentInfo where StudentID = ?", conn);
                query.Parameters.AddWithValue("@ID", StudentID);
                query.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool UpdateStudentInfo(StudentInfo aStudent)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                OleDbCommand query =
                    new OleDbCommand(@"Update StudentInfo set
                        FullName = ?, BDay = ?, Address = ?, Gender = ?,
                        Email = ?, Phone = ? where StudentID = ?", conn);
                query.Parameters.AddWithValue("@fullname", aStudent.FullName);
                query.Parameters.Add("bday", OleDbType.Date).Value = aStudent.BDay;
                query.Parameters.AddWithValue("@address", aStudent.Address);
                query.Parameters.AddWithValue("@gender", aStudent.Gender);
                query.Parameters.AddWithValue("@email", aStudent.Email);
                query.Parameters.AddWithValue("@phone", aStudent.Phone);
                query.Parameters.AddWithValue("@id", aStudent.StudentID);
                query.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}

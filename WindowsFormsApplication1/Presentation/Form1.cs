using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;
using DTO;

namespace Presentation
{
    public partial class Form1 : Form
    {
        private StudentBUS objStudent = new StudentBUS();
        private DataTable dt;
        private int SelectedIndex;
        public Form1()
        {
            InitializeComponent();
        }
    
        private void Form1_Load(object sender, EventArgs e)
        {
            dt = convertToDatatable(objStudent.getStudentList());
            dGVData.DataSource = dt;
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            FormAddStudent formAdd = new FormAddStudent();
            if (formAdd.ShowDialog() == DialogResult.OK)
            {
                if (objStudent.addStudentInfo(formAdd.Student))
                {
                    MessageBox.Show("Add Student Successfully!",
                        "Congratulation!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    dt = convertToDatatable(objStudent.getStudentList());
                    dGVData.DataSource = dt;
                }
                else
                    MessageBox.Show("Fail to Add Student!",
                        "Error!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
        }

        private void btnDelStudent_Click(object sender, EventArgs e)
        {
            string id = dGVData.SelectedRows[0].Cells[0].Value.ToString();
            objStudent.removeStudentInfo(id);
            dt = convertToDatatable(objStudent.getStudentList());
            dGVData.DataSource = dt;
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            dGVData.ReadOnly = false;
            SelectedIndex = dGVData.SelectedRows[0].Index;
            for (int i = 0; i < dGVData.Rows.Count; i++)
            {
                if (i != SelectedIndex)
                    dGVData.Rows[i].ReadOnly = true;
            }
            dGVData.Columns[0].ReadOnly = true;
            btnOK.Enabled = true;
            btnCancel.Enabled = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string strSearch = textBoxSearch.Text;
            if (strSearch.Length != 0 && 
                (radioBtnById.Checked || radioBtnByName.Checked || radioBtnByPhone.Checked))
            {
                if (radioBtnById.Checked)
                {
                    dt = convertToDatatable(objStudent.getStudentByID(strSearch));
                    dGVData.DataSource = dt;
                }
                else if (radioBtnByName.Checked)
                {
                    dt = convertToDatatable(objStudent.getStudentByName(strSearch));
                    dGVData.DataSource = dt;
                }
                else if (radioBtnByPhone.Checked)
                {
                    dt = convertToDatatable(objStudent.getStudentByPhone(strSearch));
                    dGVData.DataSource = dt;
                }
                
            } else if (strSearch.Length == 0)
            {
                dt = convertToDatatable(objStudent.getStudentList());
                dGVData.DataSource = dt;
            }
        }

        private DataTable convertToDatatable(List<StudentInfo> listStudent)
        {
            DataTable dt = new DataTable();
            
            dt.Columns.Add("Student ID");
            dt.Columns.Add("Full Name");
            dt.Columns.Add("Birthday");
            dt.Columns.Add("Address");
            dt.Columns.Add("Gender");
            dt.Columns.Add("Email");
            dt.Columns.Add("Phone");
            dt.PrimaryKey = new DataColumn[] { dt.Columns["Student ID"] };
            foreach (var aStudent in listStudent)
            {
                var row = dt.NewRow();

                row["Student ID"] = aStudent.StudentID;
                row["Full Name"] = aStudent.FullName;
                row["Birthday"] = aStudent.BDay.ToShortDateString();
                row["Address"] = aStudent.Address;
                row["Gender"] = aStudent.Gender;
                row["Email"] = aStudent.Email;
                row["Phone"] = aStudent.Phone;

                dt.Rows.Add(row);
            }
            return dt;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            StudentInfo aStudent = new StudentInfo();
            using (var selectedRows = dGVData.Rows[SelectedIndex])
            {
                aStudent.StudentID = selectedRows.Cells[0].Value.ToString();
                aStudent.FullName = selectedRows.Cells[1].Value.ToString();
                aStudent.BDay = DateTime.Parse(selectedRows.Cells[2].Value.ToString());
                aStudent.Address = selectedRows.Cells[3].Value.ToString();
                aStudent.Gender = selectedRows.Cells[4].Value.ToString()[0];
                aStudent.Email = selectedRows.Cells[5].Value.ToString();
                aStudent.Phone = selectedRows.Cells[6].Value.ToString();
                objStudent.updateStudentInfo(aStudent);
            }
            dt = convertToDatatable(objStudent.getStudentList());
            dGVData.DataSource = dt;
            dGVData.ReadOnly = true;
            btnOK.Enabled = false;
            btnCancel.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            dt = convertToDatatable(objStudent.getStudentList());
            dGVData.DataSource = dt;
            dGVData.ReadOnly = true;
            btnOK.Enabled = false;
            btnCancel.Enabled = false;
        }
    }
}

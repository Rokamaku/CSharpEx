using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class FormAddStudent : Form
    {
        public StudentInfo Student { get; set; }
        public FormAddStudent()
        {
            InitializeComponent();
            Student = new StudentInfo();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (textBoxID.Text.Length != 0 &&
                textBoxName.Text.Length != 0 &&
                textBoxAddress.Text.Length != 0 &&
                textBoxEmail.Text.Length != 0 &&
                textBoxPhone.Text.Length != 0)
            {
                Student.StudentID = textBoxID.Text;
                Student.FullName = textBoxName.Text;
                if (comboBoxGender.Text == "Male")
                    Student.Gender = 'M';
                else
                    Student.Gender = 'F';
                Student.BDay = dateTimePickerBDay.Value;
                Student.Email = textBoxEmail.Text;
                Student.Address = textBoxAddress.Text;
                Student.Phone = textBoxPhone.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("You must fill all fields",
                    "Error!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAddStudent_Load(object sender, EventArgs e)
        {
            comboBoxGender.Text = "Male";
        }

    }
}

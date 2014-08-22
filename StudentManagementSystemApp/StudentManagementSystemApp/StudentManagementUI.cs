using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystemApp
{
    public partial class StudentManagementUI : Form
    {
        public StudentManagementUI()
        {
            InitializeComponent();
            departmentSaveComboBox.DisplayMember = "Code";
            departmentShowComboBox.DisplayMember = "Code";
        }

        private University aUniversity = new University();
        private Department aDepartment;
        private Student aStudent;

        private void departmentSaveButton_Click(object sender, EventArgs e)
        {
            aDepartment=new Department();
            aDepartment.Code = departmentCodeTextBox.Text;
            aDepartment.Name = departmentNameTextBox.Text;
            bool check=aUniversity.AddDepartment(aDepartment);
            if (check)
            {
                MessageBox.Show("Department added successfully!");
                departmentSaveComboBox.Items.Add(aDepartment);
                departmentShowComboBox.Items.Add(aDepartment);
            }
            else
            {
                
            }

            //departmentSaveComboBox.DataSource = aUniversity.GetAllDepartment();
        }

        private void studentShowButton_Click(object sender, EventArgs e)
        {
            Department department =(Department )departmentShowComboBox.SelectedItem;
            MessageBox.Show(aUniversity.ShowStudent(department));
           
        }

        private void studentSaveButton_Click(object sender, EventArgs e)
        {
            aStudent = new Student();
            aStudent.RegNo = studentRegNoTextBox.Text;
            aStudent.Name = studentNameTextBox.Text;
            aStudent.Email = studentEmailTextBox.Text;

            aDepartment=new Department();
            aDepartment = (Department)departmentSaveComboBox.SelectedItem;

            bool check = aUniversity.checkRegNo(aDepartment, aStudent);

            if (check)
            {
                MessageBox.Show("This Registration No already exists.");
            }
            else
            {
                aUniversity.AddStudent(aDepartment, aStudent);
                MessageBox.Show("Student added.");
            }
        }
    }
}

using Classes.Exercice.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classes.Exercice
{
    public partial class FrmMain : Form
    {
        private SchoolData schoolData;
        public FrmMain()
        {
            InitializeComponent();
            InitializeApplication();
        }

        #region Events
        private void cboClasses_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateClassView();
        }

        private void UpdateClassView()
        {
            Class c = schoolData.GetClass(cboClasses.Text);
            DisplayClassInfo(c);
            UpdateListView(c);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Student student = schoolData.GetStudent(lvwStudents.SelectedItems[0].SubItems[0].Text);
            DisplayStudentInfo(student);
            DisplayStudentClasses(student);

            ToggleTextBoxesAndButton();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            List<string> classes = GetCheckedClasses();

            if (btnAdd.Text == "Add")
                AddStudent(classes);
            else
                UpdateStudent(classes);

            ClearNewStudent();
            UpdateClassView();

        }
        #endregion

        #region Utility Methods

        private void InitializeApplication()
        {
            schoolData = new SchoolData();

            string[] classes = schoolData.GetAllClassesText();
            cboClasses.Items.AddRange(classes);
            chlClasses.Items.AddRange(classes);

            cboClasses.SelectedIndex = 0;
        }

        private void DisplayClassInfo(Class c)
        {
            txtSubject.Text = c.Subject;
            txtTeacher.Text = c.Teacher;
        }

        private void DisplayStudentInfo(Student student)
        {
            txtFirstName.Text = student.FirstName;
            txtLastName.Text = student.LastName;
            txtBirthday.Text = student.Birthday;
        }

        private void DisplayStudentClasses(Student student)
        {
            List<string> classes = schoolData.GetStudentClasses(student).Select(c => c.Name).ToList();
            for (int i = 0; i < chlClasses.Items.Count; i++)
                chlClasses.SetItemCheckState(i, classes.Contains(chlClasses.Items[i].ToString()) ? CheckState.Checked : CheckState.Unchecked);
        }

        private List<string> GetCheckedClasses()
        {
            List<string> classes = new List<string>();

            foreach (var item in chlClasses.CheckedItems)
                classes.Add(item.ToString());

            return classes;
        }

        private void AddStudent(List<string> classes)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string birthday = txtBirthday.Text;

            schoolData.CreateStudent(firstName, lastName, birthday, classes);
        }

        private void UpdateStudent(List<string> classes)
        {
            ToggleTextBoxesAndButton();
            schoolData.EditStudent(schoolData.GetStudent(txtLastName.Text + ", " + txtFirstName.Text), classes);
        }

        private void UpdateListView(Class c)
        {
            lvwStudents.Items.Clear();

            foreach (Student student in c.Students)
            {
                ListViewItem lvi = new ListViewItem(student.FullName);
                lvi.SubItems.Add(student.Age.ToString());
                lvwStudents.Items.Add(lvi);
            }

            lvwStudents.Sort();
        }
        private void ToggleTextBoxesAndButton()
        {
            txtFirstName.Enabled = !txtFirstName.Enabled;
            txtLastName.Enabled = !txtLastName.Enabled;
            txtBirthday.Enabled = !txtBirthday.Enabled;
            btnAdd.Text = btnAdd.Text == "Add" ? "Update" : "Add";
        }

        private void ClearNewStudent()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtBirthday.Clear();
            for (int i = 0; i < chlClasses.Items.Count; i++)
                chlClasses.SetItemCheckState(i, CheckState.Unchecked);
        }

        #endregion
    }
}

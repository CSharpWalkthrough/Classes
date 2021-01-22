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
        public FrmMain()
        {
            InitializeComponent();
            // TODO: Initialize SchoolData and UI
        }

        private void cboClasses_SelectedIndexChanged(object sender, EventArgs e)
        {
            // TODO: Display class info with students
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // TODO: Display selected student's info
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // TODO: If Text is "Add" => Create student
            // TODO: If Text is "Update" => Edit student
        }
    }
}

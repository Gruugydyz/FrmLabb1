using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmLabb1
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string[] info = { "Student Number: " + txtStudentNo.Text
            , "Full Name: " + txtLastName.Text + ", " + txtFirstName.Text + ", " + txtMI.Text
            , "Program: " + cbProg.Text, "Gender: " + cbGender.Text
            , "Age: " + cbGender.Text, "Birthday: " + DtpBirth.Text
            , "Contact Number: " + txtNo.Text};

            string SetFileName = txtStudentNo.Text + ".txt";

            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath,
            SetFileName)))
            {
                foreach (string s in info)
                {
                    outputFile.WriteLine(s);
                }
            }
            Close();
        }

        private void FrmRegistration_Load(object sender, EventArgs e)
        {

            string[] ListOfPrograms = new string[]
            {
                "BS Information Technology ",
                "BS Computer Science",
                "BS Information System",
                "BS In Accountancy",
                "BS In Hospitality Managment",
                "BS In Tourism Managment",
            };
            cbGender.Items.Add("Male"); cbGender.Items.Add("Female");

            for (int i = 0; i < 6; i++)
            {
                cbProg.Items.Add(ListOfPrograms[i].ToString());
            }

        }
    }
    }


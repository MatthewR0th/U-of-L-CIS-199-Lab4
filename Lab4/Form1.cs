//Grading ID: K1791
//Lab 4
//27 September 2020
//CIS 199-02
//This lab checks to see if the gpa and test scores of a student will allow them to be enrolled into college.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form1 : Form
    {

        const double lowestGpaPossible = 3.0; //The lowest possible threshhold for GPA, but only if the user has a test score of at least  60.
        const double lowestTestScorePossible = 60; //The lowest possible gpa for a student with a test score of atleast 60.
        const double highestTestScorePossible = 80; //The highest threshhold of test score, but only if a student has a gpa of less than 3.0.

        private int howManyRejections = 0; //Storing a value for how many rejections there are
        private int howManyAcceptances = 0; //Storing a value for how many acceptances there are
        
        public Form1()
        {
            InitializeComponent();
        }
       
        
        //Sets the value of the running totals to zero at the start of the program, and displays "accepted" and "rejected".
        private void Form1_Load(object sender, EventArgs e) 
        {
            SetLabel(acceptedOutputLabel, howManyAcceptances, "Acceptances"); //Displays the default value of 0 for how many acceptances, and displays "Total Acceptances".
            SetLabel(rejectedOutputLabel, howManyRejections, "Rejections"); //Displays the default value of 0 for how many rejections, and displays "Rejected".
        }

        //Sets the value for all labels in the form
        private void SetLabel(Label label, int amount, string type)
        {
            label.Text = amount + " - " + type; //Adds together each entry on the running total.
        }

        //The main calculations for this program are done here once the calculation button is clicked.
        private void calculationButton_Click(object sender, EventArgs e)
        {
            double userGpa;  //GPA of user

            double userAdmissionScore; //Admission score of user
            _ = double.TryParse(gpaInput.Text, out userGpa); //Checks if the user has input something
            _ = double.TryParse(admissionScoreInput.Text, out userAdmissionScore); //Checks if the user has input something



            bool studentHasBeenAccepted = (userGpa >= lowestGpaPossible && userAdmissionScore >= lowestTestScorePossible) //The set of values that will lead to acceptance
               || (userGpa < lowestGpaPossible && userAdmissionScore >= highestTestScorePossible); //The set of values that will lead to acceptance


            if (userGpa < 0) 
            {
                MessageBox.Show("Error, GPA must be between 0.0-4.0, and Test score must be between 0-100");
                gpaInput.Text = ""; //Clears the error(s) for the user
                admissionScoreInput.Text = ""; //Clears the error(s) for the user
            }
            else if (userGpa > 4.0)
                {
                MessageBox.Show("Error, GPA must be between 0.0-4.0, and Test score must be between 0-100");
                gpaInput.Text = ""; //Clears the error(s) for the user
                admissionScoreInput.Text = ""; //Clears the error(s) for the user
            }
            
            
            else if (userAdmissionScore < 0 )
            {
                MessageBox.Show("Error, GPA must be between 0.0-4.0, and Test score must be between 0-100");
                admissionScoreInput.Text = ""; //Clears the error(s) for the user
                gpaInput.Text = ""; //Clears the error(s) for the user
            }
            
                else if (userAdmissionScore > 100)
                    {
                MessageBox.Show("Error, GPA must be between 0.0-4.0, and Test score must be between 0-100");
                admissionScoreInput.Text = ""; //Clears the error(s) for the user
                gpaInput.Text = ""; //Clears the error(s) for the user
            }

             else if (studentHasBeenAccepted) //If the input values match up:
            {
                resultLabel.Text = "Accept"; //Displays this message
                SetLabel(acceptedOutputLabel, ++howManyAcceptances, "Acceptances"); //Updates the running total output for acceptances
            }
              else 
            {
                resultLabel.Text = "Reject"; //Displays this message
                SetLabel(rejectedOutputLabel, ++howManyRejections, "Rejections"); //Updates the running total output for rejections
            }
        }
    }
    

}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Lesson8A
{
    public partial class Lab08Form : Form
    {
        public string UserName { get; set; }
        public float UserAge { get; set; }
        public Lab08Form()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is the Event Handler for the SubmitButton Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            UserName = NameTextBox.Text;

            // option A
            UserAge = Convert.ToSingle(AgeTextBox.Text);

            OutputLabel.Text = NameTextBox.Text + " " + AgeTextBox.Text;
            ClearForm();

            //// option B
            //UserAge = float.Parse(AgeTextBox.Text);

            //// option C
            //float tempFloat;
            //bool result = float.TryParse(AgeTextBox.Text, out tempFloat);
            //UserAge = tempFloat;

            //// option D
            //UserAge = (float)AgeTextBox.Text;   //doesn't work
        }

        private void ClearForm()
        {
            NameTextBox.Clear();
            AgeTextBox.Clear();
        }

        /// <summary>
        /// This is the Event handler for the agetextbox textchanged event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void AgeTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                float.Parse(AgeTextBox.Text);
                SubmitButton.Enabled = true;
            }
            catch
            {
                SubmitButton.Enabled = false;
            }
        }

        /// <summary>
        /// This is the event handler for the nametextbox textchanged event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            SubmitButton.Enabled = (NameTextBox.Text.Length >= 2) ? true : false;
        }
    }
}

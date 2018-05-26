using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HighBarAppWF
{
    public partial class Form1 : Form
    {
        List<Doctor> doctors = new List<Doctor>();
        public Form1()
        {
            InitializeComponent();
            Rectangle workingArea = Screen.GetWorkingArea(this);
            this.Location = new Point(workingArea.Right - Size.Width,
                                      workingArea.Bottom - Size.Height);
            //todo null check here
            var clinics = HttpService.GetClinicsAsync().Result;
            //Add clinics to drop down
            comboBox1.DataSource = clinics;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Code";
            //Make default selection
            comboBox1.SelectedIndex = 0;

            //bind doctors dropdown to doctors list
            comboBox3.DataSource = doctors;
            comboBox3.DisplayMember = "Name";
            comboBox3.ValueMember = "Id";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            MessageBox.Show("Date - "+dateTimePicker1.Value.ToString("dd/MM/yyyy")+" Clinic selected: " + ((Clinic)this.comboBox1.SelectedItem).Code);

            //uncomment code when in network of API.

            //get the fukcing doctors
            //var doctors = HttpService.GetDoctorsByClinicAsync(this.comboBox1.SelectedItem.ToString(), this.dateTimePicker1.Value.ToString("dd/MM/yyyy")).Result;
            //Add them to the dropdown 
            //doctors.ForEach(x => comboBox3.Items.Add(new { Text = x.Name, Value = x.Id }));
            //Make default selection
            //comboBox3.SelectedIndex = 0;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Date - " + dateTimePicker1.Value.ToString("dd/MM/yyyy") + " Clinic selected: " + ((Clinic)this.comboBox1.SelectedItem).Code);
        }
    }
}

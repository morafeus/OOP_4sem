using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class SpecBox : Form
    {
        FormAddres form;

        public SpecBox()
        {
            InitializeComponent();
        }

        private void SpecBox_Load(object sender, EventArgs e)
        {
            Student student;
        }

        private void LowCourse_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(CourseLabel.Text) > 1)
                {
                    CourseLabel.Text = Convert.ToString(Convert.ToInt32(CourseLabel.Text) - 1);
                }
                else
                    throw new Exception();
            }
            catch
            {
                MessageBox.Show("Курс не может быть отрицательным, либо равен 0");
            }
        }

        private void HighCourse_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(CourseLabel.Text) < 5)
                {
                    CourseLabel.Text = Convert.ToString(Convert.ToInt32(CourseLabel.Text) + 1);
                }
                else
                    throw new Exception();
            }
            catch
            {
                MessageBox.Show("Курс не может быть быть больше 5");
            }
        }

        private void GroupLow_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(GroupLabel.Text) > 1)
                {
                    GroupLabel.Text = Convert.ToString(Convert.ToInt32(GroupLabel.Text) - 1);
                }
                else
                    throw new Exception();
            }
            catch
            {
                MessageBox.Show("Группа не может быть отрицательной, либо равна 0");
            }
        }

        private void HighButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(GroupLabel.Text) < 10)
                {
                    GroupLabel.Text = Convert.ToString(Convert.ToInt32(GroupLabel.Text) + 1);
                }
                else
                    throw new Exception();
            }
            catch
            {
                MessageBox.Show("Группа не может быть больше 10");
            }
        }

        private void AdresButton_Click(object sender, EventArgs e)
        {
            if(form == null)
            {
                form = new FormAddres();
            }

            form.ShowDialog();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                //if(SurnameBox.Text != null && NameBox.Text != null && SecNameBox.Text != null && CourseLabel.Text != null 
                //    && GroupLabel.Text != null && AverageBox.Text != null && (MaleRadio != null || FemaleRadio != null))
                //Program.students.Add(new Student(SurnameBox.Text + " " + NameBox.Text + " " + SecNameBox.Text, AgePicker.Value
                //    ));
                //StudentList.DataSource = Program.students;
            }
            catch
            {

            }
        }
    }
}

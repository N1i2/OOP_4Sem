using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba_2
{
    public partial class Form2 : Form
    {
        Lesson less = new Lesson();
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(Lesson lesson) : this()
        {
            less = lesson;
            nameBox.Text = lesson.Name;
            YearsBox.Text = Convert.ToString(lesson.Year);
            if (lesson.Semester == 1)
                semestrBox.Text = "First";
            else if (lesson.Semester == 2)
                semestrBox.Text = "Second";
            else
                semestrBox.Text = "All Year";
            specialtiesBox.Text = lesson.Specialies;
            controlBox.Text = (lesson.Control == 1) ? "Exam" : "Test";
            lecturesBox.Text = lesson.Lectures.ToString();
            laboratoryBox.Text = lesson.Laboratory.ToString();
            lectorNameBox.Text = lesson.Lector.Name;
            DeportamentBox.Text = lesson.Lector.Deportament;
            classRoomBox.Text = lesson.Lector.ClassRoom.ToString();
            phoneBox.Text = lesson.Lector.PhoneNumber;

            foreach (var item in lesson.Books)
            {
                listBox.Items.Add($"{item.Name}\t\t{item.Autor}\t\t{item.Date}\t\t{item.Pages}");
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            Fone.lessons.Remove(less);

            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Point point;
        private void fone2_MouseDown(object sender, MouseEventArgs e)
        {
            point = new Point(e.X, e.Y);
        }

        private void fone2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - point.X;
                this.Top += e.Y - point.Y;
            }
        }

        private void header2_MouseDown(object sender, MouseEventArgs e)
        {
            point = new Point(e.X, e.Y);
        }

        private void header2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - point.X;
                this.Top += e.Y - point.Y;
            }
        }
    }
}

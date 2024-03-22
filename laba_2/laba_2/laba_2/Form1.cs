using System.ComponentModel;
using System.Net;

namespace laba_2
{
    public partial class Fone : Form
    {
        public static List<Lesson> lessons = new List<Lesson>();

        public Fone()
        {
            InitializeComponent();
        }
        private void label2_Click(object sender, EventArgs e)
        {
            FileWork.Serialize(lessons);
            this.Close();
        }

        private void end_MouseEnter(object sender, EventArgs e)
        {
            end.ForeColor = Color.Gray;
        }

        private void end_MouseLeave(object sender, EventArgs e)
        {
            end.ForeColor = Color.Black;
        }
        Point lastPoint;

        private void Fone_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Fone_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void hader_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void hader_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void disciplineBox_MouseEnter(object sender, EventArgs e)
        {
            disciplineBox.BackColor = Color.LightGray;
        }

        private void disciplineBox_MouseLeave(object sender, EventArgs e)
        {
            disciplineBox.BackColor = Color.White;
        }

        private void lecturesBox_MouseEnter(object sender, EventArgs e)
        {
            lecturesBox.BackColor = Color.LightGray;
        }
        private void lecturesBox_MouseLeave(object sender, EventArgs e)
        {
            lecturesBox.BackColor = Color.White;
        }
        private void laboratoryBox_MouseEnter(object sender, EventArgs e)
        {
            laboratoryBox.BackColor = Color.LightGray;
        }
        private void laboratoryBox_MouseLeave(object sender, EventArgs e)
        {
            laboratoryBox.BackColor = Color.White;
        }

        private void lecturesBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void lectorerNameBox_MouseEnter(object sender, EventArgs e)
        {
            lectorerNameBox.BackColor = Color.LightGray;
        }
        private void lectorerNameBox_MouseLeave(object sender, EventArgs e)
        {
            lectorerNameBox.BackColor = Color.White;
        }

        private void classRoomBox_MouseEnter(object sender, EventArgs e)
        {
            classRoomBox.BackColor = Color.LightGray;
        }
        private void classRoomBox_MouseLeave(object sender, EventArgs e)
        {
            classRoomBox.BackColor = Color.White;
        }

        private void phonNumberBox_MouseEnter(object sender, EventArgs e)
        {
            phoneNumberBox.BackColor = Color.LightGray;
        }

        private void phonNumberBox_MouseLeave(object sender, EventArgs e)
        {
            phoneNumberBox.BackColor = Color.White;
        }

        private void classRoomBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void phonNumberBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void laboratoryBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private async void buttonSave_Click(object sender, EventArgs e)
        {
            Lesson lesson = new Lesson();

            string result = CheckDescription(lesson);

            if (result == ErrorMessage.NoError)
            {
                lessons.Add(lesson);

                buttonClear_Click(sender, EventArgs.Empty);

                resultSave.ForeColor = Color.Green;
            }
            else
            {
                resultSave.ForeColor = Color.FromArgb(192, 0, 0);
            }

            resultSave.Text = result;
            await Task.Delay(2000);
            resultSave.Text = string.Empty;
        }
        private string CheckDescription(Lesson lesson)
        {
            if (disciplineBox.Text == string.Empty ||
                disciplineBox.Text.Length > 30)
            {
                return ErrorMessage.DisciplineError;
            }
            lesson.Name = disciplineBox.Text;

            //yyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyy
            RadioButton[] kurs = { kurs1, kurs2, kurs3, kurs4, kurs5 };
            for (int i = 0; i < 5; i++)
                if (kurs[i].Checked)
                    lesson.Year = i + 1;
            if (lesson.Year == 0)
                return ErrorMessage.YearsError;

            //yyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyy
            if (firstSemester.Checked)
                lesson.Semester += 1;
            if (secondSemester.Checked)
                lesson.Semester += 2;
            if (lesson.Semester == 0)
                return ErrorMessage.SemesterError;

            //yyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyy
            if (specialtyList.Text == string.Empty)
            {
                return ErrorMessage.SpecialtiesError;
            }
            lesson.Specialies = specialtyList.Text;

            //yyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyy
            if (controlEx.Checked)
                lesson.Control = 1;
            if (controlTest.Checked)
                lesson.Control = 2;
            if (lesson.Control == 0)
                return ErrorMessage.ControlError;

            //yyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyy
            if (lecturesBox.Text == string.Empty ||
                Convert.ToInt32(lecturesBox.Text) < 10 ||
                Convert.ToInt32(lecturesBox.Text) > 60)
            {
                return ErrorMessage.LecturesError;
            }
            lesson.Lectures = Convert.ToInt32(lecturesBox.Text);

            //yyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyy
            if (laboratoryBox.Text == string.Empty ||
                Convert.ToInt32(laboratoryBox.Text) < 10 ||
                Convert.ToInt32(laboratoryBox.Text) > 60)
            {
                return ErrorMessage.LaboratoryError;
            }
            lesson.Laboratory = Convert.ToInt32(laboratoryBox.Text);

            //yyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyy
            lesson.Lector = new Lectorer();
            if (lectorerNameBox.Text.Split(' ').Length != 3)
            {
                return ErrorMessage.LectorNameError;
            }
            lesson.Lector.Name = lectorerNameBox.Text;

            //yyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyy
            if (deportamentBox.Text == string.Empty)
            {
                return ErrorMessage.DeportamentError;
            }
            lesson.Lector.Deportament = deportamentBox.Text;

            //yyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyy
            if (classRoomBox.Text == string.Empty ||
                Convert.ToInt32(classRoomBox.Text) == 0)
            {
                return ErrorMessage.ClassRoomError;
            }
            lesson.Lector.ClassRoom = Convert.ToInt32(classRoomBox.Text);

            //yyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyy
            if (phoneNumberBox.Text.Length < 14)
            {
                return ErrorMessage.PhonError;
            }
            lesson.Lector.PhoneNumber = phoneNumberBox.Text;
            //yyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyy
            if (listBook.Items.Count != 0)
            {
                string[] text = new string[4];
                BookList books;

                foreach (string item in listBook.Items)
                {
                    books = new BookList();
                    text = item.Split("\t\t");

                    books.Name = text[0];
                    books.Autor = text[1];
                    books.Date = text[2];
                    books.Pages = Convert.ToInt32(text[3]);

                    lesson.Books.Add(books);
                }
            }

            return ErrorMessage.NoError;
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            disciplineBox.Text = string.Empty;

            kurs1.Checked = false;
            kurs2.Checked = false;
            kurs3.Checked = false;
            kurs4.Checked = false;
            kurs5.Checked = false;

            firstSemester.Checked = false;
            secondSemester.Checked = false;

            specialtyList.SelectedIndex = -1;

            controlEx.Checked = false;
            controlTest.Checked = false;

            lecturesBox.Text = string.Empty;
            laboratoryBox.Text = string.Empty;

            lectorerNameBox.Text = string.Empty;
            deportamentBox.SelectedIndex = -1;
            classRoomBox.Text = string.Empty;
            phoneNumberBox.Text = string.Empty;

            listBook.Items.Clear();
        }
        private async void buttonShow_Click(object sender, EventArgs e)
        {
            if (lessons.Count == 0)
            {
                resultSave.ForeColor = Color.Red;
                resultSave.Text = "No Records";

                await Task.Delay(2000);
                resultSave.Text = string.Empty;

                return;
            }
            Form2 form;

            foreach (var item in lessons)
            {
                form = new Form2(item);
                form.Show();
            }
        }

        private async void buttonAdd_Click(object sender, EventArgs e)
        {
            if (nameBook.Text == string.Empty ||
                autor.Text == string.Empty)
            {
                resultSave.ForeColor = Color.Red;
                resultSave.Text = "Name or autor not marked";

                await Task.Delay(2000);
                resultSave.Text = string.Empty;

                return;
            }
            listBook.Items.Add($"{nameBook.Text}\t\t{autor.Text}\t\t{dateCreat.Text}\t\t{sizePage.Text}");

            nameBook.Text = string.Empty;
            autor.Text = string.Empty;
        }

        private void remove_Click(object sender, EventArgs e)
        {
            if (listBook.SelectedIndex != -1)
            {
                listBook.Items.RemoveAt(listBook.SelectedIndex);
            }
        }

        private void Fone_Load(object sender, EventArgs e)
        {
            lessons = FileWork.Diserialize();
        }
    }
}
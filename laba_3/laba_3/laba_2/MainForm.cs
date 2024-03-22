using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Windows.Forms;

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
            FillingLine("No Save Page");

            Lesson lesson = new Lesson();

            string result = CheckDescription(lesson);

            if (result == ErrorMessage.NoError)
            {
                lessons.Add(lesson);

                buttonClear_Click(sender, EventArgs.Empty);

                FillingLine("Save Page");
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

            bool error = false;
            List<Lesson> helpLes = FileWork.Diserialize();

            foreach (var j in helpLes)
            {
                if (j.Name == disciplineBox.Text)
                {
                    error = true;
                }
            }
            if (error)
            {
                return ErrorMessage.AlradyExistsError;
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

            var cont = new ValidationContext(lesson);
            var results = new List<ValidationResult>();

            if (!Validator.TryValidateObject(lesson, cont, results, true))
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
            FillingLine("Clear Page");

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

            lecturesBox.Text = "10";
            laboratoryBox.Text = "10";

            lectorerNameBox.Text = string.Empty;
            deportamentBox.SelectedIndex = -1;
            classRoomBox.Text = string.Empty;
            phoneNumberBox.Text = string.Empty;

            listBook.Items.Clear();
        }
        public static bool Need = false;

        private async void buttonShow_Click(object sender, EventArgs e)
        {
            FillingLine("View Data");

            if (lessons.Count == 0)
            {
                resultSave.ForeColor = Color.Red;
                resultSave.Text = "No Records";

                await Task.Delay(2000);
                resultSave.Text = string.Empty;

                return;
            }
            ShowForm form;
            form = new ShowForm(lessons);

            if (this.MdiChildren.Any())
            {
                form.Close();
            }

            form.ShowDialog();

            if(Need)
            {
                Need = false;
                FillingLine("Delete Page");
            }
        }
        private async void buttonAdd_Click(object sender, EventArgs e)
        {
            if (nameBook.Text == string.Empty ||
                autor.Text == string.Empty)
            {
                FillingLine("No Add Book");
                resultSave.ForeColor = Color.Red;
                resultSave.Text = "Name or autor not marked";

                await Task.Delay(2000);
                resultSave.Text = string.Empty;

                return;
            }
            FillingLine("Add Book");
            listBook.Items.Add($"{nameBook.Text}\t\t{autor.Text}\t\t{dateCreat.Text}\t\t{sizePage.Text}");

            nameBook.Text = string.Empty;
            autor.Text = string.Empty;
        }

        private void remove_Click(object sender, EventArgs e)
        {
            FillingLine("Remove Book");
            if (listBook.SelectedIndex != -1)
            {
                listBook.Items.RemoveAt(listBook.SelectedIndex);
            }
        }

        private void Fone_Load(object sender, EventArgs e)
        {
            lessons = FileWork.Diserialize();

            FillingLine("Nothing");
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            FillingLine("Search Page");

            SearchForm form = new SearchForm();
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FillingLine("About Me");

            MessageBox.Show("Selicky Nikolay\nVersian 2.45");
        }

        private void tools_Click(object sender, EventArgs e)
        {
            toolsBool.Checked = !toolsBool.Checked;

            if (toolsBool.Checked)
            {
                FillingLine("Open Tools");

                CreatTools();
            }
            else
            {
                FillingLine("Close Tools");

                DeleteTools();
            }
        }
        private void CreatTools()
        {
            Button search2 = new Button();
            Button save2 = new Button();
            Button clear2 = new Button();
            Button showSaved2 = new Button();

            // 
            // showSaved2
            // 
            showSaved2.BackColor = Color.SpringGreen;
            showSaved2.Cursor = Cursors.Hand;
            showSaved2.FlatAppearance.BorderColor = Color.Black;
            showSaved2.FlatAppearance.BorderSize = 3;
            showSaved2.FlatAppearance.MouseDownBackColor = Color.Gray;
            showSaved2.FlatAppearance.MouseOverBackColor = Color.Yellow;
            showSaved2.FlatStyle = FlatStyle.Flat;
            showSaved2.Font = new Font("Impact", 14F, FontStyle.Italic, GraphicsUnit.Point, 0);
            showSaved2.Location = new Point(37, 84);
            showSaved2.Name = "showSaved2";
            showSaved2.Size = new Size(168, 65);
            showSaved2.TabIndex = 46;
            showSaved2.Text = "Show Saved";
            showSaved2.UseVisualStyleBackColor = false;
            showSaved2.Click += buttonShow_Click;
            // 
            // clear2
            // 
            clear2.BackColor = Color.SpringGreen;
            clear2.Cursor = Cursors.Hand;
            clear2.FlatAppearance.BorderColor = Color.Black;
            clear2.FlatAppearance.BorderSize = 3;
            clear2.FlatAppearance.MouseDownBackColor = Color.Gray;
            clear2.FlatAppearance.MouseOverBackColor = Color.Yellow;
            clear2.FlatStyle = FlatStyle.Flat;
            clear2.Font = new Font("Impact", 20F, FontStyle.Italic, GraphicsUnit.Point, 0);
            clear2.Location = new Point(37, 149);
            clear2.Name = "clear2";
            clear2.Size = new Size(168, 65);
            clear2.TabIndex = 47;
            clear2.Text = "Clear";
            clear2.UseVisualStyleBackColor = false;
            clear2.Click += buttonClear_Click;
            // 
            // save2
            // 
            save2.BackColor = Color.SpringGreen;
            save2.Cursor = Cursors.Hand;
            save2.FlatAppearance.BorderColor = Color.Black;
            save2.FlatAppearance.BorderSize = 3;
            save2.FlatAppearance.MouseDownBackColor = Color.Gray;
            save2.FlatAppearance.MouseOverBackColor = Color.Yellow;
            save2.FlatStyle = FlatStyle.Flat;
            save2.Font = new Font("Impact", 20F, FontStyle.Italic, GraphicsUnit.Point, 0);
            save2.Location = new Point(37, 214);
            save2.Name = "save2";
            save2.Size = new Size(168, 65);
            save2.TabIndex = 48;
            save2.Text = "Save";
            save2.UseVisualStyleBackColor = false;
            save2.Click += buttonSave_Click;
            // 
            // search2
            // 
            search2.BackColor = Color.SpringGreen;
            search2.Cursor = Cursors.Hand;
            search2.FlatAppearance.BorderColor = Color.Black;
            search2.FlatAppearance.BorderSize = 3;
            search2.FlatAppearance.MouseDownBackColor = Color.Gray;
            search2.FlatAppearance.MouseOverBackColor = Color.Yellow;
            search2.FlatStyle = FlatStyle.Flat;
            search2.Font = new Font("Impact", 20F, FontStyle.Italic, GraphicsUnit.Point, 0);
            search2.Location = new Point(37, 279);
            search2.Name = "search2";
            search2.Size = new Size(168, 65);
            search2.TabIndex = 49;
            search2.Text = "Search";
            search2.UseVisualStyleBackColor = false;
            search2.Click += Search_Click;

            laba3Fone.Controls.Add(search2);
            laba3Fone.Controls.Add(save2);
            laba3Fone.Controls.Add(clear2);
            laba3Fone.Controls.Add(showSaved2);
        }

        private void DeleteTools()
        {
            laba3Fone.Controls.RemoveByKey("showSaved2");
            laba3Fone.Controls.RemoveByKey("clear2");
            laba3Fone.Controls.RemoveByKey("save2");
            laba3Fone.Controls.RemoveByKey("search2");
        }
        private void FillingLine(string doit = "Delete Page")
        {
            workLine.Text = $"{DateTime.Now}\nall {lessons.Count} les.\nlast activity \"{doit}\"";
        }
    }
}
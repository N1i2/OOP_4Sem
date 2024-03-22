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
    public partial class ShowForm : Form
    {
        public List<LectorForm> lectors = new List<LectorForm>();
        public List<Lesson> lessones =new List<Lesson>();
        bool saveB = false;

        public ShowForm()
        {
            saveB = false;
            InitializeComponent();
        }
        public ShowForm(List<Lesson> less) : this()
        {
            lessones.AddRange(less);
            for (int i = 0; i < less.Count; i++)
            {
                allList.Rows.Add(GetNewRow(less[i], i % 2));
            }
        }
        public ShowForm(List<Lesson> less, string save):this(less)
        {
            saveB = true;
            Button but = new Button();
            but.BackColor = Color.Teal;
            but.FlatAppearance.BorderColor = Color.Black;
            but.FlatAppearance.BorderSize = 2;
            but.FlatAppearance.MouseDownBackColor = Color.Blue;
            but.FlatAppearance.MouseOverBackColor = Color.Gray;
            but.FlatStyle = FlatStyle.Flat;
            but.Location = new Point(34, 514);
            but.Name = "saved";
            but.Size = new Size(126, 45);
            but.TabIndex = 4;
            but.Text = save;
            but.UseVisualStyleBackColor = false;
            but.Click += save_CellContentClick;

            fone2.Controls.Add(but);
        }
        private DataGridViewRow GetNewRow(Lesson less, int col)
        {
            Color color = new Color();
            if (col == 0)
                color = Color.Green;
            else
                color = Color.Yellow;

            DataGridViewRow newRow = new DataGridViewRow();
            DataGridViewTextBoxCell name = new DataGridViewTextBoxCell();
            DataGridViewTextBoxCell year = new DataGridViewTextBoxCell();
            DataGridViewTextBoxCell sem = new DataGridViewTextBoxCell();
            DataGridViewTextBoxCell spec = new DataGridViewTextBoxCell();
            DataGridViewTextBoxCell control = new DataGridViewTextBoxCell();
            DataGridViewTextBoxCell lectures = new DataGridViewTextBoxCell();
            DataGridViewTextBoxCell laba = new DataGridViewTextBoxCell();
            DataGridViewButtonCell lector = new DataGridViewButtonCell();
            DataGridViewComboBoxCell books = new DataGridViewComboBoxCell();
            DataGridViewButtonCell del = new DataGridViewButtonCell();

            GetBackColor(((col==0)?Color.LightGreen:Color.FromArgb(241,255, 0)), name, year, sem, spec, control, lectures, laba, lector, books);

            name.Value = less.Name;
            year.Value = less.Year;

            int semm = less.Semester;
            string semestr = string.Empty;
            if (semm == 1 || semm == 3)
            {
                semestr = "1";
                semm--;
            }
            if (semm >= 2)
            {
                if (less.Semester == 3)
                    semestr += " AND ";
                semestr += "2";
            }
            sem.Value = semestr;

            spec.Value = less.Specialies;
            control.Value = (less.Control == 1) ? "Exem" : "Test";
            lectures.Value = less.Lectures;
            laba.Value = less.Laboratory;
            lector.Value = less.Lector.Name.Split(' ')[0];

            lectors.Add(new LectorForm(less.Lector));

            if (less.Books.Count != 0)
            {
                foreach (var book in less.Books)
                {
                    books.Items.Add(book.Name);
                }
                books.Value = less.Books[0].Name;
            }
            else
            {
                books.Items.Add(ErrorMessage.EmptyListBookError);
                books.Value = ErrorMessage.EmptyListBookError;
            }

            del.Value = "Delete";
            GetBackColor(Color.Red, del);

            newRow.Cells.AddRange(name, year, sem, spec, control, lectures, laba, lector, books, del);

            return newRow;
        }
        private void GetBackColor(Color col, params DataGridViewCell[] elem)
        {
            foreach(var e in elem) 
            {
                e.Style.BackColor = col;
            }
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

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            point = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - point.X;
                this.Top += e.Y - point.Y;
            }
        }

        private void end_Click(object sender, EventArgs e)
        {
            if(saveB)
            {
                FileWork.Serialize(lessones, 1);
            }



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

        private void allList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (((DataGridView)sender).Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 7)
                {
                    lectors[e.RowIndex].ShowDialog();
                }
                if (e.ColumnIndex == 9)
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this lesson?", "Hello", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(result == DialogResult.Yes)
                    {
                        Fone.Need = true;

                        allList.Rows.RemoveAt(e.RowIndex);

                        List<Lesson> helpLes = FileWork.Diserialize(1);

                        for(int i =0; i< helpLes.Count; i++)
                        {
                            if (helpLes[i].Name == lessones[e.RowIndex].Name)
                            {
                                helpLes.RemoveAt(i);
                                FileWork.Serialize(helpLes, 1);
                                break;
                            }
                        }

                        if (!saveB)
                        {
                            Fone.lessons.RemoveAt(e.RowIndex);
                            return;
                        }

                        lessones.RemoveAt(e.RowIndex);
                    }
                }
            }
        }
        private void save_CellContentClick(object sender, EventArgs e)
        {
            FileWork.Serialize(lessones, 1);
        }
    }
}

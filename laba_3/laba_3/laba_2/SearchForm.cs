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
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }
        Point point;
        private void fone_MouseDown(object sender, MouseEventArgs e)
        {
            point = new Point(e.X, e.Y);
        }

        private void fone_MouseMove(object sender, MouseEventArgs e)
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

        private void lectorSearch_CheckedChanged(object sender, EventArgs e)
        {
            if (lectorSearch.Checked)
            {
                TextBox surnameBox = new TextBox();
                surnameBox.Location = new Point(50, 169);
                surnameBox.Name = "surnameBox";
                surnameBox.Size = new Size(201, 31);
                surnameBox.TabIndex = 7;
                surnameBox.BackColor = Color.Sienna;
                surnameBox.ForeColor = Color.Orange;
                fone.Controls.Add(surnameBox);
            }
            else
            {
                fone.Controls.RemoveByKey("surnameBox");
            }
        }

        private void semestrSearch_CheckedChanged(object sender, EventArgs e)
        {
            if (semestrSearch.Checked)
            {
                // 
                // firstSem
                // 
                CheckBox firstSem = new CheckBox();
                firstSem.AutoSize = true;
                firstSem.Cursor = Cursors.Hand;
                firstSem.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
                firstSem.ForeColor = Color.Orange;
                firstSem.Location = new Point(10, 7);
                firstSem.Name = "firstSem";
                firstSem.Size = new Size(88, 30);
                firstSem.TabIndex = 7;
                firstSem.Text = "First";
                firstSem.UseVisualStyleBackColor = true;
                firstSem.Visible = true;
                firstSem.Enabled = true;
                // 
                // secondSem
                // 
                CheckBox secondSem = new CheckBox();
                secondSem.AutoSize = true;
                secondSem.Cursor = Cursors.Hand;
                secondSem.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
                secondSem.ForeColor = Color.Orange;
                secondSem.Location = new Point(10, 43);
                secondSem.Name = "secondSem";
                secondSem.Size = new Size(111, 30);
                secondSem.TabIndex = 8;
                secondSem.Text = "Second";
                secondSem.UseVisualStyleBackColor = true;
                secondSem.BringToFront();
                // 
                // checkFone
                // 
                Panel checkFone = new Panel();
                checkFone.BackColor = Color.Sienna;
                checkFone.Location = new Point(355, 160);
                checkFone.Name = "checkFone";
                checkFone.Size = new Size(130, 88);
                checkFone.TabIndex = 9;

                fone.Controls.Add(checkFone);
                checkFone.Controls.Add(secondSem);
                checkFone.Controls.Add(firstSem);
            }
            else
            {
                fone.Controls.RemoveByKey("checkFone");
                fone.Controls.RemoveByKey("firstSem");
                fone.Controls.RemoveByKey("secondSem");
            }
        }

        private void yearSearch_CheckedChanged(object sender, EventArgs e)
        {
            if (yearSearch.Checked)
            {
                NumericUpDown yearBox = new NumericUpDown();
                yearBox.BackColor = Color.Sienna;
                yearBox.ForeColor = Color.Orange;
                yearBox.Location = new Point(598, 164);
                yearBox.Name = "yearBox";
                yearBox.Size = new Size(127, 31);
                yearBox.TabIndex = 7;
                yearBox.Minimum = 1;
                yearBox.Maximum = 5;

                fone.Controls.Add(yearBox);
            }
            else
            {
                fone.Controls.RemoveByKey("yearBox");
            }
        }

        private async void reultSearch_Click(object sender, EventArgs e)
        {
            if (!(lectorSearch.Checked ||
                semestrSearch.Checked ||
                yearSearch.Checked))
            {
                ansver.Text = ErrorMessage.NotByCheckSearchError;

                await Task.Delay(2000);
                ansver.Text = string.Empty;

                return;
            }

            List<Lesson> ans = new List<Lesson>();
            ans.AddRange(Fone.lessons);

            if (lectorSearch.Checked)
            {
                Control[] text = fone.Controls.Find("surnameBox", true);

                Check_Lector(ans, text[0].Text);
            }
            if (semestrSearch.Checked)
            {
                Control[] box1 = fone.Controls.Find("firstSem", true);
                Control[] box2 = fone.Controls.Find("secondSem", true);
                int sem = 0;

                if (((box1[0] as CheckBox) ?? new CheckBox()).Checked)
                {
                    sem += 1;
                }
                if (((box2[0] as CheckBox) ?? new CheckBox()).Checked)
                {
                    sem += 2;
                }

                Check_Semestr(ans, sem);
            }
            if (yearSearch.Checked)
            {
                Control[] year = fone.Controls.Find("yearBox", true);

                Check_Year(ans, Convert.ToInt32(year[0].Text));
            }

            if (ans.Count == 0)
            {
                ansver.Text = ErrorMessage.NoSuitableOnesSearchError;

                await Task.Delay(2000);
                ansver.Text = string.Empty;

                return;
            }

            ans = ans.OrderBy(d => d.Lectures).ThenBy(g => g.Control).ToList();

            ShowForm form = new ShowForm(ans, "Save");
            form.ShowDialog();
        }

        private void Check_Lector(List<Lesson> ans, string text)
        {
            foreach (var lect in Fone.lessons)
            {
                if ((lect.Lector.Name.IndexOf(text)) == -1)
                {
                    ans.Remove(lect);
                }
            }
        }
        private void Check_Semestr(List<Lesson> ans, int sem)
        {
            if (sem == 3)
            {
                return;
            }
            List<Lesson> j = new List<Lesson>();
            j.AddRange(ans);

            foreach (var lect in j)
            {
                if (lect.Semester == 3)
                {
                    continue;
                }
                if (lect.Semester != sem)
                {
                    ans.Remove(lect);
                }
            }
        }
        private void Check_Year(List<Lesson> ans, int year)
        {
            List<Lesson> j = new List<Lesson>();
            j.AddRange(ans);

            foreach (var lect in j)
            {
                if (lect.Year != year)
                {
                    ans.Remove(lect);
                }
            }
        }

        private async void showSaved_Click(object sender, EventArgs e)
        {
            List<Lesson> les = FileWork.Diserialize(1);

            if(les.Count == 0)
            {
                ansver.Text = ErrorMessage.FileEmptySearchError;
                await Task.Delay(2000);

                ansver.Text = string.Empty;
                return;
                
            }

            ShowForm form = new ShowForm(les, "Save All");
            form.ShowDialog();
        }
    }
}

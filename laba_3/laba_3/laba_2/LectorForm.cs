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
    public partial class LectorForm : Form
    {
        public LectorForm()
        {
            InitializeComponent();
        }
        public LectorForm(Lectorer lector) : this()
        {
            nameBox.Text = lector.Name;
            deportamentBox.Text = lector.Deportament;
            classRoomBox.Text = Convert.ToString(lector.ClassRoom);
            phoneBox.Text = lector.PhoneNumber;
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
        Point point;
        private void fone3_MouseDown(object sender, MouseEventArgs e)
        {
            point = new Point(e.X, e.Y);
        }
        private void fone3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - point.X;
                this.Top += e.Y - point.Y;
            }
        }
        private void header_MouseDown(object sender, MouseEventArgs e)
        {
            point = new Point(e.X, e.Y);
        }
        private void header_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - point.X;
                this.Top += e.Y - point.Y;
            }
        }
    }
}

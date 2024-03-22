namespace laba_2
{
    partial class ShowForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowForm));
            fone2 = new Panel();
            allList = new DataGridView();
            name = new DataGridViewTextBoxColumn();
            year = new DataGridViewTextBoxColumn();
            semestr = new DataGridViewTextBoxColumn();
            speciality = new DataGridViewTextBoxColumn();
            control = new DataGridViewTextBoxColumn();
            lectures = new DataGridViewTextBoxColumn();
            laboratory = new DataGridViewTextBoxColumn();
            lector = new DataGridViewButtonColumn();
            allBook = new DataGridViewComboBoxColumn();
            delete = new DataGridViewButtonColumn();
            end = new Label();
            header = new Panel();
            listImage = new PictureBox();
            listName = new Label();
            fone2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)allList).BeginInit();
            header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)listImage).BeginInit();
            SuspendLayout();
            // 
            // fone2
            // 
            fone2.BackColor = Color.FromArgb(1, 255, 242);
            fone2.BorderStyle = BorderStyle.FixedSingle;
            fone2.Controls.Add(allList);
            fone2.Controls.Add(end);
            fone2.Controls.Add(header);
            fone2.Dock = DockStyle.Fill;
            fone2.Location = new Point(0, 0);
            fone2.Name = "fone2";
            fone2.Size = new Size(1201, 564);
            fone2.TabIndex = 0;
            fone2.MouseDown += fone2_MouseDown;
            fone2.MouseMove += fone2_MouseMove;
            // 
            // allList
            // 
            allList.AllowUserToAddRows = false;
            allList.AllowUserToDeleteRows = false;
            allList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            allList.Columns.AddRange(new DataGridViewColumn[] { name, year, semestr, speciality, control, lectures, laboratory, lector, allBook, delete });
            allList.Location = new Point(18, 96);
            allList.Name = "allList";
            allList.RowHeadersWidth = 62;
            allList.Size = new Size(1165, 407);
            allList.TabIndex = 3;
            allList.CellContentClick += allList_CellContentClick;
            // 
            // name
            // 
            name.HeaderText = "Name";
            name.MinimumWidth = 8;
            name.Name = "name";
            name.ReadOnly = true;
            name.Width = 150;
            // 
            // year
            // 
            year.HeaderText = "Year";
            year.MinimumWidth = 8;
            year.Name = "year";
            year.ReadOnly = true;
            year.Width = 50;
            // 
            // semestr
            // 
            semestr.HeaderText = "Semestr";
            semestr.MinimumWidth = 8;
            semestr.Name = "semestr";
            semestr.ReadOnly = true;
            semestr.Width = 150;
            // 
            // speciality
            // 
            speciality.HeaderText = "Speciality";
            speciality.MinimumWidth = 8;
            speciality.Name = "speciality";
            speciality.ReadOnly = true;
            speciality.Width = 90;
            // 
            // control
            // 
            control.HeaderText = "Control";
            control.MinimumWidth = 8;
            control.Name = "control";
            control.ReadOnly = true;
            control.Width = 80;
            // 
            // lectures
            // 
            lectures.HeaderText = "Lectures";
            lectures.MinimumWidth = 8;
            lectures.Name = "lectures";
            lectures.ReadOnly = true;
            lectures.Width = 90;
            // 
            // laboratory
            // 
            laboratory.HeaderText = "Laboratory";
            laboratory.MinimumWidth = 8;
            laboratory.Name = "laboratory";
            laboratory.ReadOnly = true;
            laboratory.Width = 110;
            // 
            // lector
            // 
            lector.HeaderText = "Lector";
            lector.MinimumWidth = 8;
            lector.Name = "lector";
            lector.ReadOnly = true;
            lector.Width = 80;
            // 
            // allBook
            // 
            allBook.HeaderText = "All Book";
            allBook.MinimumWidth = 8;
            allBook.Name = "allBook";
            allBook.Width = 150;
            // 
            // delete
            // 
            delete.HeaderText = "Delete";
            delete.MinimumWidth = 8;
            delete.Name = "delete";
            delete.ReadOnly = true;
            delete.Text = "delete";
            delete.Width = 150;
            // 
            // end
            // 
            end.AutoSize = true;
            end.Cursor = Cursors.Hand;
            end.Font = new Font("Times New Roman", 26F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            end.Location = new Point(533, 506);
            end.Name = "end";
            end.Size = new Size(135, 58);
            end.TabIndex = 2;
            end.Text = "Back";
            end.Click += end_Click;
            end.MouseEnter += end_MouseEnter;
            end.MouseLeave += end_MouseLeave;
            // 
            // header
            // 
            header.BackColor = Color.Teal;
            header.Controls.Add(listImage);
            header.Controls.Add(listName);
            header.Dock = DockStyle.Top;
            header.Location = new Point(0, 0);
            header.Name = "header";
            header.Size = new Size(1199, 83);
            header.TabIndex = 0;
            header.MouseDown += panel1_MouseDown;
            header.MouseMove += panel1_MouseMove;
            // 
            // listImage
            // 
            listImage.Image = Properties.Resources.list;
            listImage.Location = new Point(23, 12);
            listImage.Name = "listImage";
            listImage.Size = new Size(73, 61);
            listImage.SizeMode = PictureBoxSizeMode.StretchImage;
            listImage.TabIndex = 2;
            listImage.TabStop = false;
            // 
            // listName
            // 
            listName.AutoSize = true;
            listName.Font = new Font("Segoe Script", 28F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            listName.ForeColor = Color.FromArgb(1, 255, 242);
            listName.Location = new Point(428, -10);
            listName.Name = "listName";
            listName.Size = new Size(344, 93);
            listName.TabIndex = 1;
            listName.Text = "All Result";
            // 
            // ShowForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1201, 564);
            Controls.Add(fone2);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ShowForm";
            ShowIcon = false;
            Text = "Form2";
            fone2.ResumeLayout(false);
            fone2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)allList).EndInit();
            header.ResumeLayout(false);
            header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)listImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel fone2;
        private Panel header;
        private Label listName;
        private Label end;
        private PictureBox listImage;
        private DataGridView allList;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn year;
        private DataGridViewTextBoxColumn semestr;
        private DataGridViewTextBoxColumn speciality;
        private DataGridViewTextBoxColumn control;
        private DataGridViewTextBoxColumn lectures;
        private DataGridViewTextBoxColumn laboratory;
        private DataGridViewButtonColumn lector;
        private DataGridViewComboBoxColumn allBook;
        private DataGridViewButtonColumn delete;
    }
}
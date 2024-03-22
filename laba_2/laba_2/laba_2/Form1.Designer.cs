namespace laba_2
{
    partial class Fone
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fone));
            hader = new Panel();
            pictureBox1 = new PictureBox();
            listName = new Label();
            end = new Label();
            disciplineBox = new TextBox();
            discipline = new Label();
            firstSemester = new CheckBox();
            secondSemester = new CheckBox();
            semester = new Label();
            kurs = new Label();
            specialtyList = new ComboBox();
            specialty = new Label();
            lectures = new Label();
            laboratory = new Label();
            control = new Label();
            kurs1 = new RadioButton();
            kurs3 = new RadioButton();
            kurs2 = new RadioButton();
            kurs4 = new RadioButton();
            kurs5 = new RadioButton();
            controlEx = new RadioButton();
            controlTest = new RadioButton();
            groupType = new Panel();
            lectorFone = new Panel();
            phoneNumberBox = new MaskedTextBox();
            classRoomBox = new TextBox();
            phoneNumber = new Label();
            classRoom = new Label();
            deportamentBox = new ComboBox();
            deportament = new Label();
            lectorName = new Label();
            lectorerNameBox = new TextBox();
            buttonSave = new Button();
            buttonClear = new Button();
            buttonShow = new Button();
            resultSave = new Label();
            yearArea = new Panel();
            lecturesBox = new NumericUpDown();
            laboratoryBox = new NumericUpDown();
            remove = new Button();
            buttonAdd = new Button();
            listBook = new ListBox();
            sizePage = new NumericUpDown();
            dateCreat = new DateTimePicker();
            autor = new TextBox();
            nameBook = new TextBox();
            hader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupType.SuspendLayout();
            lectorFone.SuspendLayout();
            yearArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)lecturesBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)laboratoryBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sizePage).BeginInit();
            SuspendLayout();
            // 
            // hader
            // 
            hader.BackColor = Color.FromArgb(255, 128, 128);
            hader.Controls.Add(pictureBox1);
            hader.Controls.Add(listName);
            hader.Dock = DockStyle.Top;
            hader.Location = new Point(0, 0);
            hader.Name = "hader";
            hader.Size = new Size(819, 126);
            hader.TabIndex = 0;
            hader.MouseDown += hader_MouseDown;
            hader.MouseMove += hader_MouseMove;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.student;
            pictureBox1.Location = new Point(12, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(110, 110);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // listName
            // 
            listName.AutoSize = true;
            listName.Font = new Font("Segoe Script", 28F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            listName.ForeColor = Color.FromArgb(1, 255, 242);
            listName.Location = new Point(137, 29);
            listName.Name = "listName";
            listName.Size = new Size(598, 93);
            listName.TabIndex = 0;
            listName.Text = "Lesson Description";
            // 
            // end
            // 
            end.AutoSize = true;
            end.Cursor = Cursors.Hand;
            end.Font = new Font("Times New Roman", 26F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            end.Location = new Point(679, 946);
            end.Name = "end";
            end.Size = new Size(115, 58);
            end.TabIndex = 1;
            end.Text = "End";
            end.Click += label2_Click;
            end.MouseEnter += end_MouseEnter;
            end.MouseLeave += end_MouseLeave;
            // 
            // disciplineBox
            // 
            disciplineBox.BackColor = Color.White;
            disciplineBox.Location = new Point(226, 144);
            disciplineBox.Name = "disciplineBox";
            disciplineBox.Size = new Size(576, 31);
            disciplineBox.TabIndex = 2;
            disciplineBox.MouseEnter += disciplineBox_MouseEnter;
            disciplineBox.MouseLeave += disciplineBox_MouseLeave;
            // 
            // discipline
            // 
            discipline.AutoSize = true;
            discipline.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            discipline.ForeColor = Color.FromArgb(114, 0, 0);
            discipline.Location = new Point(12, 141);
            discipline.Name = "discipline";
            discipline.Size = new Size(208, 32);
            discipline.TabIndex = 3;
            discipline.Text = "Discipline Name";
            // 
            // firstSemester
            // 
            firstSemester.AutoSize = true;
            firstSemester.Font = new Font("Segoe UI", 9F);
            firstSemester.ForeColor = Color.Black;
            firstSemester.Location = new Point(409, 260);
            firstSemester.Name = "firstSemester";
            firstSemester.Size = new Size(71, 29);
            firstSemester.TabIndex = 4;
            firstSemester.Text = "First";
            firstSemester.UseVisualStyleBackColor = true;
            // 
            // secondSemester
            // 
            secondSemester.AutoSize = true;
            secondSemester.Font = new Font("Segoe UI", 9F);
            secondSemester.ForeColor = Color.Black;
            secondSemester.Location = new Point(409, 310);
            secondSemester.Name = "secondSemester";
            secondSemester.Size = new Size(97, 29);
            secondSemester.TabIndex = 5;
            secondSemester.Text = "Second";
            secondSemester.UseVisualStyleBackColor = true;
            // 
            // semester
            // 
            semester.AutoSize = true;
            semester.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            semester.ForeColor = Color.FromArgb(114, 0, 0);
            semester.Location = new Point(391, 209);
            semester.Name = "semester";
            semester.Size = new Size(120, 32);
            semester.TabIndex = 6;
            semester.Text = "Semester";
            // 
            // kurs
            // 
            kurs.AutoSize = true;
            kurs.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kurs.ForeColor = Color.FromArgb(114, 0, 0);
            kurs.Location = new Point(124, 218);
            kurs.Name = "kurs";
            kurs.Size = new Size(70, 32);
            kurs.TabIndex = 12;
            kurs.Text = "Year";
            // 
            // specialtyList
            // 
            specialtyList.DropDownStyle = ComboBoxStyle.DropDownList;
            specialtyList.FormattingEnabled = true;
            specialtyList.Items.AddRange(new object[] { "POIT", "DEVI", "POIBMS", "ISiT" });
            specialtyList.Location = new Point(648, 260);
            specialtyList.Name = "specialtyList";
            specialtyList.Size = new Size(140, 33);
            specialtyList.TabIndex = 13;
            // 
            // specialty
            // 
            specialty.AutoSize = true;
            specialty.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            specialty.ForeColor = Color.FromArgb(114, 0, 0);
            specialty.Location = new Point(648, 209);
            specialty.Name = "specialty";
            specialty.Size = new Size(140, 32);
            specialty.TabIndex = 14;
            specialty.Text = "Specialties";
            // 
            // lectures
            // 
            lectures.AutoSize = true;
            lectures.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lectures.ForeColor = Color.FromArgb(114, 0, 0);
            lectures.Location = new Point(445, 355);
            lectures.Name = "lectures";
            lectures.Size = new Size(250, 32);
            lectures.TabIndex = 15;
            lectures.Text = "Number of Lectures";
            // 
            // laboratory
            // 
            laboratory.AutoSize = true;
            laboratory.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            laboratory.ForeColor = Color.FromArgb(114, 0, 0);
            laboratory.Location = new Point(409, 403);
            laboratory.Name = "laboratory";
            laboratory.Size = new Size(286, 32);
            laboratory.TabIndex = 16;
            laboratory.Text = "Number of Laboratory";
            // 
            // control
            // 
            control.AutoSize = true;
            control.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            control.ForeColor = Color.FromArgb(114, 0, 0);
            control.Location = new Point(52, 348);
            control.Name = "control";
            control.Size = new Size(201, 32);
            control.TabIndex = 21;
            control.Text = "Type of Control";
            // 
            // kurs1
            // 
            kurs1.AutoSize = true;
            kurs1.Location = new Point(14, 13);
            kurs1.Name = "kurs1";
            kurs1.Size = new Size(47, 29);
            kurs1.TabIndex = 7;
            kurs1.TabStop = true;
            kurs1.Text = "1";
            kurs1.UseVisualStyleBackColor = true;
            // 
            // kurs3
            // 
            kurs3.AutoSize = true;
            kurs3.Location = new Point(120, 13);
            kurs3.Name = "kurs3";
            kurs3.Size = new Size(47, 29);
            kurs3.TabIndex = 8;
            kurs3.TabStop = true;
            kurs3.Text = "3";
            kurs3.UseVisualStyleBackColor = true;
            // 
            // kurs2
            // 
            kurs2.AutoSize = true;
            kurs2.Location = new Point(67, 13);
            kurs2.Name = "kurs2";
            kurs2.Size = new Size(47, 29);
            kurs2.TabIndex = 9;
            kurs2.TabStop = true;
            kurs2.Text = "2";
            kurs2.UseVisualStyleBackColor = true;
            // 
            // kurs4
            // 
            kurs4.AutoSize = true;
            kurs4.Location = new Point(173, 13);
            kurs4.Name = "kurs4";
            kurs4.Size = new Size(47, 29);
            kurs4.TabIndex = 10;
            kurs4.TabStop = true;
            kurs4.Text = "4";
            kurs4.UseVisualStyleBackColor = true;
            // 
            // kurs5
            // 
            kurs5.AutoSize = true;
            kurs5.Location = new Point(243, 273);
            kurs5.Name = "kurs5";
            kurs5.Size = new Size(47, 29);
            kurs5.TabIndex = 11;
            kurs5.TabStop = true;
            kurs5.Text = "5";
            kurs5.UseVisualStyleBackColor = true;
            // 
            // controlEx
            // 
            controlEx.AutoSize = true;
            controlEx.Location = new Point(12, 0);
            controlEx.Name = "controlEx";
            controlEx.Size = new Size(79, 29);
            controlEx.TabIndex = 19;
            controlEx.TabStop = true;
            controlEx.Text = "Exam";
            controlEx.TextAlign = ContentAlignment.TopCenter;
            controlEx.UseVisualStyleBackColor = true;
            // 
            // controlTest
            // 
            controlTest.AutoSize = true;
            controlTest.Location = new Point(117, 0);
            controlTest.Name = "controlTest";
            controlTest.Size = new Size(67, 29);
            controlTest.TabIndex = 20;
            controlTest.TabStop = true;
            controlTest.Text = "Test";
            controlTest.UseVisualStyleBackColor = true;
            // 
            // groupType
            // 
            groupType.Controls.Add(controlTest);
            groupType.Controls.Add(controlEx);
            groupType.Location = new Point(52, 389);
            groupType.Name = "groupType";
            groupType.Size = new Size(201, 46);
            groupType.TabIndex = 22;
            // 
            // lectorFone
            // 
            lectorFone.BackColor = Color.FromArgb(0, 150, 150);
            lectorFone.Controls.Add(phoneNumberBox);
            lectorFone.Controls.Add(classRoomBox);
            lectorFone.Controls.Add(phoneNumber);
            lectorFone.Controls.Add(classRoom);
            lectorFone.Controls.Add(deportamentBox);
            lectorFone.Controls.Add(deportament);
            lectorFone.Controls.Add(lectorName);
            lectorFone.Controls.Add(lectorerNameBox);
            lectorFone.Location = new Point(0, 457);
            lectorFone.Name = "lectorFone";
            lectorFone.Size = new Size(818, 150);
            lectorFone.TabIndex = 24;
            // 
            // phoneNumberBox
            // 
            phoneNumberBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phoneNumberBox.Location = new Point(577, 108);
            phoneNumberBox.Mask = "(999) 000-0000";
            phoneNumberBox.Name = "phoneNumberBox";
            phoneNumberBox.Size = new Size(193, 31);
            phoneNumberBox.TabIndex = 41;
            // 
            // classRoomBox
            // 
            classRoomBox.Location = new Point(321, 108);
            classRoomBox.Name = "classRoomBox";
            classRoomBox.Size = new Size(130, 31);
            classRoomBox.TabIndex = 30;
            classRoomBox.KeyPress += classRoomBox_KeyPress;
            classRoomBox.MouseEnter += classRoomBox_MouseEnter;
            classRoomBox.MouseLeave += classRoomBox_MouseLeave;
            // 
            // phoneNumber
            // 
            phoneNumber.AutoSize = true;
            phoneNumber.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            phoneNumber.ForeColor = Color.FromArgb(114, 0, 0);
            phoneNumber.Location = new Point(575, 73);
            phoneNumber.Name = "phoneNumber";
            phoneNumber.Size = new Size(195, 32);
            phoneNumber.TabIndex = 29;
            phoneNumber.Text = "Phone Number";
            // 
            // classRoom
            // 
            classRoom.AutoSize = true;
            classRoom.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            classRoom.ForeColor = Color.FromArgb(114, 0, 0);
            classRoom.Location = new Point(265, 73);
            classRoom.Name = "classRoom";
            classRoom.Size = new Size(244, 32);
            classRoom.TabIndex = 28;
            classRoom.Text = "Classroom Number";
            // 
            // deportamentBox
            // 
            deportamentBox.DropDownStyle = ComboBoxStyle.DropDownList;
            deportamentBox.FormattingEnabled = true;
            deportamentBox.Items.AddRange(new object[] { "KISiT", "KIiVD", "KPI", "KF", "KIG", "KVM" });
            deportamentBox.Location = new Point(31, 106);
            deportamentBox.Name = "deportamentBox";
            deportamentBox.Size = new Size(140, 33);
            deportamentBox.TabIndex = 25;
            // 
            // deportament
            // 
            deportament.AutoSize = true;
            deportament.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deportament.ForeColor = Color.FromArgb(114, 0, 0);
            deportament.Location = new Point(24, 71);
            deportament.Name = "deportament";
            deportament.Size = new Size(170, 32);
            deportament.TabIndex = 27;
            deportament.Text = "Deportament";
            // 
            // lectorName
            // 
            lectorName.AutoSize = true;
            lectorName.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lectorName.ForeColor = Color.FromArgb(114, 0, 0);
            lectorName.Location = new Point(12, 17);
            lectorName.Name = "lectorName";
            lectorName.Size = new Size(189, 32);
            lectorName.TabIndex = 26;
            lectorName.Text = "Lectorer Name";
            // 
            // lectorerNameBox
            // 
            lectorerNameBox.BackColor = Color.White;
            lectorerNameBox.Location = new Point(207, 20);
            lectorerNameBox.Name = "lectorerNameBox";
            lectorerNameBox.Size = new Size(576, 31);
            lectorerNameBox.TabIndex = 25;
            lectorerNameBox.MouseEnter += lectorerNameBox_MouseEnter;
            lectorerNameBox.MouseLeave += lectorerNameBox_MouseLeave;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.FromArgb(0, 150, 150);
            buttonSave.Cursor = Cursors.Hand;
            buttonSave.FlatAppearance.BorderColor = Color.Gray;
            buttonSave.FlatAppearance.BorderSize = 2;
            buttonSave.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 200, 210);
            buttonSave.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 192);
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSave.Location = new Point(556, 768);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(227, 175);
            buttonSave.TabIndex = 25;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonClear
            // 
            buttonClear.BackColor = Color.FromArgb(0, 150, 150);
            buttonClear.Cursor = Cursors.Hand;
            buttonClear.FlatAppearance.BorderColor = Color.Gray;
            buttonClear.FlatAppearance.BorderSize = 2;
            buttonClear.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 200, 210);
            buttonClear.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 192);
            buttonClear.FlatStyle = FlatStyle.Flat;
            buttonClear.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonClear.Location = new Point(298, 841);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(241, 102);
            buttonClear.TabIndex = 26;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = false;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonShow
            // 
            buttonShow.BackColor = Color.FromArgb(0, 150, 150);
            buttonShow.Cursor = Cursors.Hand;
            buttonShow.FlatAppearance.BorderColor = Color.Gray;
            buttonShow.FlatAppearance.BorderSize = 2;
            buttonShow.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 200, 210);
            buttonShow.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 192);
            buttonShow.FlatStyle = FlatStyle.Flat;
            buttonShow.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonShow.Location = new Point(24, 841);
            buttonShow.Name = "buttonShow";
            buttonShow.Size = new Size(256, 102);
            buttonShow.TabIndex = 27;
            buttonShow.Text = "Show Saved";
            buttonShow.UseVisualStyleBackColor = false;
            buttonShow.Click += buttonShow_Click;
            // 
            // resultSave
            // 
            resultSave.AutoSize = true;
            resultSave.Font = new Font("Times New Roman", 21F, FontStyle.Bold, GraphicsUnit.Point, 0);
            resultSave.ForeColor = Color.FromArgb(192, 0, 0);
            resultSave.Location = new Point(44, 954);
            resultSave.Name = "resultSave";
            resultSave.Size = new Size(0, 48);
            resultSave.TabIndex = 29;
            // 
            // yearArea
            // 
            yearArea.Controls.Add(kurs4);
            yearArea.Controls.Add(kurs2);
            yearArea.Controls.Add(kurs3);
            yearArea.Controls.Add(kurs1);
            yearArea.Location = new Point(17, 260);
            yearArea.Name = "yearArea";
            yearArea.Size = new Size(301, 68);
            yearArea.TabIndex = 30;
            // 
            // lecturesBox
            // 
            lecturesBox.Location = new Point(708, 359);
            lecturesBox.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            lecturesBox.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            lecturesBox.Name = "lecturesBox";
            lecturesBox.Size = new Size(86, 31);
            lecturesBox.TabIndex = 32;
            lecturesBox.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // laboratoryBox
            // 
            laboratoryBox.Location = new Point(708, 407);
            laboratoryBox.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            laboratoryBox.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            laboratoryBox.Name = "laboratoryBox";
            laboratoryBox.Size = new Size(86, 31);
            laboratoryBox.TabIndex = 33;
            laboratoryBox.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // remove
            // 
            remove.BackColor = Color.FromArgb(0, 150, 150);
            remove.Cursor = Cursors.Hand;
            remove.FlatAppearance.BorderColor = Color.Gray;
            remove.FlatAppearance.BorderSize = 2;
            remove.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 200, 210);
            remove.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 192);
            remove.FlatStyle = FlatStyle.Flat;
            remove.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            remove.Location = new Point(334, 768);
            remove.Name = "remove";
            remove.Size = new Size(160, 58);
            remove.TabIndex = 40;
            remove.Text = "Remove";
            remove.UseVisualStyleBackColor = false;
            remove.Click += remove_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.FromArgb(0, 150, 150);
            buttonAdd.Cursor = Cursors.Hand;
            buttonAdd.FlatAppearance.BorderColor = Color.Gray;
            buttonAdd.FlatAppearance.BorderSize = 2;
            buttonAdd.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 200, 210);
            buttonAdd.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 192);
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAdd.Location = new Point(64, 768);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(160, 58);
            buttonAdd.TabIndex = 39;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // listBook
            // 
            listBook.FormattingEnabled = true;
            listBook.ItemHeight = 25;
            listBook.Location = new Point(44, 674);
            listBook.Name = "listBook";
            listBook.Size = new Size(750, 79);
            listBook.TabIndex = 38;
            // 
            // sizePage
            // 
            sizePage.Location = new Point(614, 624);
            sizePage.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            sizePage.Name = "sizePage";
            sizePage.Size = new Size(180, 31);
            sizePage.TabIndex = 37;
            // 
            // dateCreat
            // 
            dateCreat.Location = new Point(424, 624);
            dateCreat.Name = "dateCreat";
            dateCreat.Size = new Size(180, 31);
            dateCreat.TabIndex = 36;
            // 
            // autor
            // 
            autor.Location = new Point(234, 624);
            autor.Name = "autor";
            autor.Size = new Size(180, 31);
            autor.TabIndex = 35;
            // 
            // nameBook
            // 
            nameBook.Location = new Point(44, 624);
            nameBook.Name = "nameBook";
            nameBook.Size = new Size(180, 31);
            nameBook.TabIndex = 34;
            // 
            // Fone
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(1, 255, 242);
            ClientSize = new Size(819, 1011);
            Controls.Add(remove);
            Controls.Add(buttonAdd);
            Controls.Add(listBook);
            Controls.Add(sizePage);
            Controls.Add(dateCreat);
            Controls.Add(autor);
            Controls.Add(nameBook);
            Controls.Add(laboratoryBox);
            Controls.Add(lecturesBox);
            Controls.Add(kurs5);
            Controls.Add(yearArea);
            Controls.Add(resultSave);
            Controls.Add(buttonShow);
            Controls.Add(buttonClear);
            Controls.Add(buttonSave);
            Controls.Add(lectorFone);
            Controls.Add(groupType);
            Controls.Add(control);
            Controls.Add(laboratory);
            Controls.Add(lectures);
            Controls.Add(specialty);
            Controls.Add(specialtyList);
            Controls.Add(kurs);
            Controls.Add(semester);
            Controls.Add(secondSemester);
            Controls.Add(firstSemester);
            Controls.Add(discipline);
            Controls.Add(disciplineBox);
            Controls.Add(end);
            Controls.Add(hader);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Fone";
            Text = "Form1";
            Load += Fone_Load;
            MouseDown += Fone_MouseDown;
            MouseMove += Fone_MouseMove;
            hader.ResumeLayout(false);
            hader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupType.ResumeLayout(false);
            groupType.PerformLayout();
            lectorFone.ResumeLayout(false);
            lectorFone.PerformLayout();
            yearArea.ResumeLayout(false);
            yearArea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)lecturesBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)laboratoryBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)sizePage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel hader;
        private Label listName;
        private Label end;
        private TextBox disciplineBox;
        private Label discipline;
        private PictureBox pictureBox1;
        private CheckBox firstSemester;
        private CheckBox secondSemester;
        private Label semester;
        private Label kurs;
        private ComboBox specialtyList;
        private Label specialty;
        private Label lectures;
        private Label laboratory;
        private Label control;
        private RadioButton kurs1;
        private RadioButton kurs3;
        private RadioButton kurs2;
        private RadioButton kurs4;
        private RadioButton kurs5;
        private RadioButton controlEx;
        private RadioButton controlTest;
        private Panel groupType;
        private Panel lectorFone;
        private Label lectorName;
        private TextBox lectorerNameBox;
        private ComboBox deportamentBox;
        private Label deportament;
        private TextBox classRoomBox;
        private Label phoneNumber;
        private Label classRoom;
        private Button buttonSave;
        private Button buttonClear;
        private Button buttonShow;
        private Label resultSave;
        private Panel yearArea;
        private NumericUpDown lecturesBox;
        private NumericUpDown laboratoryBox;
        private Button remove;
        private Button buttonAdd;
        private ListBox listBook;
        private NumericUpDown sizePage;
        private DateTimePicker dateCreat;
        private TextBox autor;
        private TextBox nameBook;
        private MaskedTextBox phoneNumberBox;
    }
}

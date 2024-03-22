namespace laba_2
{
    partial class LectorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LectorForm));
            fone3 = new Panel();
            end = new Label();
            phoneBox = new Label();
            classRoomBox = new Label();
            deportamentBox = new Label();
            nameBox = new Label();
            phone = new Label();
            classRoom = new Label();
            deportament = new Label();
            name = new Label();
            header = new Panel();
            listName = new Label();
            fone3.SuspendLayout();
            header.SuspendLayout();
            SuspendLayout();
            // 
            // fone3
            // 
            fone3.BackColor = Color.FromArgb(240, 75, 128);
            fone3.BorderStyle = BorderStyle.FixedSingle;
            fone3.Controls.Add(end);
            fone3.Controls.Add(phoneBox);
            fone3.Controls.Add(classRoomBox);
            fone3.Controls.Add(deportamentBox);
            fone3.Controls.Add(nameBox);
            fone3.Controls.Add(phone);
            fone3.Controls.Add(classRoom);
            fone3.Controls.Add(deportament);
            fone3.Controls.Add(name);
            fone3.Controls.Add(header);
            fone3.Dock = DockStyle.Fill;
            fone3.Location = new Point(0, 0);
            fone3.Name = "fone3";
            fone3.Size = new Size(441, 429);
            fone3.TabIndex = 0;
            fone3.MouseDown += fone3_MouseDown;
            fone3.MouseMove += fone3_MouseMove;
            // 
            // end
            // 
            end.AutoSize = true;
            end.Cursor = Cursors.Hand;
            end.Font = new Font("Times New Roman", 20F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            end.Location = new Point(296, 373);
            end.Name = "end";
            end.Size = new Size(112, 46);
            end.TabIndex = 9;
            end.Text = "Close";
            end.Click += end_Click;
            end.MouseEnter += end_MouseEnter;
            end.MouseLeave += end_MouseLeave;
            // 
            // phoneBox
            // 
            phoneBox.AutoSize = true;
            phoneBox.BackColor = Color.FromArgb(255, 108, 0);
            phoneBox.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            phoneBox.Location = new Point(278, 345);
            phoneBox.Name = "phoneBox";
            phoneBox.Size = new Size(0, 25);
            phoneBox.TabIndex = 8;
            // 
            // classRoomBox
            // 
            classRoomBox.AutoSize = true;
            classRoomBox.BackColor = Color.FromArgb(255, 108, 0);
            classRoomBox.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            classRoomBox.Location = new Point(227, 273);
            classRoomBox.Name = "classRoomBox";
            classRoomBox.Size = new Size(0, 25);
            classRoomBox.TabIndex = 7;
            // 
            // deportamentBox
            // 
            deportamentBox.AutoSize = true;
            deportamentBox.BackColor = Color.FromArgb(255, 108, 0);
            deportamentBox.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            deportamentBox.Location = new Point(249, 200);
            deportamentBox.Name = "deportamentBox";
            deportamentBox.Size = new Size(0, 25);
            deportamentBox.TabIndex = 6;
            // 
            // nameBox
            // 
            nameBox.AutoSize = true;
            nameBox.BackColor = Color.FromArgb(255, 108, 0);
            nameBox.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            nameBox.Location = new Point(152, 139);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(0, 25);
            nameBox.TabIndex = 5;
            // 
            // phone
            // 
            phone.AutoSize = true;
            phone.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            phone.Location = new Point(29, 332);
            phone.Name = "phone";
            phone.Size = new Size(226, 38);
            phone.TabIndex = 4;
            phone.Text = "Phone Number";
            // 
            // classRoom
            // 
            classRoom.AutoSize = true;
            classRoom.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            classRoom.Location = new Point(26, 260);
            classRoom.Name = "classRoom";
            classRoom.Size = new Size(178, 38);
            classRoom.TabIndex = 3;
            classRoom.Text = "Class Room";
            // 
            // deportament
            // 
            deportament.AutoSize = true;
            deportament.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            deportament.Location = new Point(26, 189);
            deportament.Name = "deportament";
            deportament.Size = new Size(203, 38);
            deportament.TabIndex = 2;
            deportament.Text = "Deportament";
            // 
            // name
            // 
            name.AutoSize = true;
            name.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            name.Location = new Point(29, 128);
            name.Name = "name";
            name.Size = new Size(99, 38);
            name.TabIndex = 1;
            name.Text = "Name";
            // 
            // header
            // 
            header.BackColor = Color.FromArgb(255, 108, 0);
            header.BorderStyle = BorderStyle.FixedSingle;
            header.Controls.Add(listName);
            header.Dock = DockStyle.Top;
            header.Location = new Point(0, 0);
            header.Name = "header";
            header.Size = new Size(439, 96);
            header.TabIndex = 0;
            header.MouseDown += header_MouseDown;
            header.MouseMove += header_MouseMove;
            // 
            // listName
            // 
            listName.AutoSize = true;
            listName.Font = new Font("Segoe Script", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listName.ForeColor = Color.FromArgb(240, 75, 128);
            listName.Location = new Point(119, 9);
            listName.Name = "listName";
            listName.Size = new Size(220, 93);
            listName.TabIndex = 2;
            listName.Text = "Lector";
            // 
            // LectorForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(441, 429);
            Controls.Add(fone3);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LectorForm";
            Text = "Form3";
            fone3.ResumeLayout(false);
            fone3.PerformLayout();
            header.ResumeLayout(false);
            header.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel fone3;
        private Panel header;
        private Label listName;
        private Label name;
        private Label deportament;
        private Label phone;
        private Label classRoom;
        private Label phoneBox;
        private Label classRoomBox;
        private Label deportamentBox;
        private Label nameBox;
        private Label end;
    }
}
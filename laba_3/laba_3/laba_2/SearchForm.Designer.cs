namespace laba_2
{
    partial class SearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchForm));
            fone = new Panel();
            ansver = new Label();
            reultSearch = new Button();
            yearSearch = new CheckBox();
            semestrSearch = new CheckBox();
            lectorSearch = new CheckBox();
            end = new Label();
            header = new Panel();
            pictureBox1 = new PictureBox();
            showSaved = new Button();
            listName = new Label();
            fone.SuspendLayout();
            header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // fone
            // 
            fone.BackColor = Color.Orange;
            fone.Controls.Add(ansver);
            fone.Controls.Add(reultSearch);
            fone.Controls.Add(yearSearch);
            fone.Controls.Add(semestrSearch);
            fone.Controls.Add(lectorSearch);
            fone.Controls.Add(end);
            fone.Controls.Add(header);
            fone.Dock = DockStyle.Fill;
            fone.Location = new Point(0, 0);
            fone.Name = "fone";
            fone.Size = new Size(800, 322);
            fone.TabIndex = 0;
            fone.MouseDown += fone_MouseDown;
            fone.MouseMove += fone_MouseMove;
            // 
            // ansver
            // 
            ansver.AutoSize = true;
            ansver.Font = new Font("Monotype Corsiva", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            ansver.ForeColor = Color.Brown;
            ansver.Location = new Point(251, 244);
            ansver.Name = "ansver";
            ansver.Size = new Size(0, 44);
            ansver.TabIndex = 8;
            // 
            // reultSearch
            // 
            reultSearch.BackColor = Color.Sienna;
            reultSearch.Cursor = Cursors.Hand;
            reultSearch.FlatAppearance.BorderColor = Color.Black;
            reultSearch.FlatAppearance.BorderSize = 2;
            reultSearch.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 128);
            reultSearch.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 0);
            reultSearch.FlatStyle = FlatStyle.Flat;
            reultSearch.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            reultSearch.ForeColor = Color.Orange;
            reultSearch.Location = new Point(34, 230);
            reultSearch.Name = "reultSearch";
            reultSearch.Size = new Size(200, 60);
            reultSearch.TabIndex = 7;
            reultSearch.Text = "Get Result";
            reultSearch.UseVisualStyleBackColor = false;
            reultSearch.Click += reultSearch_Click;
            // 
            // yearSearch
            // 
            yearSearch.AutoSize = true;
            yearSearch.Cursor = Cursors.Hand;
            yearSearch.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            yearSearch.ForeColor = Color.Sienna;
            yearSearch.Location = new Point(598, 115);
            yearSearch.Name = "yearSearch";
            yearSearch.Size = new Size(119, 30);
            yearSearch.TabIndex = 6;
            yearSearch.Text = "By Year";
            yearSearch.UseVisualStyleBackColor = true;
            yearSearch.CheckedChanged += yearSearch_CheckedChanged;
            // 
            // semestrSearch
            // 
            semestrSearch.AutoSize = true;
            semestrSearch.Cursor = Cursors.Hand;
            semestrSearch.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            semestrSearch.ForeColor = Color.Sienna;
            semestrSearch.Location = new Point(352, 115);
            semestrSearch.Name = "semestrSearch";
            semestrSearch.Size = new Size(165, 30);
            semestrSearch.TabIndex = 5;
            semestrSearch.Text = "By Semester";
            semestrSearch.UseVisualStyleBackColor = true;
            semestrSearch.CheckedChanged += semestrSearch_CheckedChanged;
            // 
            // lectorSearch
            // 
            lectorSearch.AutoSize = true;
            lectorSearch.Cursor = Cursors.Hand;
            lectorSearch.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lectorSearch.ForeColor = Color.Sienna;
            lectorSearch.Location = new Point(34, 115);
            lectorSearch.Name = "lectorSearch";
            lectorSearch.Size = new Size(239, 30);
            lectorSearch.TabIndex = 4;
            lectorSearch.Text = "By Lector Surname";
            lectorSearch.UseVisualStyleBackColor = true;
            lectorSearch.CheckedChanged += lectorSearch_CheckedChanged;
            // 
            // end
            // 
            end.AutoSize = true;
            end.Cursor = Cursors.Hand;
            end.Font = new Font("Times New Roman", 26F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            end.Location = new Point(662, 244);
            end.Name = "end";
            end.Size = new Size(114, 58);
            end.TabIndex = 3;
            end.Text = "Exit";
            end.Click += end_Click;
            end.MouseEnter += end_MouseEnter;
            end.MouseLeave += end_MouseLeave;
            // 
            // header
            // 
            header.BackColor = Color.Sienna;
            header.Controls.Add(pictureBox1);
            header.Controls.Add(showSaved);
            header.Controls.Add(listName);
            header.Location = new Point(0, 0);
            header.Name = "header";
            header.Size = new Size(800, 77);
            header.TabIndex = 0;
            header.MouseDown += panel1_MouseDown;
            header.MouseMove += panel1_MouseMove;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._115695_magnifying_glass_zoom_find_search_icon1;
            pictureBox1.Location = new Point(71, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(70, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // showSaved
            // 
            showSaved.BackColor = Color.Orange;
            showSaved.Cursor = Cursors.Hand;
            showSaved.FlatAppearance.BorderColor = Color.Black;
            showSaved.FlatAppearance.BorderSize = 2;
            showSaved.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 128);
            showSaved.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 0);
            showSaved.FlatStyle = FlatStyle.Flat;
            showSaved.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            showSaved.ForeColor = Color.Sienna;
            showSaved.Location = new Point(576, 10);
            showSaved.Name = "showSaved";
            showSaved.Size = new Size(200, 60);
            showSaved.TabIndex = 9;
            showSaved.Text = "Show Saved";
            showSaved.UseVisualStyleBackColor = false;
            showSaved.Click += showSaved_Click;
            // 
            // listName
            // 
            listName.AutoSize = true;
            listName.Font = new Font("Segoe Script", 20F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            listName.ForeColor = Color.Orange;
            listName.Location = new Point(283, 10);
            listName.Name = "listName";
            listName.Size = new Size(234, 67);
            listName.TabIndex = 2;
            listName.Text = "Search By";
            // 
            // SearchForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 322);
            Controls.Add(fone);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SearchForm";
            Text = "SearchForm";
            fone.ResumeLayout(false);
            fone.PerformLayout();
            header.ResumeLayout(false);
            header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel fone;
        private Panel header;
        private Label end;
        private Label listName;
        private CheckBox lectorSearch;
        private CheckBox semestrSearch;
        private CheckBox yearSearch;
        private Button reultSearch;
        private Label ansver;
        private PictureBox pictureBox1;
        private Button showSaved;
    }
}
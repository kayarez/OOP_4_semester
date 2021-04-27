namespace lab5
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.namebox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.genresbox = new System.Windows.Forms.GroupBox();
            this.RomanButton1 = new System.Windows.Forms.RadioButton();
            this.ComedyButton1 = new System.Windows.Forms.RadioButton();
            this.SadButton1 = new System.Windows.Forms.RadioButton();
            this.FantasyButton1 = new System.Windows.Forms.RadioButton();
            this.HorrorsButton1 = new System.Windows.Forms.RadioButton();
            this.SizeBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.UDKBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listCount = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.openPage1 = new System.Windows.Forms.TabPage();
            this.openDatePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.releasePage2 = new System.Windows.Forms.TabPage();
            this.releaseDatePicker1 = new System.Windows.Forms.DateTimePicker();
            this.authorBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AddAuthor = new System.Windows.Forms.Button();
            this.countryBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.serializeBut = new System.Windows.Forms.Button();
            this.deserializeBut = new System.Windows.Forms.Button();
            this.writeAll = new System.Windows.Forms.Button();
            this.Form2_Button = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.genresbox.SuspendLayout();
            this.SizeBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listCount)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.openPage1.SuspendLayout();
            this.releasePage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // namebox
            // 
            this.namebox.Location = new System.Drawing.Point(48, 39);
            this.namebox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(132, 22);
            this.namebox.TabIndex = 0;
            this.namebox.Tag = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название книги";
            // 
            // genresbox
            // 
            this.genresbox.Controls.Add(this.RomanButton1);
            this.genresbox.Controls.Add(this.ComedyButton1);
            this.genresbox.Controls.Add(this.SadButton1);
            this.genresbox.Controls.Add(this.FantasyButton1);
            this.genresbox.Controls.Add(this.HorrorsButton1);
            this.genresbox.Location = new System.Drawing.Point(48, 117);
            this.genresbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.genresbox.Name = "genresbox";
            this.genresbox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.genresbox.Size = new System.Drawing.Size(133, 169);
            this.genresbox.TabIndex = 2;
            this.genresbox.TabStop = false;
            this.genresbox.Text = "Жанры";
            // 
            // RomanButton1
            // 
            this.RomanButton1.AutoSize = true;
            this.RomanButton1.Location = new System.Drawing.Point(4, 138);
            this.RomanButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RomanButton1.Name = "RomanButton1";
            this.RomanButton1.Size = new System.Drawing.Size(101, 21);
            this.RomanButton1.TabIndex = 4;
            this.RomanButton1.TabStop = true;
            this.RomanButton1.Text = "Романтика";
            this.RomanButton1.UseVisualStyleBackColor = true;
            this.RomanButton1.CheckedChanged += new System.EventHandler(this.RomanButton1_CheckedChanged);
            // 
            // ComedyButton1
            // 
            this.ComedyButton1.AutoSize = true;
            this.ComedyButton1.Location = new System.Drawing.Point(4, 110);
            this.ComedyButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ComedyButton1.Name = "ComedyButton1";
            this.ComedyButton1.Size = new System.Drawing.Size(87, 21);
            this.ComedyButton1.TabIndex = 3;
            this.ComedyButton1.TabStop = true;
            this.ComedyButton1.Text = "Комедия";
            this.ComedyButton1.UseVisualStyleBackColor = true;
            this.ComedyButton1.CheckedChanged += new System.EventHandler(this.ComedyButton1_CheckedChanged);
            // 
            // SadButton1
            // 
            this.SadButton1.AutoSize = true;
            this.SadButton1.Location = new System.Drawing.Point(4, 81);
            this.SadButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SadButton1.Name = "SadButton1";
            this.SadButton1.Size = new System.Drawing.Size(73, 21);
            this.SadButton1.TabIndex = 2;
            this.SadButton1.TabStop = true;
            this.SadButton1.Text = "Драма";
            this.SadButton1.UseVisualStyleBackColor = true;
            this.SadButton1.CheckedChanged += new System.EventHandler(this.SadButton1_CheckedChanged);
            // 
            // FantasyButton1
            // 
            this.FantasyButton1.AutoSize = true;
            this.FantasyButton1.Location = new System.Drawing.Point(4, 53);
            this.FantasyButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FantasyButton1.Name = "FantasyButton1";
            this.FantasyButton1.Size = new System.Drawing.Size(110, 21);
            this.FantasyButton1.TabIndex = 1;
            this.FantasyButton1.TabStop = true;
            this.FantasyButton1.Text = "Фантастика";
            this.FantasyButton1.UseVisualStyleBackColor = true;
            this.FantasyButton1.CheckedChanged += new System.EventHandler(this.FantasyButton1_CheckedChanged);
            // 
            // HorrorsButton1
            // 
            this.HorrorsButton1.AutoSize = true;
            this.HorrorsButton1.Location = new System.Drawing.Point(4, 25);
            this.HorrorsButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HorrorsButton1.Name = "HorrorsButton1";
            this.HorrorsButton1.Size = new System.Drawing.Size(72, 21);
            this.HorrorsButton1.TabIndex = 0;
            this.HorrorsButton1.TabStop = true;
            this.HorrorsButton1.Text = "Ужасы";
            this.HorrorsButton1.UseVisualStyleBackColor = true;
            this.HorrorsButton1.CheckedChanged += new System.EventHandler(this.HorrorsButton1_CheckedChanged);
            // 
            // SizeBox1
            // 
            this.SizeBox1.Controls.Add(this.listBox1);
            this.SizeBox1.Controls.Add(this.numericUpDown1);
            this.SizeBox1.Location = new System.Drawing.Point(48, 294);
            this.SizeBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SizeBox1.Name = "SizeBox1";
            this.SizeBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SizeBox1.Size = new System.Drawing.Size(133, 129);
            this.SizeBox1.TabIndex = 3;
            this.SizeBox1.TabStop = false;
            this.SizeBox1.Text = "Размер файла";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "b",
            "Kb",
            "Mb"});
            this.listBox1.Location = new System.Drawing.Point(9, 58);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(111, 52);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(9, 25);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(116, 22);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // UDKBox
            // 
            this.UDKBox.Location = new System.Drawing.Point(48, 454);
            this.UDKBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UDKBox.Name = "UDKBox";
            this.UDKBox.Size = new System.Drawing.Size(132, 22);
            this.UDKBox.TabIndex = 4;
            this.UDKBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UDKBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 432);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "УДК";
            // 
            // listCount
            // 
            this.listCount.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.listCount.Location = new System.Drawing.Point(48, 514);
            this.listCount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listCount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.listCount.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.listCount.Name = "listCount";
            this.listCount.Size = new System.Drawing.Size(133, 22);
            this.listCount.TabIndex = 6;
            this.listCount.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 487);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Кол-во листов";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.openPage1);
            this.tabControl1.Controls.Add(this.releasePage2);
            this.tabControl1.Location = new System.Drawing.Point(216, 16);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(227, 75);
            this.tabControl1.TabIndex = 8;
            // 
            // openPage1
            // 
            this.openPage1.Controls.Add(this.openDatePicker1);
            this.openPage1.Controls.Add(this.label4);
            this.openPage1.Location = new System.Drawing.Point(4, 25);
            this.openPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.openPage1.Name = "openPage1";
            this.openPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.openPage1.Size = new System.Drawing.Size(219, 46);
            this.openPage1.TabIndex = 0;
            this.openPage1.Text = "Дата загрузки";
            this.openPage1.UseVisualStyleBackColor = true;
            // 
            // openDatePicker1
            // 
            this.openDatePicker1.Location = new System.Drawing.Point(8, 9);
            this.openDatePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.openDatePicker1.Name = "openDatePicker1";
            this.openDatePicker1.Size = new System.Drawing.Size(199, 22);
            this.openDatePicker1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 0;
            // 
            // releasePage2
            // 
            this.releasePage2.Controls.Add(this.releaseDatePicker1);
            this.releasePage2.Location = new System.Drawing.Point(4, 25);
            this.releasePage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.releasePage2.Name = "releasePage2";
            this.releasePage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.releasePage2.Size = new System.Drawing.Size(219, 46);
            this.releasePage2.TabIndex = 1;
            this.releasePage2.Text = "Дата выхода";
            this.releasePage2.UseVisualStyleBackColor = true;
            // 
            // releaseDatePicker1
            // 
            this.releaseDatePicker1.Location = new System.Drawing.Point(8, 9);
            this.releaseDatePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.releaseDatePicker1.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.releaseDatePicker1.Name = "releaseDatePicker1";
            this.releaseDatePicker1.Size = new System.Drawing.Size(199, 22);
            this.releaseDatePicker1.TabIndex = 0;
            // 
            // authorBox1
            // 
            this.authorBox1.Location = new System.Drawing.Point(0, 37);
            this.authorBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.authorBox1.Name = "authorBox1";
            this.authorBox1.Size = new System.Drawing.Size(220, 22);
            this.authorBox1.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 17);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Автор";
            // 
            // AddAuthor
            // 
            this.AddAuthor.Location = new System.Drawing.Point(0, 119);
            this.AddAuthor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddAuthor.Name = "AddAuthor";
            this.AddAuthor.Size = new System.Drawing.Size(221, 28);
            this.AddAuthor.TabIndex = 12;
            this.AddAuthor.Text = "Добавить автора";
            this.AddAuthor.UseVisualStyleBackColor = true;
            this.AddAuthor.Click += new System.EventHandler(this.AddAuthor_Click);
            // 
            // countryBox1
            // 
            this.countryBox1.Location = new System.Drawing.Point(0, 87);
            this.countryBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.countryBox1.Name = "countryBox1";
            this.countryBox1.Size = new System.Drawing.Size(220, 22);
            this.countryBox1.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1, 65);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Страна";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.AddAuthor);
            this.groupBox1.Controls.Add(this.countryBox1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.authorBox1);
            this.groupBox1.Location = new System.Drawing.Point(216, 100);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(221, 148);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(216, 256);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(221, 65);
            this.button1.TabIndex = 15;
            this.button1.Text = "Сохранить книгу";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // serializeBut
            // 
            this.serializeBut.Location = new System.Drawing.Point(216, 330);
            this.serializeBut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.serializeBut.Name = "serializeBut";
            this.serializeBut.Size = new System.Drawing.Size(221, 75);
            this.serializeBut.TabIndex = 16;
            this.serializeBut.Text = "Сериализовать";
            this.serializeBut.UseVisualStyleBackColor = true;
            this.serializeBut.Click += new System.EventHandler(this.serializeBut_Click);
            // 
            // deserializeBut
            // 
            this.deserializeBut.Location = new System.Drawing.Point(216, 414);
            this.deserializeBut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deserializeBut.Name = "deserializeBut";
            this.deserializeBut.Size = new System.Drawing.Size(221, 74);
            this.deserializeBut.TabIndex = 17;
            this.deserializeBut.Text = "Десериализовать";
            this.deserializeBut.UseVisualStyleBackColor = true;
            this.deserializeBut.Click += new System.EventHandler(this.deserializeBut_Click);
            // 
            // writeAll
            // 
            this.writeAll.Location = new System.Drawing.Point(216, 495);
            this.writeAll.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.writeAll.Name = "writeAll";
            this.writeAll.Size = new System.Drawing.Size(221, 43);
            this.writeAll.TabIndex = 18;
            this.writeAll.Text = "Список объектов";
            this.writeAll.UseVisualStyleBackColor = true;
            this.writeAll.Click += new System.EventHandler(this.writeAll_Click);
            // 
            // Form2_Button
            // 
            this.Form2_Button.Location = new System.Drawing.Point(452, 16);
            this.Form2_Button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Form2_Button.Name = "Form2_Button";
            this.Form2_Button.Size = new System.Drawing.Size(163, 48);
            this.Form2_Button.TabIndex = 19;
            this.Form2_Button.Text = "Перейти к окну поиска";
            this.Form2_Button.UseVisualStyleBackColor = true;
            this.Form2_Button.Click += new System.EventHandler(this.Form2_Button_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 560);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1067, 22);
            this.statusStrip1.TabIndex = 20;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 16);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 16);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 582);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.Form2_Button);
            this.Controls.Add(this.writeAll);
            this.Controls.Add(this.deserializeBut);
            this.Controls.Add(this.serializeBut);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UDKBox);
            this.Controls.Add(this.SizeBox1);
            this.Controls.Add(this.genresbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.namebox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.genresbox.ResumeLayout(false);
            this.genresbox.PerformLayout();
            this.SizeBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listCount)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.openPage1.ResumeLayout(false);
            this.openPage1.PerformLayout();
            this.releasePage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox namebox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox genresbox;
        private System.Windows.Forms.RadioButton RomanButton1;
        private System.Windows.Forms.RadioButton ComedyButton1;
        private System.Windows.Forms.RadioButton SadButton1;
        private System.Windows.Forms.RadioButton FantasyButton1;
        private System.Windows.Forms.RadioButton HorrorsButton1;
        private System.Windows.Forms.GroupBox SizeBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox UDKBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown listCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage openPage1;
        private System.Windows.Forms.DateTimePicker openDatePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage releasePage2;
        private System.Windows.Forms.DateTimePicker releaseDatePicker1;
        private System.Windows.Forms.TextBox authorBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AddAuthor;
        private System.Windows.Forms.TextBox countryBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button serializeBut;
        private System.Windows.Forms.Button deserializeBut;
        private System.Windows.Forms.Button writeAll;
        private System.Windows.Forms.Button Form2_Button;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
    }
}


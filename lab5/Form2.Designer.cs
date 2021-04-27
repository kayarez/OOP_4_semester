namespace lab5
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.SearchButtonTool = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.названиюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UpSortToolMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.DescSortTool = new System.Windows.Forms.ToolStripMenuItem();
            this.датеЗагрузкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UpDateSortTool = new System.Windows.Forms.ToolStripMenuItem();
            this.DescDateSortTool = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SearchButtonTool,
            this.toolStripButton1,
            this.toolStripDropDownButton1,
            this.toolStripButton2,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(718, 25);
            this.toolStrip1.TabIndex = 0;
            // 
            // SearchButtonTool
            // 
            this.SearchButtonTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SearchButtonTool.Image = ((System.Drawing.Image)(resources.GetObject("SearchButtonTool.Image")));
            this.SearchButtonTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SearchButtonTool.Name = "SearchButtonTool";
            this.SearchButtonTool.Size = new System.Drawing.Size(46, 22);
            this.SearchButtonTool.Text = "Поиск";
            this.SearchButtonTool.Click += new System.EventHandler(this.SearchButtonTool_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(63, 22);
            this.toolStripButton1.Text = "Очистить";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.названиюToolStripMenuItem,
            this.датеЗагрузкиToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(103, 22);
            this.toolStripDropDownButton1.Text = "Сортировка по";
            // 
            // названиюToolStripMenuItem
            // 
            this.названиюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UpSortToolMenu,
            this.DescSortTool});
            this.названиюToolStripMenuItem.Name = "названиюToolStripMenuItem";
            this.названиюToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.названиюToolStripMenuItem.Text = "Названию";
            // 
            // UpSortToolMenu
            // 
            this.UpSortToolMenu.Name = "UpSortToolMenu";
            this.UpSortToolMenu.Size = new System.Drawing.Size(109, 22);
            this.UpSortToolMenu.Text = "Вовзр.";
            this.UpSortToolMenu.Click += new System.EventHandler(this.UpSortToolMenu_Click);
            // 
            // DescSortTool
            // 
            this.DescSortTool.Name = "DescSortTool";
            this.DescSortTool.Size = new System.Drawing.Size(109, 22);
            this.DescSortTool.Text = "Убыв.";
            this.DescSortTool.Click += new System.EventHandler(this.DescSortTool_Click);
            // 
            // датеЗагрузкиToolStripMenuItem
            // 
            this.датеЗагрузкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UpDateSortTool,
            this.DescDateSortTool});
            this.датеЗагрузкиToolStripMenuItem.Name = "датеЗагрузкиToolStripMenuItem";
            this.датеЗагрузкиToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.датеЗагрузкиToolStripMenuItem.Text = "Дате загрузки";
            // 
            // UpDateSortTool
            // 
            this.UpDateSortTool.Name = "UpDateSortTool";
            this.UpDateSortTool.Size = new System.Drawing.Size(109, 22);
            this.UpDateSortTool.Text = "Вовзр.";
            this.UpDateSortTool.Click += new System.EventHandler(this.UpDateSortTool_Click);
            // 
            // DescDateSortTool
            // 
            this.DescDateSortTool.Name = "DescDateSortTool";
            this.DescDateSortTool.Size = new System.Drawing.Size(109, 22);
            this.DescDateSortTool.Text = "Убыв.";
            this.DescDateSortTool.Click += new System.EventHandler(this.DescDateSortTool_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(69, 22);
            this.toolStripButton2.Text = "Сохранить";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(86, 22);
            this.toolStripButton3.Text = "О программе";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 311);
            this.label1.TabIndex = 1;
            this.label1.UseCompatibleTextRendering = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(609, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Скрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 400);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem названиюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UpSortToolMenu;
        private System.Windows.Forms.ToolStripMenuItem DescSortTool;
        private System.Windows.Forms.ToolStripMenuItem датеЗагрузкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UpDateSortTool;
        private System.Windows.Forms.ToolStripMenuItem DescDateSortTool;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton SearchButtonTool;
        private System.Windows.Forms.Button button1;
    }
}
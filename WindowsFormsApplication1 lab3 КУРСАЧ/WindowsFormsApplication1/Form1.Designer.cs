namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadMyShapeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadMyImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShapeStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Addmyshape = new System.Windows.Forms.ToolStripMenuItem();
            this.DD = new System.Windows.Forms.ToolStripComboBox();
            this.paletteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.widthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.fToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.fToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteShapeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.labelX = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelY = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox13 = new System.Windows.Forms.CheckBox();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.eraseBox = new System.Windows.Forms.CheckBox();
            this.triangleBox = new System.Windows.Forms.CheckBox();
            this.pencilBox = new System.Windows.Forms.CheckBox();
            this.lineBox = new System.Windows.Forms.CheckBox();
            this.ellipseBox = new System.Windows.Forms.CheckBox();
            this.rectangleBox = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.ShapeStripMenuItem,
            this.paletteToolStripMenuItem,
            this.widthToolStripMenuItem,
            this.deleteShapeToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(919, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.saveImageToolStripMenuItem,
            this.loadToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // saveImageToolStripMenuItem
            // 
            this.saveImageToolStripMenuItem.Name = "saveImageToolStripMenuItem";
            this.saveImageToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.saveImageToolStripMenuItem.Text = "Save";
            this.saveImageToolStripMenuItem.Click += new System.EventHandler(this.saveImageToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadMyShapeToolStripMenuItem,
            this.loadMyImageToolStripMenuItem});
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem.Text = "Load";
            // 
            // loadMyShapeToolStripMenuItem
            // 
            this.loadMyShapeToolStripMenuItem.Name = "loadMyShapeToolStripMenuItem";
            this.loadMyShapeToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.loadMyShapeToolStripMenuItem.Text = "Load my shape";
            this.loadMyShapeToolStripMenuItem.Click += new System.EventHandler(this.loadMyShapeToolStripMenuItem_Click);
            // 
            // loadMyImageToolStripMenuItem
            // 
            this.loadMyImageToolStripMenuItem.Name = "loadMyImageToolStripMenuItem";
            this.loadMyImageToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.loadMyImageToolStripMenuItem.Text = "Load my image";
            this.loadMyImageToolStripMenuItem.Click += new System.EventHandler(this.loadMyImageToolStripMenuItem_Click);
            // 
            // ShapeStripMenuItem
            // 
            this.ShapeStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.Addmyshape,
            this.DD});
            this.ShapeStripMenuItem.Name = "ShapeStripMenuItem";
            this.ShapeStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.ShapeStripMenuItem.Text = "     Shape     ";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(207, 6);
            // 
            // Addmyshape
            // 
            this.Addmyshape.Name = "Addmyshape";
            this.Addmyshape.Size = new System.Drawing.Size(210, 22);
            this.Addmyshape.Text = "Add my shape";
            this.Addmyshape.Click += new System.EventHandler(this.Addmyshape_Click);
            // 
            // DD
            // 
            this.DD.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.DD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DD.IntegralHeight = false;
            this.DD.Items.AddRange(new object[] {
            "Rectangle",
            "Ellipse",
            "Triangle"});
            this.DD.MaxDropDownItems = 20;
            this.DD.Name = "DD";
            this.DD.Size = new System.Drawing.Size(150, 23);
            this.DD.SelectedIndexChanged += new System.EventHandler(this.DD_SelectedIndexChanged);
            // 
            // paletteToolStripMenuItem
            // 
            this.paletteToolStripMenuItem.Name = "paletteToolStripMenuItem";
            this.paletteToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.paletteToolStripMenuItem.Text = "Pallette";
            this.paletteToolStripMenuItem.Click += new System.EventHandler(this.paletteToolStripMenuItem_Click);
            // 
            // widthToolStripMenuItem
            // 
            this.widthToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fToolStripMenuItem,
            this.fToolStripMenuItem1,
            this.fToolStripMenuItem2,
            this.fToolStripMenuItem3,
            this.fToolStripMenuItem4});
            this.widthToolStripMenuItem.Name = "widthToolStripMenuItem";
            this.widthToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.widthToolStripMenuItem.Text = "Width";
            // 
            // fToolStripMenuItem
            // 
            this.fToolStripMenuItem.Name = "fToolStripMenuItem";
            this.fToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.fToolStripMenuItem.Text = "1.0F";
            this.fToolStripMenuItem.Click += new System.EventHandler(this.fToolStripMenuItem_Click);
            // 
            // fToolStripMenuItem1
            // 
            this.fToolStripMenuItem1.Name = "fToolStripMenuItem1";
            this.fToolStripMenuItem1.Size = new System.Drawing.Size(95, 22);
            this.fToolStripMenuItem1.Text = "2.0F";
            this.fToolStripMenuItem1.Click += new System.EventHandler(this.fToolStripMenuItem1_Click);
            // 
            // fToolStripMenuItem2
            // 
            this.fToolStripMenuItem2.Name = "fToolStripMenuItem2";
            this.fToolStripMenuItem2.Size = new System.Drawing.Size(95, 22);
            this.fToolStripMenuItem2.Text = "3.0F";
            this.fToolStripMenuItem2.Click += new System.EventHandler(this.fToolStripMenuItem2_Click);
            // 
            // fToolStripMenuItem3
            // 
            this.fToolStripMenuItem3.Name = "fToolStripMenuItem3";
            this.fToolStripMenuItem3.Size = new System.Drawing.Size(95, 22);
            this.fToolStripMenuItem3.Text = "4.0F";
            this.fToolStripMenuItem3.Click += new System.EventHandler(this.fToolStripMenuItem3_Click);
            // 
            // fToolStripMenuItem4
            // 
            this.fToolStripMenuItem4.Name = "fToolStripMenuItem4";
            this.fToolStripMenuItem4.Size = new System.Drawing.Size(95, 22);
            this.fToolStripMenuItem4.Text = "5.0F";
            this.fToolStripMenuItem4.Click += new System.EventHandler(this.fToolStripMenuItem4_Click);
            // 
            // deleteShapeToolStripMenuItem
            // 
            this.deleteShapeToolStripMenuItem.Name = "deleteShapeToolStripMenuItem";
            this.deleteShapeToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.deleteShapeToolStripMenuItem.Text = "DeleteShape";
            this.deleteShapeToolStripMenuItem.Click += new System.EventHandler(this.deleteShapeToolStripMenuItem_Click);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("undoToolStripMenuItem.Image")));
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.undoToolStripMenuItem.Text = " ";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("redoToolStripMenuItem.Image")));
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.redoToolStripMenuItem.Text = " ";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelX,
            this.labelY});
            this.statusStrip1.Location = new System.Drawing.Point(0, 511);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(919, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // labelX
            // 
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(17, 17);
            this.labelX.Text = " X";
            // 
            // labelY
            // 
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(14, 17);
            this.labelY.Text = "Y";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Location = new System.Drawing.Point(90, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(817, 425);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDoubleClick);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBox13);
            this.panel1.Controls.Add(this.checkBox12);
            this.panel1.Controls.Add(this.checkBox11);
            this.panel1.Controls.Add(this.checkBox10);
            this.panel1.Controls.Add(this.checkBox9);
            this.panel1.Controls.Add(this.checkBox8);
            this.panel1.Controls.Add(this.checkBox7);
            this.panel1.Controls.Add(this.checkBox6);
            this.panel1.Controls.Add(this.checkBox5);
            this.panel1.Controls.Add(this.checkBox4);
            this.panel1.Controls.Add(this.checkBox3);
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.eraseBox);
            this.panel1.Controls.Add(this.triangleBox);
            this.panel1.Controls.Add(this.pencilBox);
            this.panel1.Controls.Add(this.lineBox);
            this.panel1.Controls.Add(this.ellipseBox);
            this.panel1.Controls.Add(this.rectangleBox);
            this.panel1.Location = new System.Drawing.Point(2, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(82, 425);
            this.panel1.TabIndex = 8;
            // 
            // checkBox13
            // 
            this.checkBox13.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox13.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBox13.Image = ((System.Drawing.Image)(resources.GetObject("checkBox13.Image")));
            this.checkBox13.Location = new System.Drawing.Point(10, 278);
            this.checkBox13.Name = "checkBox13";
            this.checkBox13.Size = new System.Drawing.Size(23, 23);
            this.checkBox13.TabIndex = 21;
            this.checkBox13.UseVisualStyleBackColor = true;
            // 
            // checkBox12
            // 
            this.checkBox12.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBox12.Image = ((System.Drawing.Image)(resources.GetObject("checkBox12.Image")));
            this.checkBox12.Location = new System.Drawing.Point(10, 249);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(23, 23);
            this.checkBox12.TabIndex = 20;
            this.checkBox12.UseVisualStyleBackColor = true;
            // 
            // checkBox11
            // 
            this.checkBox11.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBox11.Image = ((System.Drawing.Image)(resources.GetObject("checkBox11.Image")));
            this.checkBox11.Location = new System.Drawing.Point(10, 220);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(23, 23);
            this.checkBox11.TabIndex = 19;
            this.checkBox11.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            this.checkBox10.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBox10.Image = ((System.Drawing.Image)(resources.GetObject("checkBox10.Image")));
            this.checkBox10.Location = new System.Drawing.Point(39, 308);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(23, 23);
            this.checkBox10.TabIndex = 18;
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            this.checkBox9.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBox9.Image = ((System.Drawing.Image)(resources.GetObject("checkBox9.Image")));
            this.checkBox9.Location = new System.Drawing.Point(10, 191);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(23, 23);
            this.checkBox9.TabIndex = 9;
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBox8.Image = ((System.Drawing.Image)(resources.GetObject("checkBox8.Image")));
            this.checkBox8.Location = new System.Drawing.Point(39, 279);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(23, 23);
            this.checkBox8.TabIndex = 17;
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBox7.Image = ((System.Drawing.Image)(resources.GetObject("checkBox7.Image")));
            this.checkBox7.Location = new System.Drawing.Point(10, 162);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(23, 23);
            this.checkBox7.TabIndex = 16;
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBox6.Image = ((System.Drawing.Image)(resources.GetObject("checkBox6.Image")));
            this.checkBox6.Location = new System.Drawing.Point(39, 250);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(23, 23);
            this.checkBox6.TabIndex = 15;
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBox5.Image = ((System.Drawing.Image)(resources.GetObject("checkBox5.Image")));
            this.checkBox5.Location = new System.Drawing.Point(10, 133);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(23, 23);
            this.checkBox5.TabIndex = 14;
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBox4.Image = ((System.Drawing.Image)(resources.GetObject("checkBox4.Image")));
            this.checkBox4.Location = new System.Drawing.Point(39, 221);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(23, 23);
            this.checkBox4.TabIndex = 13;
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBox3.Image = ((System.Drawing.Image)(resources.GetObject("checkBox3.Image")));
            this.checkBox3.Location = new System.Drawing.Point(39, 162);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(23, 23);
            this.checkBox3.TabIndex = 12;
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBox2.Image = ((System.Drawing.Image)(resources.GetObject("checkBox2.Image")));
            this.checkBox2.Location = new System.Drawing.Point(39, 192);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(23, 23);
            this.checkBox2.TabIndex = 11;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBox1.Image = ((System.Drawing.Image)(resources.GetObject("checkBox1.Image")));
            this.checkBox1.Location = new System.Drawing.Point(39, 133);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(23, 23);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // eraseBox
            // 
            this.eraseBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.eraseBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.eraseBox.Image = ((System.Drawing.Image)(resources.GetObject("eraseBox.Image")));
            this.eraseBox.Location = new System.Drawing.Point(39, 92);
            this.eraseBox.Name = "eraseBox";
            this.eraseBox.Size = new System.Drawing.Size(23, 24);
            this.eraseBox.TabIndex = 9;
            this.eraseBox.UseVisualStyleBackColor = true;
            this.eraseBox.CheckedChanged += new System.EventHandler(this.eraseBox_CheckedChanged);
            // 
            // triangleBox
            // 
            this.triangleBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.triangleBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.triangleBox.Image = ((System.Drawing.Image)(resources.GetObject("triangleBox.Image")));
            this.triangleBox.Location = new System.Drawing.Point(10, 64);
            this.triangleBox.Name = "triangleBox";
            this.triangleBox.Size = new System.Drawing.Size(23, 23);
            this.triangleBox.TabIndex = 1;
            this.triangleBox.UseVisualStyleBackColor = true;
            this.triangleBox.CheckedChanged += new System.EventHandler(this.triangleBox_CheckedChanged);
            // 
            // pencilBox
            // 
            this.pencilBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.pencilBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pencilBox.Image = ((System.Drawing.Image)(resources.GetObject("pencilBox.Image")));
            this.pencilBox.Location = new System.Drawing.Point(10, 93);
            this.pencilBox.Name = "pencilBox";
            this.pencilBox.Size = new System.Drawing.Size(23, 23);
            this.pencilBox.TabIndex = 1;
            this.pencilBox.UseVisualStyleBackColor = true;
            this.pencilBox.CheckedChanged += new System.EventHandler(this.pencilBox_CheckedChanged);
            // 
            // lineBox
            // 
            this.lineBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.lineBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lineBox.Image = ((System.Drawing.Image)(resources.GetObject("lineBox.Image")));
            this.lineBox.Location = new System.Drawing.Point(39, 64);
            this.lineBox.Name = "lineBox";
            this.lineBox.Size = new System.Drawing.Size(23, 23);
            this.lineBox.TabIndex = 1;
            this.lineBox.UseVisualStyleBackColor = true;
            this.lineBox.CheckedChanged += new System.EventHandler(this.lineBox_CheckedChanged);
            // 
            // ellipseBox
            // 
            this.ellipseBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.ellipseBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ellipseBox.Image = ((System.Drawing.Image)(resources.GetObject("ellipseBox.Image")));
            this.ellipseBox.Location = new System.Drawing.Point(39, 35);
            this.ellipseBox.Name = "ellipseBox";
            this.ellipseBox.Size = new System.Drawing.Size(23, 23);
            this.ellipseBox.TabIndex = 1;
            this.ellipseBox.UseVisualStyleBackColor = true;
            this.ellipseBox.CheckedChanged += new System.EventHandler(this.ellipseBox_CheckedChanged);
            // 
            // rectangleBox
            // 
            this.rectangleBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.rectangleBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rectangleBox.Image = ((System.Drawing.Image)(resources.GetObject("rectangleBox.Image")));
            this.rectangleBox.Location = new System.Drawing.Point(10, 35);
            this.rectangleBox.Name = "rectangleBox";
            this.rectangleBox.Size = new System.Drawing.Size(23, 23);
            this.rectangleBox.TabIndex = 1;
            this.rectangleBox.UseVisualStyleBackColor = true;
            this.rectangleBox.CheckedChanged += new System.EventHandler(this.rectangleBox_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 533);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pictureBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "MyPaint";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel labelX;
        private System.Windows.Forms.ToolStripStatusLabel labelY;
        private System.Windows.Forms.ToolStripMenuItem ShapeStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox DD;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem Addmyshape;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadMyShapeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadMyImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paletteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox rectangleBox;
        private System.Windows.Forms.CheckBox lineBox;
        private System.Windows.Forms.CheckBox ellipseBox;
        private System.Windows.Forms.CheckBox triangleBox;
        private System.Windows.Forms.CheckBox pencilBox;
        private System.Windows.Forms.ToolStripMenuItem deleteShapeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem widthToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem fToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem fToolStripMenuItem4;
        private System.Windows.Forms.CheckBox eraseBox;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox13;
        private System.Windows.Forms.CheckBox checkBox12;
        private System.Windows.Forms.CheckBox checkBox11;
    }
}


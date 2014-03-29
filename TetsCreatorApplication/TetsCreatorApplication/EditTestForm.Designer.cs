namespace TetsCreatorApplication
{
    partial class EditTestForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.TimeTestLabel = new System.Windows.Forms.Label();
            this.TestTimeUpDown = new System.Windows.Forms.NumericUpDown();
            this.TestModeLabel = new System.Windows.Forms.Label();
            this.CommonModeTextBox = new System.Windows.Forms.CheckBox();
            this.ControlModeCheckBox = new System.Windows.Forms.CheckBox();
            this.ExcellentPersentLabel = new System.Windows.Forms.Label();
            this.PercentExcelentUpDown = new System.Windows.Forms.NumericUpDown();
            this.PercentWellUpDown = new System.Windows.Forms.NumericUpDown();
            this.WellPercentLabel = new System.Windows.Forms.Label();
            this.PercentSatisfactorilyUpDown = new System.Windows.Forms.NumericUpDown();
            this.CreateTestButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.testNameLabel = new System.Windows.Forms.Label();
            this.TetsNameTextBox = new System.Windows.Forms.TextBox();
            this.SatisfactorilyPercentLabel = new System.Windows.Forms.Label();
            this.TestThemeLabel = new System.Windows.Forms.Label();
            this.ThemeNameTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.TestTimeUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PercentExcelentUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PercentWellUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PercentSatisfactorilyUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(193, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Общая информация о тесте";
            // 
            // TimeTestLabel
            // 
            this.TimeTestLabel.AutoSize = true;
            this.TimeTestLabel.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimeTestLabel.Location = new System.Drawing.Point(22, 127);
            this.TimeTestLabel.Name = "TimeTestLabel";
            this.TimeTestLabel.Size = new System.Drawing.Size(210, 18);
            this.TimeTestLabel.TabIndex = 1;
            this.TimeTestLabel.Text = "Время выполнения (мин)";
            // 
            // TestTimeUpDown
            // 
            this.TestTimeUpDown.Location = new System.Drawing.Point(251, 125);
            this.TestTimeUpDown.Name = "TestTimeUpDown";
            this.TestTimeUpDown.Size = new System.Drawing.Size(50, 20);
            this.TestTimeUpDown.TabIndex = 2;
            // 
            // TestModeLabel
            // 
            this.TestModeLabel.AutoSize = true;
            this.TestModeLabel.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TestModeLabel.Location = new System.Drawing.Point(22, 158);
            this.TestModeLabel.Name = "TestModeLabel";
            this.TestModeLabel.Size = new System.Drawing.Size(279, 18);
            this.TestModeLabel.TabIndex = 3;
            this.TestModeLabel.Text = "Возможные режимы выполнения";
            // 
            // CommonModeTextBox
            // 
            this.CommonModeTextBox.AutoSize = true;
            this.CommonModeTextBox.Location = new System.Drawing.Point(341, 159);
            this.CommonModeTextBox.Name = "CommonModeTextBox";
            this.CommonModeTextBox.Size = new System.Drawing.Size(73, 17);
            this.CommonModeTextBox.TabIndex = 4;
            this.CommonModeTextBox.Text = "Обычный";
            this.CommonModeTextBox.UseVisualStyleBackColor = true;
            // 
            // ControlModeCheckBox
            // 
            this.ControlModeCheckBox.AutoSize = true;
            this.ControlModeCheckBox.Location = new System.Drawing.Point(430, 158);
            this.ControlModeCheckBox.Name = "ControlModeCheckBox";
            this.ControlModeCheckBox.Size = new System.Drawing.Size(74, 17);
            this.ControlModeCheckBox.TabIndex = 5;
            this.ControlModeCheckBox.Text = "Контроль";
            this.ControlModeCheckBox.UseVisualStyleBackColor = true;
            // 
            // ExcellentPersentLabel
            // 
            this.ExcellentPersentLabel.AutoSize = true;
            this.ExcellentPersentLabel.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExcellentPersentLabel.Location = new System.Drawing.Point(22, 188);
            this.ExcellentPersentLabel.Name = "ExcellentPersentLabel";
            this.ExcellentPersentLabel.Size = new System.Drawing.Size(364, 18);
            this.ExcellentPersentLabel.TabIndex = 6;
            this.ExcellentPersentLabel.Text = "Процент правильных ответов на отлично";
            // 
            // PercentExcelentUpDown
            // 
            this.PercentExcelentUpDown.Location = new System.Drawing.Point(414, 186);
            this.PercentExcelentUpDown.Name = "PercentExcelentUpDown";
            this.PercentExcelentUpDown.Size = new System.Drawing.Size(50, 20);
            this.PercentExcelentUpDown.TabIndex = 7;
            // 
            // PercentWellUpDown
            // 
            this.PercentWellUpDown.Location = new System.Drawing.Point(414, 223);
            this.PercentWellUpDown.Name = "PercentWellUpDown";
            this.PercentWellUpDown.Size = new System.Drawing.Size(50, 20);
            this.PercentWellUpDown.TabIndex = 9;
            // 
            // WellPercentLabel
            // 
            this.WellPercentLabel.AutoSize = true;
            this.WellPercentLabel.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WellPercentLabel.Location = new System.Drawing.Point(22, 225);
            this.WellPercentLabel.Name = "WellPercentLabel";
            this.WellPercentLabel.Size = new System.Drawing.Size(353, 18);
            this.WellPercentLabel.TabIndex = 8;
            this.WellPercentLabel.Text = "Процент правильных ответов на хорошо\r\n";
            // 
            // PercentSatisfactorilyUpDown
            // 
            this.PercentSatisfactorilyUpDown.Location = new System.Drawing.Point(511, 258);
            this.PercentSatisfactorilyUpDown.Name = "PercentSatisfactorilyUpDown";
            this.PercentSatisfactorilyUpDown.Size = new System.Drawing.Size(50, 20);
            this.PercentSatisfactorilyUpDown.TabIndex = 11;
            // 
            // CreateTestButton
            // 
            this.CreateTestButton.Location = new System.Drawing.Point(373, 339);
            this.CreateTestButton.Name = "CreateTestButton";
            this.CreateTestButton.Size = new System.Drawing.Size(188, 23);
            this.CreateTestButton.TabIndex = 12;
            this.CreateTestButton.Text = "Создать";
            this.CreateTestButton.UseVisualStyleBackColor = true;
            this.CreateTestButton.Click += new System.EventHandler(this.CreateTestButtonClick);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(101, 339);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(188, 23);
            this.CancelButton.TabIndex = 13;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // testNameLabel
            // 
            this.testNameLabel.AutoSize = true;
            this.testNameLabel.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.testNameLabel.Location = new System.Drawing.Point(22, 68);
            this.testNameLabel.Name = "testNameLabel";
            this.testNameLabel.Size = new System.Drawing.Size(142, 18);
            this.testNameLabel.TabIndex = 14;
            this.testNameLabel.Text = "Название теста\r\n";
            // 
            // TetsNameTextBox
            // 
            this.TetsNameTextBox.Location = new System.Drawing.Point(170, 69);
            this.TetsNameTextBox.Name = "TetsNameTextBox";
            this.TetsNameTextBox.Size = new System.Drawing.Size(440, 20);
            this.TetsNameTextBox.TabIndex = 15;
            // 
            // SatisfactorilyPercentLabel
            // 
            this.SatisfactorilyPercentLabel.AutoSize = true;
            this.SatisfactorilyPercentLabel.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SatisfactorilyPercentLabel.Location = new System.Drawing.Point(22, 260);
            this.SatisfactorilyPercentLabel.Name = "SatisfactorilyPercentLabel";
            this.SatisfactorilyPercentLabel.Size = new System.Drawing.Size(463, 18);
            this.SatisfactorilyPercentLabel.TabIndex = 10;
            this.SatisfactorilyPercentLabel.Text = "Процент правильных ответов на удовлетворительно";
            // 
            // TestThemeLabel
            // 
            this.TestThemeLabel.AutoSize = true;
            this.TestThemeLabel.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TestThemeLabel.Location = new System.Drawing.Point(22, 99);
            this.TestThemeLabel.Name = "TestThemeLabel";
            this.TestThemeLabel.Size = new System.Drawing.Size(105, 18);
            this.TestThemeLabel.TabIndex = 16;
            this.TestThemeLabel.Text = "Тема теста";
            // 
            // ThemeNameTextBox
            // 
            this.ThemeNameTextBox.Location = new System.Drawing.Point(170, 99);
            this.ThemeNameTextBox.Name = "ThemeNameTextBox";
            this.ThemeNameTextBox.Size = new System.Drawing.Size(440, 20);
            this.ThemeNameTextBox.TabIndex = 17;
            // 
            // EditTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 386);
            this.Controls.Add(this.ThemeNameTextBox);
            this.Controls.Add(this.TestThemeLabel);
            this.Controls.Add(this.TetsNameTextBox);
            this.Controls.Add(this.testNameLabel);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.CreateTestButton);
            this.Controls.Add(this.PercentSatisfactorilyUpDown);
            this.Controls.Add(this.SatisfactorilyPercentLabel);
            this.Controls.Add(this.PercentWellUpDown);
            this.Controls.Add(this.WellPercentLabel);
            this.Controls.Add(this.PercentExcelentUpDown);
            this.Controls.Add(this.ExcellentPersentLabel);
            this.Controls.Add(this.ControlModeCheckBox);
            this.Controls.Add(this.CommonModeTextBox);
            this.Controls.Add(this.TestModeLabel);
            this.Controls.Add(this.TestTimeUpDown);
            this.Controls.Add(this.TimeTestLabel);
            this.Controls.Add(this.label1);
            this.Name = "EditTestForm";
            this.Text = "Содание теста";
            ((System.ComponentModel.ISupportInitialize)(this.TestTimeUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PercentExcelentUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PercentWellUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PercentSatisfactorilyUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TimeTestLabel;
        private System.Windows.Forms.NumericUpDown TestTimeUpDown;
        private System.Windows.Forms.Label TestModeLabel;
        private System.Windows.Forms.CheckBox CommonModeTextBox;
        private System.Windows.Forms.CheckBox ControlModeCheckBox;
        private System.Windows.Forms.Label ExcellentPersentLabel;
        private System.Windows.Forms.NumericUpDown PercentExcelentUpDown;
        private System.Windows.Forms.NumericUpDown PercentWellUpDown;
        private System.Windows.Forms.Label WellPercentLabel;
        private System.Windows.Forms.NumericUpDown PercentSatisfactorilyUpDown;
        private System.Windows.Forms.Button CreateTestButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label testNameLabel;
        private System.Windows.Forms.TextBox TetsNameTextBox;
        private System.Windows.Forms.Label SatisfactorilyPercentLabel;
        private System.Windows.Forms.Label TestThemeLabel;
        private System.Windows.Forms.TextBox ThemeNameTextBox;
    }
}
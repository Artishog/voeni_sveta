namespace TetsCreatorApplication
{
    partial class EditTaskForm
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
            this.QwestionPanel = new System.Windows.Forms.Panel();
            this.QwestionTextLabel = new System.Windows.Forms.Label();
            this.QwestionTextBox = new System.Windows.Forms.RichTextBox();
            this.AnswerPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.QwestionNumberLabel = new System.Windows.Forms.Label();
            this.QwestionTypeCombobox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.VersionCountLabel = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.QwestionPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // QwestionPanel
            // 
            this.QwestionPanel.Controls.Add(this.QwestionTextLabel);
            this.QwestionPanel.Controls.Add(this.QwestionTextBox);
            this.QwestionPanel.Location = new System.Drawing.Point(52, 140);
            this.QwestionPanel.Name = "QwestionPanel";
            this.QwestionPanel.Size = new System.Drawing.Size(565, 91);
            this.QwestionPanel.TabIndex = 0;
            // 
            // QwestionTextLabel
            // 
            this.QwestionTextLabel.AutoSize = true;
            this.QwestionTextLabel.Location = new System.Drawing.Point(3, 9);
            this.QwestionTextLabel.Name = "QwestionTextLabel";
            this.QwestionTextLabel.Size = new System.Drawing.Size(82, 13);
            this.QwestionTextLabel.TabIndex = 3;
            this.QwestionTextLabel.Text = "Текст вопроса";
            // 
            // QwestionTextBox
            // 
            this.QwestionTextBox.Location = new System.Drawing.Point(4, 25);
            this.QwestionTextBox.Name = "QwestionTextBox";
            this.QwestionTextBox.Size = new System.Drawing.Size(558, 63);
            this.QwestionTextBox.TabIndex = 0;
            this.QwestionTextBox.Text = "";
            // 
            // AnswerPanel
            // 
            this.AnswerPanel.Location = new System.Drawing.Point(52, 252);
            this.AnswerPanel.Name = "AnswerPanel";
            this.AnswerPanel.Size = new System.Drawing.Size(565, 143);
            this.AnswerPanel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.QwestionNumberLabel);
            this.panel1.Controls.Add(this.QwestionTypeCombobox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(52, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(565, 93);
            this.panel1.TabIndex = 2;
            // 
            // QwestionNumberLabel
            // 
            this.QwestionNumberLabel.AutoSize = true;
            this.QwestionNumberLabel.Location = new System.Drawing.Point(19, 15);
            this.QwestionNumberLabel.Name = "QwestionNumberLabel";
            this.QwestionNumberLabel.Size = new System.Drawing.Size(93, 13);
            this.QwestionNumberLabel.TabIndex = 2;
            this.QwestionNumberLabel.Text = "Вопрос номер №";
            // 
            // QwestionTypeCombobox
            // 
            this.QwestionTypeCombobox.FormattingEnabled = true;
            this.QwestionTypeCombobox.Location = new System.Drawing.Point(115, 47);
            this.QwestionTypeCombobox.Name = "QwestionTypeCombobox";
            this.QwestionTypeCombobox.Size = new System.Drawing.Size(395, 21);
            this.QwestionTypeCombobox.TabIndex = 1;
            this.QwestionTypeCombobox.SelectedIndexChanged += new System.EventHandler(this.QwestionTypeCombobox_SelectedIndexChanged);
            this.QwestionTypeCombobox.SelectedValueChanged += new System.EventHandler(this.QwestionTypeCombobox_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Тип вопроса";
            // 
            // checkBox1
            // 
            this.checkBox1.Location = new System.Drawing.Point(0, 0);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(104, 24);
            this.checkBox1.TabIndex = 0;
            // 
            // VersionCountLabel
            // 
            this.VersionCountLabel.Location = new System.Drawing.Point(0, 0);
            this.VersionCountLabel.Name = "VersionCountLabel";
            this.VersionCountLabel.Size = new System.Drawing.Size(100, 23);
            this.VersionCountLabel.TabIndex = 0;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(0, 0);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 0;
            // 
            // EditTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 407);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AnswerPanel);
            this.Controls.Add(this.QwestionPanel);
            this.Name = "EditTaskForm";
            this.Text = "Редактирование задания";
            this.QwestionPanel.ResumeLayout(false);
            this.QwestionPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel QwestionPanel;
        private System.Windows.Forms.Panel AnswerPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label QwestionTextLabel;
        private System.Windows.Forms.RichTextBox QwestionTextBox;
        private System.Windows.Forms.Label QwestionNumberLabel;
        private System.Windows.Forms.ComboBox QwestionTypeCombobox;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label VersionCountLabel;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}
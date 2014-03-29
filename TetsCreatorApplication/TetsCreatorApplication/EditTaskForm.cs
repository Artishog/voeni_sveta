using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TetsCreatorApplication.Model;

namespace TetsCreatorApplication
{
    public partial class EditTaskForm : Form
    {
        public EditTaskForm()
        {
            InitializeComponent();
            SetQwestionTypes();
        }

        private void SetQwestionTypes()
        {
            var dict = new Dictionary<TaskType, String>();
            dict.Add(TaskType.Test, "Выбр вариантов из предложенных");
            dict.Add(TaskType.InsertAnswer, "Написать ответ вручную");
            dict.Add(TaskType.MapWork, "Задание с картой");
            QwestionTypeCombobox.DataSource = new BindingSource(dict, null);
            QwestionTypeCombobox.DisplayMember = "Value";
            QwestionTypeCombobox.ValueMember = "Key";
        }

        private void QwestionTypeCombobox_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void QwestionTypeCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var value = (TaskType)QwestionTypeCombobox.SelectedValue;
            QwestionManager.QwestionManager.SetControlsForDifineAnswer(AnswerPanel,value);
        }
    }
}

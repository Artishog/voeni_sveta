using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TetsCreatorApplication
{
    public partial class EditTestForm : Form
    {
        public EditTestForm()
        {
            InitializeComponent();
        }

        private void CreateTestButtonClick(object sender, EventArgs e)
        {
            var editTaskForm = new EditTaskForm();
            editTaskForm.ShowDialog();
        }
    }
}

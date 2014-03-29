using System.Windows.Forms;

namespace TetsCreatorApplication
{
    public partial class TestCreatorForm : Form
    {
        public TestCreatorForm()
        {
            InitializeComponent();

        }

        private void NewTestToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var testCreatorForm = new EditTestForm();
            //this.Visible = false;
            //this.ShowDialog(testCreatorForm);
            testCreatorForm.ShowDialog();
        }
    }
}

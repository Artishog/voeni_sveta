using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TetsCreatorApplication.Model;

namespace TetsCreatorApplication.QwestionManager
{
    class QwestionManager
    {
        public static void SetControlsForDifineAnswer(Panel panel,TaskType taskType)
        {
            switch (taskType)
            {
                case TaskType.InsertAnswer:
                    {
                        CreateInsertAswerControls();
                        break;
                    }
                case TaskType.Test:
                    {
                        CreateTestAnswerControls(panel);
                        break;
                    }
                case TaskType.MapWork:
                    {
                        break;
                    }
            }

        }

        static private void CreateTestAnswerControls(Panel panel)
        {
            var versionCountLabel = new Label();
            var versionCountUpDown = new NumericUpDown();
            

            versionCountLabel.AutoSize = true;
            versionCountLabel.Location = new System.Drawing.Point(19, 10);
            versionCountLabel.Name = "VersionCountLabel";
            versionCountLabel.Size = new System.Drawing.Size(159, 13);
            versionCountLabel.TabIndex = 1;
            versionCountLabel.Text = "Количество вариантов ответа";
            
 
            versionCountUpDown.Location = new System.Drawing.Point(185, 10);
            versionCountUpDown.Name = "numericUpDown1";
            versionCountUpDown.Size = new System.Drawing.Size(39, 20);
            versionCountUpDown.TabIndex = 2;

            panel.Controls.Add(versionCountLabel);
            panel.Controls.Add(versionCountUpDown);
        }

        private static void CreateInsertAswerControls()
        {
            throw new NotImplementedException();
        }
    }
}

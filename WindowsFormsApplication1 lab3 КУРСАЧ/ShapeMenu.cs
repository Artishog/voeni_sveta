using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using WindowsFormsApplication1;

namespace WindowsFormsApplication1
{
    public class ShapeMenu
    {
        private List<System.Windows.Forms.ToolStripMenuItem> list_of_Shapes = new List<System.Windows.Forms.ToolStripMenuItem>();
        public System.Windows.Forms.ToolStripMenuItem currentMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        public string GetCurrentMenuItemName()
        {
            return currentMenuItem.Name;
        }
    }
}

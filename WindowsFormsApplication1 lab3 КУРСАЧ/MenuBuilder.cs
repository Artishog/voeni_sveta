using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class MenuBuilder
    {
        /*private ToolStripMenuItem newMenuItem;
        private ToolStripMenuItem shapeMenu;*/
        public MenuBuilder(string itemName, ComboBox DD, List<ShapeBuilder> list_of_builders, List<Shape> list_of_Shapes)
        {
            /*this.shapeMenu = shapeMenu;

            newMenuItem = new ToolStripMenuItem();
            newMenuItem.Name = itemName;
            newMenuItem.Size = new System.Drawing.Size(41, 20);
            newMenuItem.Text = itemName;
            shapeMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { newMenuItem });*/
            UserShapeBuilder createUserShape = new UserShapeBuilder();
           // createUserShape.SaveNameandList(itemName, list_of_Shapes);
            list_of_builders.Add(createUserShape);
            DD.Items.Add(itemName);
        }

        /*public void AddDropDownItem(string newitem )
        {
            
        }
        void InitializeNewItem(string itemName)
        {
            newMenuItem = new ToolStripMenuItem();
            newMenuItem.Name = itemName;
            newMenuItem.Size = new System.Drawing.Size(41, 20);
            newMenuItem.Text = itemName;

            shapeMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { newMenuItem });
        }*/
    }
}

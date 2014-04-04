using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApplication1;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using ShapeInterface;
using System.Reflection;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //this.Cursor = SetCursor.LoadCustomCursor(Application.StartupPath+@"\lastik.cur");
        }
        
        private Shape currentShape;
        private int numberPickedShape;
        private bool isItTool;
        private ShapeBuilder createShape;
        private CircleBuilder createCircle;
        private TriangleBuilder createTriangle;
        private RectangleBuilder createRectangle;
        private LineBuilder createLine;
        private PencilBuilder createPencil;
        private EraseBuilder createErase;
        public Graphics grph;
        public Designer designerWindow ;
        private Pen current_pen = new Pen(Color.Black), whitepen = new Pen(Color.White);
        private Point p = new Point();
        private List<ShapeBuilder> list_of_builders = new List<ShapeBuilder>();
        private List<Shape> list_of_Shapes = new List <Shape>();
        private bool leftbuttondown = false;
        private bool leftbuttondouble = false;
        private bool shapeIsPicked = false;
        private ManagerUndoRedo managerUndoRedo = new ManagerUndoRedo();

        private void LoadButtonShapes()
        {
            string[] fileNames = Directory.GetFiles("./buttonShapes", "*.xml");

            foreach (var fileName in fileNames)
            {
                try
                {
                    DeserializeBuilder(fileName);
                }
                catch (Exception)
                {
                    MessageBox.Show("Pick valid file", "Error");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.grph = this.pictureBox1.CreateGraphics();
            createCircle = new CircleBuilder();
            createRectangle = new RectangleBuilder();
            createTriangle = new TriangleBuilder();
            createLine = new LineBuilder();
            createPencil = new PencilBuilder();
            createErase = new EraseBuilder();
            createShape = createRectangle;
            list_of_builders.Add(createRectangle);
            list_of_builders.Add(createCircle);
            list_of_builders.Add(createTriangle);
            DD.Text = "Rectangle";
            isItTool = false;
            current_pen.Width = 1.0F;
            this.Cursor = Cursors.Cross;

            this.LoadButtonShapes();
        }

        private int CheckPickedShape(MouseEventArgs e)
        {
            if (shapeIsPicked)
            {
                if ((e.Location.X > currentShape.P2.X - 4) && (e.Location.Y > currentShape.P2.Y - 4))
                    if ((e.Location.X < currentShape.P2.X + 4) && (e.Location.Y < currentShape.P2.Y + 4))
                    {
                        return 2;
                    }
                if ((e.Location.X > currentShape.P1.X - 4 + (currentShape.P2.X - currentShape.P1.X) / 2) && (e.Location.Y > currentShape.P1.Y - 4 + (currentShape.P2.Y - currentShape.P1.Y) / 2))
                    if ((e.Location.X < currentShape.P1.X + 4 + (currentShape.P2.X - currentShape.P1.X) / 2) && (e.Location.Y < currentShape.P1.Y + 4 + (currentShape.P2.Y - currentShape.P1.Y) / 2))
                    {
                        return 1;
                    }
            }
            return 0;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            leftbuttondown = true;
            grph.Clear(Color.White);
            dr_objects();
            numberPickedShape = CheckPickedShape(e);
            if (numberPickedShape == 0)
            {
                shapeIsPicked = false;
                currentShape = createShape.CreateShape();
                if (e.Button == MouseButtons.Left)
                {
                    p.X = e.Location.X; p.Y = e.Location.Y;
                }
                currentShape.P1 = p;
                currentShape.P2 = p;
                currentShape.SetPenColor(current_pen);
                currentShape.SetPenWidth(current_pen);
                currentShape.draw(grph);
                list_of_Shapes.Add(currentShape);
            }
        }

        private void ChangePickedOutShape(MouseEventArgs e, Shape currentShape, int numberPickedShape, Point p)
        {
            if (numberPickedShape == 2)
                currentShape.P2 = p;
            else
            {
                int x1 = currentShape.P1.X, y1 = currentShape.P1.Y, x2 = currentShape.P2.X, y2 = currentShape.P2.Y;
                currentShape.P2 = new Point(p.X + (x2 - x1) / 2, p.Y + (y2 - y1) / 2);
                currentShape.P1 = new Point(p.X - (x2 - x1) / 2, p.Y - (y2 - y1) / 2);
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Shape tmpShape;
            labelX.Text = "X"+e.Location.X.ToString();
            labelY.Text = "Y"+e.Location.Y.ToString();
            if (leftbuttondown)
            {
                if (isItTool)
                {
                    if (numberPickedShape != 0)
                    {
                        currentShape.SetPenColor(whitepen);
                        currentShape.SetPenWidth(current_pen);
                        currentShape.draw(grph);
                        p.X = e.Location.X; p.Y = e.Location.Y;
                        currentShape.SetPenColor(current_pen);                
                        ChangePickedOutShape(e, currentShape, numberPickedShape, p);
                    }
                    else
                    {
                        tmpShape = createShape.CreateShape();
                        tmpShape.P1 = currentShape.P2;
                        tmpShape.P2 = e.Location;
                        currentShape = createShape.CreateShape();
                        currentShape = tmpShape;
                        currentShape.SetPenColor(current_pen);
                        currentShape.SetPenWidth(current_pen);
                    }
                    currentShape.draw(grph);
                    list_of_Shapes.Add(currentShape);
                    this.dr_objects();
                }
                else
                {
                    currentShape.SetPenColor(whitepen);
                    currentShape.SetPenWidth(current_pen);
                    currentShape.draw(grph);
                    p.X = e.Location.X; p.Y = e.Location.Y;
                    currentShape.SetPenColor(current_pen);
                    if (numberPickedShape != 0)
                        ChangePickedOutShape(e, currentShape, numberPickedShape, p);
                    else
                        currentShape.P2 = p;
                    currentShape.draw(grph);
                    this.dr_objects();
                }
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (leftbuttondown)
            {
                if (!shapeIsPicked)  //if ((currentShape.P1.X != currentShape.P2.X) && (currentShape.P1.Y != currentShape.P2.Y))
                    list_of_Shapes.Add(currentShape);
                else
                    currentShape.PickOutMe(grph);
                managerUndoRedo.AddNewCurrentState(list_of_Shapes);
            }
            leftbuttondown = false;
            if (leftbuttondouble)
            {
                managerUndoRedo.Undo();
                managerUndoRedo.Undo();
                leftbuttondouble = false;
            }

            if (e.Button == MouseButtons.Right)
            {
                this.p.X = e.Location.X;
                this.p.Y = e.Location.Y;
            }
        }

        private void pictureBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int x1, y1, x2, y2;
            leftbuttondouble = true;
            for (int i = 0; i < list_of_Shapes.Count; i++)
            {
                if (list_of_Shapes[i].P1.X < list_of_Shapes[i].P2.X)
                {
                    x1 = list_of_Shapes[i].P1.X;
                    x2 = list_of_Shapes[i].P2.X;
                }
                else
                {
                    x2 = list_of_Shapes[i].P1.X;
                    x1 = list_of_Shapes[i].P2.X;
                }
                if (list_of_Shapes[i].P1.Y < list_of_Shapes[i].P2.Y)
                {
                    y1 = list_of_Shapes[i].P1.Y;
                    y2 = list_of_Shapes[i].P2.Y;
                }
                else
                {
                    y2 = list_of_Shapes[i].P1.Y;
                    y1 = list_of_Shapes[i].P2.Y;
                }
                if ((e.Location.X > x1) && (e.Location.Y > y1))
                {
                    if ((e.Location.X < x2) && (e.Location.Y < y2))
                    {
                        currentShape = list_of_Shapes[i];
                        currentShape.PickOutMe(grph);
                        shapeIsPicked = true;
                        break;
                    }
                }
            }
        }

        public void dr_objects()
        {
            Bitmap bmp = new Bitmap(pictureBox1.Size.Width, pictureBox1.Size.Height);
            Graphics grphBmp = Graphics.FromImage(bmp);
            list_of_Shapes.ForEach(delegate(Shape currentShape) { currentShape.draw(grphBmp); });
            grph.DrawImage(bmp, 0, 0);
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grph.Clear(Color.White);
            //managerUndoRedo.ClearStack();
            list_of_Shapes.Clear();
            managerUndoRedo.AddNewCurrentState(list_of_Shapes);
        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (shapeIsPicked)
            {
                currentShape.SetPenColor(new Pen(Color.Black));
                dr_objects();
            }
            else
                current_pen.Color = Color.Black;
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (shapeIsPicked)
            {
                currentShape.SetPenColor(new Pen(Color.Red));
                dr_objects();
            }
            else
                current_pen.Color = Color.Red;
        }

        private void allToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            if (MyDialog.ShowDialog() == DialogResult.OK)

                if (shapeIsPicked)
                {
                    currentShape.SetPenColor(new Pen(MyDialog.Color));
                    dr_objects();
                }
                else
                    current_pen.Color = MyDialog.Color;
        }

        private void Addmyshape_Click(object sender, EventArgs e)
        {
            designerWindow = new Designer(this);
            designerWindow.ShowDialog();
        }

        public void AddBuilderAndMenuItem(string itemName/*, ComboBox DD, List<ShapeBuilder> list_of_builders*/, List<Shape> list_of_Shapes)
        {
            foreach (string DDitem in DD.Items)
            {
                if (DDitem == itemName) 
                    itemName = "New " + itemName;
            }
            UserShapeBuilder createUserShape = new UserShapeBuilder();
            createUserShape.SaveNameandList(itemName, list_of_Shapes);
            list_of_builders.Add(createUserShape);
            DD.Items.Add(itemName);
            SerializeUserBuilder(createUserShape);
        }

        private void SerializeUserBuilder(UserShapeBuilder fromCreateUserShape)
        {
                XmlSerializer xs = new XmlSerializer(typeof(UserShapeBuilder));
                Stream writer = new FileStream(fromCreateUserShape.namebuilder + ".xml", FileMode.Create);
                xs.Serialize(writer, fromCreateUserShape);
                writer.Close();
        }
        
        /*private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolStripMenuItem item1 = new ToolStripMenuItem();
            item1.Name = "greenToolStripMenuItem";
            item1.Size = new System.Drawing.Size(104, 22);
            item1.Text = "pieceofshit";
            item1.Click += new System.EventHandler(f1);
            this.ShapeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {item1});
        }

        private void f1(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolStripMenuItem temp1 = (System.Windows.Forms.ToolStripMenuItem)sender;
            label1.Text = temp1.Text;
        }*/

        private void DD_SelectedIndexChanged(object sender, EventArgs e)
        {
            //label2.Text = DD.Text;
            createShape = list_of_builders.Find(item => item.namebuilder == DD.Text);
            ShapeStripMenuItem.HideDropDown();
            isItTool = false;
            this.Cursor = Cursors.Cross;
            
        }

        private void loadMyShapeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openfiledialog = new OpenFileDialog();
                openfiledialog.Filter = "txt files (*.xml)|*.xml";
                if (openfiledialog.ShowDialog() == DialogResult.OK)
                    DeserializeBuilder(openfiledialog.FileName);
            }
            catch (Exception)
            {
                MessageBox.Show("Pick valid file", "Error");
            }
        }

        private void DeserializeBuilder(string filename)
        {
            UserShapeBuilder createUserShape = new UserShapeBuilder();
            XmlSerializer xs = new XmlSerializer(typeof(UserShapeBuilder));
            Stream reader = new FileStream(filename, FileMode.Open);
            createUserShape = (UserShapeBuilder)xs.Deserialize(reader);
            reader.Close();
            list_of_builders.Add(createUserShape);
            DD.Items.Add(createUserShape.namebuilder);
        }



        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            list_of_Shapes = managerUndoRedo.Undo();
            grph.Clear(Color.White);
            dr_objects();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            list_of_Shapes = managerUndoRedo.Redo();
            grph.Clear(Color.White);
            dr_objects();
        }

        private void saveImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefiledialog = new SaveFileDialog();
            if (savefiledialog.ShowDialog() == DialogResult.OK)
            {
                /*List<MementoShape> mementolist = new List<MementoShape>();
                foreach (var item in list_of_Shapes)
                {
                    mementolist.Add(item.CreateMementoShape());
                }*/
                managerUndoRedo.SaveMementoes(savefiledialog.FileName);
            }
        }

        private void loadMyImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openfiledialog = new OpenFileDialog();
                openfiledialog.Filter = "txt files (*.xml)|*.xml";
                if (openfiledialog.ShowDialog() == DialogResult.OK)
                    list_of_Shapes = managerUndoRedo.LoadMementoes(openfiledialog.FileName);
                grph.Clear(Color.White);
                dr_objects();
            }
            catch (Exception)
            {
                MessageBox.Show("Pick valid file", "Error");
            }
        }

        private void paletteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            if (MyDialog.ShowDialog() == DialogResult.OK)

                if (shapeIsPicked)
                {
                    currentShape.SetPenColor(new Pen(MyDialog.Color));
                    dr_objects();
                }
                else
                    current_pen.Color = MyDialog.Color;

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grph.Clear(Color.White);
            managerUndoRedo = new ManagerUndoRedo();
            managerUndoRedo.ClearStack();
            list_of_Shapes.Clear();
            managerUndoRedo.AddNewCurrentState(list_of_Shapes);
        }
        
        private void rectangleBox_CheckedChanged(object sender, EventArgs e)
        {
            createShape = createRectangle;
            isItTool = false;
            this.Cursor = Cursors.Cross;
        }

        private void ellipseBox_CheckedChanged(object sender, EventArgs e)
        {
            createShape = createCircle;
            isItTool = false;
            this.Cursor = Cursors.Cross;
        }

        private void triangleBox_CheckedChanged(object sender, EventArgs e)
        {
            createShape = createTriangle;
            isItTool = false;
            this.Cursor = Cursors.Cross;
        }

        private void lineBox_CheckedChanged(object sender, EventArgs e)
        {
            createShape = createLine;
            isItTool = false;
            this.Cursor = Cursors.Cross;
        }



        private void deleteShapeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Shape> tmpList_of_Shapes = new List<Shape>();
            foreach (var shape in list_of_Shapes)
            {
                if (shape != currentShape)
                {
                    tmpList_of_Shapes.Add(shape);
                }
            }
            list_of_Shapes.Clear();
            list_of_Shapes = tmpList_of_Shapes;
            managerUndoRedo.AddNewCurrentState(list_of_Shapes);
            grph.Clear(Color.White);
            dr_objects();
        }

        private void pencilBox_CheckedChanged(object sender, EventArgs e)
        {
            createShape = createPencil;
            isItTool = true;
            this.Cursor = SetCursor.LoadCustomCursor(Application.StartupPath + @"\aero_pen.cur");
        }

        private void eraseBox_CheckedChanged(object sender, EventArgs e)
        {
            createShape = createErase;
            isItTool = true;
            this.Cursor = SetCursor.LoadCustomCursor(Application.StartupPath + @"\lastik.cur");
        }


        private void fToolStripMenuItem_Click(object sender, EventArgs e)
        {
            current_pen.Width = 1.0F;
        }

        private void fToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            current_pen.Width = 2.0F;
        }

        private void fToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            current_pen.Width = 3.0F;
        }

        private void fToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            current_pen.Width = 4.0F;
        }

        private void fToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            current_pen.Width = 5.0F;
        }

        private void pipetteBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            //pictureBox1.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
            //pictureBox1.Dock = (DockStyle.Bottom | DockStyle.Right);

        }

    }
}
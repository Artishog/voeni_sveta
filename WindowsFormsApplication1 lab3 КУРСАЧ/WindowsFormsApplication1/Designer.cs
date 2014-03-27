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
    public partial class Designer : Form
    {
        private Form1 form1Window;
        public Shape current_Shape;
        private ShapeBuilder createShape;
        private CircleBuilder createCircle;
        private TriangleBuilder createTriangle;
        private RectangleBuilder createRectangle;
        private List<Shape> list_of_Shapes = new List<Shape>();
        public Graphics grph;
        private Pen current_pen = new Pen(Color.Black), whitepen = new Pen(Color.White);
        private Point p = new Point();

        public Designer(Form1 fromwindow)
        {
            form1Window = fromwindow;
            InitializeComponent();
        }
        
        private void triangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createShape = createTriangle;
        }

        private void circleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createShape = createCircle;
        }

        private void rectangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createShape = createRectangle;
        }

        private void pictureBox1_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                current_Shape = createShape.CreateShape();
                p.X = e.Location.X; p.Y = e.Location.Y;
                current_Shape.P1 = p;
                current_Shape.P2 = p;
                current_Shape.SetPenColor(current_pen);
            }
        }

        public void dr_objects()
        {
            list_of_Shapes.ForEach(delegate(Shape current_Shape) { current_Shape.draw(grph); });

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                current_Shape.SetPenColor(whitepen);
                current_Shape.draw(grph);

                current_Shape.SetPenColor(current_pen);
                p.X = e.Location.X; p.Y = e.Location.Y;
                current_Shape.P2 = p;
                current_Shape.draw(grph);
                this.dr_objects();
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            list_of_Shapes.Add(current_Shape);
        }

        private void Designer_Load(object sender, EventArgs e)
        {
            this.grph = this.pictureBox1.CreateGraphics();
            createCircle = new CircleBuilder();
            createRectangle = new RectangleBuilder();
            createTriangle = new TriangleBuilder();
            createShape = createRectangle;
        }

        private void clearToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            grph.Clear(Color.White);
            list_of_Shapes.Clear();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            //menuBuilder = new MenuBuilder(textBox1.Text, form1Window.GetBox(), form1Window.Getlistofbuiders(), list_of_Shapes);
            form1Window.AddBuilderAndMenuItem(textBox1.Text/*, form1Window.GetBox(), form1Window.Getlistofbuiders()*/, list_of_Shapes);
            Close();
        }
    }
}

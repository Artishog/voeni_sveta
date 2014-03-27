using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;

namespace WindowsFormsApplication1
{
    class ManagerUndoRedo
    {
        private Stack<List<MementoShape>> stackCurrentMementoes = new Stack<List<MementoShape>>();
        private Stack<List<MementoShape>> stackMementoesundoredo = new Stack<List<MementoShape>>();

        public void AddNewCurrentState(List<Shape> list_of_Shapes)
        {
            List<MementoShape> mementolist = new List<MementoShape>();
            foreach (var item in list_of_Shapes)
            {
                mementolist.Add(item.CreateMementoShape());
            }
            stackCurrentMementoes.Push(mementolist);
            stackMementoesundoredo.Clear();
        }

        public void ClearStack()
        {
            stackCurrentMementoes.Clear();
            stackMementoesundoredo.Clear();
   
        }

        public List<Shape> Undo()
        {
            List<MementoShape> mementolist;
            List<Shape> list_of_Shapes = new List<Shape>();
            if (stackCurrentMementoes.Count != 0)
            {
                stackMementoesundoredo.Push(stackCurrentMementoes.Pop());
                if (stackCurrentMementoes.Count != 0)
                {
                    mementolist = stackCurrentMementoes.Peek();
                    foreach (var item in mementolist)
                        list_of_Shapes.Add(item.ShapeState);
                }
            }
            return list_of_Shapes;
        }

        public List<Shape> Redo()
        {
            List<MementoShape> mementolist;
            List<Shape> list_of_Shapes = new List<Shape>();
            if (stackMementoesundoredo.Count != 0)
                stackCurrentMementoes.Push(stackMementoesundoredo.Pop());
            mementolist = stackCurrentMementoes.Peek();
            foreach (var item in mementolist)
                list_of_Shapes.Add(item.ShapeState);
            return list_of_Shapes;
        }

        public void SaveMementoes(string path)
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<MementoShape>));
            StreamWriter sw = new StreamWriter(path + ".xml");
            if (stackCurrentMementoes.Count != 0)
            { xs.Serialize(sw, stackCurrentMementoes.Peek()); }
            sw.Close();
        }

        public List<Shape> LoadMementoes(string path)
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<MementoShape>));
            Stream reader = new FileStream(path, FileMode.Open);
            stackCurrentMementoes.Push((List<MementoShape>)xs.Deserialize(reader));
            reader.Close();
            List<Shape> list_of_Shapes = new List<Shape>();
            List<MementoShape> mementolist;
            mementolist = stackCurrentMementoes.Peek();
            foreach (var item in mementolist)
                list_of_Shapes.Add(item.ShapeState);
            return list_of_Shapes;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace WpfApp1
{
    public class ForReUnDo
    {

        Stack<BindingList<ToDoTask>> undoStack;
        Stack<BindingList<ToDoTask>> redoStack;


        public ForReUnDo()
        {
            undoStack = new Stack<BindingList<ToDoTask>>();
            redoStack = new Stack<BindingList<ToDoTask>>();
        }


        void Clear()
        {
            undoStack.Clear();
            redoStack.Clear();
        }

        public void AddItem(BindingList<ToDoTask> item)
        {
            undoStack.Push(item);
        }

        public BindingList<ToDoTask> UnDo()
        {
            var item = undoStack.Pop();
            redoStack.Push(item);
            return undoStack.First();
        }

        public BindingList<ToDoTask> ReDo()
        {
            if(redoStack.Count == 0)
                return undoStack.First();
            var item = redoStack.Pop();
            undoStack.Push(item);
            return undoStack.First();
        }

        public bool CanUndo()
        {
            return undoStack.Count > 1;
        }

        public bool CanRedo()
        {
            return redoStack.Count > 0;
        }
        public List<BindingList<ToDoTask>> UndoItems()
        {
            return undoStack.ToList();
        }

        public List<BindingList<ToDoTask>> RedoItems()
        {
            return redoStack.ToList();
        }
        //List<BindingList<ToDoList>> toDoLists;

        //public ForReUnDo(BindingList<ToDoList> lists)
        //{
        //    toDoLists = new List<BindingList<ToDoList>> { lists};
        //}

        //public BindingList<ToDoList> UnDo()
        //{

        //}

        //public BindingList<ToDoList> ReDo()
        //{
        //    return 
        //}
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.IO;

namespace WpfApp1
{
    class FileJson
    {
        private readonly string PATH;

        public FileJson(string _path)
        {
            PATH = _path;
        }

        public BindingList<ToDoTask> FromJson()
        {
            if (!File.Exists(PATH))
            {
                File.CreateText(PATH).Dispose();
                return new BindingList<ToDoTask>();
            }
            else
            {

                string fileText = File.ReadAllText(PATH);
                BindingList<ToDoTask> toDoList = JsonConvert.DeserializeObject<BindingList<ToDoTask>>(fileText);
                return toDoList;
            }
        }

        public void IntoJson(BindingList<ToDoTask> _toDoList)
        {
            string input = JsonConvert.SerializeObject(_toDoList);
            File.WriteAllText(PATH, input);
        }


    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.HearingClass;

namespace OOP_7_8.Services
{
    class FileIOService
    {
        private readonly string PATH;

        public FileIOService(string path)
        {
            PATH = path;
        }
        public BindingList<ToDoList> LoadData()
        {
            var fileExists = File.Exists(PATH);
            if(!fileExists)
            {
                File.CreateText(PATH).Dispose();
                return new BindingList<ToDoList>();
            }
            using (var reader = File.OpenText(PATH))
            {
                var fileText = reader.ReadToEnd();
                return JsonConvert.DeserializeObject<BindingList<ToDoList>>(fileText);
            }
               
        }

        public void SaveData(object _toDoList)
        {
            using (StreamWriter writer = File.CreateText(PATH))
            {
                string output = JsonConvert.SerializeObject(_toDoList);
                writer.WriteLine(output);
            }

        }
    }
}

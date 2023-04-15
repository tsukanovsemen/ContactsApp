using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace ContactsApp.Model
{
    /// <summary>
    /// Класс, описывающий менеджер проекта.
    /// </summary>
    internal class ProjectManager
    {
        /// <summary>
        /// Путь к файлу для записи.
        /// </summary>
        private const string _fileName = "C:/users/cukan/source/repos/ContactsApp/ContactsApp.notes/notes.txt";

        /// <summary>
        /// Сохранение объекта Project в файл.
        /// </summary>
        /// <param name="project"></param>
        public void SaveProject(Project project)
        {
            File.WriteAllText(_fileName,JsonConvert.SerializeObject(project));
        }

        /// <summary>
        /// Загрузка объекта Project из файла.
        /// </summary>
        /// <returns></returns>
        public Project LoadProject()
        {
            return JsonConvert.DeserializeObject<Project>(File.ReadAllText(_fileName));
        }
    }
}

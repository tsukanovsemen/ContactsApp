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
    public class ProjectManager
    {
        /// <summary>
        /// Путь к особой системной папке.
        /// </summary>
        private static string _appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

        /// <summary>
        /// Путь к папке файла.
        /// </summary>
        private static string _path = $@"{_appData}\Tsukanov\ContactsApp";

        /// <summary>
        /// Путь к файлу.
        /// </summary>
        private static string _fullPath = $@"{_appData}\Tsukanov\ContactsApp\data.json";

        /// <summary>
        /// Сохранение объекта Project в файл.
        /// </summary>
        /// <param name="project"></param>
        public void SaveProject(Project project)
        {
            if (!Directory.Exists(_path))
            {
                Directory.CreateDirectory(_path);
            }

            File.WriteAllText(_fullPath, JsonConvert.SerializeObject(project));
        }

        /// <summary>
        /// Загрузка объекта Project из файла.
        /// </summary>
        /// <returns></returns>
        public Project LoadProject()
        {
            try
            {
                var project = JsonConvert.
                    DeserializeObject<Project>(File.ReadAllText(_fullPath));
                if (project == null)
                {
                    return new Project();
                }

                return project;
            }
            catch (Exception ex)
            {
                return new Project();
            }
        }
    }
}

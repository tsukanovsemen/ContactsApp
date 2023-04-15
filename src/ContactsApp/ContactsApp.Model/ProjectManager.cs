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
        /// Путь к файлу.
        /// </summary>
        private static string _path = $@"{_appData}\Roaming\ContactsApp\data.json";

        /// <summary>
        /// Сохранение объекта Project в файл.
        /// </summary>
        /// <param name="project"></param>
        public void SaveProject(Project project)
        {
            try
            {
                File.WriteAllText(_path, JsonConvert.SerializeObject(project));
            }
            catch (Exception ex)
            {
                 new ArgumentException(ex.Message);
            }
        }

        /// <summary>
        /// Загрузка объекта Project из файла.
        /// </summary>
        /// <returns></returns>
        public Project LoadProject()
        {
            try
            {
                return JsonConvert.DeserializeObject<Project>(File.ReadAllText(_path));
            }
            catch (Exception ex)
            {
                new ArgumentException(ex.Message);
                return null;
            }

        }
    }
}

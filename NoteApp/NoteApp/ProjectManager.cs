using System;
using System.IO;
using Newtonsoft.Json;

namespace NoteApp
{
    /// <summary>
    /// "Менеджер проекта" реализует метод
    /// для сохранения проекта в файл и метод загрузки из файла
    /// </summary>
    public class ProjectManager
    {
        /// <summary>
        /// хранит имя файла
        /// </summary>
        private const string FileName = "NoteApp.notes";

        /// <summary>
        /// хранит путь до файла
        /// </summary>
        public static readonly string _path =
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\" + FileName;

        /// <summary>
        /// сериализует объект Project в файл
        /// </summary>
        /// <param name="project">сериализируемый объект</param>
        public static void SaveToFile(Project project)
        {
            JsonSerializer serializer = new JsonSerializer();

            using (StreamWriter sw = new StreamWriter(_path))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, project);
            }
        }

        /// <summary>
        /// дессериализирует объект из файла
        /// </summary>
        /// <returns>дессериализированный объект</returns>
        public static Project LoadFromFile()
        {
            Project project = new Project();

            JsonSerializer serializer = new JsonSerializer();

            if (!File.Exists(_path))
            {
                return new Project();
            }

            using (StreamReader sr = new StreamReader(_path))
            using (JsonReader reader = new JsonTextReader(sr))
            {
                project = serializer.Deserialize<Project>(reader);
            }

            return project;
        }
    }
}
